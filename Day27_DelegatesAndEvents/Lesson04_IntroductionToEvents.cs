
using System;

public class Player
{
    public event Action OnPlayerAttack;

    public void Attack()
    {
        Console.WriteLine("Player attacked!");

        OnPlayerAttack?.Invoke();
    }
}

public class Game
{
    public static void PlayAttackSound()
    {
        Console.WriteLine("Attack sound playing!");
    }

    public static void CreateAttackEffect()
    {
        Console.WriteLine("Attack effect created!");
    }

    public static void Main()
    {
        Player player = new Player();

        player.OnPlayerAttack += PlayAttackSound;
        player.OnPlayerAttack += CreateAttackEffect;

        player.Attack();
    }
}
