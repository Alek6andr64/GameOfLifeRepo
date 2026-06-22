using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Game : Form
    {
        private Random random = new Random();

        // Параметры игры
        private int aliveCells = 0; // Количество живых клеток на поле
        private int startAvailableCells; // Начальное количество клеток, доступных для расстановки
        private int availableCells; // Текущее количество клеток, доступных для расстановки
        private int stepCount; // Максимальное количество шагов симуляции в классическом режиме 
        private int fieldSize; // Размер игрового поля 
        private int targetCells; // Целевое количество клеток для победы 
        private string targetType; // Оператор сравнения для определения победы (">", ">=", "<", "<=", "==", "=")
        private int step = 0; // Текущий номер шага симуляции
        private bool isGameStarted = false; // Начата ли игра 
        private bool isGameFinished = false; // Завершена ли игра 
        private short gameType = 0; //  0 - классическим режим, 1 - бесконечный режим

        // Коллекции для правил игры
        private HashSet<int> survivalRules = new HashSet<int>();
        private HashSet<int> birthRules = new HashSet<int>();
        private string rawSurvive;
        private string rawBirth;

        // Двумерный массив кнопок игрового поля
        private Button[,] cells;
        private bool[,] fieldState;

        // Параметры зума
        private int viewportSize = 30;
        private int viewX = 0;
        private int viewY = 0;

        // Текст экрана загрузки
        private Label lblLoading;

        // Текст цели
        Label lblTargetScore;

        Button btnRestart;
        public Game(int fieldSize, int availableCells, int stepCount, int targetCells, string targetType, short gameType,
                    string surviveRulesStr = "23", string birthRulesStr = "3", bool[,] field = null, int step = 0)
        {
            InitializeComponent();

            // Сохраняем базовые параметры игры
            this.availableCells = availableCells;
            this.startAvailableCells = availableCells;
            this.stepCount = stepCount;
            this.fieldSize = fieldSize;
            this.targetCells = targetCells;
            this.targetType = targetType;
            this.step = step;
            this.gameType = gameType;
            this.rawSurvive = surviveRulesStr;
            this.rawBirth = birthRulesStr;

            // Преобразуем строки правил в наборы чисел 
            foreach (char c in surviveRulesStr) survivalRules.Add(c - '0');
            foreach (char c in birthRulesStr) birthRules.Add(c - '0');

            // Настраиваем сколько клеток помещается на экране 
            viewportSize = Math.Min(fieldSize, 70);
            fieldState = new bool[fieldSize, fieldSize];

            // Настройка элементов игры
            pbGameProgress.Maximum = stepCount;
            lblCellsStatus.Text = $"Доступно для установки: {availableCells}";
            slRules.Text = $"Правила выживания: {surviveRulesStr}, Правила рождения: {birthRulesStr}";
           
            // Подписка на событие авто симуляции
            gameTimer.Tick += timer_Step;

            // Создаем кнопки
            InitializeLoadingLabel();
            InitializeGameGrid();

            // Убираем в бесконечном режиме прогресс-бар 
            if (gameType == 1)
            {
                pbGameProgress.Visible = false;
            }

            // Если загружено готовое поле  - восстанавливаем 
            if (field != null)
            {
                for (int row = 0; row < fieldSize; row++)
                {
                    for (int col = 0; col < fieldSize; col++)
                    {
                        fieldState[row, col] = field[row, col];
                    }
                }
                UpdateViewport();
                start_Game();
            }
        }

        private void InitializeGameGrid()
        {
            // Вычисляем иразмер кнопки по минимальной стороне панели
            int minDimension = Math.Min(gameField.Width, gameField.Height);
            int buttonSize = minDimension / viewportSize;

            // Защита от деления на ноль
            if (buttonSize == 0) buttonSize = 1;

            // Вычисляем отступы для центрирования сетки
            int offsetX = (gameField.Width - (buttonSize * viewportSize)) / 2;
            int offsetY = (gameField.Height - (buttonSize * viewportSize)) / 2;

            Button[,] newCells = new Button[viewportSize, viewportSize];
            List<Button> oldButtons = gameField.Controls.OfType<Button>().ToList();

            // Замораживаем интерфейс
            gameField.SuspendLayout();

            for (int row = 0; row < viewportSize; row++)
            {
                for (int col = 0; col < viewportSize; col++)
                {
                    Button cell = new Button();
                    cell.Size = new Size(buttonSize, buttonSize);
                    cell.Location = new Point(offsetX + col * buttonSize, offsetY + row * buttonSize);
                    cell.FlatStyle = FlatStyle.Flat;
                    cell.BackColor = Color.White;

                    // Хранит позицию клетки в видимой области
                    cell.Tag = new Point(col, row);
                    cell.Click += cell_Click;

                    newCells[row, col] = cell;
                }
            }

            // Освобождаем ресурсы старых кнопок перед добавлением новых
            foreach (var btn in oldButtons)
            {
                gameField.Controls.Remove(btn);
                btn.Dispose();
            }

            cells = newCells;

            // Добавляем все новые кнопки на форму
            for (int row = 0; row < viewportSize; row++)
            {
                for (int col = 0; col < viewportSize; col++)
                {
                    gameField.Controls.Add(cells[row, col]);
                }
            }

            // Возвращаем перерисовку и обновляем отображение
            gameField.ResumeLayout(true);
            UpdateViewport();
        }

        private void UpdateViewport()
        {
            // viewX, viewY - положение камеры
            // viewportSize - сколько клеток видно
            // Для каждой клетки на экране (row, col) находим соответствующую клетку и отображаем её состояние
            for (int row = 0; row < viewportSize; row++)
            {
                for (int col = 0; col < viewportSize; col++)
                {
                    int fieldR = viewY + row;
                    int fieldC = viewX + col;

                    if (fieldR >= 0 && fieldR < fieldSize && fieldC >= 0 && fieldC < fieldSize)
                    {
                        cells[row, col].BackColor = fieldState[fieldR, fieldC] ? Color.Black : Color.White;
                    }
                }
            }
        }

        private void InitializeLoadingLabel()
        {
            // Создаем текст загрузки
            lblLoading = new Label();
            lblLoading.Text = "Пожалуйста, подождите.\nИдет отрисовка сетки...";
            lblLoading.ForeColor = Color.DimGray;
            lblLoading.TextAlign = ContentAlignment.MiddleCenter;
            lblLoading.AutoSize = true;
            lblLoading.Visible = false;

            this.Controls.Add(lblLoading);
        }

        private void ShowLoading(bool show)
        {
            if (show)
            {
                // Центрируем надпись
                lblLoading.Location = new Point(
                    (this.ClientSize.Width - lblLoading.Width) / 2,
                    (this.ClientSize.Height - lblLoading.Height) / 2 + 40
                );

                // Делаем метку видимой и выводим ее на передний план
                lblLoading.Visible = true;
                lblLoading.BringToFront();

                // Принудительно заставляем обновить интерфейс 
                Application.DoEvents();
            }
            else
            {
                // Скрываем метку
                lblLoading.Visible = false;
            }
        }

        private void gameField_Resize(object sender, EventArgs e)
        {
            if (cells == null) return;

            ShowLoading(true);

            // Пересчитываем размеры под новые габариты окна
            int minDimension = Math.Min(gameField.Width, gameField.Height);
            int buttonSize = minDimension / viewportSize;
            if (buttonSize == 0) buttonSize = 1;

            // Вычисляем отступы для центрирования сетки
            int offsetX = (gameField.Width - (buttonSize * viewportSize)) / 2;
            int offsetY = (gameField.Height - (buttonSize * viewportSize)) / 2;

            // Отключаем обновления кнопок
            gameField.SuspendLayout();

            for (int row = 0; row < viewportSize; row++)
            {
                for (int col = 0; col < viewportSize; col++)
                {
                    cells[row, col].Size = new Size(buttonSize, buttonSize);
                    cells[row, col].Location = new Point(offsetX + col * buttonSize, offsetY + row * buttonSize);
                }
            }

            gameField.ResumeLayout(true);
            ShowLoading(false);
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            start_Game();
        }

        private void start_Game()
        {
            isGameStarted = true;

            // Активируем кнопки 
            btnPause.Enabled = true;
            btnNextStep.Enabled = true;
            btnStartAuto.Enabled = true;

            // Меняем назначение кнопок в режиме игры
            btnClearAndLeave.Text = $"Выйти";
            btnSaveAndRand.Text = $"Сохранить";

            // Скрываем кнопку старта
            btnStartGame.Hide();

            lblCellsStatus.Text = $"Текущее число клеток: {startAvailableCells - availableCells}";

            if (gameType == 0)
            {

                // Текст цели раунда
                lblTargetScore = new Label();
                lblTargetScore.AutoSize = true;
                lblTargetScore.Dock = DockStyle.Fill;
                lblTargetScore.TextAlign = ContentAlignment.MiddleCenter;
                tlpTopMenu.Controls.Add(lblTargetScore, 3, 0);

                lblTargetScore.Text = $"Цель: {targetType} {targetCells.ToString()}";
            } else
            {
                btnRestart = new Button();
                btnRestart.AutoSize = true;
                btnRestart.Dock = DockStyle.Fill;
                btnRestart.Click += btnRestart_Click;
                tlpTopMenu.Controls.Add(btnRestart, 3, 0);

                btnRestart.Text = $"Начать заново";
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            // Останавливаем таймер, если он запущен
            if (gameTimer.Enabled)
                gameTimer.Stop();
        }
        private void btnNextStep_Click(object sender, EventArgs e)
        {
            // Симулируем шаг
            game_Step();
        }

        private void btnStartAuto_Click(object sender, EventArgs e)
        {
            // Авто симуляция
            if (!gameTimer.Enabled)
                gameTimer.Start();
        }

        private void game_Step()
        {
            // Классический режим
            if (gameType == 0)
            {
                if (step < stepCount)
                {
                    step++;
                    pbGameProgress.Value = step;
                    slMoveCount.Text = $"Осталось ходов: {stepCount - step} (из {stepCount})";
                    simulate();
                }
                else
                {
                    gameTimer.Stop();
                    end_Game();
                }
            }
            else
            {
                // Бесконечный режим 
                step++;
                slMoveCount.Text = $"Ход: {step}";
                simulate();
            }
        }


        private void simulate()
        {
            // Создаем копию поля, чтобы не влиять на текущее во время расчетов
            bool[,] nextState = new bool[fieldSize, fieldSize];
            aliveCells = 0;

            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    int neighbors = countNeighbors(col, row);
                    bool isAlive = fieldState[row, col];

                    // Перекрашиванием кнопки согласно правилам
                    if (isAlive && survivalRules.Contains(neighbors))
                    {
                        nextState[row, col] = true;
                        aliveCells++;
                    }
                    else if (!isAlive && birthRules.Contains(neighbors))
                    {
                        nextState[row, col] = true;
                        aliveCells++;
                    }
                    else
                    {
                        nextState[row, col] = false;
                    }
                }
            }

            // Заменяем текущее состояние новым
            fieldState = nextState;
            UpdateViewport();

            lblCellsStatus.Text = $"Текущее число клеток: {aliveCells}";

            // Заканчиваем игру если все клетки мертвы в классическом режиме
            if (aliveCells == 0 && gameType == 0)
            {
                end_Game();
            }
        }

        private int countNeighbors(int x, int y)
        {
            int count = 0;

            // Проверяем все 8 соседних клеток на жизнь 
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    // Пропускаем саму клетку
                    if (i == 0 && j == 0)
                        continue;

                    int neighborX = x + j;
                    int neighborY = y + i;

                    // Защита от выхода за границы массива
                    if (neighborX >= 0 && neighborX < fieldSize && neighborY >= 0 && neighborY < fieldSize)
                    {
                        if (fieldState[neighborY, neighborX])
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }

        private void end_Game()
        {
            // Останавливаем таймер, если он запущен
            if (gameTimer.Enabled)
                gameTimer.Stop();

            btnPause.Enabled = false;
            btnNextStep.Enabled = false;
            btnStartAuto.Enabled = false;

            // Расчитываем условия победы в зависимости от заданных условий
            if (aliveCells > targetCells && targetType == ">" ||
                aliveCells >= targetCells && targetType == ">=" ||
                aliveCells < targetCells && targetType == "<" ||
                aliveCells <= targetCells && targetType == "<=" ||
                aliveCells == targetCells && targetType == "==" ||
                aliveCells == targetCells && targetType == "=")
            {
                MessageBox.Show("Вы победили!");
            }
            else
            {
                MessageBox.Show("Вы проиграли :(");
            }

            btnSaveAndRand.Text = "Начать заново";
            isGameFinished = true;
        }

        private void timer_Step(object sender, EventArgs e)
        {
            game_Step();
        }

        private void cell_Click(object sender, EventArgs e)
        {
            Button cell = sender as Button;
            if (cell == null) return;

            // Координаты в видимой области
            Point pt = (Point)cell.Tag;

            // Преобразуем координаты видимой области в глобальные координаты поля
            int fieldC = viewX + pt.X;
            int fieldR = viewY + pt.Y;

            if (fieldR < 0 || fieldR >= fieldSize || fieldC < 0 || fieldC >= fieldSize) return;

            // Расстановка начальных клеток вручную
            if (!isGameStarted && gameType == 0)
            {
                if (!fieldState[fieldR, fieldC] && availableCells > 0)
                {
                    // Устанавливаем живую клетку, если есть свободные ячейки
                    fieldState[fieldR, fieldC] = true;
                    cell.BackColor = Color.Black;
                    availableCells--;
                    aliveCells++;
                }
                else if (fieldState[fieldR, fieldC])
                {
                    // Удаляем клетку, возвращая ячейку в пул доступных
                    fieldState[fieldR, fieldC] = false;
                    cell.BackColor = Color.White;
                    availableCells++;
                    aliveCells--;
                }
                lblCellsStatus.Text = $"Доступно для установки: {availableCells}";
            }
            else if (gameType == 1)
            {
                // В бесконечном режиме клетки можно добавлять/удалять в любой момент
                if (!fieldState[fieldR, fieldC])
                {
                    fieldState[fieldR, fieldC] = true;
                    cell.BackColor = Color.Black;
                    aliveCells++;
                }
                else if (fieldState[fieldR, fieldC])
                {
                    fieldState[fieldR, fieldC] = false;
                    cell.BackColor = Color.White;
                    aliveCells--;
                }
            }
        }

        private void random_Place()
        {
            // Используем начальное количество клеток
            availableCells = startAvailableCells;

            // Очищаем поле
            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    fieldState[row, col] = false;
                }
            }

            aliveCells = 0;

            // Расставляем случайные клетки, пока не израсходуем все доступные
            while (availableCells > 0)
            {
                int r = random.Next(fieldSize);
                int c = random.Next(fieldSize);

                if (!fieldState[r, c])
                {
                    fieldState[r, c] = true;
                    availableCells--;
                    aliveCells++;
                }
            }

            UpdateViewport();
            lblCellsStatus.Text = $"Доступно для установки: {availableCells}";
        }

        private void restart_Game()
        {
            // Сохраняем позицию и размер текущего окна
            Point previousLocation = this.Location;
            Size previousSize = this.Size;
            FormWindowState previousState = this.WindowState;

            this.Close();

            // Создаем новую игру с теми же параметрами
            Game game = new Game(fieldSize, startAvailableCells, stepCount, targetCells, targetType, gameType, rawSurvive, rawBirth);
            game.StartPosition = FormStartPosition.Manual;

            // Восстанавливаем позицию и размер, если окно не было развернуто
            if (previousState == FormWindowState.Maximized)
            {
                game.WindowState = FormWindowState.Maximized;
            }
            else
            {
                game.Location = previousLocation;
                game.Size = previousSize;
            }

            game.Show();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            restart_Game();
        }

        private void btnSaveAndRand_Click(object sender, EventArgs e)
        {
            if (!isGameStarted)
            {
                random_Place();
            }
            else
            {
                if (!isGameFinished)
                {
                    if (gameTimer.Enabled)
                        gameTimer.Stop();

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Сохраняем все параметры игры в текстовый файл
                        string[] lines = new string[]
                        {
                            aliveCells.ToString(),
                            availableCells.ToString(),
                            stepCount.ToString(),
                            fieldSize.ToString(),
                            targetCells.ToString(),
                            targetType.ToString(),
                            step.ToString(),
                            gameType.ToString(),
                            rawSurvive,
                            rawBirth
                        };

                        string field = "";

                        for (int row = 0; row < fieldSize; row++)
                        {
                            for (int col = 0; col < fieldSize; col++)
                            {
                                if (!fieldState[row, col])
                                    field += "0";
                                else
                                    field += "1";
                            }
                        }

                        lines = lines.Append(field).ToArray();
                        File.WriteAllLines(saveFileDialog.FileName, lines);
                        MessageBox.Show("Сохранено!");
                    }
                }
                else
                {
                    restart_Game();
                }
            }
        }

        private void btnClearAndLeave_Click(object sender, EventArgs e)
        {
            if (!isGameStarted)
            {
                // Очистка поля до начала игры
                for (int row = 0; row < fieldSize; row++)
                {
                    for (int col = 0; col < fieldSize; col++)
                    {
                        fieldState[row, col] = false;
                    }
                }
                availableCells = startAvailableCells;
                UpdateViewport();
            }
            else
            {
                // Выход из игры
                this.Close();
            }
        }

        private void numGameSpeed_ValueChanged(object sender, EventArgs e)
        {
            // Скорость симуляции в миллисекундах между шагами
            gameTimer.Interval = (int)numGameSpeed.Value;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            // Уменьшение масштаба
            int maxZoom = Math.Min(fieldSize, 70);
            if (viewportSize < maxZoom)
            {
                viewportSize++;
                InitializeGameGrid();
            }
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            // Увеличение масштаба
            if (viewportSize > 5)
            {
                viewportSize--;

                // Корректируем позицию камеры, чтобы она не выходила за границы поля
                if (viewX + viewportSize > fieldSize) viewX = fieldSize - viewportSize;
                if (viewY + viewportSize > fieldSize) viewY = fieldSize - viewportSize;

                InitializeGameGrid();
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            // Смещаем видимую область вверх
            if (viewY > 0)
            {
                viewY--;
                UpdateViewport();
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            // Смещаем вниз, пока не упремся в нижнюю границу
            if (viewY + viewportSize < fieldSize)
            {
                viewY++;
                UpdateViewport();
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            // Смещаем влево, пока не упремся в левую границу
            if (viewX > 0)
            {
                viewX--;
                UpdateViewport();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            // Смещаем вправо, пока не упремся в правую границу
            if (viewX + viewportSize < fieldSize)
            {
                viewX++;
                UpdateViewport();
            }
        }
    }
}