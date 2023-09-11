using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Comportamientos
{
    public class NadarNo : INadar
    {
        public void nadar()
        {
            Console.WriteLine(" El pato se hunde, no puede nadar");
        }
    }
}
