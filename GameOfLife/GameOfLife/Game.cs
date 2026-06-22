using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Game : Form
    {

        private Random random = new Random();

        // Параметры игры
        private int aliveCells = 0;
        private int availableCells;
        private int stepCount;
        private int fieldSize;
        private int targetCells;
        private string targetType;
        private int step = 0;
        private bool isGameStarted = false;

        // Двумерный массив кнопок игрового поля
        private Button[,] cells;

        // Текст экрана загрузки
        private Label lblLoading;

        // Текст цели
        Label lblTargetScore;

        public Game(int fieldSize, int availableCells, int stepCount, int targetCells, string targetType)
        {
            InitializeComponent();

            this.availableCells = availableCells;
            this.stepCount = stepCount;
            this.fieldSize = fieldSize;
            this.targetCells = targetCells;
            this.targetType = targetType;

            // Настройка элементов игры
            pbGameProgress.Maximum = stepCount;
            grpMovesInfo.Text = $"Осталось ходов: {stepCount}  (из {stepCount})";
            lblCellsStatus.Text = $"Доступно для установки: {availableCells}";

            // Подписка на событие авто симуляции
            gameTimer.Tick += timer_Step;

            // Создаем кнопки
            InitializeLoadingLabel();
            InitializeGameGrid();
        }

        private void InitializeGameGrid()
        {
            cells = new Button[fieldSize, fieldSize];

            // Вычисляем иразмер кнопки по минимальной стороне панели
            int minDimension = Math.Min(gameField.Width, gameField.Height);
            int buttonSize = minDimension / fieldSize;

            // Защита от деления на ноль
            if (buttonSize == 0) buttonSize = 1; 

            // Вычисляем отступы для центрирования сетки
            int offsetX = (gameField.Width - (buttonSize * fieldSize)) / 2;
            int offsetY = (gameField.Height - (buttonSize * fieldSize)) / 2;

            // Замораживаем интерфейс 
            gameField.SuspendLayout();

            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    Button cell = new Button();
                    cell.Size = new Size(buttonSize, buttonSize);

                    // Устанавливаем координаты кнопок
                    cell.Location = new Point(offsetX + col * buttonSize, offsetY + row * buttonSize);
                    cell.FlatStyle = FlatStyle.Flat;

                    // Задаем цвета кнопок
                    /*
                    if (random.Next(0, 2) == 1)
                    {
                        cell.BackColor = Color.Black;
                    }
                    else
                    {
                        */
                        cell.BackColor = Color.White;
                    //}

                    // Подписка на клик по клетке
                    cell.Click += cell_Click;

                    cells[row, col] = cell;
                    gameField.Controls.Add(cell);
                }
            }

            // Разамораживаем интерфейс 
            gameField.ResumeLayout(true);
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
                // Скрываем поле с кнопками 
                gameField.Visible = false;

                // Центрируем надпись
                lblLoading.Location = new Point(
                    (this.ClientSize.Width - lblLoading.Width) / 2,
                    (this.ClientSize.Height - lblLoading.Height) / 2 + 40
                );

                // Делаем метку видимой и выводим ее на передний план
                lblLoading.Visible = true;
                lblLoading.BringToFront();

                // Принудительно заставляем бновить интерфейс 
                Application.DoEvents();
            }
            else
            {
                // Скрываем метку и возвращаем видимость игрового поля
                lblLoading.Visible = false;
                gameField.Visible = true;
            }
        }

        private void gameField_Resize(object sender, EventArgs e)
        {
            if (cells == null) return;

            // Включаем режим загрузки
            ShowLoading(true);

            // Пересчитываем размеры под новые габариты окна
            int minDimension = Math.Min(gameField.Width, gameField.Height);
            int buttonSize = minDimension / fieldSize;
            if (buttonSize == 0) buttonSize = 1;

            // Вычисляем отступы для центрирования сетки
            int offsetX = (gameField.Width - (buttonSize * fieldSize)) / 2;
            int offsetY = (gameField.Height - (buttonSize * fieldSize)) / 2;

            // Отключаем обновления кнопок
            gameField.SuspendLayout();

            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    cells[row, col].Size = new Size(buttonSize, buttonSize);
                    cells[row, col].Location = new Point(offsetX + col * buttonSize, offsetY + row * buttonSize);
                }
            }

            // Выключаем режим загрузки
            gameField.ResumeLayout(true);
            ShowLoading(false);
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            isGameStarted = true;

            // Активируем кнопки 
            btnPause.Enabled = true;
            btnNextStep.Enabled = true;
            btnStartAuto.Enabled = true;

            // Скрываем кнопку старта
            btnStartGame.Hide();

            lblCellsStatus.Text = $"Текущее число клеток: {aliveCells}";

            // Текст цели раунда
            lblTargetScore = new Label();
            lblTargetScore.AutoSize = true;
            lblTargetScore.Dock = DockStyle.Fill;
            lblTargetScore.TextAlign = ContentAlignment.MiddleCenter;
            tlpTopMenu.Controls.Add(lblTargetScore, 3, 0);
            lblTargetScore.Text = $"Цель: 0";

            lblTargetScore.Text = $"{targetType} {targetCells.ToString()}";
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
            // Логика одного шага
            if (step < stepCount)
            {
                step++;
                pbGameProgress.Value = step;
                grpMovesInfo.Text = $"Осталось ходов: {stepCount - step} (из {stepCount})";
                simulate();
            }
            else
            {
                gameTimer.Stop();
                end_Game();
            }
        }

        private void simulate()
        {
            bool[,] nextState = new bool[fieldSize, fieldSize];
            aliveCells = 0;

            // Замораживаем интерфейс 
            gameField.SuspendLayout();

            // Создание поля для следующего шага
            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    int neighbors = countNeighbors(col, row);
                    bool isAlive = (cells[row, col].BackColor == Color.Black);

                    if (!isAlive && neighbors == 3)
                    {
                        nextState[row, col] = true;
                        aliveCells++;
                    }
                    else if (isAlive && (neighbors == 2 || neighbors == 3))
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

            // Перекрашивание кнопок согласно правилам
            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    cells[row, col].BackColor = nextState[row, col] ? Color.Black : Color.White;
                }
            }

            // Размораживаем интерфейс
            gameField.ResumeLayout(true);

            lblCellsStatus.Text = $"Текущее число клеток: {aliveCells}";

            if (aliveCells == 0)
            {
                end_Game();
            }
        }

        private int countNeighbors(int x, int y)
        {
            // Подсчитываем соседние живые клетки
            int count = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0)
                        continue;

                    int neighborX = x + j;
                    int neighborY = y + i;

                    // Проверка на выход за границы индекса массива
                    if (neighborX >= 0 && neighborX < fieldSize &&
                        neighborY >= 0 && neighborY < fieldSize)
                    {
                        if (cells[neighborY, neighborX].BackColor == Color.Black)
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
            // Расчитываем условия победы в зависимости от заданных условий
            if (aliveCells > targetCells && targetType == ">" ||
                aliveCells >= targetCells && targetType == ">=" ||
                aliveCells < targetCells && targetType == "<" ||
                aliveCells <= targetCells && targetType == "<=" ||
                aliveCells == targetCells && targetType == "==" ||
                aliveCells == targetCells && targetType == "="
           )
            {
                MessageBox.Show("Вы победили!");

            } else {
                MessageBox.Show("Вы проиграли :(");
            }
            // Останавливаем таймер, если он запущен
            if (gameTimer.Enabled)
                gameTimer.Stop();
            btnPause.Enabled = false;
            btnNextStep.Enabled = false;
            btnStartAuto.Enabled = false;
        }

        private void timer_Step(object sender, EventArgs e)
        {
            game_Step();
        }

        private void cell_Click(object sender, EventArgs e)
        {
            if (!isGameStarted)
            {
                Button cell = sender as Button;
                if (cell != null)
                {
                    // Красим клетки в противоположный цвет согласно количеству доступных клеток на размещение
                    if (cell.BackColor == Color.White && availableCells > 0)
                    {
                        cell.BackColor = Color.Black;
                        availableCells--;
                        aliveCells++;
                    }
                    else if (cell.BackColor == Color.Black)
                    {
                        cell.BackColor = Color.White;
                        availableCells++;
                        aliveCells--;
                    }
                    lblCellsStatus.Text = $"Доступно для установки: {availableCells}";
                }
            }
        }
    }
}