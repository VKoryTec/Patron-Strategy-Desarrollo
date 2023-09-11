using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Comportamientos
{
    public class NadarMagia : INadar
    {
        public void nadar()
        {
            Console.WriteLine(" El pato nada usando alguna clase de magia");
        }
    }
}
