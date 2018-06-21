using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_design_patterns.Builder.Factory
{
    public interface IMeat
    {
        double Weight { get; set; }
        string Name { get; set; }
        void ShowName();

    }
}
