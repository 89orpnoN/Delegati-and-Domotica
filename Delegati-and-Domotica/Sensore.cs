using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati_and_Domotica
{
    internal abstract class Sensore
    {
        private float _valore;
        protected bool LeggiDato(out float Variable)
        {
            Variable = _valore;
            return true;
        }
    }

    internal class LightSensor : Sensore
    {

    }

}
