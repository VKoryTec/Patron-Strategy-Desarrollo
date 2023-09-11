using PatronStrategy.Comportamientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Patos
{
    public class MallardDuck : _Pato
    {
        public MallardDuck() {

            Nombre = "Pato Mallard";

            varVolar = new VolarNo();
            varQuack = new QuackNormal();
            varNadar = new NadarNormal();
        }
        public override void Presentacion()
        {
            Console.WriteLine("  El pato te mira con curiosidad...");
        }
    }
}
