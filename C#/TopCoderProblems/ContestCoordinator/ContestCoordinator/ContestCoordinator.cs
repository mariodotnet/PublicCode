using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestCoordinator
{
    class ContestCoordinator
    {
        public double bestAverage(int[] scores)
        {
            List<int> s = scores.ToList();

            s.Sort();

            if (s.Distinct().ToList().Count == 1)
            {
                return s.First();
            }

            var tempValue = s.First();
            var tempValue2 = s.Last();

            bool removed = true;
            bool removed2 = true;
            while (removed || removed2)
            {
                removed = s.Remove(tempValue);
                removed2 = s.Remove(tempValue2);
            }


            return s.Average();
        }
    }
}
