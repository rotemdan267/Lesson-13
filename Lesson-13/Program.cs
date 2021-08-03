using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public void Fly(IFlyable a)
        {
            a.Fly();
        }
        public double Altitude(IFlyable a)
        {
            return a.GetAltitude();
        }
    }
}
