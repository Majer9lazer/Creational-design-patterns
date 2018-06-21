using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_design_patterns.Builder.Factory.Prototype
{
    public abstract class Clonable
    {
        public double Weight { get; set; }
        public string Name { get; set; }
        public abstract Clonable Clone(object obj);
    }
}
