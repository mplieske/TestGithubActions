using System;
using System.Collections.Generic;
using System.Text;

namespace TestGithubActions
{
    public class SimpleMath
    {
        private SimpleMath() { }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static decimal Subtract(decimal a, decimal b)
        {
            return a - b;
        }

        public static decimal Divide(decimal a, decimal b)
        {
            // intentional breaking code
            return a * b;
        }
    }
}
