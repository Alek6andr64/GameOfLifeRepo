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
        private int fieldSize = 50;
        private int cellCount = 25;
        private int stepCount = 90;

        public PreGameSettings()
        {
            InitializeComponent();
            numericUpDown1.Value = fieldSize;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Game game = new Game(fieldSize, cellCount, stepCount);
            game.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            fieldSize = (int)numericUpDown1.Value;

            gameFieldRepresentation.ColumnStyles.Clear();
            gameFieldRepresentation.RowStyles.Clear();

            gameFieldRepresentation.ColumnCount = fieldSize;
            gameFieldRepresentation.RowCount = fieldSize;


            for (int i = 0; i < gameFieldRepresentation.ColumnCount; i++)
            {
                gameFieldRepresentation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            }

            for (int i = 0; i < gameFieldRepresentation.RowCount; i++)
            {
                gameFieldRepresentation.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            cellCount = (int)numericUpDown4.Value;
        }


        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            stepCount = (int)numericUpDown5.Value;
        }
    }
}
