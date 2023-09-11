using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Comportamientos
{
    public class QuackNo : IQuack
    {
        public void quack() 
        {
            Console.WriteLine(" ...");
            Console.WriteLine(" Lamentablemente este pato no puede hacer quack");
        }
    }
}
