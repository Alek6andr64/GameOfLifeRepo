using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace GameOfLife
{
    public partial class Game : Form
    {
        private Random random = new Random();
        private int aliveCells = 0;
        private int availableCells;
        private int stepCount;
        private int fieldSize;
        private int step = 0;
        private bool isGameStarted = false;         

        public Game(int fieldSize, int availableCells, int stepCount)
        {
            InitializeComponent();

            this.availableCells = availableCells;
            this.stepCount = stepCount;
            this.fieldSize = fieldSize;

            gameField.ColumnStyles.Clear();
            gameField.RowStyles.Clear();

            gameField.ColumnCount = fieldSize;
            gameField.RowCount = fieldSize;

            float percent = 100f / fieldSize;
            for (int i = 0; i < gameField.ColumnCount; i++)
            {
                gameField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, percent));
            }

            for (int i = 0; i < gameField.RowCount; i++)
            {
                gameField.RowStyles.Add(new RowStyle(SizeType.Percent, percent));
            }

            progressBar1.Maximum = stepCount;
            groupBox1.Text = $"Осталось ходов: {stepCount}  (из {stepCount})";
            label1.Text = $"Доступно для установки: {availableCells}";

            timer1.Tick += timer_Step;

            for (int i = 0; i < gameField.RowCount; i++)
            {
                for (int j = 0; j < gameField.ColumnCount; j++)
                {
                    Panel cell = new Panel();
                    cell.Margin = new Padding(1); 
                    cell.BackColor = Color.White;
                    if (random.Next(0,2)  == 1)
                    {
                        cell.BackColor = Color.Black;
                    }
                    cell.Dock = DockStyle.Fill;
                    cell.Click += cell_Click;

                    gameField.Controls.Add(cell, j, i);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            isGameStarted = true;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

            button4.Hide();

            label1.Text = $"Текущее число клеток: {aliveCells}";

            Label label2 = new Label();
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            tableLayoutPanel1.Controls.Add(label2, 3, 0);
            label2.Text = $"Цель: 0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game_Step();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                timer1.Start();
        }

        private void game_Step()
        {
            if (step < stepCount)
            {
                step++;
                progressBar1.Value = step;
                groupBox1.Text = $"Осталось ходов: {stepCount - step} (из {stepCount})";
                simulate();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void simulate()
        {
            bool[,] nextState = new bool[fieldSize, fieldSize];
            aliveCells = 0;

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    int neighbors = countNeighbors(j, i);
                    Control cell = gameField.GetControlFromPosition(j, i);
                    if (cell == null) continue;

                    bool isAlive = (cell.BackColor == Color.Black);

                    if (!isAlive && neighbors == 3)
                    {
                        nextState[i, j] = true;
                        aliveCells++;
                    }
                    else if (isAlive && (neighbors == 2 || neighbors == 3))
                    {
                        nextState[i, j] = true;
                        aliveCells++;
                    }
                    else
                    {
                        nextState[i, j] = false;
                    }
                }
            }

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    Control cell = gameField.GetControlFromPosition(j, i);
                    if (cell == null) continue;

                    cell.BackColor = nextState[i, j] ? Color.Black : Color.White;
                }
            }

            label1.Text = $"Текущее число клеток: {aliveCells}";
        }

        private int countNeighbors(int x, int y)
        {
            int count = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0)
                        continue;

                    int neighborX = x + i;
                    int neighborY = y + j;

                    if (neighborX >= 0 && neighborX < fieldSize &&
                        neighborY >= 0 && neighborY < fieldSize)
                    {
                        Control cell = gameField.GetControlFromPosition(neighborX, neighborY);
                        if (cell != null && cell.BackColor == Color.Black)
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
            MessageBox.Show("Игра окончена. ");
        }

        private void timer_Step(object sender, EventArgs e)
        {
            game_Step();
        }

        private void cell_Click(object sender, EventArgs e)
        {
            if (!isGameStarted)
            {
                Panel cell = sender as Panel;
                if (cell != null)
                {
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
                    label1.Text = $"Доступно для установки: {availableCells}";
                }
            }
        }
    }
}
