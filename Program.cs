using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Listas;

namespace Listas
{
    class Frutas
    {
        public abstract class Fruta {}
        public abstract class Maça : Fruta {}
        public abstract class Banana : Fruta { }
        public abstract class Laranja : Fruta { }

        public Fruta Inserir()
        {
            Console.WriteLine("O que deseja inserir?");
            Console.WriteLine("1 - Banana");
            Console.WriteLine("2 - Maça");
            Console.WriteLine("3 - Laranja");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    return Maça;
                case 2:
                    return Banana;
                case 3:
                    return Laranja;
                default:
                    return Inserir();
            }
        }

        class testcesta
        {
            static void Main()
            {
                string opcao = "0";

                Frutas frutas = new Frutas();

                List<Fruta> cesta = new List<Fruta>();

                do {
                    Console.WriteLine("Deseja inserir fruta 1-Sim 2-Não");
                    if (Console.ReadLine() == "1")
                    {
                        cesta.Add(frutas.Inserir());
                    }
                    else
                    { opcao = "1"; }
                } while (opcao == "0");

                Console.ReadLine();



            }
        }
    }
}

