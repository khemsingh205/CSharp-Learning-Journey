
using System;

public class Lesson01_IntroductionToDelegates
{
    
    public delegate void GameAction();

    
    public static void PlayAttackSound()
    {
        Console.WriteLine("Attack sound playing...");
    }

    public static void CreateAttackEffect()
    {
        Console.WriteLine("Attack effect created...");
    }

    public static void Main()
    {
        
        GameAction attack = PlayAttackSound;

        
        attack();

        
        attack = CreateAttackEffect;

        attack();
    }
}
