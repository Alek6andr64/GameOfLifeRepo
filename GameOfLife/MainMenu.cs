namespace GameOfLife
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            PreGameSettings preGameSettings = new PreGameSettings();
            preGameSettings.Show();

        }

        private void loadGameButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName);
                if (lines.Length >= 11)
                {
                    int aliveCells = int.Parse(lines[0]);
                    int availableCells = int.Parse(lines[1]);

                    int stepCount = int.Parse(lines[2]);
                    int fieldSize = int.Parse(lines[3]);

                    int targetCells = int.Parse(lines[4]);
                    string targetType = lines[5];
                    int step = int.Parse(lines[6]);
                    short gameType = short.Parse(lines[7]);

                    string loadedSurvive = lines[8];
                    string loadedBirth = lines[9];

                    string field = lines[10];
                    int charIndex = 0;

                    bool[,] gameField = new bool[fieldSize, fieldSize];

                    for (int row = 0; row < fieldSize; row++)
                    {
                        for (int col = 0; col < fieldSize; col++)
                        {
                            gameField[row, col] = field[charIndex] != '0';
                            charIndex++;
                        }
                    }

                    MessageBox.Show("Успешно загружено!");

                    Game game = new Game(fieldSize, 0, stepCount, targetCells, targetType, gameType, loadedSurvive, loadedBirth, gameField, step);
                    game.Show();
                }
                else
                {
                    MessageBox.Show("Файл поврежден или имеет устаревший формат.");
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            string helpText =
                "ЧТО ТАКОЕ ИГРА «ЖИЗНЬ»?\n" +
                "Это математический симулятор, созданный Джоном Конвеем. " +
                "Здесь вы лишь задаете начальные условия, " +
                "а затем наблюдаете, как эволюционирует созданный вами мир.\n\n" +

                "Жизнь вселенной подчиняется двум правилам (B/S):\n" +
                "- Рождение (Birth) — при каком количестве соседей на пустой клетке зарождается жизнь.\n" +
                "- Выживание (Survival) — сколько соседей нужно живой клетке, чтобы не умереть от одиночества или перенаселения.\n\n" +

                "РЕЖИМЫ ИГРЫ\n" +
                "1. Стандартный\n" +
                "У вас есть ограниченное количество клеток для установки и лимит ходов. " +
                "Ваша цель — расставить клетки так, чтобы к концу таймера популяция достигла заданного значения (например, стало больше 50 клеток).\n\n" +

                "2. Бесконечный\n" +
                "Полная свобода творчества. Лимитов на ходы и клетки нет. Вы можете рисовать на поле любые фигуры, " +
                "экспериментировать с правилами физики мира и запускать бесконечную симуляцию.";

            MessageBox.Show(helpText, "Справка по игре", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
