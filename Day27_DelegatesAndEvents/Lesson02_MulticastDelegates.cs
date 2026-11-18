
using System;

public class Lesson02_MulticastDelegates
{
    public delegate void GameAction();

    public static void PlayAttackSound()
    {
        Console.WriteLine("Attack sound playing!");
    }

    public static void CreateAttackEffect()
    {
        Console.WriteLine("Attack effect created!");
    }

    public static void UpdateCombatStats()
    {
        Console.WriteLine("Combat stats updated!");
    }

    public static void Main()
    {
        GameAction attackActions = PlayAttackSound;

        attackActions += CreateAttackEffect;
        attackActions += UpdateCombatStats;

        attackActions();
    }
}
