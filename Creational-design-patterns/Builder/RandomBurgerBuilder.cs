using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Creational_design_patterns.Builder.Singleton;

namespace Creational_design_patterns.Builder.Factory
{
    public class RandomBurgerBuilder : BurgerBuilder
    {
        private readonly int[] _maxItems = new int[3];
        public MoneyCounter Counter = MoneyCounter.GetMoneyCounter();
        public RandomBurgerBuilder(int maxMeats = 1, int maxVegetables = 1, int maxCheeseSlices = 1)
        {
            _maxItems[0] = maxMeats;
            _maxItems[1] = maxVegetables;
            _maxItems[2] = maxCheeseSlices;
        }
        public override void BuildBurger()
        {
            Random rnd = new Random();
            int randomMaxMeats = rnd.Next(_maxItems[0]);
            for (int i = 0; i < randomMaxMeats; i++)
            {
                int randMeat = rnd.Next(3);
                switch (randMeat)
                {
                    case 0:
                        Beef b = new Beef { Weight = rnd.NextDouble() * rnd.Next(5),Name = "говядина"};
                        Burger.AddMeat(b);
                        Console.WriteLine("Добавили говядины");
                        MoneyCounter.LogBuyes(b);
                        break;
                    case 1:
                        Ham h = new Ham { Weight = rnd.NextDouble() * rnd.Next(5), Name = "ветчина" };
                        Burger.AddMeat(h);
                        Console.WriteLine("Добавили ветчины");
                        MoneyCounter.LogBuyes(h);
                        break;
                    case 2:
                        Sausage s = new Sausage { Weight = rnd.NextDouble() * rnd.Next(5), Name = "сосиска" };
                        Burger.AddMeat(s);
                        Console.WriteLine("Добавили сосиску");
                        MoneyCounter.LogBuyes(s);
                        break;
                }
                Thread.Sleep(40);
            }

            int randomMaxVegetables = rnd.Next(_maxItems[1]);
            for (int i = 0; i < randomMaxVegetables; i++)
            {
                int randVegetable = rnd.Next(3);
                switch (randVegetable)
                {
                    case 0:
                        Vegetable Tomato = new Vegetable()
                        {
                            Weight = rnd.NextDouble(),
                            VegetableType = TypeOfVegetable.Tomato,
                            Name = "красный помидор"
                        };
                        Burger.AddVegetable(Tomato);
                        Console.WriteLine("Добавили красного помидора");
                        MoneyCounter.LogBuyes(Tomato);
                        break;
                    case 1:
                        Vegetable Onion = new Vegetable()
                        {
                            Weight = rnd.NextDouble(),
                            VegetableType = TypeOfVegetable.Onion,
                            Name = "лук репчатый"
                        };
                        Burger.AddVegetable(Onion);
                        Console.WriteLine("Добавили лука репчатого");
                        MoneyCounter.LogBuyes(Onion);
                        break;
                    case 2:
                        Vegetable Cucumber = new Vegetable()
                        {
                            Weight = rnd.NextDouble(),
                            VegetableType = TypeOfVegetable.Cucumber,
                            Name = "соленый огурчик"
                        };
                        Burger.AddVegetable(Cucumber);
                        Console.WriteLine("Добавили соленого огурчика");
                        MoneyCounter.LogBuyes(Cucumber);
                        break;
                }
                Thread.Sleep(40);
            }

            int randomMaxCheeseSlices = rnd.Next(_maxItems[2]);
            for (int i = 0; i < randomMaxCheeseSlices; i++)
            {
                MoneyCounter.LogBuyes(Burger.AddCheeseSlice());
                Thread.Sleep(40);
            }
            Console.WriteLine("Ура ваш бургер был собран");
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
