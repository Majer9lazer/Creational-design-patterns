using System;
using Creational_design_patterns.Builder.Factory;
using Creational_design_patterns.Builder.Factory.Prototype;

namespace Creational_design_patterns.Builder
{
    public class OriginalBurgerBuilder : BurgerBuilder
    {
        private readonly Random _rnd = new Random();
        public void AddMeat(string typeOfMeat)
        {

            switch (typeOfMeat)
            {
                case nameof(Beef):
                    Burger.AddMeat(new Beef
                    {
                        Weight = _rnd.NextDouble() * _rnd.Next(10),
                        Name = "говядина"
                    });
                    Console.WriteLine("Добавили говядины");
                    break;
                case nameof(Ham):
                    Burger.AddMeat(new Ham { Weight = _rnd.NextDouble() * _rnd.Next(10), Name = "ветчина" });
                    Console.WriteLine("Добавили ветчины");
                    break;
                case nameof(Sausage):
                    Burger.AddMeat(new Sausage { Weight = _rnd.NextDouble() * _rnd.Next(10), Name = "сосиска" });
                    Console.WriteLine("Добавили сосиску");
                    break;
            }
        }
        public void AddVegetable(string typeOfVegetable)
        {
            switch (typeOfVegetable)
            {
                case "Tomato":
                    Burger.AddVegetable(new Vegetable() { Weight = _rnd.NextDouble() * _rnd.Next(10), VegetableType = TypeOfVegetable.Tomato, Name = "Red Tomato" });
                    Console.WriteLine("Добавили красного помидора");
                    break;
                case "Onion":
                    Burger.AddVegetable(new Vegetable() { Weight = _rnd.NextDouble() * _rnd.Next(10), VegetableType = TypeOfVegetable.Onion, Name = "Bulb Onion" });
                    Console.WriteLine("Добавили лука репчатого");
                    break;
                case "Cucumber":
                    Burger.AddVegetable(new Vegetable() { Weight = _rnd.NextDouble() * _rnd.Next(10), VegetableType = TypeOfVegetable.Cucumber, Name = "Salty Cucumber" });
                    Console.WriteLine("Добавили соленого огурчика");
                    break;
            }
        }
        public CheeseSlice AddCheeseSlice() => Burger.AddCheeseSlice();
        public override void BuildBurger()
        {
            if(Burger.GetPriceOfCheeseSlices()>0||Burger.GetPriceOfMeats()>0||Burger.GetPriceOfVegetables()>0)
            Console.WriteLine("Ура ваш бургер был собран");
            else
                Console.WriteLine("Увы вы ничего не заказали");
        }
        public override void ShowPrice()
        {
            double p1 = Burger.GetPriceOfMeats(),
                p2 = Burger.GetPriceOfVegetables(),
                p3 = Burger.GetPriceOfCheeseSlices();
            Console.WriteLine("Общая цена за мясные изделия : " + p1);
            Console.WriteLine("Общая цена за овощи : " + p2);
            Console.WriteLine("Общая цена за сыр : " + p3);
            Console.WriteLine("Итого : " + (p1 + p2 + p3));
        }
    }
}
