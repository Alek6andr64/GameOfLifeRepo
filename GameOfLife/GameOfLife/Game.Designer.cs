namespace GameOfLife
{
    partial class Game
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gameField = new Panel();
            tlpTopMenu = new TableLayoutPanel();
            grpMovesInfo = new GroupBox();
            pbGameProgress = new ProgressBar();
            tlpControlButtons = new TableLayoutPanel();
            btnPause = new Button();
            btnNextStep = new Button();
            btnStartAuto = new Button();
            lblCellsStatus = new Label();
            btnStartGame = new Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            tlpTopMenu.SuspendLayout();
            grpMovesInfo.SuspendLayout();
            tlpControlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // gameField
            // 
            gameField.Dock = DockStyle.Fill;
            gameField.Location = new Point(0, 83);
            gameField.Margin = new Padding(4, 5, 4, 5);
            gameField.Name = "gameField";
            gameField.Size = new Size(1029, 607);
            gameField.TabIndex = 1;
            gameField.Resize += gameField_Resize;
            // 
            // tlpTopMenu
            // 
            tlpTopMenu.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tlpTopMenu.ColumnCount = 5;
            tlpTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpTopMenu.Controls.Add(grpMovesInfo, 0, 0);
            tlpTopMenu.Controls.Add(tlpControlButtons, 1, 0);
            tlpTopMenu.Controls.Add(lblCellsStatus, 2, 0);
            tlpTopMenu.Controls.Add(btnStartGame, 3, 0);
            tlpTopMenu.Dock = DockStyle.Top;
            tlpTopMenu.Location = new Point(0, 0);
            tlpTopMenu.Margin = new Padding(4, 5, 4, 5);
            tlpTopMenu.Name = "tlpTopMenu";
            tlpTopMenu.RowCount = 1;
            tlpTopMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTopMenu.Size = new Size(1029, 83);
            tlpTopMenu.TabIndex = 0;
            // 
            // grpMovesInfo
            // 
            grpMovesInfo.Controls.Add(pbGameProgress);
            grpMovesInfo.Dock = DockStyle.Fill;
            grpMovesInfo.Location = new Point(6, 7);
            grpMovesInfo.Margin = new Padding(4, 5, 4, 5);
            grpMovesInfo.Name = "grpMovesInfo";
            grpMovesInfo.Padding = new Padding(4, 5, 4, 5);
            grpMovesInfo.Size = new Size(195, 69);
            grpMovesInfo.TabIndex = 1;
            grpMovesInfo.TabStop = false;
            grpMovesInfo.Text = "Осталось ходов:";
            // 
            // pbGameProgress
            // 
            pbGameProgress.BackColor = SystemColors.Control;
            pbGameProgress.Dock = DockStyle.Fill;
            pbGameProgress.ForeColor = SystemColors.ActiveCaption;
            pbGameProgress.Location = new Point(4, 29);
            pbGameProgress.Name = "pbGameProgress";
            pbGameProgress.Size = new Size(187, 35);
            pbGameProgress.Style = ProgressBarStyle.Continuous;
            pbGameProgress.TabIndex = 0;
            // 
            // tlpControlButtons
            // 
            tlpControlButtons.ColumnCount = 3;
            tlpControlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpControlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpControlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpControlButtons.Controls.Add(btnPause, 0, 0);
            tlpControlButtons.Controls.Add(btnNextStep, 1, 0);
            tlpControlButtons.Controls.Add(btnStartAuto, 2, 0);
            tlpControlButtons.Dock = DockStyle.Fill;
            tlpControlButtons.Location = new Point(210, 5);
            tlpControlButtons.Name = "tlpControlButtons";
            tlpControlButtons.RowCount = 1;
            tlpControlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpControlButtons.Size = new Size(197, 73);
            tlpControlButtons.TabIndex = 2;
            // 
            // btnPause
            // 
            btnPause.BackgroundImageLayout = ImageLayout.Zoom;
            btnPause.Dock = DockStyle.Fill;
            btnPause.Enabled = false;
            btnPause.ForeColor = SystemColors.ControlText;
            btnPause.Image = Properties.Resources.pause_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            btnPause.Location = new Point(3, 3);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(59, 67);
            btnPause.TabIndex = 0;
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnNextStep
            // 
            btnNextStep.BackgroundImageLayout = ImageLayout.Zoom;
            btnNextStep.Dock = DockStyle.Fill;
            btnNextStep.Enabled = false;
            btnNextStep.Image = Properties.Resources.keyboard_arrow_right_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            btnNextStep.Location = new Point(68, 3);
            btnNextStep.Name = "btnNextStep";
            btnNextStep.Size = new Size(59, 67);
            btnNextStep.TabIndex = 1;
            btnNextStep.UseVisualStyleBackColor = true;
            btnNextStep.Click += btnNextStep_Click;
            // 
            // btnStartAuto
            // 
            btnStartAuto.BackgroundImageLayout = ImageLayout.Zoom;
            btnStartAuto.Dock = DockStyle.Fill;
            btnStartAuto.Enabled = false;
            btnStartAuto.Image = Properties.Resources.keyboard_double_arrow_right_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            btnStartAuto.Location = new Point(133, 3);
            btnStartAuto.Name = "btnStartAuto";
            btnStartAuto.Size = new Size(61, 67);
            btnStartAuto.TabIndex = 2;
            btnStartAuto.UseVisualStyleBackColor = true;
            btnStartAuto.Click += btnStartAuto_Click;
            // 
            // lblCellsStatus
            // 
            lblCellsStatus.AutoSize = true;
            lblCellsStatus.Dock = DockStyle.Fill;
            lblCellsStatus.Location = new Point(416, 2);
            lblCellsStatus.Margin = new Padding(4, 0, 4, 0);
            lblCellsStatus.Name = "lblCellsStatus";
            lblCellsStatus.Size = new Size(195, 79);
            lblCellsStatus.TabIndex = 0;
            lblCellsStatus.Text = "Осталось клеток: 0";
            lblCellsStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStartGame
            // 
            btnStartGame.Dock = DockStyle.Fill;
            btnStartGame.Location = new Point(620, 5);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(197, 73);
            btnStartGame.TabIndex = 3;
            btnStartGame.Text = "Начать";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 1500;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 690);
            Controls.Add(gameField);
            Controls.Add(tlpTopMenu);
            Font = new Font("Impact", 14.25F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Game";
            Text = "Game";
            tlpTopMenu.ResumeLayout(false);
            tlpTopMenu.PerformLayout();
            grpMovesInfo.ResumeLayout(false);
            tlpControlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel gameField;
        private System.Windows.Forms.TableLayoutPanel tlpTopMenu;
        private System.Windows.Forms.Label lblCellsStatus;
        private System.Windows.Forms.GroupBox grpMovesInfo;
        private System.Windows.Forms.ProgressBar pbGameProgress;
        private System.Windows.Forms.TableLayoutPanel tlpControlButtons;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.Button btnStartAuto;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Timer gameTimer;
    }
}