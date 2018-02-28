using System;
using System.Linq;

namespace Katas
{
    public static class PlayingWithDigits
    {
        public static long digPow(int n, int p)
        {
            char[] characters = n.ToString().ToCharArray();

            int[] digits = characters
                .Select(c => (int)Char.GetNumericValue(c)).ToArray();

            int exponent = p;

            int sum = 0;

            foreach (var digit in digits)
            {
                sum += (int)Math.Pow(digit, exponent);

                exponent += 1;
            }

            decimal k = (decimal)sum / n;

            int result = (int)(k > 0 && k % 1 == 0 ? k : -1);

            return result;
        }
    }
}
