using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //incomplete....
            Console.WriteLine(GetNumber());
            Console.ReadLine();
        }

        public static int GetNumber()
        {
            Random ran = new Random();
            int count = 1;
            int prev = -1;
            string num = "";
            do
            {
                int r = 0;
                while (r % 2 == 0 || r == prev)
                {
                    r = ran.Next(0, 9);
                }

                num += r.ToString();
                count++;

            } while (count <= 4);

            return int.Parse(num);
        }
    }
}
