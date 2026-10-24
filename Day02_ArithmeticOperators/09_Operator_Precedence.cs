
using System;

class OperatorPrecedence
{
    static void Main()
    {
        // Multiplication happens before addition
        int result1 = 10 + 5 * 2;

        // Parentheses change the calculation order
        int result2 = (10 + 5) * 2;

        // Division happens before addition
        int result3 = 20 + 12 / 3;

        // Modulus happens before addition
        int result4 = 10 + 7 % 3;

        Console.WriteLine("Result 1: " + result1);
        Console.WriteLine("Result 2: " + result2);
        Console.WriteLine("Result 3: " + result3);
        Console.WriteLine("Result 4: " + result4);
    }
}
