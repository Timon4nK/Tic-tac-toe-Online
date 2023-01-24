using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe_Online
{
    public partial class Form1 : Form
    {
        static public bool isPlayerCross;
        static public Bot opponent; 

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
            // Выбрать режим
            isPlayerCross = false;
            opponent = new Bot(isPlayerCross); // Потом переделать, чтобы создавался бот с выбранным поведением
        }

        public bool Turn(int cellNumber, bool cross)
        {
            if (field[cellNumber] == 0)
            {
                field[cellNumber] = Convert.ToInt32(cross) + 1;
                return true;
            }
            return false;
        }

        public void CheckWin()
        {
            if 
               (field[0] == 0 && field[1] == 0 & field[2] == 0 || // верхняя строка
                field[3] == 0 && field[4] == 0 & field[5] == 0 || // средняя строка
                field[6] == 0 && field[7] == 0 & field[8] == 0 || // нижняя строка

                field[0] == 0 && field[3] == 0 & field[6] == 0 || // левый столб
                field[1] == 0 && field[4] == 0 & field[7] == 0 || // средний столб
                field[2] == 0 && field[5] == 0 & field[8] == 0 || // правый столб

                field[0] == 0 && field[4] == 0 & field[8] == 0 || // первая диагональ
                field[6] == 0 && field[4] == 0 & field[2] == 0)   // вторая диагональ
            {
                // Круги побеждают
            }
            else if 
               (field[0] == 1 && field[1] == 1 & field[2] == 1 || // верхняя строка
                field[3] == 1 && field[4] == 1 & field[5] == 1 || // средняя строка
                field[6] == 1 && field[7] == 1 & field[8] == 1 || // нижняя строка

                field[0] == 1 && field[3] == 1 & field[6] == 1 || // левый столб
                field[1] == 1 && field[4] == 1 & field[7] == 1 || // средний столб
                field[2] == 1 && field[5] == 1 & field[8] == 1 || // правый столб

                field[0] == 1 && field[4] == 1 & field[8] == 1 || // первая диагональ
                field[6] == 1 && field[4] == 1 & field[2] == 1)   // вторая диагональ
            {
                // Кресты побеждают
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Turn(0, isPlayerCross))
            {
                CheckWin();
                Turn(opponent.ChooseTurn(field), !isPlayerCross);
                CheckWin();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Turn(1, isPlayerCross))
            {
                CheckWin();
                Turn(opponent.ChooseTurn(field), !isPlayerCross);
                CheckWin();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Turn(2, isPlayerCross))
            {
                CheckWin();
                Turn(opponent.ChooseTurn(field), !isPlayerCross);
                CheckWin();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Turn(3, isPlayerCross))
            {
                CheckWin();
                Turn(opponent.ChooseTurn(field), !isPlayerCross);
                CheckWin();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Turn(4, isPlayerCross))
            {
                CheckWin();
                Turn(opponent.ChooseTurn(field), !isPlayerCross);
                CheckWin();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Turn(5, isPlayerCross))
            {
                CheckWin();
                Turn(opponent.ChooseTurn(field), !isPlayerCross);
                CheckWin();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Turn(6, isPlayerCross))
            {
                CheckWin();
                Turn(opponent.ChooseTurn(field), !isPlayerCross);
                CheckWin();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Turn(7, isPlayerCross))
            {
                CheckWin();
                Turn(opponent.ChooseTurn(field), !isPlayerCross);
                CheckWin();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Turn(8, isPlayerCross))
            {
                CheckWin();
                Turn(opponent.ChooseTurn(field), !isPlayerCross);
                CheckWin();
            }
        }
    }
}