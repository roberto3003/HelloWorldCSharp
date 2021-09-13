using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");
            int count = 10;
            float totalPrice = 20.95F;
            char character = 'A';
            string firstName = "Roberto";
            bool isWorking = true;
            Console.WriteLine(isWorking);
            Console.WriteLine(firstName);   
            Console.WriteLine(character);
            byte number = 2;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            int i = 1;
            byte b = (byte)i;
            Console.WriteLine(i);
            var number2 = "1234";
            byte d = Convert.ToByte(number2);
        }

    }
}
