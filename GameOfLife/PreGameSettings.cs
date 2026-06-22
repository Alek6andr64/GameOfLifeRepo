using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class PreGameSettings : Form
    {
        private int fieldSize = 25;
        private int cellCount = 25;
        private int stepCount = 90;
        private int targetCells = 50;
        private string targetType = ">";
        public PreGameSettings()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            numericUpDown1.Value = fieldSize;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Game game = new Game(fieldSize, cellCount, stepCount, targetCells, targetType);
            game.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            fieldSize = (int)numericUpDown1.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            cellCount = (int)numericUpDown4.Value;
        }


        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            stepCount = (int)numericUpDown5.Value;
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            string text = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Поле не может быть пустым. Установлено значение по умолчанию: >50");
                targetType = ">";
                targetCells = 50;
                textBox3.Text = targetType + targetCells.ToString();
                return;
            }

            if (text[0] == '>' || text[0] == '<' || text[0] == '=')
            {
                if (text.Length > 1 && text[1] == '=')
                {
                    targetType = text.Substring(0, 2); 
                }
                else
                {
                    targetType = text[0].ToString();
                }

                string numberPart = text.Substring(targetType.Length);
                if (!int.TryParse(numberPart, out targetCells))
                {
                    targetCells = 50;
                    MessageBox.Show("Введено некорректное число. Установлено значение по умолчанию: 50");
                }
            }
            else
            {
                MessageBox.Show("Введено некорректное правило. Установлено значение по умолчанию: >50");
                targetType = ">";
                targetCells = 50;
            }

            textBox3.Text = targetType + targetCells.ToString();
        }
    }
}
