using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Tic_tac_toe_Online
{
    public partial class Form1 : Form
    {
        bool isPlayerCross = true;
        int[] field = new int[] { // 0 - пусто, 1 - круг, 2 - крест
                0, 0, 0,
                0, 0, 0,
                0, 0, 0
        };

        public Form1()
        {
            this.Size = new Size(580, 600);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ResetGame()
        {
            isPlayerCross = true;

            for (int i = 0; i < 9; i++) field[i] = 0;

            button1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            button4.BackgroundImage = null;
            button5.BackgroundImage = null;
            button6.BackgroundImage = null;
            button7.BackgroundImage = null;
            button8.BackgroundImage = null;
            button9.BackgroundImage = null;
        }

        public bool Turn(int cellNumber)
        {
            if (field[cellNumber] == 0)
            {
                field[cellNumber] = Convert.ToInt32(isPlayerCross) + 1;
                return true;
            }
            return false;
        }

        public void CheckWin()
        {
            if // Поменять 0 на 2
               (field[0] == 2 && field[1] == 2 && field[2] == 2 || // верхняя строка
                field[3] == 2 && field[4] == 2 && field[5] == 2 || // средняя строка
                field[6] == 2 && field[7] == 2 && field[8] == 2 || // нижняя строка

                field[0] == 2 && field[3] == 2 && field[6] == 2 || // левый столб
                field[1] == 2 && field[4] == 2 && field[7] == 2 || // средний столб
                field[2] == 2 && field[5] == 2 && field[8] == 2 || // правый столб

                field[0] == 2 && field[4] == 2 && field[8] == 2 || // первая диагональ
                field[6] == 2 && field[4] == 2 && field[2] == 2)   // вторая диагональ
            {
                if(MessageBox.Show("Do you want to restart?", "Cross wins!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    ResetGame();
                }
                else
                {
                    this.Close();
                }
            }
            else if 
               (field[0] == 1 && field[1] == 1 && field[2] == 1 || // верхняя строка
                field[3] == 1 && field[4] == 1 && field[5] == 1 || // средняя строка
                field[6] == 1 && field[7] == 1 && field[8] == 1 || // нижняя строка

                field[0] == 1 && field[3] == 1 && field[6] == 1 || // левый столб
                field[1] == 1 && field[4] == 1 && field[7] == 1 || // средний столб
                field[2] == 1 && field[5] == 1 && field[8] == 1 || // правый столб

                field[0] == 1 && field[4] == 1 && field[8] == 1 || // первая диагональ
                field[6] == 1 && field[4] == 1 && field[2] == 1)   // вторая диагональ
            {
                if (MessageBox.Show("Do you want to restart?", "Zero wins!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    ResetGame();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Turn(0))
            {
                button1.BackgroundImage = isPlayerCross ? new Bitmap(Properties.Resources.Cross)
                                                        : new Bitmap(Properties.Resources.Zero);
                CheckWin();
                isPlayerCross = !isPlayerCross;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Turn(1))
            {
                button2.BackgroundImage = isPlayerCross ? new Bitmap(Properties.Resources.Cross)
                                                        : new Bitmap(Properties.Resources.Zero);
                CheckWin();
                isPlayerCross = !isPlayerCross;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Turn(2))
            {
                button3.BackgroundImage = isPlayerCross ? new Bitmap(Properties.Resources.Cross)
                                                        : new Bitmap(Properties.Resources.Zero);
                CheckWin();
                isPlayerCross = !isPlayerCross;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Turn(3))
            {
                button4.BackgroundImage = isPlayerCross ? new Bitmap(Properties.Resources.Cross)
                                                        : new Bitmap(Properties.Resources.Zero);
                CheckWin();
                isPlayerCross = !isPlayerCross;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Turn(4))
            {
                button5.BackgroundImage = isPlayerCross ? new Bitmap(Properties.Resources.Cross)
                                                        : new Bitmap(Properties.Resources.Zero);
                CheckWin();
                isPlayerCross = !isPlayerCross;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Turn(5))
            {
                button6.BackgroundImage = isPlayerCross ? new Bitmap(Properties.Resources.Cross)
                                                        : new Bitmap(Properties.Resources.Zero);
                CheckWin();
                isPlayerCross = !isPlayerCross;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Turn(6))
            {
                button7.BackgroundImage = isPlayerCross ? new Bitmap(Properties.Resources.Cross)
                                                        : new Bitmap(Properties.Resources.Zero);
                CheckWin();
                isPlayerCross = !isPlayerCross;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Turn(7))
            {
                button8.BackgroundImage = isPlayerCross ? new Bitmap(Properties.Resources.Cross)
                                                        : new Bitmap(Properties.Resources.Zero);
                CheckWin();
                isPlayerCross = !isPlayerCross;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Turn(8))
            {
                button9.BackgroundImage = isPlayerCross ? new Bitmap(Properties.Resources.Cross)
                                                        : new Bitmap(Properties.Resources.Zero);
                CheckWin();
                isPlayerCross = !isPlayerCross;
            }
        }
    }
}