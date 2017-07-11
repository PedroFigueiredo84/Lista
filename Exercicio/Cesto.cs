using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Cesto
    {
        public Cesto() { }

        List<Fruta> Cest = new List<Fruta>();
        public void Inserir(Fruta f)
        {

            Cest.Add(f);   
            
        }

        public string contar()
        {

            int bananas = 0;
            int laranjas = 0;
            int macas = 0;

            bananas = Cest.OfType<Banana>().Count();
            laranjas = Cest.OfType<Laranja>().Count();
            macas = Cest.OfType<Maca>().Count();

            return "Existem " + bananas + " bananas " + macas + " macas, " + laranjas + " laranjas";

        }

    }
}
