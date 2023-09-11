using PatronStrategy.Comportamientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Patos
{
    public abstract class _Pato
    {
        public IVolarInter varVolar;
        public IQuack varQuack;
        public INadar varNadar;

        public string Nombre;

        public abstract void Presentacion();
        public void IntentarVolar()
        {
            varVolar.fly();
        }
        public void IntentarQuack()
        {
            varQuack.quack();
        }

        public void IntentarNadar()
        {
            varNadar.nadar();
        }


        public void SetVolar(IVolarInter tipovuelo)
        {
            varVolar = tipovuelo;
        }
        public void SetQuack(IQuack tipoquack)
        {
            varQuack = tipoquack;
        }
        public void SetNadar(INadar tiponado)
        {
            varNadar = tiponado;
        }
    }
}
