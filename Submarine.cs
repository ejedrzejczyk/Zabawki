using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Submarine : IAccelerate, IDive
    {
        private string name;
        private static int counter = 0;
        private int speed;
        private int dive;

        public Submarine()
        {
            name = "Submarine " + (++counter).ToString();
        }

        public int SpeedIncrease()
        {
            speed++;
            return speed;
        }

        public int SpeedDecrease()
        {
            if (speed > 0)
            {
                speed--;
            }
            else speed = 0;

            return speed;
        }

        public int GetCurrentSpeed()
        {
            return speed;
        }

        public int DiveIncrease()
        {
            dive++;
            return dive;
        }

        public int DiveDecrease()
        {
            if (dive > 0)
            {
                dive--;
            }
            else dive = 0;

            return dive;
        }

        public int GetCurrentDive()
        {
            return dive;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
