using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati_and_Domotica
{
    
    public delegate void SendValueEventHandler(float val);
    public delegate void SendStatusEventHandler(float val, string status);

}
