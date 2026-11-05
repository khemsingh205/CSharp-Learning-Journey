using System;

namespace Day14_Lesson08_StructVsClass
{
    public struct PositionStruct
    {
        public int X;
    }

    public class PositionClass
    {
        public int X;
    }

    public class Lesson08Runner
    {
        static void Main()
        {
            PositionStruct s1 = new PositionStruct();
            s1.X = 5;
            PositionStruct s2 = s1;
            s2.X = 99;
            Console.WriteLine("Struct: s1.X = " + s1.X + ", s2.X = " + s2.X);

            PositionClass c1 = new PositionClass();
            c1.X = 5;
            PositionClass c2 = c1;
            c2.X = 99;
            Console.WriteLine("Class: c1.X = " + c1.X + ", c2.X = " + c2.X);

            Console.ReadLine();
        }
    }
}