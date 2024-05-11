using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class BasicMenu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Базове меню:");
            Console.WriteLine("1. Перші страви");
            Console.WriteLine("2. Другі страви");
            Console.WriteLine("3. Напої");
        }
    }

}
