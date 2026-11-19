using System;

interface IDataManager<T>
{
    void SaveData(T data);
    T LoadData();
}

class WeaponDataManager : IDataManager<string>
{
    private string weapon;

    public void SaveData(string data)
    {
        weapon = data;
        Console.WriteLine("Weapon Data Saved");
    }

    public string LoadData()
    {
        return weapon;
    }
}

class GoldDataManager : IDataManager<int>
{
    private int gold;

    public void SaveData(int data)
    {
        gold = data;
        Console.WriteLine("Gold Data Saved");
    }

    public int LoadData()
    {
        return gold;
    }
}

class GenericInterfaceDemo
{
    static void Main()
    {
        WeaponDataManager weaponManager = new WeaponDataManager();

        weaponManager.SaveData("Legendary Sword");
        Console.WriteLine("Loaded Weapon: " + weaponManager.LoadData());

        Console.WriteLine();

        GoldDataManager goldManager = new GoldDataManager();

        goldManager.SaveData(5000);
        Console.WriteLine("Loaded Gold: " + goldManager.LoadData());
    }
}