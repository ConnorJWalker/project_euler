using System;

namespace ProjectEuler
{
    public partial class Problems
    {
        private void Problem6()
        {
            int sum = 0, squareSum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum += i;
                squareSum += i * i;
            }

            Console.WriteLine((sum * sum) - squareSum);
        }
    }
}
