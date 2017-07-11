using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao = 0;

            Cesto c = new Cesto();


            while (opcao == 0)
            {

                int num = EscolheMenu();

                switch (num)
                {
                    case 1:
                        Fruta f = InserirFruta();
                        c.Inserir(f);
                        break;

                    case 2:
                        Console.WriteLine(c.contar());
                        break;
                    case 3:
                        opcao = 1;
                        break;
                    default:
                        Console.WriteLine("Opçao Invalida");
                        continue;
                }

            }

        }

        static int EscolheMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1 - Inserir fruta");
            Console.WriteLine("2 - Contabilizar frutas no cesto");
            Console.WriteLine("3 - Sair");

            return Convert.ToInt16(Console.ReadLine());
        }

        static Fruta InserirFruta()
        {
            Console.WriteLine("Escolha a fruta");
            Console.WriteLine("1-Banana");
            Console.WriteLine("2-Maça");
            Console.WriteLine("3-Laranja");
            int num2 = Convert.ToInt16(Console.ReadLine());

            switch (num2)
            {
                case 1:
                    return new Banana();
                case 2:
                    return new Maca();
                case 3:
                    return new Laranja();
                default:
                    Console.WriteLine("Opçao errada");
                    return InserirFruta();
            }
        }

       

    

            



    }
}
