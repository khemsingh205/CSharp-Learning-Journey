
using System;

class AncientGuardian
{
    private int secretHealth = 150;

    public int swordPower = 60;

    public void PerformSwordStrike()
    {
        Console.WriteLine("Ancient Guardian attacks!");
        Console.WriteLine("Sword Damage: " + swordPower);
    }

    public void RevealVitality()
    {
        Console.WriteLine("Guardian Health: " + secretHealth);
    }

    public void ReceiveEnemyStrike(int incomingDamage)
    {
        secretHealth = secretHealth - incomingDamage;

        if (secretHealth < 0)
        {
            secretHealth = 0;
        }

        Console.WriteLine("Guardian received enemy damage!");
    }
}

class Day10Lesson03Runner
{
    static void Main()
    {
        AncientGuardian guardianUnit = new AncientGuardian();

        Console.WriteLine("=== ANCIENT DUNGEON BATTLE ===");

        guardianUnit.RevealVitality();

        guardianUnit.PerformSwordStrike();

        guardianUnit.ReceiveEnemyStrike(45);

        guardianUnit.RevealVitality();

        Console.WriteLine("Public Sword Power: " + guardianUnit.swordPower);

        Console.ReadLine();
    }
}
