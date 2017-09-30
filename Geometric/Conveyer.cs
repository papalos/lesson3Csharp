using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    class Conveyer
    {
        enum action { START = 37, STOP, FORWAR, BACK };
        void main()
        {
            action a = action.STOP;
            Console.WriteLine((int)a);
        }
    }
}
