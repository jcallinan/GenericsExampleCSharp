using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchestraOOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Violin myViolin = new Violin();
            myViolin.setName("Jeremy's Violin");
            myViolin.setManufacturer("Stentor");
            myViolin.Strum();
            myViolin.setMaxPrice(1000000);
            
            Viola myViola = new Viola();
            myViola.setName("Jeremy's Viola");
            myViola.setManufacturer("D Z Strad");
            myViola.Strum();
            myViola.setMaxPrice(100000);

            Guitar myGuitar = new Guitar();
            myGuitar.setName("Jeremy's Guitar");
            myGuitar.setManufacturer("Ibanez");
            myGuitar.Strum();
            myGuitar.setMaxPrice(1000);


            //find out which is the most expensive
            List<StringInstrument> myStringInstruments = new List<StringInstrument>();

            myStringInstruments.Add(myGuitar);
            myStringInstruments.Add(myViolin);
            myStringInstruments.Add(myViola);

            int highestPrice = 0;

            foreach (StringInstrument i in myStringInstruments)
            {
                Console.WriteLine("Checking price");

                Console.WriteLine(i.getMaxPrice());

                if (i.getMaxPrice() > highestPrice)
                {
                    highestPrice = i.getMaxPrice();
                    Console.WriteLine(i.getName() + " is the most expensive");
                }
            }



            Console.ReadLine();
         

        }
    }
}
