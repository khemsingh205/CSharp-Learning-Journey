using System;

class GenericStorage<T>
{
    public T Value;

    public void Store(T value)
    {
        Value = value;
    }

    public void Display()
    {
        Console.WriteLine("Stored Value: " + Value);
    }
}

class GenericsIntroductionDemo
{
    static void Main()
    {
        GenericStorage<int> goldStorage = new GenericStorage<int>();
        goldStorage.Store(500);
        goldStorage.Display();

        GenericStorage<string> itemStorage = new GenericStorage<string>();
        itemStorage.Store("Legendary Sword");
        itemStorage.Display();

        GenericStorage<double> damageStorage = new GenericStorage<double>();
        damageStorage.Store(125.75);
        damageStorage.Display();
    }
}