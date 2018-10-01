using System;

namespace ProjectEuler
{
    public partial class Problems
    {
        private void Problem3()
        {
            long startNumber = 600851475143;
            int largestPrimeFactor = 0;

            for (int i = 3; i < Math.Sqrt(startNumber); i++)
            {
                if (startNumber % i == 0 && IsPrime(i))
                    largestPrimeFactor = i;
            }

            Console.WriteLine(largestPrimeFactor);
        }
    }
}
