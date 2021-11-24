using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koshka
{
     class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Маруся", new DateTime(2010, 4, 15));
            cat.makenoise();
            Console.WriteLine($"знакомьтесь, {cat.Name}, ей уже {cat.getage()} лет");
            cat.Hungrystatus = 150;
            Console.WriteLine("Hungry = " + cat.Hungrystatus + "\n");
            cat.getstatus();
            Console.ReadLine();
        }
    }
}
