
using System;

public enum BossPhase
{
    Phase1,
    Phase2,
    Phase3,
    Dead
}

public class Boss
{
    private int health = 100;

    private BossPhase currentPhase = BossPhase.Phase1;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health < 0)
            health = 0;

        Console.WriteLine("Boss Health: " + health);

        CheckPhase();

        if (health == 0)
        {
            currentPhase = BossPhase.Dead;
            Console.WriteLine("Boss is Dead!");
        }
    }

    private void CheckPhase()
    {
        if (health <= 30 && health > 0 &&
            currentPhase != BossPhase.Phase3)
        {
            currentPhase = BossPhase.Phase3;
            Console.WriteLine("Boss entered Phase 3: Rage Mode!");
        }
        else if (health <= 70 && health > 30 &&
                 currentPhase == BossPhase.Phase1)
        {
            currentPhase = BossPhase.Phase2;
            Console.WriteLine("Boss entered Phase 2: Aggressive Mode!");
        }
    }

    public void Attack()
    {
        switch (currentPhase)
        {
            case BossPhase.Phase1:
                Console.WriteLine("Boss performs Normal Attack!");
                break;

            case BossPhase.Phase2:
                Console.WriteLine("Boss performs Heavy Attack!");
                break;

            case BossPhase.Phase3:
                Console.WriteLine("Boss performs Rage Attack!");
                break;

            case BossPhase.Dead:
                Console.WriteLine("Boss cannot attack.");
                break;
        }
    }
}

public class Lesson09_Program
{
    public static void Main()
    {
        Boss boss = new Boss();

        boss.Attack();

        Console.WriteLine();

        boss.TakeDamage(40);
        boss.Attack();

        Console.WriteLine();

        boss.TakeDamage(40);
        boss.Attack();

        Console.WriteLine();

        boss.TakeDamage(20);
        boss.Attack();

        Console.ReadKey();
    }
}
