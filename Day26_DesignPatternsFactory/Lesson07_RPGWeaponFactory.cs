using System;

namespace Day26.Lesson07
{
    public enum WeaponType
    {
        Sword,
        Bow,
        Staff
    }

    public interface IWeapon
    {
        string Name { get; }
        int Damage { get; }
        string Attack(string target);
    }

    public class Sword : IWeapon
    {
        public string Name { get { return "Iron Sword"; } }
        public int Damage { get { return 25; } }

        public string Attack(string target)
        {
            return Name + " ne " + target + " par vaar kiya! (-" + Damage + " HP)";
        }
    }

    public class Bow : IWeapon
    {
        public string Name { get { return "Hunter Bow"; } }
        public int Damage { get { return 18; } }

        public string Attack(string target)
        {
            return Name + " se teer " + target + " ko laga! (-" + Damage + " HP)";
        }
    }

    public class Staff : IWeapon
    {
        public string Name { get { return "Magic Staff"; } }
        public int Damage { get { return 35; } }

        public string Attack(string target)
        {
            return Name + " se jadoo chala " + target + " par! (-" + Damage + " HP)";
        }
    }

    public static class WeaponFactory
    {
        public static IWeapon Create(WeaponType type)
        {
            switch (type)
            {
                case WeaponType.Sword:
                    return new Sword();
                case WeaponType.Bow:
                    return new Bow();
                case WeaponType.Staff:
                    return new Staff();
                default:
                    throw new ArgumentOutOfRangeException("type", "Unknown weapon type");
            }
        }
    }

    public class Player
    {
        public string Name { get; private set; }
        private IWeapon _weapon;

        public Player(string name, IWeapon weapon)
        {
            Name = name;
            _weapon = weapon;
        }

        public void Equip(IWeapon weapon)
        {
            _weapon = weapon;
            Console.WriteLine("  " + Name + " ne " + weapon.Name + " equip kiya");
        }

        public void Attack(string target)
        {
            Console.WriteLine("  " + _weapon.Attack(target));
        }
    }

    public static class Lesson07_RPGWeaponFactory
    {
        public static void Run()
        {
            Console.WriteLine("=== Lesson 07: RPG Weapon Factory ===\n");

            Console.WriteLine("Saare weapons ki list:");
            foreach (WeaponType type in Enum.GetValues(typeof(WeaponType)))
            {
                IWeapon w = WeaponFactory.Create(type);
                Console.WriteLine("  " + type + " -> " + w.Name + " | Damage: " + w.Damage);
            }

            Console.WriteLine("\nPlayer ka battle:");
            Player hero = new Player("Arjun", WeaponFactory.Create(WeaponType.Sword));
            hero.Attack("Goblin");

            hero.Equip(WeaponFactory.Create(WeaponType.Bow));
            hero.Attack("Goblin");

            hero.Equip(WeaponFactory.Create(WeaponType.Staff));
            hero.Attack("Goblin");
        }
    }
}