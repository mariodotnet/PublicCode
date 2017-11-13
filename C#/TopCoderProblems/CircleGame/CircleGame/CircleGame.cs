using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleGame
{
    public class CircleGame
    {
        public int cardsLeft(string deck)
        {
            var d = new Dictionary<string, int>();

            d.Add("A", 1);
            d.Add("2", 2);
            d.Add("3", 3);
            d.Add("4", 4);
            d.Add("5", 5);
            d.Add("6", 6);
            d.Add("7", 7);
            d.Add("8", 8);
            d.Add("9", 9);
            d.Add("T", 10);
            d.Add("J", 11);
            d.Add("Q", 12);
            d.Add("K", 13);

            var str = deck.ToCharArray();
            var list = str.Where(x => x != 'K').ToList();

            bool removed = true;
            while (removed)
            {
                removed = false;
                for (int i = 1; i < list.Count; i++)
                {
                        if (d[list.ElementAt(i).ToString()] + d[list.ElementAt(i-1).ToString()] == 13)
                        {
                            list.Remove(list.ElementAt(i));
                            list.Remove(list.ElementAt(i-1));
                            removed = true;
                            break;
                        }
                        if (removed)
                            break;
                }
            }

            return list.Count;
        }
    }
}
