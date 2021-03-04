using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchestraOOPExample
{
    public abstract class StringInstrument
    {
        private int _numOfStrings;
        private string _name;
        private string _manufacturer;
        private int _MaxPrice;
        public StringInstrument(int numOStrings = 0, string manufacturer = "",string name = "", int MaxPrice = 0)
        {
            _numOfStrings = numOStrings;
            _manufacturer = manufacturer;
            _name = name;
            _MaxPrice = MaxPrice;
        }
        public string getName()
        {
            return _name;
        }
        public string getManufacturer()
        {
            return _manufacturer;
        }
        public int getMaxPrice()
        {
            return _MaxPrice;
        }
        public void setMaxPrice(int maxPrice)
        {
            if (maxPrice < 0)
            {
                _MaxPrice = 999;
            } else
            {
            _MaxPrice = maxPrice;
            }
        }
        public void setName(string name)
        {
            if (name == null)
            {
                _name = "Unknown";
            } else
            {
                _name = name;
            }   
        }
        public void setManufacturer(string manufacturer)
        {
            if (manufacturer == null)
            {
                _manufacturer = "Unknown";
            } else
            {
                _manufacturer = manufacturer;
            }
            
        }
        public void Strum()
        {
            Console.WriteLine(_name + " is being strummed, it is a beautiful piece of work by " + _manufacturer);
        }

    }
}
