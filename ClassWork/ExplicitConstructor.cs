using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

    //Explicit / parametrized Constructor
    internal class ExplicitConstructor
    {
        public ExplicitConstructor(int a, int b)
        {
            Console.WriteLine( "Explicit constructor calling addition is : " + (a+b));
        }
        static void Main(string[] args)
        {
            int c, d;
            Console.WriteLine("Enter first Number");
            c=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            d=int.Parse(Console.ReadLine());
            ExplicitConstructor obj = new ExplicitConstructor(c,d);
        }
    }
}
