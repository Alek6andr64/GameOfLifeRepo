namespace GameOfLife
{
    partial class PreGameSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainMenuTable = new TableLayoutPanel();
            preGameSettingsTitle = new Label();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            startButton = new Button();
            mainMenuTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuTable
            // 
            mainMenuTable.AutoSize = true;
            mainMenuTable.ColumnCount = 3;
            mainMenuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.4908371F));
            mainMenuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.018322F));
            mainMenuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.49084F));
            mainMenuTable.Controls.Add(preGameSettingsTitle, 1, 1);
            mainMenuTable.Controls.Add(startButton, 1, 9);
            mainMenuTable.Dock = DockStyle.Fill;
            mainMenuTable.Location = new Point(0, 0);
            mainMenuTable.Margin = new Padding(5, 8, 5, 8);
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
            mainMenuTable.Size = new Size(456, 561);
            mainMenuTable.TabIndex = 1;
            // 
            // preGameSettingsTitle
            // 
            preGameSettingsTitle.Dock = DockStyle.Fill;
            preGameSettingsTitle.Font = new Font("Impact", 25F);
            preGameSettingsTitle.Location = new Point(134, 50);
            preGameSettingsTitle.Margin = new Padding(5, 0, 5, 0);
            preGameSettingsTitle.Name = "preGameSettingsTitle";
            preGameSettingsTitle.Size = new Size(186, 50);
            preGameSettingsTitle.TabIndex = 0;
            preGameSettingsTitle.Text = "Настройки Игры";
            preGameSettingsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 5, 4, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(mainMenuTable);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(784, 561);
            splitContainer1.SplitterDistance = 456;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(323, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(111, 192);
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(99, 177);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // startButton
            // 
            startButton.Dock = DockStyle.Fill;
            startButton.Location = new Point(133, 455);
            startButton.Margin = new Padding(4, 5, 4, 5);
            startButton.Name = "startButton";
            startButton.Size = new Size(188, 40);
            startButton.TabIndex = 1;
            startButton.Text = "Начать";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // PreGameSettings
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(splitContainer1);
            Font = new Font("Impact", 14.25F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PreGameSettings";
            Text = "PreGameSettings";
            mainMenuTable.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainMenuTable;
        private Label preGameSettingsTitle;
        private SplitContainer splitContainer1;
        private StatusStrip statusStrip1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button startButton;
    }
}