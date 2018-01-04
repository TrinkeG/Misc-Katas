namespace FindTheOutlier
{
    public class Kata
    {
        public static int Find(int[] integers)
        {
            var isOdd = integers[0] % 2 == 0 && integers[1] % 2 == 0 && integers[2] % 2 == 0;
            foreach (var integer in integers)
            {
                if (isOdd)
                {
                    if (integer % 2 != 0)
                    {
                        return integer;
                    }
                }
                else
                {
                    if (integer % 2 == 0)
                    {
                        return integer;
                    }
                }
            }
            return 0;
        }
    }
}