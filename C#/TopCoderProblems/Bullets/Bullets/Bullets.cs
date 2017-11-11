using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bullets
{
    class Bullets
    {
        public int match(string[] guns, string bullet)
        {

            for (int x = 0; x < guns.Length; x++)
            {
                if (guns[x] == bullet) return x;

                if (guns[x] != null)
                {
                    string tmp = swifth(guns[x]);
                    for (int i = 0; i < guns[x].Length; i++)
                    {
                        tmp = swifth(tmp);
                        if (tmp == bullet)
                            return x;
                    }
                }

            }

            return -1;
        }

        private string swifth(string v)
        {
            if (v.Length > 1)
            {
                string s1 = v.Substring(v.Length - 1, 1);
                string s2 = v.Substring(0, v.Length - 1);
                return s1 + s2;

            }
            return v;
        }
    }
}
