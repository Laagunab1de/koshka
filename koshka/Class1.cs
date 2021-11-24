using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koshka
{
    class Cat 
    {
        public Cat(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
            Task.Run(Lifecircle);
        }
        private byte hungrystatus;
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public byte Hungrystatus
        {
            get { return hungrystatus; }    
            set
            {
                hungrystatus = value;
                
                if (value < 0)
                    hungrystatus = 0;
                if (value > 100) 
                    hungrystatus = 100;
            }           
        }
        public void makenoise()
        { Console.WriteLine($"{Name} произносит что-то невнятное на кошачьем"); }
        public int getage()
        { return DateTime.Now.Year - Birthday.Year;}
        public void getstatus()
        {           
            if (hungrystatus <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("кажется кот сейчас умрет от голода :( ");
                Console.ResetColor();
            }
            if (hungrystatus > 10 && hungrystatus <= 40)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("кошка прям очень хочет есть  :( ");
                Console.ResetColor();
            }
            if (hungrystatus > 40 && hungrystatus <= 70)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("кошка хочет есть  :| ");
                Console.ResetColor();
            }
            if (hungrystatus > 70  && hungrystatus <= 90)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("кошка сейчас бы поела :) ");
                Console.ResetColor();
            }
            if (hungrystatus > 90)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("кошка поела и довольная лежит на солнышке :) ");
                Console.ResetColor();
            }
            
            
          
        }
        async Task Lifecircle()
        {
            await Task.Delay(1000);
            hungrystatus -= 10;
            getstatus();
            await Lifecircle();           
        }
    }


}
