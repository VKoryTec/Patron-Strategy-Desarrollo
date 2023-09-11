using PatronStrategy.Comportamientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Patos
{
    public class RubberDuck : _Pato
    {
        public RubberDuck() {

            Nombre = "Pato hule";

            varVolar = new VolarNo();
            varQuack = new QuackNo();
            varNadar = new NadarNormal();
        }
        public override void Presentacion()
        {
            Console.WriteLine("  Tomas al pato de hule, se siente muy elastico");
        }
    }
}
