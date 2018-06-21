using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Creational_design_patterns.Builder.Factory;

namespace Creational_design_patterns.Builder
{
    public class Director
    {
        private BurgerBuilder _builder;

        public void StartToBuild(BurgerBuilder builder)
        {
            this._builder = builder;
            _builder.BuildBurger();
        }
    }
}
