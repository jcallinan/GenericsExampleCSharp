using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class Dog: Animal
    {
        
 public override string SpelledSound1
        {
            get { return "Woof"; }
        }
        public override string SpelledSound2
        {
            get { return "Wooooof"; }
        }

        public override string SpelledSound3
        {
            get { return "Grr"; }
        }

        public override string DanceCharacters
        {
            get { return @"/-\ \-\ /-/"; }
        }

        public Dog(string name) : base(name)
        {
        }
    }
}
