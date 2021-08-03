using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    class Crow : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("crow fly");        }

        public double GetAltitude()
        {
            return 500;
        }
    }
}
