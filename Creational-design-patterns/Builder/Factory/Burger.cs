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
        private static readonly Random _rnd = new Random();
        public string Name { get; set; }
        private List<IMeat> Meats { get; } = new List<IMeat>();
        private List<Vegetable> Vegetables { get; } = new List<Vegetable>();
        private List<CheeseSlice> CheeseSlices { get; } = new List<CheeseSlice>();
        private readonly CheeseSlice _cheeseSlice = new CheeseSlice(_rnd.NextDouble()*_rnd.Next(100),"Кусочек сыра");
        public void AddVegetable(Vegetable v) => Vegetables.Add(v);
        public void AddMeat(IMeat m) => Meats.Add(m);

        public CheeseSlice AddCheeseSlice()
        {
            CheeseSlice cheese = (CheeseSlice) _cheeseSlice.Clone(_cheeseSlice);
            CheeseSlices.Add((CheeseSlice) _cheeseSlice.Clone(_cheeseSlice));
            Console.WriteLine("Добавили сыра");
            return cheese;
        }

        public double GetPriceOfMeats()
        {
            double price = 0;
            foreach (IMeat meat in Meats)
                price += meat.Weight * _rnd.Next(500);
            return price;
        }
        public double GetPriceOfVegetables()
        {
            double price = 0;
            foreach (Vegetable vegetable in Vegetables)
                price += vegetable.Weight * _rnd.Next(250);
            return price;
        }
        public double GetPriceOfCheeseSlices()
        {
            double price = 0;
            foreach (CheeseSlice slice in CheeseSlices)
                price += slice.Weight * _rnd.Next(100);
            return price;
        }


    }
}
