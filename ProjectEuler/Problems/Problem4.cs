using System;

namespace ProjectEuler
{
    public partial class Problems
    {
        private void Problem4()
        {
            int largestPalidrome = 0;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    int product = i * j;
                    if (IsPalidrome(product) && product > largestPalidrome)
                        largestPalidrome = product;
                }
            }

            Console.WriteLine(largestPalidrome);
        }

        private bool IsPalidrome(int number)
        {
            char[] broken = number.ToString().ToCharArray();

            for (int i = 0; i < broken.Length / 2; i++)
            {
                if (broken[i] != broken[broken.Length - (i + 1)])
                    return false;
            }

            return true;
        }
    }
}
