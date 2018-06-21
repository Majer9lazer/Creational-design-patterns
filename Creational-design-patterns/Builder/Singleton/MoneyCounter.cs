using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Creational_design_patterns.Builder.Factory;
using Creational_design_patterns.Builder.Factory.Prototype;

namespace Creational_design_patterns.Builder.Singleton
{
    public class MoneyCounter
    {
        public static List<IMeat> Meats = new List<IMeat>();
        public static List<Vegetable> Vegetables = new List<Vegetable>();
        public static List<CheeseSlice> CheeseSlices = new List<CheeseSlice>();
        private static MoneyCounter _counter;
        private static readonly Random _rnd = new Random();
        private MoneyCounter() { }

        public static MoneyCounter GetMoneyCounter()
        {
            if (_counter == null)
                _counter = new MoneyCounter();
            lock (_counter)
                return _counter;
        }
        public static double GetPrice(double weight, int maxRandom) => weight * _rnd.Next(500);
        public static void LogBuyes(IMeat m) => Meats.Add(m);
        public static void LogBuyes(Vegetable v) => Vegetables.Add(v);
        public static void LogBuyes(CheeseSlice c) => CheeseSlices.Add(c);

        public void GetBoughtItems()
        {
            Console.WriteLine("Купили");
            int i = 0;
            int j = 0;
            foreach (CheeseSlice slice in CheeseSlices)
            {
                Console.WriteLine(slice.Name);
                i++;
            }
            j += i;
            Console.WriteLine("Итого  купили : " + i + " сыра");
            i = 0;
            foreach (IMeat meat in Meats)
            {
                Console.WriteLine(meat.Name);
                i++;
            }
            Console.WriteLine("Итого  купили : " + i + " мясных изделий");
            j += i;
            i = 0;
            foreach (Vegetable vegetable in Vegetables)
            {
                Console.WriteLine(vegetable.Name);
                i++;
            }
            Console.WriteLine("Итого  купили : " + i + " овощей");
            j += i;
            Console.WriteLine("Итого  купили : " + j + " продуктов");
        }

    }
}
