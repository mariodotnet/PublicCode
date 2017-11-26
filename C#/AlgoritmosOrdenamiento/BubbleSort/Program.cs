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
            int[] entrada = { 1, 5, 3, 2, 4 };

            // ejecuta metodo
            int[] resutado = BubbleSort(entrada);


            // imprime valores
            for (int i = 0; i < entrada.Length; i++)
                Console.Write(entrada[i] + " ");

            // pausa en pantalla
            Console.ReadLine();
        }

        //metodo de ordenacion burbuja
        private static int[] BubbleSort(int[] entrada)
        {
            //fors anidados
            for (int i = 0; i < entrada.Length; i++)
            {
                for (int j = 0; j < entrada.Length - 1; j++)
                {
                    //si el de la izquierda es mayor intercambia
                    if (entrada[j] > entrada[j + 1])
                    {
                        //intercambia
                        int temp = entrada[j + 1];
                        entrada[j + 1] = entrada[j];
                        entrada[j] = temp;
                    }
                }
            }

            // devuelve arreglo ordenado
            return entrada;
        }
    }
}
