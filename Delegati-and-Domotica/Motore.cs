using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati_and_Domotica
{
    internal class Motore
    {
        private bool _status; 
        // terribile
        public bool Status()
        {
            return _status;
        }
        public void Operate()
        {
            _status = !_status;
        }
    }
}
