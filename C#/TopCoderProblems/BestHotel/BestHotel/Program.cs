using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] precio = { 200, 300, 100, 500, 100, 100, 200 };
            int[] calidad = { 7, 7, 4, 8, 4, 3, 6 };

            var b = new BestHotel();
            var r = b.numberOfDisadvantageous(precio, calidad);
        }
    }
}
