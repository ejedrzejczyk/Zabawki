using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Computer
    {
        private string name;
        private static int counter = 0;

        public Computer()
        {
            name = "Computer " + (++counter).ToString();
        }

        public override string ToString()
        {
            return name;
        }
    }
}
