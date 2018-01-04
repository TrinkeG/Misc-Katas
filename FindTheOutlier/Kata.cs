using System.Linq;

namespace FindTheOutlier
{
    public class Kata
    {
        public static int Find(int[] integers)
        {
            int rem = integers.Take(3).Count(x => x % 2 == 0) > 1?1:0;
            return integers.First(x=> x%2==rem);
        }
    }
}