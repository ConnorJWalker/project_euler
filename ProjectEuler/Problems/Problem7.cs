using System;

namespace ProjectEuler
{
    public partial class Problems
    {
        private void Problem7()
        {
            int counter = 1, currentPrime = 0;
            for (int i = 3; true; i++)
            {
                if (IsPrime(i))
                {
                    counter++;
                    currentPrime = i;
                }

                if (counter == 10001) break;
            }

            Console.WriteLine(currentPrime);
        }
    }
}
