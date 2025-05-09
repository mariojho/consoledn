using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class DividirNumeros
    {
        public int Dividir(int numero1, int numero2)
        {
            if (numero2 == 0)
            {
                throw new DivideByZeroException("El denominador no puede ser cero.");
            }
            else
            {
                return numero1 / numero2;
            }
        }
    }
}
