

using System;

public class RPGCombatEnemy
{
    private string enemyName;
    private int health;
    private int stamina;
    private int attackPower;
    private bool isDefeated;

    public RPGCombatEnemy(
        string name,
        int hp,
        int stamina,
        int attackPower)
    {
        enemyName = name;
        health = hp;
        this.stamina = stamina;
        this.attackPower = attackPower;
        isDefeated = false;
    }

    public void ShowStatus()
    {
        Console.WriteLine("Enemy: " + enemyName);
        Console.WriteLine("Health: " + health);
        Console.WriteLine("Stamina: " + stamina);
    }

    public void DetectPlayer()
    {
        if (isDefeated)
            return;

        Console.WriteLine(enemyName + " detected the player!");
    }

    public void NormalAttack()
    {
        if (isDefeated)
            return;

        Console.WriteLine(
            enemyName + " deals " + attackPower + " damage!");
    }

    public void SpecialAttack()
    {
        if (isDefeated)
            return;

        if (stamina >= 30)
        {
            stamina -= 30;

            Console.WriteLine(
                enemyName + " performs Dark Flame Attack!");

            Console.WriteLine("Damage: " + (attackPower * 2));
            Console.WriteLine("Remaining Stamina: " + stamina);
        }
        else
        {
            Console.WriteLine("Not enough stamina!");
        }
    }

    public void RecoverStamina()
    {
        if (isDefeated)
            return;

        stamina += 20;

        if (stamina > 100)
            stamina = 100;

        Console.WriteLine("Stamina recovered: " + stamina);
    }

    public void ReceiveDamage(int damage)
    {
        if (isDefeated)
            return;

        health -= damage;

        if (health < 0)
            health = 0;

        Console.WriteLine(enemyName + " received damage!");
        Console.WriteLine("Remaining Health: " + health);

        if (health == 0)
        {
            DefeatEnemy();
        }
    }

    private void DefeatEnemy()
    {
        isDefeated = true;

        Console.WriteLine(enemyName + " has been defeated!");
        DropLoot();
    }

    private void DropLoot()
    {
        Console.WriteLine("Enemy dropped a Dark Soul!");
        Console.WriteLine("Loot collected successfully!");
    }
}

public class Lesson10_Program
{
    public static void Main()
    {
        RPGCombatEnemy enemy = new RPGCombatEnemy(
            "Dark Knight",
            150,
            100,
            25
        );

        enemy.ShowStatus();

        Console.WriteLine();

        enemy.DetectPlayer();

        Console.WriteLine();

        enemy.NormalAttack();

        Console.WriteLine();

        enemy.SpecialAttack();

        Console.WriteLine();

        enemy.RecoverStamina();

        Console.WriteLine();

        enemy.ReceiveDamage(70);

        Console.WriteLine();

        enemy.ReceiveDamage(80);

        Console.ReadKey();
    }
}
