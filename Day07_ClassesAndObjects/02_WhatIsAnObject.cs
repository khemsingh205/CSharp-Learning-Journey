

using System;

class DungeonCharacter
{
    public string characterName;
}

class ObjectLesson
{
    static void Main()
    {
        DungeonCharacter knight = new DungeonCharacter();
        DungeonCharacter skeleton = new DungeonCharacter();

        knight.characterName = "Dark Knight";
        skeleton.characterName = "Skeleton Warrior";

        Console.WriteLine("=== Dark Fantasy Dungeon ===");

        Console.WriteLine("First object: " + knight.characterName);
        Console.WriteLine("Second object: " + skeleton.characterName);
    }
}
