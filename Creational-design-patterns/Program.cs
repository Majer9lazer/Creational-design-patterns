using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Creational_design_patterns.Builder;
using Creational_design_patterns.Builder.Factory;
using Creational_design_patterns.Builder.Singleton;

namespace Creational_design_patterns
{
     
    class Program
    {
        private static string _message = "";
        static void Main(string[] args)
        { 
            string beginSentence = "<---";
            string finishSentence = "--->";
            Director director = new Director();
            beginning:
            ShowMenu();
            int.TryParse(Console.ReadLine(), out int option);
            switch (option)
            {
                case 1:
                    {
                        _message = $"{beginSentence} Добро пожаловать в меню {finishSentence}\n" +
                                   $"{beginSentence} Вот что мы имеем : {finishSentence}\n" +
                                   $"{beginSentence} Сыр : {finishSentence}\n" +
                                   $"{beginSentence} Разные виды мяса: {finishSentence}\n" +
                                   $"{beginSentence} Разные виды овощей: {finishSentence}\n";
                        Console.WriteLine(_message);
                        Console.WriteLine("Нажмите Enter чтобы войти в главное меню или любую другю клавищу чтобы выйти");
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                            goto beginning;
                        Exit();
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        ShowMenu();
                        Console.WriteLine("[1]Положить все игредиенты рандомно");
                        Console.WriteLine("[2]Собрать бургер самому");
                        int.TryParse(Console.ReadLine(), out option);
                        switch (option)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Сколько положить максимально мясных изделий ?");
                                    int.TryParse(Console.ReadLine(), out int maxMeats);
                                    Console.WriteLine("Сколько положить максимально овощей ?");
                                    int.TryParse(Console.ReadLine(), out int maxVegetables);
                                    Console.WriteLine("Сколько положить максимально кусочков сыра ?");
                                    int.TryParse(Console.ReadLine(), out int maxCheeseSlices);
                                    RandomBurgerBuilder builder = new RandomBurgerBuilder(maxMeats: maxMeats,
                                        maxVegetables: maxVegetables, maxCheeseSlices: maxCheeseSlices);
                                    director.StartToBuild(builder);
                                    builder.ShowPrice();
                                    builder.Counter.GetBoughtItems();
                                    break;
                                }
                            case 2:

                                OriginalBurgerBuilder originalBurgerBuilder = new OriginalBurgerBuilder();
                                startMenu:
                                Console.Clear();
                                Console.WriteLine("[1] Добавить сыра");
                                Console.WriteLine("[2] Добавить мяса");
                                Console.WriteLine("[3] Добавить овощей");
                                Console.WriteLine("[4] Сготовить бургер");
                                Console.WriteLine("[5] Выйти");
                                int.TryParse(Console.ReadLine(), out option);
                                switch (option)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Сколько кусочков добавить");
                                            int.TryParse(Console.ReadLine(), out option);
                                            for (int i = 0; i < option; i++)
                                            {
                                                MoneyCounter.LogBuyes(originalBurgerBuilder.AddCheeseSlice());
                                            }
                                            Thread.Sleep(200);
                                            goto startMenu;
                                        }
                                    case 2:
                                        {
                                            meatMenu:
                                            Console.Clear();
                                            Console.WriteLine("[1] Добавить говядины");
                                            Console.WriteLine("[2] Добавить сосиски");
                                            Console.WriteLine("[3] Добавить ветчины");
                                            Console.WriteLine("[4] Вернуться к меню");

                                            int.TryParse(Console.ReadLine(), out option);
                                            switch (option)
                                            {
                                                case 1:
                                                    {
                                                        Console.WriteLine("Сколько кусочков добавить");
                                                        int.TryParse(Console.ReadLine(), out option);
                                                        for (int i = 0; i < option; i++)
                                                        {
                                                            originalBurgerBuilder.AddMeat(nameof(Beef));
                                                        }
                                                        Thread.Sleep(200);
                                                        goto meatMenu;
                                                    }
                                                case 2:
                                                    {
                                                        Console.WriteLine("Сколько кусочков добавить");
                                                        int.TryParse(Console.ReadLine(), out option);
                                                        for (int i = 0; i < option; i++)
                                                        {
                                                            originalBurgerBuilder.AddMeat(nameof(Sausage));
                                                        }
                                                        Thread.Sleep(200);
                                                        goto meatMenu;
                                                    }
                                                case 3:
                                                    {
                                                        Console.WriteLine("Сколько кусочков добавить");
                                                        int.TryParse(Console.ReadLine(), out option);
                                                        for (int i = 0; i < option; i++)
                                                        {
                                                            originalBurgerBuilder.AddMeat(nameof(Ham));
                                                        }
                                                        Thread.Sleep(200);
                                                        goto meatMenu;
                                                    }
                                                case 4: { goto startMenu; }
                                            }
                                            break;
                                        }
                                    case 3:
                                        {
                                            {
                                                VegMenu:
                                                Console.Clear();
                                                Console.WriteLine("[1] Добавить лука");
                                                Console.WriteLine("[2] Добавить помидора");
                                                Console.WriteLine("[3] Добавить огурца");
                                                Console.WriteLine("[4] Вернуться к меню");
                                                int.TryParse(Console.ReadLine(), out option);
                                                switch (option)
                                                {
                                                    case 1:
                                                        {
                                                            Console.WriteLine("Сколько кусочков добавить");
                                                            int.TryParse(Console.ReadLine(), out option);
                                                            for (int i = 0; i < option; i++)
                                                            {
                                                                originalBurgerBuilder.AddVegetable("Tomato");
                                                            }
                                                            Thread.Sleep(200);
                                                            goto VegMenu;
                                                        }
                                                    case 2:
                                                        {
                                                            Console.WriteLine("Сколько кусочков добавить");
                                                            int.TryParse(Console.ReadLine(), out option);
                                                            for (int i = 0; i < option; i++)
                                                            {
                                                                originalBurgerBuilder.AddVegetable("Cucumber");
                                                            }
                                                            Thread.Sleep(200);
                                                            goto VegMenu;
                                                        }
                                                    case 3:
                                                        {
                                                            Console.WriteLine("Сколько кусочков добавить");
                                                            int.TryParse(Console.ReadLine(), out option);
                                                            for (int i = 0; i < option; i++)
                                                            {
                                                                originalBurgerBuilder.AddVegetable("Onion");
                                                            }
                                                            Thread.Sleep(200);
                                                            goto VegMenu;
                                                        }
                                                    case 4: { goto startMenu; }
                                                }
                                                break;
                                            }
                                        }
                                    case 4:
                                        {
                                            director.StartToBuild(originalBurgerBuilder);
                                            originalBurgerBuilder.ShowPrice();
                                            break;
                                        }
                                    case 5: Console.Clear(); Exit(); break;

                                }

                                break;
                            default:
                                Console.WriteLine("Вы выбрали несуществующий пункт");
                                Exit();
                                break;
                        }
                        break;
                    }
                case 9:
                    {
                        Console.Clear();
                        Exit();
                        break;
                    }
                default:
                    _message = "Вы выбрали несуществующий пункт";
                    Console.WriteLine(_message);
                    break;
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("[1] - Меню");
            Console.WriteLine("[2] - Заказать Бургер");
            Console.WriteLine("[9] - Выход");
        }

        private static void Exit()
        {
            Console.WriteLine("Good bye");
            for (int i = 4; i >= 0; i--)
            {
                _message = $"Application will close in {i} seconds ";
                Console.WriteLine(_message);
                for (int j = 0; j < 4; j++)
                {
                    Console.Clear();
                    _message = $"Application will close in {i} seconds{new string('.', j)}";
                    Console.WriteLine(_message);
                    Thread.Sleep(250);
                }
            }
        }
    }
}
