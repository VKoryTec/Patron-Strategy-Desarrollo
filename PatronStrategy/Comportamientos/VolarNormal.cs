using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Comportamientos
{
    public class VolarNormal : IVolarInter
    {
        public void fly() 
        {
            Console.WriteLine(" El pato esta volando...");
        }
    }
}
