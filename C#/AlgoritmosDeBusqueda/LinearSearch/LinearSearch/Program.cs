using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            //arreglo de datos
            int[] datos = { 1, 3, 7, 4, 8, 9, 433, 5, 66, 99, 1, 2 };

            //numero que queremos buscar
            int numeroBusqueda = 99;

            //ejecutamos el metodo
            int indice = BusquedaLinear(datos, numeroBusqueda);

            //imprimir indice
            Console.WriteLine("Indice encontrado: {0}", indice);
        }

        //metodo de busqueda linear
        private static int BusquedaLinear(int[] datos, int numeroBusqueda)
        {
            //iteramos todos los elementos
            for (int i = 0; i < datos.Length; i++)
            {
                //si encontramos el valor en el arreglo, retornamos el indice
                if(datos[i] == numeroBusqueda)
                {
                    return i;
                }
            }

            //no se encontro el valor
            return -1;
        }
    }
}
