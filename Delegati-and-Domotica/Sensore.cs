using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati_and_Domotica
{
    internal abstract class Sensore
    {
        protected string Unita;
        protected float? _valore;
        protected bool LeggiDato(out float Variable) // lancia errore
        {
            Variable = _valore ?? 0;
            return (_valore != null);
        } 

        protected event SendValueEventHandler SendValue;
        protected event SendStatusEventHandler SendStatus;

    }

    internal class LightSensor : Sensore
    {
        //fai costruttore
        LightSensor() 
        {
            Unita = "Lumen";
            _valore = 46;
        }
    }

    internal class TempSensor : Sensore
    {
        TempSensor()
        {
            Unita = "Celsius";
            _valore = 140;
        }
    }

}
