using System;

namespace Day19_Lesson04_MultipleTypeParameters
{
    class Pair<TKey, TValue>
    {
        public TKey Key;
        public TValue Value;

        public Pair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public void Show()
        {
            Console.WriteLine(Key + " : " + Value);
        }
    }

    class Lesson04Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Pair");

            Pair<string, int> price = new Pair<string, int>("Iron Sword", 150);
            price.Show();

            Pair<string, double> weight = new Pair<string, double>("Shadow Blade", 3.5);
            weight.Show();

            Pair<int, string> slot = new Pair<int, string>(1, "Health Potion");
            slot.Show();
        }
    }
}