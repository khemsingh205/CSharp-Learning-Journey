
using System;

class KnightProperties
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Stamina { get; set; }

    public void ShowStatus()
    {
        Console.WriteLine("Knight: " + Name);
        Console.WriteLine("Health: " + Health);
        Console.WriteLine("Stamina: " + Stamina);
    }
}

class PropertiesLesson
{
    static void Main()
    {
        KnightProperties knight = new KnightProperties();

        knight.Name = "Dark Knight";
        knight.Health = 150;
        knight.Stamina = 80;

        Console.WriteLine("=== Before Battle ===");
        knight.ShowStatus();

        knight.Health = 100;
        knight.Stamina = 50;

        Console.WriteLine();
        Console.WriteLine("=== After Battle ===");
        knight.ShowStatus();
    }
}
