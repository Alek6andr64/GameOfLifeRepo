namespace GameOfLife
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainMenuTable = new TableLayoutPanel();
            gameTitle = new Label();
            startGameButton = new Button();
            loadGameButton = new Button();
            settingsButton = new Button();
            exitButton = new Button();
            mainMenuTable.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuTable
            // 
            mainMenuTable.AutoSize = true;
            mainMenuTable.ColumnCount = 5;
            mainMenuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            mainMenuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            mainMenuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            mainMenuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            mainMenuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            mainMenuTable.Controls.Add(gameTitle, 1, 1);
            mainMenuTable.Controls.Add(startGameButton, 1, 3);
            mainMenuTable.Controls.Add(loadGameButton, 1, 5);
            mainMenuTable.Controls.Add(settingsButton, 1, 7);
            mainMenuTable.Controls.Add(exitButton, 1, 9);
            mainMenuTable.Dock = DockStyle.Fill;
            mainMenuTable.Location = new Point(0, 0);
            mainMenuTable.Margin = new Padding(4, 5, 4, 5);
            mainMenuTable.Name = "mainMenuTable";
            mainMenuTable.RowCount = 11;
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            mainMenuTable.Size = new Size(784, 861);
            mainMenuTable.TabIndex = 0;
            // 
            // gameTitle
            // 
            gameTitle.Dock = DockStyle.Fill;
            gameTitle.Font = new Font("Impact", 25F);
            gameTitle.Location = new Point(134, 78);
            gameTitle.Margin = new Padding(4, 0, 4, 0);
            gameTitle.Name = "gameTitle";
            gameTitle.Size = new Size(253, 78);
            gameTitle.TabIndex = 0;
            gameTitle.Text = "Игра \"Жизнь\"";
            gameTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startGameButton
            // 
            startGameButton.Dock = DockStyle.Fill;
            startGameButton.Location = new Point(134, 239);
            startGameButton.Margin = new Padding(4, 5, 4, 5);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(253, 68);
            startGameButton.TabIndex = 1;
            startGameButton.Text = "Начать Новую Игру";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += startGameButton_Click;
            // 
            // loadGameButton
            // 
            loadGameButton.Dock = DockStyle.Fill;
            loadGameButton.Location = new Point(134, 395);
            loadGameButton.Margin = new Padding(4, 5, 4, 5);
            loadGameButton.Name = "loadGameButton";
            loadGameButton.Size = new Size(253, 68);
            loadGameButton.TabIndex = 2;
            loadGameButton.Text = "Загрузить Сохранение";
            loadGameButton.UseVisualStyleBackColor = true;
            loadGameButton.Click += loadGameButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.Dock = DockStyle.Fill;
            settingsButton.Location = new Point(134, 551);
            settingsButton.Margin = new Padding(4, 5, 4, 5);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(253, 68);
            settingsButton.TabIndex = 3;
            settingsButton.Text = "Настройки";
            settingsButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Dock = DockStyle.Fill;
            exitButton.Location = new Point(134, 707);
            exitButton.Margin = new Padding(4, 5, 4, 5);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(253, 68);
            exitButton.TabIndex = 4;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 861);
            Controls.Add(mainMenuTable);
            Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainMenu";
            Text = "Main Menu";
            mainMenuTable.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel mainMenuTable;
        private Label gameTitle;
        private Button startGameButton;
        private Button loadGameButton;
        private Button settingsButton;
        private Button exitButton;
    }
}
