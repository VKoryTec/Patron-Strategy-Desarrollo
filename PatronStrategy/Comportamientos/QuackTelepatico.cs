using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Comportamientos
{
    public class QuackTelepatico : IQuack
    {
        public void quack() 
        {
            Console.WriteLine(" *Escuchas \"Quack!\" dentro de tu cabeza*");
        }
    }
}
