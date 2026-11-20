using System;
using System.Collections.Generic;
using System.Linq;

class DungeonCharacter
{
    public string Name { get; set; }
    public int Level { get; set; }
}

class LINQElementDemo
{
    static void Main()
    {
        List<DungeonCharacter> characters = new List<DungeonCharacter>()
        {
            new DungeonCharacter { Name = "Knight", Level = 10 },
            new DungeonCharacter { Name = "Mage", Level = 20 },
            new DungeonCharacter { Name = "Archer", Level = 30 },
            new DungeonCharacter { Name = "Paladin", Level = 20 }
        };

        var firstCharacter = characters.FirstOrDefault();

        Console.WriteLine("First Character:");
        Console.WriteLine(firstCharacter.Name);

        var firstLevel20 = characters.FirstOrDefault(character => character.Level == 20);

        Console.WriteLine("\nFirst Level 20 Character:");
        Console.WriteLine(firstLevel20.Name);

        var uniqueLevel10 = characters.SingleOrDefault(character => character.Level == 10);

        Console.WriteLine("\nUnique Level 10 Character:");
        Console.WriteLine(uniqueLevel10.Name);

        var missingCharacter = characters.FirstOrDefault(character => character.Level == 100);

        Console.WriteLine("\nMissing Character:");

        if (missingCharacter == null)
        {
            Console.WriteLine("Character Not Found");
        }
    }
}