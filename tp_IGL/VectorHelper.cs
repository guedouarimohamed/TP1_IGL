using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_IGL
{
    class VectorHelper
    {
        //c'est la table principale ou on va executer les methodes(tri,somme,invers...)
        private int[] tab1;
        //cette table pour tester la methode (somme de deux vecteur)
        private int[] tab2;
        private int n1;
        private int n2;
        public VectorHelper()
        {

        }
        public int[] get_tab1()
        {
            return tab1;
        }
        public int[] get_tab2()
        {
            return tab2;
        }

        public int get_n1()
        {
            return n1;
        }
        public int get_n2()
        {
            return n2;
        }

        public void set_n1(int n)
        {
            n1 = n;
        }
        public void set_n2(int n)
        {
            n2 = n;
        }



        //ecrire la table 1
        public void ecrire_tab1()
        {
            Console.WriteLine("les elelment de tableau sont :");

            for (int i = 0; i < n1; i++)
            {
                Console.Write("   " + tab1[i]);
            }

            Console.WriteLine();
        }

        ///////////////////////////////////////////////////////////

        //ecrire une table
        public void ecrire_tab(int[] tab, int n)
        {
            Console.WriteLine("les elelment de tableau sont :");

            for (int i = 0; i < n; i++)
            {
                Console.Write("   " + tab[i]);
            }

            Console.WriteLine();
        }
        //////////////////////////////////////////////////////////////////////////////
        //initialiser la table 1
        public void init_tab1()
        {

            tab1 = new int[n1];
            Console.WriteLine("entrer les valeurs de tableau");
            for (int i = 0; i < n1; i++)
            {

                Console.WriteLine("tab[" + i + "]=");
                tab1[i] = int.Parse(Console.ReadLine());
            }
        }
        //////////////////////////////////////////////////////////////////////////////
        //initialiser la table 2
        public void init_tab2()
        {

            tab2 = new int[n2];
            Console.WriteLine("entrer les valeurs de tableau");
            for (int i = 0; i < n2; i++)
            {

                Console.WriteLine("tab[" + i + "]=");
                tab2[i] = int.Parse(Console.ReadLine());
            }
        }
        //////////////////////////////////////////////////////////////////////
        //permutation entre deux nombre
        public void permut(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;

        }
    }
}

/////////////////////////////////////////////////////////////////////
        //tri par selection
        public void tri_selection()
        {
            for (int i = 0; i < n1 - 1; i++)
            {
                for (int j = i + 1; j < n1; j++)
                {
                    if (tab1[j] < tab1[i])
                    {
                        permut(ref tab1[i], ref tab1[j]);
                    }
                }
            }

        }
        ///////////////////////////////////////////////////
		  //inverser un tableau
        public void invers_tab(int[] tab_invers)
        {
            for (int i = 0; i < n1; i++)
            {
                tab_invers[n1 - 1 - i] = tab1[i];
            }
        }
        //////////////////////////////////////////////////
        //trouver le min et le max dans un tableau
        public void max_min(ref int max, ref int min)
        {
            max = tab1[0];
            min = tab1[0];
            for (int i = 1; i < n1; i++)
            {
                if (max < tab1[i])
                {
                    max = tab1[i];
                }
                if (min > tab1[i])
                {
                    min = tab1[i];
                }
            }
        }