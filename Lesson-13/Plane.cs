using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    class Plane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Plane fly");
        }

        public double GetAltitude()
        {
            return 800000;        }
    }
}
