
using System;

class ModulusOperator
{
    static void Main()
    {
        int a = 10;
        int b = 3;

        // Calculate the remainder
        Console.WriteLine("10 % 3 = " + (a % b));
        Console.WriteLine("10 % 2 = " + (a % 2));
        Console.WriteLine("15 % 5 = " + (15 % 5));

        // Game example: Check every second hit
        int hitCount = 6;

        Console.WriteLine("Hit count: " + hitCount);
        Console.WriteLine("Remainder after dividing by 2: " + (hitCount % 2));
    }
}
