using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_IGL
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////




            VectorHelper V = new VectorHelper();
            int max = new int();
            int min = new int();

            bool init_tab1 = false;
            bool init_tab2 = false;

            String choix = "5";
            while (choix != "0")
            {
                Console.WriteLine("1-initialiser tab1");
                Console.WriteLine("2-initialiser tab2");
                Console.WriteLine("3-invers");
                Console.WriteLine("4-tri");
                Console.WriteLine("5-max_min");
                Console.WriteLine("6-somme");
                Console.WriteLine("0-quitter");


                Console.WriteLine("entrer le choix : ");
                choix = Console.ReadLine();

                Console.Clear();

                switch (choix)
                {

                    case "1":
                        Console.WriteLine("entrer la longueur de vecteur : ");
                        V.set_n1(int.Parse(Console.ReadLine()));
                        V.init_tab1();
                        //V.ecrire_tab1();
                        V.ecrire_tab(V.get_tab1(), V.get_n1());
                        init_tab1 = true;
                        break;
                    case "2":
                        Console.WriteLine("entrer la longueur de vecteur : ");
                        V.set_n2(int.Parse(Console.ReadLine()));
                        V.init_tab2();
                        V.ecrire_tab(V.get_tab2(), V.get_n2());
                        init_tab2 = true;
                        break;
                    case "3":
                        if (init_tab1 == true)
                        {
                            int[] inv_tab = new int[V.get_n1()];
                            V.invers_tab(inv_tab);
                            V.ecrire_tab(inv_tab, V.get_n1());
                        }
                        else
                        {
                            Console.WriteLine("initialisez le tableau");
                        }

                        break;
                    case "4":
                        if (init_tab1 == true)
                        {
                            V.tri_selection();
                            V.ecrire_tab1();
                        }
                        else
                        {
                            Console.WriteLine("initialisez le tableau");
                        }

                        break;
                    case "5":
                        if (init_tab1 == true)
                        {
                            V.max_min(ref max, ref min);
                            Console.WriteLine("le max = " + max + "           le min" + min);
                        }
                        else
                        {
                            Console.WriteLine("initialisez le tableau");
                        }


                        break;
                    case "6":

                        if (init_tab1 == true && init_tab2 == true)
                        {

                            try
                            {

                                int[] tab_somme = new int[V.get_n1()];
                                V.somme(tab_somme);
                                Console.WriteLine("tab somme");
                                V.ecrire_tab(tab_somme, V.get_n1());
                            }
                            catch (exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                        }
                        else
                        {
                            Console.WriteLine("initialisez les vecteurs");
                        }

                        break;
                    case "0":
                        choix = "0";
                        break;

                }
                // Console.Clear();
            }






            Console.ReadKey();
        








            /////////////////////////////////////

        }
    }
}
