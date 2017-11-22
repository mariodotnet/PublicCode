using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abacus
{
    public class Abacus
    {
        public string[] add(string[] original, int val) {

            // ponemos en resultado como la original, luego la modificaremos?
            string[] r = original;


            //valores que se agregan
            for (int x = 0; x < val; x++)
            {
                bool acarreo = false; // si el valor es 'o' se acarre al siguiente...

                // 6 lineas
                for (int i = 5; i >= 0; i--) // valor mas a la derecha es el que importa.
                {
                    //10 circulos por linea
                    for (int j = 9; j >= 0; j--) // idem
                    {
                        var arr = r[i].ToArray();

                        if(arr[j] == 'o')
                        {
                            acarreo = true;
                        }
                        else
                        {
                            acarreo = false;
                        }
                    }
                }
            }
            
            return r;
        }
    }
}
