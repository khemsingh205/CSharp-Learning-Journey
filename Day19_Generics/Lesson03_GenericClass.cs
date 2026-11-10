using System;

namespace Day19_Lesson03_GenericClass
{
    class Chest<T>
    {
        private T content;

        public void Put(T item)
        {
            content = item;
            Console.WriteLine("Chest now holds: " + content);
        }

        public T Take()
        {
            return content;
        }
    }

    class Lesson03Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Generic Chest");

            Chest<string> weaponChest = new Chest<string>();
            weaponChest.Put("Shadow Blade");
            string weapon = weaponChest.Take();
            Console.WriteLine("Took weapon: " + weapon);

            Chest<int> goldChest = new Chest<int>();
            goldChest.Put(500);
            int gold = goldChest.Take();
            Console.WriteLine("Took gold: " + gold);
        }
    }
}
