using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploUnitTesting
{
    public class Genio
    {
        public bool Bandera = false;

        public string CrearMundo(int x)
        {
            switch (x)
            {

                case 1: return "Mundo Magico";
                case 2: return "Mundo Electrico";
                case 3: return "Mundo Acuatico";
                default:
                    break;

            }
            return "";
        }


        public void ThrowException()
        {
            Bandera = true;
        }
    }
}
