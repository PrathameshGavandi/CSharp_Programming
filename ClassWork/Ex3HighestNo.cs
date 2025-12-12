using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Ex3HighestNo
    {
       static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter first numbers");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second numbers");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third numbers");
            c = int.Parse(Console.ReadLine());


            if(a>b)
            {
                if(a>c)
                {
                    Console.WriteLine("The gretest number was : " + a);

                }
            }
            if(b>a)
            {
                if (b>c)
                {
                    Console.WriteLine("The gretest number was : " + b);
                }
                else
                {
                    Console.WriteLine("The gretest number was : " + c);
                }
            }
            //if (c>a)
            //{
            //    if (c>b)
            //    {
            //        Console.WriteLine(c);
            //    }
            //}

            Console.ReadLine();

        }
              
        
    }
}
