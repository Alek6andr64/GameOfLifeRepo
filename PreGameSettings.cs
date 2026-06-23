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
        private string surviveRules = "23";
        private string birthRules = "3";

        public PreGameSettings()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            numericUpDown1.Value = fieldSize;

            textBox1.Text = "2,3";
            textBox2.Text = "3";
            textBox3.Text = ">50";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Game game = new Game(fieldSize, cellCount, stepCount, targetCells, targetType, (short)comboBox1.SelectedIndex, surviveRules, birthRules);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                groupBox5.Hide();
                groupBox7.Hide();
            }
            else
            {
                groupBox5.Show();
                groupBox7.Show();
            }
        }

        private string ParseRules(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;

            var digits = new HashSet<char>();
            foreach (char c in input)
            {
                if (c >= '0' && c <= '8')
                {
                    digits.Add(c);
                }
            }

            return string.Join("", digits.OrderBy(d => d));
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Поле не может быть пустым. Установлено значение по умолчанию: 2,3");
                surviveRules = "23";
                textBox1.Text = "2,3";
                return;
            }

            string parsed = ParseRules(input);

            if (string.IsNullOrEmpty(parsed))
            {
                MessageBox.Show("Введено некорректное правило выживания. Разрешены только цифры от 0 до 8. Установлено значение по умолчанию: 2,3");
                surviveRules = "23";
                textBox1.Text = "2,3";
            }
            else
            {
                surviveRules = parsed;
                textBox1.Text = string.Join(",", parsed.Select(c => c.ToString()));
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            string input = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Поле не может быть пустым. Установлено значение по умолчанию: 3");
                birthRules = "3";
                textBox2.Text = "3";
                return;
            }

            string parsed = ParseRules(input);

            if (string.IsNullOrEmpty(parsed))
            {
                MessageBox.Show("Введено некорректное правило рождения. Разрешены только цифры от 0 до 8. Установлено значение по умолчанию: 3");
                birthRules = "3";
                textBox2.Text = "3";
            }
            else
            {
                birthRules = parsed;
                textBox2.Text = string.Join(",", parsed.Select(c => c.ToString()));
            }
        }
    }
}