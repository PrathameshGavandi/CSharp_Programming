using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Exe1
    {
        //static void Main(string[] args)
        //{
            
        //    int input, lastdigit;
        //    Console.WriteLine("Enter a number");
        //    input = int.Parse(Console.ReadLine());

        //    lastdigit = input % 10;

        //    Console.WriteLine("last digit of input is : " + lastdigit);
        //    Console.ReadLine();

        //}

        static void main(string[] args)
        {
            int input, count = 0;
            Console.WriteLine("Enter a number");
            input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                count++;
            }

            if (count <= 1)
            {
                Console.WriteLine(input + " is prime");
            }
            else
            {
                Console.WriteLine(input + " is not prime");
            }
            Console.ReadLine();
        }
    }
}
