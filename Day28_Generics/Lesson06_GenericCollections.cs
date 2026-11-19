using System;
using System.Collections.Generic;

class RPGInventoryManager
{
    static void Main()
    {
        List<string> inventory = new List<string>();

        inventory.Add("Fire Sword");
        inventory.Add("Health Potion");
        inventory.Add("Shadow Shield");

        Console.WriteLine("Player Inventory:");

        foreach (string item in inventory)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        Dictionary<string, int> playerGold = new Dictionary<string, int>();

        playerGold.Add("Warrior", 1500);
        playerGold.Add("Mage", 2500);

        Console.WriteLine("Player Gold:");

        foreach (var player in playerGold)
        {
            Console.WriteLine(player.Key + ": " + player.Value);
        }

        Console.WriteLine();

        Queue<string> enemyQueue = new Queue<string>();

        enemyQueue.Enqueue("Skeleton");
        enemyQueue.Enqueue("Dark Knight");
        enemyQueue.Enqueue("Dragon");

        Console.WriteLine("Next Enemy: " + enemyQueue.Dequeue());

        Console.WriteLine();

        Stack<string> weaponHistory = new Stack<string>();

        weaponHistory.Push("Iron Sword");
        weaponHistory.Push("Fire Sword");
        weaponHistory.Push("Shadow Blade");

        Console.WriteLine("Latest Weapon: " + weaponHistory.Pop());
    }
}