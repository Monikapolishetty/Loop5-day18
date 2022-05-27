using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculator
{
    public static class Calculator
    {
        public static int Add(string num)
        {
            if (string.IsNullOrEmpty(num))
            {
                return 0;
            }

            if (num.Any(n => !char.IsDigit(n) && n != ','))
            {
                throw new ArgumentException("FK U");
            }

            return 1;

        }
    }
}