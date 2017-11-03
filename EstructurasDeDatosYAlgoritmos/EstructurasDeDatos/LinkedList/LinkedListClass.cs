using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListClass
    {
        Node root; // keeps track of head, TODO, rename to head.
        Node tail; // keeps track of tail

        /// <summary>
        /// Adds a node as a child of tail
        /// </summary>
        /// <param name="n"></param>
        public void AddNode(Node n)
        {
            if (root == null)
            {
                root = n;
                tail = n;
            }

            tail.child = n;
            tail = n;
        }

        /// <summary>
        /// Prints all nodes starting from root
        /// </summary>
        public void Print()
        {
            Node p = root;
            while (p != null)
            {
                Console.WriteLine(p.value);
                p = p.child;
            }
        }

        /// <summary>
        /// Removes root
        /// </summary>
        internal void Remove()
        {
            root = root.child;
        }
    }
}
