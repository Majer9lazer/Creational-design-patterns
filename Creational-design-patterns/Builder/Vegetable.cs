using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_design_patterns.Builder
{
    public enum TypeOfVegetable
    {
        Tomato, Onion, Cucumber
    }
    public class Vegetable
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public TypeOfVegetable VegetableType { get; set; }
    }
}
