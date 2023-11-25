using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsFormsApp1
{
    class Vector
    {
        const int MAX = 100;
        private int[] v;
        private int n;
        public Vector()
        {
            n = 0;
            v = new int[MAX];
        }

        public void cargardato(int nele)
        {
            n = nele;//JCE
            int num = n;
            for (int i = 1; i <= num; i++)
            {//JCE
                v[i] = Conversions.ToInteger(Interaction.InputBox(" ", " "));
            }
        }
        public void Cargar_rnd(int n1, int a, int b)
        {
            Random r;
            r = new Random();
            int i;
            n = n1;
            for (i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }

        }

        public string descargar()
        {
            string s;
            int i;
            s = "";
            for (i = 1; i <= n; i++)
            {
                s = s + v[i] + " | ";
            }
            return s;
        }

        //----------------EXAMEN----------------------------





        public void ejercicio2(int a, int b, ref Vector e, ref Vector f)
        {

            OrdenarSegVec(a, b);
            Nent n1 = new Nent();
            e.n = 0;
            f.n = 0;
            int i;
            i = a;
            while (i <= b)
            {
                int ele = v[i];
                int fr = 0;
                while ((i <= b) & (ele == v[i]))
                {
                    i++;
                    fr++;
                }
                n1.cargar(ele);
                // if (n1.Veri_fibo())
                if (frec_elem_segmento(ele, a, b) > 1)
                {
                    e.Insertar(ele);
                    f.Insertar(fr);
                }

            }

        }

        public int frec_elem_segmento(int elem, int a, int b)
        {
            int c = 0;
            int num = a;
            int num2 = b;
            checked
            {
                for (int i = num; i <= num2; i++)
                {

                    if (elem == v[i])
                    {
                        c++;
                    }
                }
                return c;
            }
        }



        public void Insertar(int ele)
        {
            checked
            {
                n++;
                v[n] = ele;
            }
        }

        public void OrdenarSegVec(int a, int b)
        {
            checked
            {
                for (int i = a; i <= b; i++)
                {
                    int num = i + 1;
                    for (int j = num; j <= b; j++)
                    {
                        if (v[i] < v[j])  //cambie de > a <
                        {
                            intercambiar(i, j);
                        }
                    }
                }
            }
        }

        public void intercambiar(int a, int b)
        {
            int aux_JCE;

            aux_JCE = v[a];
            v[a] = v[b];
            v[b] = aux_JCE;
        }



    }
}
