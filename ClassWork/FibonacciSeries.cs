using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

    // write a program to print fibonacci series 0 to n number
    class FibonacciSeries
    {

        //static void Main(string[] args)
        //{

        //    int input = 25, op = 0, randomcount = 0, firstnumber = 0, secondnumber = 1;

        //    for (int i = 2; i <= input; i++)
        //    {
        //        while (randomcount <= 15)
        //        {
        //            op = firstnumber + secondnumber;   //1,1
        //            Console.WriteLine(firstnumber);
        //            firstnumber = secondnumber;

        //            secondnumber = op;
        //            randomcount++;
        //        }

        //    }
        //    Console.ReadLine();
        //}



        static void Main(string[] args)
        {
            int inputn=20 ,next, firstnumber = 0,secondnumber = 1;

            for(int i = 2; i <= inputn; i++)
            {
                next = firstnumber + secondnumber;

                Console.WriteLine(firstnumber);

                firstnumber = secondnumber;
                secondnumber = next;

            }
            Console.ReadLine();
        }




    }
}
