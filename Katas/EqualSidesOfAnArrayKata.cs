using System;
using System.Linq;

namespace Katas
{
    public static class EqualSidesOfAnArrayKata
    {
        public static int FindEvenIndex(int[] arr)
        {
            int evenIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                int[] leftSideArray = arr.Where((a, j) => j < i).ToArray();

                int[] rightSideArray = arr.Where((a, j) => j > i).ToArray();

                int leftSum = leftSideArray.Sum(x => x);

                int rightSum = rightSideArray.Sum(x => x);

                if (leftSum == rightSum) 
                {
                    return i;
                }
            }

            return evenIndex;
        }
    }
}
