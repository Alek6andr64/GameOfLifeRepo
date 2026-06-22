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
            statusStrip = new StatusStrip();
            slMoveCount = new ToolStripStatusLabel();
            pbGameProgress = new ToolStripProgressBar();
            tlpTopMenu = new TableLayoutPanel();
            grpMovesInfo = new GroupBox();
            numGameSpeed = new NumericUpDown();
            tlpControlButtons = new TableLayoutPanel();
            btnPause = new Button();
            btnNextStep = new Button();
            btnStartAuto = new Button();
            lblCellsStatus = new Label();
            btnStartGame = new Button();
            btnSaveAndRand = new Button();
            btnClearAndLeave = new Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            toolTip = new ToolTip(components);
            gameField.SuspendLayout();
            statusStrip.SuspendLayout();
            tlpTopMenu.SuspendLayout();
            grpMovesInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGameSpeed).BeginInit();
            tlpControlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // gameField
            // 
            gameField.Controls.Add(statusStrip);
            gameField.Dock = DockStyle.Fill;
            gameField.Location = new Point(0, 83);
            gameField.Margin = new Padding(4, 5, 4, 5);
            gameField.Name = "gameField";
            gameField.Size = new Size(1184, 678);
            gameField.TabIndex = 1;
            gameField.Resize += gameField_Resize;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { slMoveCount, pbGameProgress });
            statusStrip.Location = new Point(0, 656);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1184, 22);
            statusStrip.TabIndex = 0;
            statusStrip.Text = "statusStrip1";
            // 
            // slMoveCount
            // 
            slMoveCount.ForeColor = SystemColors.ControlText;
            slMoveCount.Name = "slMoveCount";
            slMoveCount.Size = new Size(94, 17);
            slMoveCount.Text = "Прогресс игры:";
            // 
            // pbGameProgress
            // 
            pbGameProgress.Name = "pbGameProgress";
            pbGameProgress.Size = new Size(250, 16);
            // 
            // tlpTopMenu
            // 
            tlpTopMenu.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tlpTopMenu.ColumnCount = 6;
            tlpTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.242527F));
            tlpTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.69869F));
            tlpTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.69869F));
            tlpTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.69869F));
            tlpTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3307009F));
            tlpTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3307009F));
            tlpTopMenu.Controls.Add(grpMovesInfo, 0, 0);
            tlpTopMenu.Controls.Add(tlpControlButtons, 1, 0);
            tlpTopMenu.Controls.Add(lblCellsStatus, 2, 0);
            tlpTopMenu.Controls.Add(btnStartGame, 3, 0);
            tlpTopMenu.Controls.Add(btnSaveAndRand, 4, 0);
            tlpTopMenu.Controls.Add(btnClearAndLeave, 5, 0);
            tlpTopMenu.Dock = DockStyle.Top;
            tlpTopMenu.Location = new Point(0, 0);
            tlpTopMenu.Margin = new Padding(4, 5, 4, 5);
            tlpTopMenu.Name = "tlpTopMenu";
            tlpTopMenu.RowCount = 1;
            tlpTopMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTopMenu.Size = new Size(1184, 83);
            tlpTopMenu.TabIndex = 0;
            // 
            // grpMovesInfo
            // 
            grpMovesInfo.Controls.Add(numGameSpeed);
            grpMovesInfo.Dock = DockStyle.Fill;
            grpMovesInfo.Location = new Point(6, 7);
            grpMovesInfo.Margin = new Padding(4, 5, 4, 5);
            grpMovesInfo.Name = "grpMovesInfo";
            grpMovesInfo.Padding = new Padding(4, 5, 4, 5);
            grpMovesInfo.Size = new Size(275, 69);
            grpMovesInfo.TabIndex = 1;
            grpMovesInfo.TabStop = false;
            grpMovesInfo.Text = "Скорость ходов:";
            // 
            // numGameSpeed
            // 
            numGameSpeed.Dock = DockStyle.Fill;
            numGameSpeed.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numGameSpeed.Location = new Point(4, 29);
            numGameSpeed.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numGameSpeed.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numGameSpeed.Name = "numGameSpeed";
            numGameSpeed.Size = new Size(267, 31);
            numGameSpeed.TabIndex = 0;
            toolTip.SetToolTip(numGameSpeed, "Определяет сколько миллисекунд уходит на ход");
            numGameSpeed.Value = new decimal(new int[] { 1500, 0, 0, 0 });
            numGameSpeed.ValueChanged += numGameSpeed_ValueChanged;
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
            tlpControlButtons.Location = new Point(290, 5);
            tlpControlButtons.Name = "tlpControlButtons";
            tlpControlButtons.RowCount = 1;
            tlpControlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpControlButtons.Size = new Size(201, 73);
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
            btnPause.Size = new Size(60, 67);
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
            btnNextStep.Location = new Point(69, 3);
            btnNextStep.Name = "btnNextStep";
            btnNextStep.Size = new Size(60, 67);
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
            btnStartAuto.Location = new Point(135, 3);
            btnStartAuto.Name = "btnStartAuto";
            btnStartAuto.Size = new Size(63, 67);
            btnStartAuto.TabIndex = 2;
            btnStartAuto.UseVisualStyleBackColor = true;
            btnStartAuto.Click += btnStartAuto_Click;
            // 
            // lblCellsStatus
            // 
            lblCellsStatus.AutoSize = true;
            lblCellsStatus.Dock = DockStyle.Fill;
            lblCellsStatus.Location = new Point(500, 2);
            lblCellsStatus.Margin = new Padding(4, 0, 4, 0);
            lblCellsStatus.Name = "lblCellsStatus";
            lblCellsStatus.Size = new Size(199, 79);
            lblCellsStatus.TabIndex = 0;
            lblCellsStatus.Text = "Осталось клеток: 0";
            lblCellsStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStartGame
            // 
            btnStartGame.Dock = DockStyle.Fill;
            btnStartGame.Location = new Point(708, 5);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(201, 73);
            btnStartGame.TabIndex = 3;
            btnStartGame.Text = "Начать";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // btnSaveAndRand
            // 
            btnSaveAndRand.Dock = DockStyle.Fill;
            btnSaveAndRand.Location = new Point(917, 5);
            btnSaveAndRand.Name = "btnSaveAndRand";
            btnSaveAndRand.Size = new Size(126, 73);
            btnSaveAndRand.TabIndex = 4;
            btnSaveAndRand.Text = "Рандомизировать поле";
            btnSaveAndRand.UseVisualStyleBackColor = true;
            btnSaveAndRand.Click += btnSaveAndRand_Click;
            // 
            // btnClearAndLeave
            // 
            btnClearAndLeave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClearAndLeave.Dock = DockStyle.Fill;
            btnClearAndLeave.Location = new Point(1051, 5);
            btnClearAndLeave.Name = "btnClearAndLeave";
            btnClearAndLeave.Size = new Size(128, 73);
            btnClearAndLeave.TabIndex = 5;
            btnClearAndLeave.Text = "Очистить поле";
            btnClearAndLeave.UseMnemonic = false;
            btnClearAndLeave.UseVisualStyleBackColor = true;
            btnClearAndLeave.Click += btnClearAndLeave_Click;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 1500;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(gameField);
            Controls.Add(tlpTopMenu);
            Font = new Font("Impact", 14.25F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Game";
            Text = "Game";
            gameField.ResumeLayout(false);
            gameField.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            tlpTopMenu.ResumeLayout(false);
            tlpTopMenu.PerformLayout();
            grpMovesInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numGameSpeed).EndInit();
            tlpControlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel gameField;
        private System.Windows.Forms.TableLayoutPanel tlpTopMenu;
        private System.Windows.Forms.Label lblCellsStatus;
        private System.Windows.Forms.GroupBox grpMovesInfo;
        private System.Windows.Forms.TableLayoutPanel tlpControlButtons;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.Button btnStartAuto;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Timer gameTimer;
        private Button btnSaveAndRand;
        private Button btnClearAndLeave;
        private StatusStrip statusStrip;
        private ToolStripProgressBar pbGameProgress;
        private NumericUpDown numGameSpeed;
        private NotifyIcon notifyIcon1;
        private ToolTip toolTip;
        private ToolStripStatusLabel slMoveCount;
    }
}