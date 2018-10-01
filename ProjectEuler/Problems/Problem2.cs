using System;

namespace ProjectEuler
{
    public partial class Problems
    {
        private void Problem2()
        {
            int num1 = 1, num2 = 2, sum = 2;

            while (true)
            {
                int tempSum = num1 + num2;
                num1 = num2;
                num2 = tempSum;

                if (tempSum % 2 == 0)
                    sum += tempSum;

                if (tempSum > 4000000)
                {
                    Console.WriteLine(sum);
                    break;
                }
            }
        }
    }
}
