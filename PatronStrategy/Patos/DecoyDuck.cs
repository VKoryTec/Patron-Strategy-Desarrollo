using PatronStrategy.Comportamientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Patos
{
    public class DecoyDuck : _Pato
    {
        public DecoyDuck() {

            Nombre = "Pato Falso";

            varVolar = new VolarNo();
            varQuack = new QuackNo();
            varNadar = new NadarNo();
        }

        public override void Presentacion()
        {
            Console.WriteLine("  El pato no reacciona... Es falso :(");
        }
    }
}
