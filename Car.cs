using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Car : IAccelerate
    {
        private string name;
        private static int counter = 0;
        private int speed = 0;

        public Car()
        {
            name = "Car " + (++counter).ToString();
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

        public override string ToString()
        {
            return name;
        }
    }
}
