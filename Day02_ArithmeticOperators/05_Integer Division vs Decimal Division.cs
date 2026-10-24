
using System;

class IntegerVsDecimalDivision
{
    static void Main()
    {
        // Integer division
        int a = 10;
        int b = 3;

        int integerResult = a / b;

        Console.WriteLine("Integer Division:");
        Console.WriteLine(integerResult);

        // Decimal division
        double x = 10.0;
        double y = 3.0;

        double decimalResult = x / y;

        Console.WriteLine("Decimal Division:");
        Console.WriteLine(decimalResult);
    }
}
