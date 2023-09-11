using PatronStrategy.Comportamientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Patos
{
    public class ModelDuck : _Pato
    {
        public ModelDuck() {

            Nombre = "Pato Modelo";

            varVolar = new VolarNormal();
            varQuack = new QuackNormal();
            varNadar = new NadarNormal();
        }
        public override void Presentacion()
        {
            Console.WriteLine("  El pato voltea con ojos brillosos, tambien tiene un plumaje muy bonito");
        }
    }
}
