
using System;

public class CombatEngine
{
    public event Action<string, int> OnDamageDealt;
    public event Action<string> OnCriticalHit;
    public event Action<string> OnEnemyDefeated;

    public void Attack(string enemyName, int damage, bool isCritical)
    {
        Console.WriteLine("Attacking " + enemyName);

        if (isCritical)
        {
            OnCriticalHit?.Invoke(enemyName);
            damage *= 2;
        }

        OnDamageDealt?.Invoke(enemyName, damage);

        if (damage >= 100)
        {
            OnEnemyDefeated?.Invoke(enemyName);
        }
    }
}

public class CombatLogger
{
    public void DisplayDamage(string enemyName, int damage)
    {
        Console.WriteLine(enemyName + " received " + damage + " damage!");
    }

    public void DisplayCriticalHit(string enemyName)
    {
        Console.WriteLine("Critical hit against " + enemyName + "!");
    }

    public void DisplayDefeat(string enemyName)
    {
        Console.WriteLine(enemyName + " has been defeated!");
    }
}

public class CombatRewards
{
    public void GiveReward(string enemyName)
    {
        Console.WriteLine("Reward unlocked for defeating " + enemyName);
    }
}

public class RPGCombatDemo
{
    public static void Main()
    {
        CombatEngine combat = new CombatEngine();

        CombatLogger logger = new CombatLogger();
        CombatRewards rewards = new CombatRewards();

        combat.OnDamageDealt += logger.DisplayDamage;
        combat.OnCriticalHit += logger.DisplayCriticalHit;
        combat.OnEnemyDefeated += logger.DisplayDefeat;
        combat.OnEnemyDefeated += rewards.GiveReward;

        combat.Attack("Dark Knight", 60, true);
    }
}
