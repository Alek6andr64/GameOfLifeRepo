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
                if (lines.Length >= 8)
                {
                    int aliveCells = int.Parse(lines[0]);
                    int availableCells = int.Parse(lines[1]);
                    int stepCount = int.Parse(lines[2]);
                    int fieldSize = int.Parse(lines[3]); 
                    int targetCells = int.Parse(lines[4]);
                    string targetType = lines[5];
                    int step = int.Parse(lines[6]);

                    string field = lines[7];
                    int charIndex = 0;

                    bool[,] gameField = new bool[fieldSize, fieldSize]; 

                    for (int row = 0; row < fieldSize; row++)
                    {
                        for (int col = 0; col < fieldSize; col++)
                        {
                            if (field[charIndex] == '0')
                                gameField[row, col] = false;
                            else
                                gameField[row, col] = true;

                            charIndex++;
                        }
                    }

                    MessageBox.Show("Успешно загружено!");

                    Game game = new Game(fieldSize, 0, stepCount, targetCells, targetType, gameField, step);
                    game.Show();
                }
                else
                {
                    MessageBox.Show("Файл поврежден или имеет неверный формат.");
                }
            }
        }
    }
}
