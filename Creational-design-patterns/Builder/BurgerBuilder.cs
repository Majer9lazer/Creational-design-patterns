using Creational_design_patterns.Builder.Factory;

namespace Creational_design_patterns.Builder
{
    public abstract class BurgerBuilder
    {
        protected Burger Burger = new Burger();
        public abstract void BuildBurger();
        public abstract void ShowPrice();
    }
}
