using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProblem
{
    public class AdditionGame
    {
        public int getMaximumPoints(int A, int B, int C, int N)
        {
            int points = 0;
            while (N > 0 && (A > 0 || B >= 0 || C >= 0))
            {
                if (A >= B && A >= C)
                {
                    points += A;
                    A--;
                }
                else if (B >= A && B >= C)
                {
                    points += B;
                    B--;
                }
                else if (C >= B && C >= A)
                {
                    points += C;
                    C--;
                }

                N--;
            }

            return points;
        }
    }
}
