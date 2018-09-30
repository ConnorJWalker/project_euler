using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Menu
    {
        private string[] menuItems;
        private ConsoleKey currentKey;
        private int currentSelectedIndex;
        private int max;
        private Problems problems;

        public Menu()
        {
            currentSelectedIndex = 0;

            menuItems = new string[]
            {
                "Problem 1 - Multiples of 3 and 5",
                "Problem 2 - Even Fibonacci numbers"
            };

            max = menuItems.Length - 1;
            problems = new Problems();
        }

        public void Render()
        {
            Console.Clear();
            for (int i = 0; i < menuItems.Length; i++)
            {
                if (i == currentSelectedIndex)
                    Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine(menuItems[i]);
                Console.ResetColor();
            }

            Console.WriteLine("\nPress ESC to exit");
        }

        public void HandleInput()
        {
            currentKey = Console.ReadKey().Key;

            switch (currentKey)
            {
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                case ConsoleKey.DownArrow:
                    currentSelectedIndex = currentSelectedIndex == max ? 0 : currentSelectedIndex + 1;
                    break;
                case ConsoleKey.UpArrow:
                    currentSelectedIndex = currentSelectedIndex == 0 ? max : currentSelectedIndex - 1;
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.Enter:
                    RunMenuItem();
                    break;
            }
        }

        private void RunMenuItem()
        {
            Console.Clear();
            problems.Methods[currentSelectedIndex].Invoke();
            Console.WriteLine("\nPress Enter to return");
            Console.ReadLine();
        }
    }
}
