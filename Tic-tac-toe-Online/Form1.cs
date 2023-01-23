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
        static public bool isPlayerCross = false;
        static public Bot opponent = new Bot(isPlayerCross); // Потом переделать, чтобы создавался бот с выбранным поведением

        int[] field = new int[] { // 0 - пусто, 1 - круг, 2 - крест
                0, 0, 0,
                0, 0, 0,
                0, 0, 0};

        public Form1()
        {
            this.Size = new Size(580, 600);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Выбрать режим
            // Добавить 9 кнопок
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
            // Если кто-то победил, вывести и предложить рестарт
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