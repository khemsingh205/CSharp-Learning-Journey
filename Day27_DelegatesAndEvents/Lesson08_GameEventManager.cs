
using System;

public static class GameEventManager
{
    public static event Action<int> OnPlayerHealthChanged;
    public static event Action<string> OnEnemyDefeated;
    public static event Action<int> OnGoldCollected;

    public static void UpdateHealth(int health)
    {
        OnPlayerHealthChanged?.Invoke(health);
    }

    public static void DefeatEnemy(string enemyName)
    {
        OnEnemyDefeated?.Invoke(enemyName);
    }

    public static void CollectGold(int amount)
    {
        OnGoldCollected?.Invoke(amount);
    }
}

public class HealthSystem
{
    public void UpdateHealthUI(int health)
    {
        Console.WriteLine("Player Health: " + health);
    }
}

public class QuestSystem
{
    public void CompleteEnemyQuest(string enemyName)
    {
        Console.WriteLine("Quest Updated: " + enemyName + " defeated!");
    }
}

public class InventorySystem
{
    private int totalGold;

    public void AddGold(int amount)
    {
        totalGold += amount;

        Console.WriteLine("Gold Added: " + amount);
        Console.WriteLine("Total Gold: " + totalGold);
    }
}

public class RPGGameDemo
{
    public static void Main()
    {
        HealthSystem health = new HealthSystem();
        QuestSystem quests = new QuestSystem();
        InventorySystem inventory = new InventorySystem();

        GameEventManager.OnPlayerHealthChanged += health.UpdateHealthUI;
        GameEventManager.OnEnemyDefeated += quests.CompleteEnemyQuest;
        GameEventManager.OnGoldCollected += inventory.AddGold;

        GameEventManager.UpdateHealth(75);
        GameEventManager.DefeatEnemy("Dark Knight");
        GameEventManager.CollectGold(250);
        GameEventManager.CollectGold(100);

        GameEventManager.OnPlayerHealthChanged -= health.UpdateHealthUI;
        GameEventManager.OnEnemyDefeated -= quests.CompleteEnemyQuest;
        GameEventManager.OnGoldCollected -= inventory.AddGold;
    }
}
