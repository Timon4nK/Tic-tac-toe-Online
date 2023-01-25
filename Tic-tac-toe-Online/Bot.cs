using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe_Online
{
    public class Bot
    {
        bool isCross;
        public virtual int ChooseTurn(int[] field)
        {
            int res = -1;
            if (field[0] == 0 && field[2] == 2 && field[1] == 0) // верхняя строка без центра
            {
                res = 1;
            }
            else if (field[1] == 0 && field[2] == 2 && field[0] == 0) // верхняя строка без лева
            {
                res = 0;
            }
            else if (field[0] == 0 && field[1] == 2 && field[2] == 0) // верхняя строка без права
            {
                res = 2;
            }

            else if (field[3] == 0 && field[5] == 2 && field[5] == 0) // средняя строка без центра
            {
                res = 5;
            }
            else if (field[4] == 0 && field[5] == 2 && field[4] == 0) // средняя строка без лева
            {
                res = 4;
            }
            else if (field[3] == 0 && field[4] == 2 && field[6] == 0) // средняя строка без права
            {
                res = 6;
            }

            else if (field[6] == 0 && field[8] == 2 && field[8] == 0) // нижняя строка без центра
            {
                res = 8;
            }
            else if (field[7] == 0 && field[8] == 2 && field[7] == 0) // нижняя строка без лева
            {
                res = 7;
            }
            else if (field[6] == 0 && field[7] == 2 && field[0] == 0) // нижняя строка без права
            {
                res = 0;
            }

            else
            {
                Random rnd = new Random();
                int randf = rnd.Next(0, 8);
                for (int i = 0; i < 9; i++)
                {
                    if (field[randf] == 0)
                    {
                        res = randf;
                    }
                    randf += 1;
                    randf %= 9;
                }
            }
            switch(res)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
            }
                

            Console.WriteLine("Bot error");
            return res;
        }

        public Bot(bool isCross)
        {
            this.isCross = isCross;
        }
    }
}