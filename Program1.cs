using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice :");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Any Two NO: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c;
            switch(choice)
            {
                case 1:
                    c = a + b;
                    Console.WriteLine("sum ="  +c);
                    break;
                case 2:
                    c = a - b;
                    Console.WriteLine("sub =" +c);
                    break;
                case 3:
                    c = a * b;
                    Console.WriteLine("MUL =" +c);
                    break;
                case 4:
                    c = a / b;
                    Console.WriteLine("div =" +c);
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }


        }

    }
}
