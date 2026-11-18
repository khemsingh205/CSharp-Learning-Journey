
using System;

public class Lesson03_ActionDelegate
{
    public static void PlayerAttack()
    {
        Console.WriteLine("Player is attacking!");
    }

    public static void PlayAttackSound()
    {
        Console.WriteLine("Attack sound playing!");
    }

    public static void Main()
    {
        Action attackAction = PlayerAttack;

        attackAction();

        Action soundAction = PlayAttackSound;

        soundAction();
    }
}
