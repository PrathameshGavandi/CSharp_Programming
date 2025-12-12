using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Ex2Swap
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
           // Console.WriteLine("A is : " + a, "B is : " + b);


            a = a + b;//30
            b = a - b;//10
            a = a - b;

            Console.WriteLine("A is : " + a ) ;
            Console.WriteLine("B is : " + b ) ;






            Console.ReadLine();
           
        }
    }
}
