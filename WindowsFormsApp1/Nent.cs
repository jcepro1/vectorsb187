using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Nent
    {
        private int n;
        public Nent()
        {
            n = 0;
        }

        public void cargar(int dato)
        {
            n = dato;
        }

        public int descargar()
        {
            return n;
        }

        
        
            public bool Veri_Primo()
            {
                int r, i;
                i = 1;
                if (n > 1)
                {
                    do
                    {
                        i = i + 1;
                        r = n % i;
                    }
                    while (!(r == 0));
                }
                else
                    i = -1;

                return n == i;
            }

            // Verificar si un NE pertenece a la serie de Fibonacci /////////////////////////////////////
            // n=7 => true

            public bool Veri_fibo()
            {
                int a, b, c;
                a = -1;
                b = 1;

                do
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                while (!(n == c) || (c > n));

                return n == c;
            }

            // Factorial

            public int Factorial()
            {
                int f;
                f = 1;
                if (n > 0)
                {
                    for (var i = n; i >= 1; i += -1)
                        f = f * i;
                }
                else
                    f = f;

                return f;
            }

            // Verificar si un NE es Par

            public bool Veri_Par()
            {
                return n % 2 == 0;
            }

            // Verificar si un NE es Impar
            public bool Veri_Impar()
            {
                return n % 2 == 1;
            }

    }


}
