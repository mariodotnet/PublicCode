using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // input array
            int[] input = { 1, 5, 3, 2, 4 };

            int temp = 0;

            for (int write = 0; write < input.Length; write++)
            {
                for (int sort = 0; sort < input.Length - 1; sort++)
                {
                    if (input[sort] > input[sort + 1])
                    {
                        temp = input[sort + 1];
                        input[sort + 1] = input[sort];
                        input[sort] = temp;
                    }
                }
            }

            // print array
            for (int i = 0; i < input.Length; i++)
                Console.Write(input[i] + " ");

            // screen pause
            Console.ReadLine();
        }
    }
}
