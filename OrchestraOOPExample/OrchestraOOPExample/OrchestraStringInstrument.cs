using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchestraOOPExample
{
    class OrchestraStringInstrument : StringInstrument
    {
        public OrchestraStringInstrument(int numOStrings = 4, string manufacturer = "", string name = "") : base(numOStrings,manufacturer, name)
        {
            
        }
       
    }
}
