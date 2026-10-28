
using System;

class Day06Lesson04
{
    static void Main()
    {
        Console.WriteLine("=== Dungeon Combat ===");

        Attack("Skeleton", 20);
        Attack("Dark Knight", 50);
        Attack("Dungeon Boss", 100);
    }

    static void Attack(string enemyName, int damage)
    {
        Console.WriteLine(
            "Attacked " + enemyName +
            " for " + damage + " damage!"
        );
    }
}
