using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Comportamientos
{
    public class NadarNormal : INadar
    {
        public void nadar()
        {
            Console.WriteLine(" El pato nada tranquilamente");
        }
    }
}
