using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlienAndPassword
{
        class AlienAndPassword
        {
            public int getNumber(string S)
            {
                List<string> l = new List<string>();

                for (int i = 0; i < S.Length; i++)
                {
                    var arr = S.ToList();
                    arr.RemoveAt(i);
                    l.Add(string.Concat(arr));
                }

                l = l.Distinct().ToList();

                return l.Count;
            }
        }
}
