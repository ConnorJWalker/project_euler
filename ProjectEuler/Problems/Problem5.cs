using System;

namespace ProjectEuler
{
    public partial class Problems
    {
        private void Problem5()
        {
            for (int i = 20; true; i += 20)
            {
                for (int j = 1; j <= 20; j++)
                {
                    if (i % j != 0)
                    {
                        break;
                    }

                    if (j == 20)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }
            }
        }
    }
}
