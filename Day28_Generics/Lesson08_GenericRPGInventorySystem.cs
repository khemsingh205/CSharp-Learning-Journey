using System;
using System.Collections.Generic;

class GenericInventory<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
        Console.WriteLine("Item Added: " + item);
    }

    public void RemoveItem(T item)
    {
        if (items.Remove(item))
        {
            Console.WriteLine("Item Removed: " + item);
        }
        else
        {
            Console.WriteLine("Item Not Found: " + item);
        }
    }

    public void DisplayItems()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("Inventory is Empty");
            return;
        }

        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }

    public int GetItemCount()
    {
        return items.Count;
    }
}

class GenericRPGInventoryProject
{
    static void Main()
    {
        GenericInventory<string> weaponInventory = new GenericInventory<string>();

        Console.WriteLine("WEAPON INVENTORY");

        weaponInventory.AddItem("Shadow Blade");
        weaponInventory.AddItem("Dragon Slayer");
        weaponInventory.AddItem("Fire Sword");

        Console.WriteLine();

        weaponInventory.DisplayItems();

        Console.WriteLine();

        weaponInventory.RemoveItem("Fire Sword");

        Console.WriteLine("Total Weapons: " + weaponInventory.GetItemCount());

        Console.WriteLine();

        GenericInventory<int> potionInventory = new GenericInventory<int>();

        Console.WriteLine("POTION INVENTORY");

        potionInventory.AddItem(5);
        potionInventory.AddItem(10);
        potionInventory.AddItem(15);

        Console.WriteLine();

        potionInventory.DisplayItems();

        Console.WriteLine("Total Potion Entries: " + potionInventory.GetItemCount());

        Console.WriteLine();

        GenericInventory<double> treasureInventory = new GenericInventory<double>();

        Console.WriteLine("TREASURE INVENTORY");

        treasureInventory.AddItem(250.50);
        treasureInventory.AddItem(500.75);

        Console.WriteLine();

        treasureInventory.DisplayItems();

        Console.WriteLine("Total Treasure Entries: " + treasureInventory.GetItemCount());
    }
}