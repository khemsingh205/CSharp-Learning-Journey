
using System;

class Day06Lesson08
{
    static void Main()
    {
        Console.WriteLine("=== Dungeon Battle ===");

        CheckEnemyHealth(50);
        CheckEnemyHealth(10);
        CheckEnemyHealth(0);
        CheckEnemyHealth(-5);
    }

    static void CheckEnemyHealth(int health)
    {
        if (health <= 0)
        {
            Console.WriteLine("Enemy is defeated!");
        }
        else
        {
            Console.WriteLine("Enemy is still alive!");
        }
    }
}
