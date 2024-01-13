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
        private bool InviaEmail()
    }
    internal class Watch
    {

    }
}
