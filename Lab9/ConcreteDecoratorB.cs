using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class DailySpecialsDecorator : MenuDecorator
    {
        private string _special;

        public DailySpecialsDecorator(IMenu menu, string special) : base(menu)
        {
            _special = special;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("\nОсоблива пропозиція дня:");
            Console.WriteLine(_special);
        }
    }
}
