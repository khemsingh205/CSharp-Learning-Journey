
using System;

class Day06Lesson03
{
    static void Main()
    {
        Console.WriteLine("Dark Fantasy Dungeon");
        Console.WriteLine("Knight is fighting an enemy!");

        Attack(10);
        Attack(25);
        Attack(50);
    }

    static void Attack(int damage)
    {
        Console.WriteLine("Knight deals " + damage + " damage!");
    }
}
