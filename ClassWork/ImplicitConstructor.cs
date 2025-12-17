using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class ImplicitConstructor
    {
        int a;
        bool b;

       
        class Program12
        {
            static void Main(string[] args)
            {
                ImplicitConstructor obj = new ImplicitConstructor();
                Console.WriteLine("Value of a is : "+ (obj. a));
                Console.WriteLine("Value of b is : " + (obj.b));

            }
        }
        
       
        


    }
}
