using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class SumDigPowerKata
    {
        public static long[] SumDigPow(long a, long b)
        {
            List<long> powNumbers = new List<long>();

            for (long i = a; i <= b; i++)
            {
                int number = 0;

                int powCount = 1;

                var digits = i.ToString().Select(d => Char.GetNumericValue(d));

                foreach (var digit in digits)
                {
                    number += (int)Math.Pow(digit, powCount);

                    powCount++;
                }

                if (number == i)
                {
                    powNumbers.Add(number);
                }
            }

            return powNumbers.ToArray();
        }
    }
}
