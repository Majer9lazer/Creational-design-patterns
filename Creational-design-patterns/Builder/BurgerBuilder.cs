using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_design_patterns.Builder.Factory
{
    public abstract class BurgerBuilder
    {
        protected Burger Burger = new Burger();
        public abstract void BuildBurger();
        public abstract void ShowPrice();
    }
}
