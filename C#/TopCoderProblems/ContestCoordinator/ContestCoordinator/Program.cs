using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestCoordinator
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = new ContestCoordinator();

            int[] input = { 1, 13, 8, 6, 7, 9 };

            var r = o.bestAverage(input);
        }
    }
}
