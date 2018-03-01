using System.Linq;

namespace Katas
{
    public class DirectionsReductionKata
    {
        public static string[] DirReduc(string[] arr)
        {
            bool hasReduction = false;

            int firstPosition = 0, 
                secondPosition = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 1)
                {
                    bool hasNorthSouthReduction = (arr[i] == "NORTH" && arr[i + 1] == "SOUTH") 
                        || (arr[i + 1] == "NORTH" && arr[i] == "SOUTH");

                    bool hasEastWestReduction = (arr[i] == "EAST" && arr[i + 1] == "WEST")
                        || (arr[i + 1] == "EAST" && arr[i] == "WEST");

                    if (hasNorthSouthReduction || hasEastWestReduction)
                    {
                        firstPosition = i;

                        secondPosition = i + 1;

                        hasReduction = true;

                        break;
                    }
                }
            }

            if (arr.Length <= 1 || (arr.Length == 2 && !hasReduction))
            {
                return arr;
            }

            if (hasReduction)
            {
                arr = arr.Where((a, i) => i != firstPosition 
                                && i != secondPosition).ToArray();

                return DirReduc(arr);
            }

            return arr;
        }
    }
}
