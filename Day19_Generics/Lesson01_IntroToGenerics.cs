using System;

namespace Day19_Lesson01_IntroToGenerics
{
    class Lesson01Runner
    {
        static void ShowItem<T>(T item)
        {
            Console.WriteLine("Item: " + item);
        }

        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Generic Method");

            ShowItem("Iron Sword");
            ShowItem(150);
            ShowItem(3.5);
        }
    }
}