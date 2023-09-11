using PatronStrategy.Comportamientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Patos
{
    public class RedHeadDuck : _Pato
    {
        public RedHeadDuck() {

            Nombre = "Pato Cabeza Roja";
            
            varVolar = new VolarBrujo();
            varQuack = new QuackTelepatico();
            varNadar = new NadarMagia();
        }
        public override void Presentacion()
        {
            Console.WriteLine("  Sientes una prescencia oscura mientras te acercas al pato...");
        }
    }
}
