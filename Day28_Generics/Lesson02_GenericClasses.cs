using System;

class InventoryContainer<T>
{
    private T item;

    public void AddItem(T newItem)
    {
        item = newItem;
        Console.WriteLine("Item Added Successfully");
    }

    public T GetItem()
    {
        return item;
    }

    public void DisplayItem()
    {
        Console.WriteLine("Inventory Item: " + item);
    }
}

class GenericClassDemo
{
    static void Main()
    {
        InventoryContainer<string> weaponInventory = new InventoryContainer<string>();
        weaponInventory.AddItem("Shadow Sword");
        weaponInventory.DisplayItem();

        InventoryContainer<int> goldInventory = new InventoryContainer<int>();
        goldInventory.AddItem(1500);
        goldInventory.DisplayItem();

        InventoryContainer<double> potionInventory = new InventoryContainer<double>();
        potionInventory.AddItem(75.5);
        potionInventory.DisplayItem();

        string weapon = weaponInventory.GetItem();
        Console.WriteLine("Retrieved Weapon: " + weapon);
    }
}