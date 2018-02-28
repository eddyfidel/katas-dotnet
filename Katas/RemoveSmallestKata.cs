using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public static class RemoveSmallestKata
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            if (numbers.Count() == 0)
            {
                return new List<int>();
            }

            int smallestValue = numbers.Min();

            int smallestValueIndex = numbers.IndexOf(smallestValue);

            numbers.RemoveAt(smallestValueIndex);

            List<int> compactRatings = numbers;

            return compactRatings;
        }
    }
}
