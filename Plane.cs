using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Plane : IAccelerate, IRise
    {
        private string name;
        private static int counter = 0;
        private int speed;
        private int height;

        public Plane()
        {
            name = "Plane " + (++counter).ToString();
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

        public int RiseIncrease()
        {
            height++;
            return height;
        }

        public int RiseDecrease()
        {
            if (height > 0)
            {
                height--;
            }
            else height = 0;

            return height;
        }

        public int GetCurrentRise()
        {
            return height;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
