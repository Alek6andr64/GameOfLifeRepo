namespace GameOfLife
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void startGameButton_Click (object sender, EventArgs e)
        {
            PreGameSettings preGameSettings = new PreGameSettings();
            preGameSettings.Show();

        }
    }
}
