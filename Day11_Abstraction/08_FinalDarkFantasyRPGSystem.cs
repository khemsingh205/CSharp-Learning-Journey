
using System;

namespace Day11Lesson08
{
    interface ICombat
    {
        void Attack();
    }

    interface IMagicUser
    {
        void CastMagic();
    }

    abstract class RPGCharacter
    {
        public abstract string CharacterName { get; set; }

        public abstract int Health { get; set; }

        public void ShowStatus()
        {
            Console.WriteLine("Character: " + CharacterName);
            Console.WriteLine("Health: " + Health);
        }

        public abstract void UseSpecialAbility();
    }

    class DarkKnight : RPGCharacter, ICombat
    {
        public override string CharacterName { get; set; }

        public override int Health { get; set; }

        public DarkKnight()
        {
            CharacterName = "Dark Knight";
            Health = 150;
        }

        public void Attack()
        {
            Console.WriteLine("Dark Knight attacks with a cursed sword!");
            Console.WriteLine("Enemy takes 50 damage!");
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("Dark Knight activates Shadow Rage!");
        }
    }

    class ShadowMage : RPGCharacter, ICombat, IMagicUser
    {
        public override string CharacterName { get; set; }

        public override int Health { get; set; }

        public ShadowMage()
        {
            CharacterName = "Shadow Mage";
            Health = 100;
        }

        public void Attack()
        {
            Console.WriteLine("Shadow Mage attacks with a magic staff!");
            Console.WriteLine("Enemy takes 30 damage!");
        }

        public void CastMagic()
        {
            Console.WriteLine("Shadow Mage casts Dark Fire!");
            Console.WriteLine("Enemy takes 70 magic damage!");
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("Shadow Mage activates Dark Energy!");
        }
    }

    class FinalRPGSystemLesson08Runner
    {
        static void Main(string[] args)
        {
            DarkKnight knight = new DarkKnight();

            Console.WriteLine("=== DARK KNIGHT ===");

            knight.ShowStatus();
            knight.Attack();
            knight.UseSpecialAbility();

            Console.WriteLine();

            ShadowMage mage = new ShadowMage();

            Console.WriteLine("=== SHADOW MAGE ===");

            mage.ShowStatus();
            mage.Attack();
            mage.CastMagic();
            mage.UseSpecialAbility();

            Console.ReadKey();
        }
    }
}
