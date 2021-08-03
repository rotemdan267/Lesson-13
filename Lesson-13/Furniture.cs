using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    abstract class Furniture
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public void Break()
        {
            Console.WriteLine("Break");
        }
        public abstract void NewFromIkea();
    }
    class Table : Furniture
    {
        public void HostMeal()
        {
            Console.WriteLine("bon appetit!");
        }
        public override void NewFromIkea()
        {
            Console.WriteLine("Build Table");
        }
    }
    class Bed : Furniture
    {
        public int NumofPillows { get; set; }
        public override void NewFromIkea()
        {
            Console.WriteLine("Build Bed");
        }
    }
}
