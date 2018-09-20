using System.Linq;

namespace Kata
{
    public static class Kata
    {
        public static int find_it(int[] seq)
        {
            var freq = -1;
            var it = -1;

            foreach (var item in seq.ToList())
            {
                var numOccurence = seq.ToList().FindAll(x => x == item).Count;
                if (numOccurence % 2 != 0 && numOccurence > freq)
                {
                    it = item;
                    freq = numOccurence;
                }
            }
            return it;
        }
    }
}