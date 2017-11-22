using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abacus
{
    class Program
    {
        static void Main(string[] args)
        {

            var c = new Abacus();

            string[] input = { "ooo---oooooo", "---ooooooooo", "---ooooooooo", "---ooooooooo", "oo---ooooooo", "---ooooooooo" };


            c.add(input, 5);

            //"ooo---oooooo", 
            //"---ooooooooo", 
            //"---ooooooooo", 
            //"---ooooooooo", 
            //"o---oooooooo", 
            //"ooooo---oooo" }
            //When we add 5 to the original, it is necessary to "carry" 1 to the next thread up.This shows the arithmetic 699979 + 5 = 699984
        }
    }
}
