using System;

namespace ProjectEuler
{
    public partial class Problems
    {
        private void Problem10()
        {
            long sum = 2;
            for (int i = 3; i < 2000000; i++)
            {
                if (i % 2 != 0 && IsPrime(i)) sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}
