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
                () => Problem3()
            };
        }
    }
}