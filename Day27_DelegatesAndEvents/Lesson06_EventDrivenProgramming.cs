
using System;

public class PressurePlate
{
    public event Action OnPlateActivated;

    public void Activate()
    {
        Console.WriteLine("Pressure plate activated!");

        OnPlateActivated?.Invoke();
    }
}

public class SecretDoor
{
    public void OpenDoor()
    {
        Console.WriteLine("Secret door opened!");
    }
}

public class TrapController
{
    public void DeactivateTrap()
    {
        Console.WriteLine("Dungeon trap deactivated!");
    }
}

public class DungeonAudio
{
    public void PlayActivationSound()
    {
        Console.WriteLine("Pressure plate sound playing!");
    }
}

public class DungeonEventSystem
{
    public static void Main()
    {
        PressurePlate plate = new PressurePlate();

        SecretDoor door = new SecretDoor();
        TrapController trap = new TrapController();
        DungeonAudio audio = new DungeonAudio();

        plate.OnPlateActivated += door.OpenDoor;
        plate.OnPlateActivated += trap.DeactivateTrap;
        plate.OnPlateActivated += audio.PlayActivationSound;

        plate.Activate();
    }
}
