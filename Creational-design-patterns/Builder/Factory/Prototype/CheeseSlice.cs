using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_design_patterns.Builder.Factory.Prototype
{
    public class CheeseSlice : Clonable
    {
        public CheeseSlice(double weight,string name)
        {
            this.Weight = weight;
            Name = name;
        }



        public override Clonable Clone(object obj)
        {

            return ((CheeseSlice) obj);
        }
    }
}
