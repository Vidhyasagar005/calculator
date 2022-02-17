using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int res;
            Console.Write("Enter the  first number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the symbole(/,*,+,-)");
            string symbole = Console.ReadLine();
            switch(symbole)
            {
                case "+":
                    res = num + num2;
                    Console.WriteLine("Addition" + res);
                    break;
                case "-":
                    res = num - num2;
                    Console.WriteLine("Subtraction" + res);
                    break;
                case "*":
                    res = num * num2;
                    Console.WriteLine("Multiplication" + res);
                    break;
                case "/":
                    res = num / num2;
                    Console.WriteLine("Division" + res);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;

            }
            Console.ReadLine();

        }
    }
}
