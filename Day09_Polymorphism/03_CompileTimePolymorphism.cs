
using System;

class CompileTimePlayer
{
     public void Attack(int damage)
    {
        Console.WriteLine("Normal Attack!");
        Console.WriteLine("Damage: " + damage);
    }


    public void Attack(int damage, int stamina)
    {
        Console.WriteLine("Heavy Attack!");
        Console.WriteLine("Damage: " + damage);
        Console.WriteLine("Stamina Used: " + stamina);
    }

    public void Attack(int damage, int stamina, int magic)
    {
        Console.WriteLine("Special Magic Attack!");
        Console.WriteLine("Damage: " + damage);
        Console.WriteLine("Stamina Used: " + stamina);
        Console.WriteLine("Magic Used: " + magic);
    }
}

class Day09Lesson03
{
    static void Main()
    {
        Console.WriteLine("=== DARK FANTASY COMBAT ===");
        Console.WriteLine();

        CompileTimePlayer player = new CompileTimePlayer();


        player.Attack(20);

        Console.WriteLine();


        player.Attack(50, 15);

        Console.WriteLine();


        player.Attack(100, 30, 25);

        Console.WriteLine();
        Console.WriteLine("Combat Finished!");

        Console.ReadKey();
    }
}
