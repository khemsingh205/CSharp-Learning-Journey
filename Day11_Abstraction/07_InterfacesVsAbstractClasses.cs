
using System;

namespace Day11Lesson07
{
    abstract class RPGCharacter
    {
        public string Name;

        public void ShowName()
        {
            Console.WriteLine("Character: " + Name);
        }

        public abstract void UseSpecialPower();
    }

    interface IWeaponUser
    {
        void UseWeapon();
    }

    interface IMagicUser
    {
        void CastMagic();
    }

    class DarkKnight : RPGCharacter, IWeaponUser
    {
        public DarkKnight()
        {
            Name = "Dark Knight";
        }

        public override void UseSpecialPower()
        {
            Console.WriteLine("Dark Knight activates Shadow Rage!");
        }

        public void UseWeapon()
        {
            Console.WriteLine("Dark Knight attacks with a cursed sword!");
        }
    }

    class ShadowMage : RPGCharacter, IMagicUser
    {
        public ShadowMage()
        {
            Name = "Shadow Mage";
        }

        public override void UseSpecialPower()
        {
            Console.WriteLine("Shadow Mage activates Dark Energy!");
        }

        public void CastMagic()
        {
            Console.WriteLine("Shadow Mage casts a powerful dark spell!");
        }
    }

    class ComparisonLesson07Runner
    {
        static void Main(string[] args)
        {
            DarkKnight knight = new DarkKnight();

            knight.ShowName();
            knight.UseSpecialPower();
            knight.UseWeapon();

            Console.WriteLine();

            ShadowMage mage = new ShadowMage();

            mage.ShowName();
            mage.UseSpecialPower();
            mage.CastMagic();

            Console.ReadKey();
        }
    }
}
