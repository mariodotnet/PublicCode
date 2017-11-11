using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bullets
{
    class Program
    {
        static void Main(string[] args)
        {

            var b = new Bullets();

            var x = new string[2];

            x[0] = "|| || ||";
            x[1] = "||| ||| ";

            var r = b.match(x, "|| ||| |");
        }
    }
}
