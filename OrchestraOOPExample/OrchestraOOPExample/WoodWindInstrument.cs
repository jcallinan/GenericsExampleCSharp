using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchestraOOPExample
{
    public enum Material
    {
        Wood,
        Metal
    }

    public abstract class WoodWindInstrument
    {
        private Material _typeOfMaterial;
        private string _manufacturer;
        private string _name;
        public WoodWindInstrument(Material typeOfMaterial, string manufacturer, string name)
        {
            _typeOfMaterial = typeOfMaterial;
            _manufacturer = manufacturer;
            _name = name;
        }
    }
}
