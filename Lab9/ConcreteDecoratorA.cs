using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class SeasonalMenuDecorator : MenuDecorator
    {
        private List<string> _seasonalItems;

        public SeasonalMenuDecorator(IMenu menu) : base(menu)
        {
            _seasonalItems = new List<string>();
        }

        public void AddSeasonalItem(string item)
        {
            _seasonalItems.Add(item);
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("\nСезонні пропозиції:");
            foreach (var item in _seasonalItems)
            {
                Console.WriteLine(item);
            }
        }
    }

}
