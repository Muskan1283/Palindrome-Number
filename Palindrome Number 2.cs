using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("Enter the number:");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("Number is Palindrome.");
            else
                Console.WriteLine("Number is not palindrome:");

        }
    }
}
