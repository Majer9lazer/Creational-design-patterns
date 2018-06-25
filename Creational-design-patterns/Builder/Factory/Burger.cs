using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Creational_design_patterns.Builder.Factory.Prototype;

namespace Creational_design_patterns.Builder.Factory
{
    public class Burger
    {
        private static readonly Random Rnd = new Random();
        private List<IMeat> Meats { get; } = new List<IMeat>();
        private List<Vegetable> Vegetables { get; } = new List<Vegetable>();
        private List<CheeseSlice> CheeseSlices { get; } = new List<CheeseSlice>();
        private readonly CheeseSlice _cheeseSlice = new CheeseSlice(Rnd.NextDouble() * Rnd.Next(5, 10), "Кусочек сыра");
        public void AddVegetable(Vegetable v) => Vegetables.Add(v);
        public void AddMeat(IMeat m) => Meats.Add(m);

        public CheeseSlice AddCheeseSlice()
        {
            Clonable cheese = _cheeseSlice.Clone(_cheeseSlice);
            CheeseSlices.Add((CheeseSlice)_cheeseSlice.Clone(_cheeseSlice));
            Console.WriteLine("Добавили сыра");
            return (CheeseSlice)cheese;
        }

        public double GetPriceOfMeats()
        {
            double price = 0;
            foreach (IMeat meat in Meats)
                price += meat.Weight * Rnd.Next(500);
            return price;
        }
        public double GetPriceOfVegetables()
        {
            double price = 0;
            foreach (Vegetable vegetable in Vegetables)
                price += vegetable.Weight * Rnd.Next(250);
            return price;
        }
        public double GetPriceOfCheeseSlices()
        {
            double price = 0;
            foreach (CheeseSlice slice in CheeseSlices)
                price += slice.Weight * Rnd.Next(100);
            return price;
        }


    }
}
