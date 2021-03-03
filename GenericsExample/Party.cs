using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class Party<T> where T : IAnimal
    {
        private List<T> _members;
        public T Leader { get; private set; }
        public Party(T leader)
        {
            this.Leader = leader;
            this._members = new List<T>();
            this._members.Add(leader);
        }
        public void AddMember(T member)
        {
            this._members.Add(member);
            Leader.SayWelcome(member);
        }
        public bool RemoveMember(T member)
        {
            if (member.Equals(this.Leader))
            {
                throw new InvalidOperationException("You cannot remove the leader from the party.");
            }
            var result = this._members.Remove(member);
            if (result)
            {
                member.SayGoodbye(this.Leader);
            }
            return result;
        }
        public virtual void Dance()
        {
            foreach (var member in _members)
            {
                member.Dance();
            }
        }
        public virtual void Sing()
        {
            foreach (var member in _members)
            {
                member.Sing();
            }
        }
        public void VoteLeader()
        {
            if (this._members.Count == 1)
            {
                throw new InvalidOperationException("You need at least two members to vote a new Leader.");
               }
         var newLeader = this.Leader;
         while (newLeader.Equals(this.Leader))
         {
                    var randomLeader =
                    new Random().Next(this._members.Count);
                    newLeader = this._members[randomLeader];
                }

         this.Leader.Say(
         String.Format(
         "{0} has been voted as our new party leader.",
         newLeader.Name));
         newLeader.Dance();
         this.Leader = newLeader;
        }
    }
}
