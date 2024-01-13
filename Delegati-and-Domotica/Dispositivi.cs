using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati_and_Domotica
{
    internal class Vocale
    {
        void parla(string testo)
        {
            Console.WriteLine(testo);
        }
        private event SendValueEventHandler _comandi;
        public void Comandi(int value)
        {
            _comandi(value);
        }

    }
    internal class Phone
    {
        private event SendStatusEventHandler? _inviaEmail ;
        private bool InviaEmail(int valore, string messaggio)
        {
            _inviaEmail(valore, messaggio);

            return _inviaEmail != null;
        }
    }
    internal class Watch
    {
        void scrivi(int valore,string unita)
        {
            Console.WriteLine($"{valore} {unita}");
        }
    }
}
