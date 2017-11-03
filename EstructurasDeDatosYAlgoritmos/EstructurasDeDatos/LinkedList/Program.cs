using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new LinkedListClass();

            l.AddNode(new Node() { value = "1" });
            l.AddNode(new Node() { value = "2" });
            l.AddNode(new Node() { value = "3" });
            l.AddNode(new Node() { value = "4" });
            l.AddNode(new Node() { value = "5" });

            l.Print();

            l.Remove();

            l.Print();

            Console.ReadLine();
        }
    }
}
