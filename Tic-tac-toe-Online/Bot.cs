using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe_Online
{
    public class Bot
    {
        bool isCross;
        public virtual int ChooseTurn(int[] field)
        {
            if (field[0] == 0 && field[2] == 2) // верхняя строка без центра
            {
                return 1;
            }
            else if (field[1] == 0 && field[2] == 2) // верхняя строка без лева
            {
                return 0;
            }
            else if (field[0] == 0 && field[1] == 2) // верхняя строка без права
            {
                return 2;
            }

            else if (field[3] == 0 && field[5] == 2) // средняя строка без центра
            {
                return 5;
            }
            else if (field[4] == 0 && field[5] == 2) // средняя строка без лева
            {
                return 4;
            }
            else if (field[3] == 0 && field[4] == 2) // средняя строка без права
            {
                return 6;
            }

            else if (field[7] == 0 && field[9] == 2) // нижняя строка без центра
            {
                return 8;
            }
            else if (field[8] == 0 && field[9] == 2) // нижняя строка без лева
            {
                return 7;
            }
            else if (field[7] == 0 && field[8] == 2) // нижняя строка без права
            {
                return 9;
            }

            else
            {
                Random rnd = new Random();
                return rnd.Next(1, 9);

            }
        }

        public Bot(bool isCross)
        {
            this.isCross = isCross;
        }
    }

    public class CleverBot : Bot
    {
        public override int ChooseTurn(int[] field)
        {
            return base.ChooseTurn(field);
        }

        public CleverBot(bool isCross) : base(isCross)
        {

        }
    }
}