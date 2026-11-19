using System;

class RPGItem<TName, TPrice, TWeight>
{
    public TName Name;
    public TPrice Price;
    public TWeight Weight;

    public void DisplayItem()
    {
        Console.WriteLine("Item Name: " + Name);
        Console.WriteLine("Item Price: " + Price);
        Console.WriteLine("Item Weight: " + Weight);
    }
}

class MultipleTypeParametersDemo
{
    static void Main()
    {
        RPGItem<string, int, double> sword = new RPGItem<string, int, double>();

        sword.Name = "Dragon Slayer";
        sword.Price = 5000;
        sword.Weight = 12.5;

        sword.DisplayItem();

        Console.WriteLine();

        RPGItem<string, double, int> potion = new RPGItem<string, double, int>();

        potion.Name = "Health Potion";
        potion.Price = 99.50;
        potion.Weight = 2;

        potion.DisplayItem();
    }
}