using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    public partial class Problems
    {
        public List<Action> Methods;

        public Problems()
        {
            Methods = new List<Action>()
            {
                () => Problem1(),
                () => Problem2(),
                () => Problem3(),
                () => Problem4(),
                () => Problem5(),
                () => Problem6()
            };
        }

        private bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}