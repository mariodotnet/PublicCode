using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListClass
    {
        Node root; // raiz
        Node cola; // keeps track of tail

        /// agrega un elemento hijo
        public void AddNode(Node n)
        {
            if (root == null)
            {
                root = n;
                cola = n;
            }

            cola.hijo = n;
            cola = n;
        }

        /// imprime todos los nodos
        public void Print()
        {
            Node p = root;
            while (p != null)
            {
                Console.WriteLine(p.value);
                p = p.hijo;
            }
        }

        /// Removes root
        internal void Remove()
        {
            root = root.hijo;
        }
    }
}
