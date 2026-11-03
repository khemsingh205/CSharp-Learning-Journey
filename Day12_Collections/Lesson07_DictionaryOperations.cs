using System;
using System.Collections.Generic;

namespace Day12_Lesson07_DictionaryOperations
{
    public class DictionaryOperationsLesson
    {
        public void Run()
        {
            Dictionary<string, int> weaponDamage = new Dictionary<string, int>();

            weaponDamage.Add("Iron Sword", 25);
            weaponDamage.Add("Shadow Dagger", 18);
            weaponDamage.Add("Cursed Bow", 30);
            Console.WriteLine("After Add: " + weaponDamage.Count);

            weaponDamage["Iron Sword"] = 40;
            Console.WriteLine("Updated Iron Sword: " + weaponDamage["Iron Sword"]);

            Console.WriteLine("Has Cursed Bow: " + weaponDamage.ContainsKey("Cursed Bow"));

            int damage;
            if (weaponDamage.TryGetValue("Shadow Dagger", out damage))
            {
                Console.WriteLine("Shadow Dagger damage: " + damage);
            }

            weaponDamage.Remove("Cursed Bow");
            Console.WriteLine("After Remove: " + weaponDamage.Count);
        }
    }

    public class Lesson07Runner
    {
        static void Main()
        {
            DictionaryOperationsLesson lesson = new DictionaryOperationsLesson();
            lesson.Run();
            Console.ReadLine();
        }
    }
}