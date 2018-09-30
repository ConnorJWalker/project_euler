using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            while (true)
            {
                menu.Render();
                menu.HandleInput();
            }
        }
    }
}
