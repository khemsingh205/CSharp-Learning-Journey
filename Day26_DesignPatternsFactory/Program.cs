using System;

namespace Day26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== Day 26: Design Patterns =====");
                Console.WriteLine("1. Introduction To Design Patterns");
                Console.WriteLine("2. Understanding Factory Pattern");
                Console.WriteLine("3. Simple Factory Pattern");
                Console.WriteLine("4. Factory With Interfaces");
                Console.WriteLine("5. Factory With Inheritance");
                Console.WriteLine("6. Factory vs Normal Object Creation");
                Console.WriteLine("7. RPG Weapon Factory");
                Console.WriteLine("8. Enemy Factory System");
                Console.WriteLine("0. Exit");
                Console.Write("Lesson number chuno: ");

                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1": Lesson01.Lesson01_IntroductionToDesignPatterns.Run(); break;
                    case "2": Lesson02.Lesson02_UnderstandingFactoryPattern.Run(); break;
                    case "3": Lesson03.Lesson03_SimpleFactoryPattern.Run(); break;
                    case "4": Lesson04.Lesson04_FactoryWithInterfaces.Run(); break;
                    case "5": Lesson05.Lesson05_FactoryWithInheritance.Run(); break;
                    case "6": Lesson06.Lesson06_FactoryVsNormalObjectCreation.Run(); break;
                    case "7": Lesson07.Lesson07_RPGWeaponFactory.Run(); break;
                    case "8": Lesson08.Lesson08_EnemyFactorySystem.Run(); break;
                    case "0": return;
                    default: Console.WriteLine("Galat number, dobara try karo."); break;
                }
            }
        }
    }
}