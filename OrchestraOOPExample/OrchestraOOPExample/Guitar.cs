using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchestraOOPExample
{
    class Guitar : StringInstrument
    {
        public Guitar(int numOStrings = 6) : base(numOStrings)
        {
        }
    }
}
