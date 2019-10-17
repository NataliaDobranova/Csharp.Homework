using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 5
            Console.WriteLine("Task 5");
            Console.WriteLine("Enter your number:");
            string N = Console.ReadLine();
            int a = Convert.ToInt32(N);
            int b = 0;
            while (a > 0)
            {
                b = 10 * b + a % 10;
                a /= 10;
            }
            Console.WriteLine(b);

            // Task 1
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter symbols: ");
            char symbol;
            int count = 0;
            do
            {
                symbol = Console.ReadKey().KeyChar;
                if (symbol == ' ')
                    count++;
            }
            while (symbol != '.');

            Console.WriteLine("Quantity of spaces: " + count);

            // Task 2
            Console.WriteLine("Task 2");
            Console.WriteLine("Enter the number of your ticket: ");
            string s = Console.ReadLine();
            int lengh = s.Length;
            if (lengh == 6)
            {
                int n1 = (int)s[0] + (int)s[1] + (int)s[2];
                int n2 = (int)s[3] + (int)s[4] + (int)s[5];
                if (n1 == n2)
                    Console.WriteLine("Your ticket is lucky");
                else
                    Console.WriteLine("Your ticket isn't lucky");
            }
            else
                Console.WriteLine("The ticket number is wrong");


            // Task 3
            Console.WriteLine("Task 3");
            char m = ' ';
            Console.WriteLine("Enter your symbols:");
            while (m != '.')
            {
                var n = Console.Read();
                if (n >= 65 && n <= 90)
                    n += 32;
                else if (n >= 97 && n <= 122)
                    n -= 32;
                m = Convert.ToChar(n);
                Console.Write(m);

            }
            Console.WriteLine();

            // Task 4

            Console.WriteLine("Task 4");
            int A = 2;
            int B = 5;
            for (int i = A; i <= B; i++)
                { for (int j=0; j <i; j++)
                    {
                      Console.Write(i + " ");
                    }
             Console.WriteLine();
            }
           

           
        }
    }
}
