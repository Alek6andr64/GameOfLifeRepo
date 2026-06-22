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
            components = new System.ComponentModel.Container();
            mainMenuTable = new TableLayoutPanel();
            preGameSettingsTitle = new Label();
            groupBox5 = new GroupBox();
            numericUpDown5 = new NumericUpDown();
            groupBox4 = new GroupBox();
            numericUpDown4 = new NumericUpDown();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            groupBox6 = new GroupBox();
            comboBox1 = new ComboBox();
            startButton = new Button();
            groupBox7 = new GroupBox();
            textBox3 = new TextBox();
            splitContainer1 = new SplitContainer();
            toolTip1 = new ToolTip(components);
            mainMenuTable.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuTable
            // 
            mainMenuTable.AutoSize = true;
            mainMenuTable.ColumnCount = 3;
            mainMenuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.323505F));
            mainMenuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.3583145F));
            mainMenuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.31818056F));
            mainMenuTable.Controls.Add(preGameSettingsTitle, 1, 1);
            mainMenuTable.Controls.Add(groupBox5, 1, 8);
            mainMenuTable.Controls.Add(groupBox4, 1, 7);
            mainMenuTable.Controls.Add(groupBox3, 1, 6);
            mainMenuTable.Controls.Add(groupBox2, 1, 5);
            mainMenuTable.Controls.Add(groupBox1, 1, 4);
            mainMenuTable.Controls.Add(groupBox6, 1, 3);
            mainMenuTable.Controls.Add(startButton, 1, 11);
            mainMenuTable.Controls.Add(groupBox7, 1, 9);
            mainMenuTable.Dock = DockStyle.Fill;
            mainMenuTable.Location = new Point(0, 0);
            mainMenuTable.Margin = new Padding(5, 8, 5, 8);
            mainMenuTable.Name = "mainMenuTable";
            mainMenuTable.RowCount = 13;
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            mainMenuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            mainMenuTable.Size = new Size(656, 797);
            mainMenuTable.TabIndex = 1;
            // 
            // preGameSettingsTitle
            // 
            preGameSettingsTitle.Dock = DockStyle.Fill;
            preGameSettingsTitle.Font = new Font("Impact", 25F);
            preGameSettingsTitle.Location = new Point(53, 61);
            preGameSettingsTitle.Margin = new Padding(5, 0, 5, 0);
            preGameSettingsTitle.Name = "preGameSettingsTitle";
            preGameSettingsTitle.Size = new Size(556, 61);
            preGameSettingsTitle.TabIndex = 0;
            preGameSettingsTitle.Text = "Условия Игры";
            preGameSettingsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(numericUpDown5);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(51, 491);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(560, 55);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Количество ходов:";
            toolTip1.SetToolTip(groupBox5, "Определяет количество шагов которое пройдет в симуляции до конца игры");
            // 
            // numericUpDown5
            // 
            numericUpDown5.Dock = DockStyle.Fill;
            numericUpDown5.Location = new Point(3, 27);
            numericUpDown5.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown5.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(554, 31);
            numericUpDown5.TabIndex = 3;
            numericUpDown5.Value = new decimal(new int[] { 90, 0, 0, 0 });
            numericUpDown5.ValueChanged += numericUpDown5_ValueChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(numericUpDown4);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(51, 430);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(560, 55);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Клеток на размещение:";
            toolTip1.SetToolTip(groupBox4, "Количество клеток доступных для размещения перед началом игры");
            // 
            // numericUpDown4
            // 
            numericUpDown4.Dock = DockStyle.Fill;
            numericUpDown4.Location = new Point(3, 27);
            numericUpDown4.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown4.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(554, 31);
            numericUpDown4.TabIndex = 2;
            numericUpDown4.Value = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDown4.ValueChanged += numericUpDown4_ValueChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(51, 369);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(560, 55);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Нужно соседей для смерти:";
            toolTip1.SetToolTip(groupBox3, "В");
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Enabled = false;
            textBox2.Location = new Point(3, 27);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "4,5,6,7,8";
            textBox2.Size = new Size(554, 31);
            textBox2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(51, 308);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(560, 55);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Нужно соседей для выживания:";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Enabled = false;
            textBox1.Location = new Point(3, 27);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "2,3";
            textBox1.Size = new Size(554, 31);
            textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(51, 247);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 55);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Размер поля ";
            toolTip1.SetToolTip(groupBox1, "Влияет на длину и ширину игрового поля");
            // 
            // numericUpDown1
            // 
            numericUpDown1.Dock = DockStyle.Fill;
            numericUpDown1.Location = new Point(3, 27);
            numericUpDown1.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(554, 31);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(comboBox1);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Location = new Point(51, 186);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(560, 55);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "Режим Игры";
            toolTip1.SetToolTip(groupBox6, "Определяет условия и цели игры");
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Классика", "Бесконечный" });
            comboBox1.Location = new Point(3, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(554, 31);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // startButton
            // 
            startButton.Dock = DockStyle.Fill;
            startButton.Location = new Point(52, 676);
            startButton.Margin = new Padding(4, 5, 4, 5);
            startButton.Name = "startButton";
            startButton.Size = new Size(558, 51);
            startButton.TabIndex = 1;
            startButton.Text = "Начать";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(textBox3);
            groupBox7.Dock = DockStyle.Fill;
            groupBox7.Location = new Point(51, 552);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(560, 55);
            groupBox7.TabIndex = 8;
            groupBox7.TabStop = false;
            groupBox7.Text = "Условие победы:";
            toolTip1.SetToolTip(groupBox7, "Определяет условия победы, формат записи: *символ**число* (Доступные символы: >, <, <=, >=, ==)");
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(3, 27);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = ">50";
            textBox3.Size = new Size(554, 31);
            textBox3.TabIndex = 0;
            textBox3.Leave += textBox3_Leave;
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
            splitContainer1.Size = new Size(1128, 797);
            splitContainer1.SplitterDistance = 656;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 2;
            // 
            // PreGameSettings
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 797);
            Controls.Add(splitContainer1);
            Font = new Font("Impact", 14.25F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PreGameSettings";
            Text = "PreGameSettings";
            mainMenuTable.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainMenuTable;
        private Label preGameSettingsTitle;
        private SplitContainer splitContainer1;
        private StatusStrip statusStrip1;
        private Button startButton;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private GroupBox groupBox6;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox7;
        private TextBox textBox3;
        private ToolTip toolTip1;
    }
}