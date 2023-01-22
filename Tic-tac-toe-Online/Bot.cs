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
            return 0;
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