using System;
class Character
{
    public string name;
    public int health;
    public int damage;

    public void ShowStats()
    {
        Console.WriteLine("Character: " + name);
        Console.WriteLine("Health: " + health);
        Console.WriteLine("Damage: " + damage);
    }
}


class Knight : Character
{

}


class Lesson01_Inheritance
{
    static void Main(string[] args)
    {
        Knight knight = new Knight();
        knight.name = "Ancient Knight";
        knight.health = 500;
        knight.damage = 75;

        knight.ShowStats();

        Console.ReadLine();
    }
}