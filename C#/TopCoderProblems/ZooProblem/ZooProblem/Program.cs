using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new AdditionGame();

            int[] i = new int[4];
            i[0] = 3;
            i[1] = 4;
            i[2] = 5;
            i[3] = 3;

            var result = c.getMaximumPoints(i[0], i[1], i[2], i[3]);
        }
    }
}
