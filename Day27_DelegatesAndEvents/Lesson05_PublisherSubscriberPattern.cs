

using System;

public class TreasureChest
{
    public event Action<int> OnTreasureOpened;

    public void OpenChest()
    {
        Console.WriteLine("Treasure chest opened!");

        OnTreasureOpened?.Invoke(500);
    }
}

public class GoldCollector
{
    public void CollectGold(int amount)
    {
        Console.WriteLine("Collected Gold: " + amount);
    }
}

public class AchievementSystem
{
    public void UnlockAchievement(int amount)
    {
        Console.WriteLine("Achievement Unlocked: Treasure Hunter");
    }
}

public class NotificationSystem
{
    public void ShowNotification(int amount)
    {
        Console.WriteLine("Notification: You found " + amount + " gold!");
    }
}

public class TreasureGame
{
    public static void Main()
    {
        TreasureChest chest = new TreasureChest();

        GoldCollector collector = new GoldCollector();
        AchievementSystem achievements = new AchievementSystem();
        NotificationSystem notifications = new NotificationSystem();

        chest.OnTreasureOpened += collector.CollectGold;
        chest.OnTreasureOpened += achievements.UnlockAchievement;
        chest.OnTreasureOpened += notifications.ShowNotification;

        chest.OpenChest();
    }
}
