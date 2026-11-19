using System;

class CharacterProfile<T> where T : class
{
    public T Character;

    public void SetCharacter(T character)
    {
        Character = character;
    }

    public void DisplayCharacter()
    {
        Console.WriteLine("Character: " + Character);
    }
}

class GenericConstraintsDemo
{
    static void Main()
    {
        CharacterProfile<string> enemyProfile = new CharacterProfile<string>();

        enemyProfile.SetCharacter("Dark Knight");
        enemyProfile.DisplayCharacter();

        CharacterProfile<object> bossProfile = new CharacterProfile<object>();

        bossProfile.SetCharacter("Ancient Dragon");
        bossProfile.DisplayCharacter();
    }
}