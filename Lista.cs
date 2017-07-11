using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Fruta
    {
        public Fruta()
        { }

        public string Escolher()
        {
            Console.WriteLine("O que deseja inserir?");
            Console.WriteLine("1 - Banana");
            Console.WriteLine("2 - Maça");
            Console.WriteLine("3 - Laranja");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    return "Banana";
                case 2:
                    return "Maça";
                case 3:
                    return "Laranja";
                default:
                    return Escolher();
            }
        }

        public void inserir(List<string> l, Fruta a)
        {
            string opcao = "0";
            do
            {
                Console.WriteLine("Deseja inserir fruta 1-Sim 2-Não");
                if (Console.ReadLine() == "1")
                {
                    l.Add(a.Escolher());
                }
                else
                { opcao = "1"; }
            } while (opcao == "0");
        }

        public void imprimir(List<string> l)
        {
            foreach (string i in l)
            {
                Console.WriteLine(i);
            }
        }
    }

        class testcesta
        {
            static void Main()
            {
                

                Fruta frutas = new Fruta();

                List<string> cesta = new List<string>();

                frutas.inserir(cesta, frutas);

                frutas.imprimir(cesta);

            Console.ReadLine();

            }
        }
    }

