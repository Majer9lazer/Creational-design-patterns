using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_design_patterns.Builder.Factory
{
    class Beef:IMeat
    {
        public double Weight { get; set; }
        public string Name { get; set; }

        public void ShowName()
        {
            Console.WriteLine("Это говядина");
        }
    }
}
