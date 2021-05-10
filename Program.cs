using System;

namespace ConsoleApplicationCheckpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 12;
            Console.WriteLine("myInt Initial Value: " + myInt);

            myInt *= myInt;
            myInt += 14;
            myInt -= 3;
            Console.WriteLine("myInt Manipulated Value: " + myInt);
        }
    }
}
