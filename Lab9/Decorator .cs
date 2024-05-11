using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public abstract class MenuDecorator : IMenu
    {
        protected IMenu _menu;

        public MenuDecorator(IMenu menu)
        {
            _menu = menu;
        }

        public virtual void Display()
        {
            _menu.Display();
        }
    }
}
