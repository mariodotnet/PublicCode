using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 3, 5, 2, 4, 6 };

            var result = cocktailSort(input);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        /// Sorts input array.
        public static int[] cocktailSort(int[] input)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i <= input.Length - 2; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        //test whether the two elements are in the wrong order
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    //we can exit the outer loop here if no swaps occurred.
                    break;
                }
                swapped = false;
                for (int i = input.Length - 2; i >= 0; i--)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        swapped = true;
                    }
                }

                //if no elements have been swapped, then the list is sorted
            } while (swapped);

            return input;
        }
    }
}
