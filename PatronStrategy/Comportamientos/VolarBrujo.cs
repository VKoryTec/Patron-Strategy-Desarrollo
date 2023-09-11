using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Comportamientos
{
    public class VolarBrujo : IVolarInter
    {
        public void fly() 
        {
            Console.WriteLine(" El pato esta volando con brujeria!!");
        }
    }
}
