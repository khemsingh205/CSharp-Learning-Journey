using System;

class GameDataPrinter
{
    public void DisplayData<T>(T data)
    {
        Console.WriteLine("Game Data: " + data);
    }

    public T GetDefaultValue<T>(T value)
    {
        return value;
    }
}

class GenericMethodDemo
{
    static void Main()
    {
        GameDataPrinter printer = new GameDataPrinter();

        printer.DisplayData<string>("Dark Knight");
        printer.DisplayData<int>(2500);
        printer.DisplayData<double>(125.75);
        printer.DisplayData<bool>(true);

        string enemyName = printer.GetDefaultValue("Dragon");
        int enemyHealth = printer.GetDefaultValue(500);

        Console.WriteLine("Enemy Name: " + enemyName);
        Console.WriteLine("Enemy Health: " + enemyHealth);
    }
}