using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class Program
    { 
        static void Main(string[] args)
        {
            var jake = new Dog("Jake");
            var duke = new Dog("Duke");
            var lady = new Dog("Lady");
            var dakota = new Dog("Dakota");
            var dogsParty = new Party<Dog>(jake);
            dogsParty.AddMember(duke);
            dogsParty.AddMember(lady);
            dogsParty.AddMember(dakota);
            dogsParty.Dance();
            dogsParty.RemoveMember(duke);
            dogsParty.VoteLeader();
            dogsParty.Sing();

            var frog1 = new Frog("Frog #1");
            var frog2 = new Frog("Frog #2");
            var frog3 = new Frog("Frog #3");
            var frog4 = new Frog("Frog #4");
            var frogsParty = new Party<Frog>(frog1);
            frogsParty.AddMember(frog2);
            frogsParty.AddMember(frog3);
            frogsParty.AddMember(frog4);
            frogsParty.Dance();
            frogsParty.RemoveMember(frog3);
            frogsParty.VoteLeader();
            frogsParty.Sing();
            Console.ReadLine();

        }
    }
}
