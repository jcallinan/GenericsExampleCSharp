using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public interface IAnimal
    {
        string Name { get; set; }
        void Dance();
        void Say(string message);
        void SayGoodbye(IAnimal destination);
        void SayWelcome(IAnimal destination);
        void Sing();
    }
   public abstract class Animal : IAnimal, IEquatable<IAnimal>
    {
        protected string _name;

        public string Name
        {
            get { return this._name; }
            set
            {
                throw new InvalidOperationException("Name is a read-only property.");
            }
        }
        public virtual string DanceCharacters
        {
            get { return string.Empty; }
        }
        public virtual string SpelledSound1 { get { return string.Empty; } }
        public virtual string SpelledSound2 { get { return string.Empty; } }
        public virtual string SpelledSound3 { get { return string.Empty; } }
        public Animal(string name)
        {
            this._name = name;
        }
        public void Dance()
        {
            Console.WriteLine(
            String.Format(
            "{0} dances {1}",
            this.Name,
            DanceCharacters));
        }
        public bool Equals(IAnimal otherAnimal)
        {
            return (this == otherAnimal);
        }
        public void Say(string message)
        {
            Console.WriteLine(
            String.Format(
            "{0} says: {1}",
            this.Name, message));
        }
        public void SayGoodbye(IAnimal destination)
        {
            Console.WriteLine(
            String.Format(
            "{0} says goodbye to {1}: {2} {3} {4}",
            this.Name,
            destination.Name,
            SpelledSound1,
            SpelledSound3,
            SpelledSound1));
        }

        public void SayWelcome(IAnimal destination)
        {
            Console.WriteLine(
            String.Format(
            "{0} welcomes {1}: {2}",
            this.Name,
            destination.Name,
            SpelledSound2));
        }
        public void Sing()
        {
            var spelledSingSound = SpelledSound1 + " ";
            var sb = new StringBuilder();
            sb.Append(String.Format("{0} sings: ", this.Name));
            sb.Append(String.Concat(Enumerable.Repeat(spelledSingSound, 3)));
            sb.Append(". ");
            sb.Append(String.Concat(Enumerable.Repeat(spelledSingSound, 2)));
            sb.Append(". ");
            sb.Append(spelledSingSound);
            sb.Append(". ");
            Console.WriteLine(sb.ToString());
        }
    }
  


}
