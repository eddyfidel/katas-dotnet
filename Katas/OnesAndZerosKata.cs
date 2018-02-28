using System;

namespace Katas
{
    public static class OnesAndZerosKata
    {
        public static int BinaryArrayToNumber(int[] binaryArray)
        {
            int number = 0;

            int count = binaryArray.Length - 1;

            foreach (var binary in binaryArray)
            {
                if (binary == 1)
                {
                    number += (int)Math.Pow(2, count);
                }

                count--;
            }

            return number;
        }
    }
}
