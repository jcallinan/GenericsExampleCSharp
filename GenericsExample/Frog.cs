using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class Frog : Animal
    {
        public override string SpelledSound1
        {
            get { return "Ribbit"; }
        }

        public override string SpelledSound2
        {
            get { return "Croak"; }
        }

        public override string SpelledSound3
        {
            get { return "Croooaaak"; }
        }

        public override string DanceCharacters
        {
            get { return @"/|\ \|/ ^ ^ "; }
        }

        public Frog(string name): base(name)
        {
        }
    }
}
