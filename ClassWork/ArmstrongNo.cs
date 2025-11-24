using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class ArmstrongNo
    {

        static void Main(string[] args)
        {
            int input=153,  rem, temp, sum = 0;

            temp = input;

            while(input>0)
            {

                rem = input % 10;
                sum = sum + (rem * rem * rem);
                input = input / 10;

            }
            if(sum==temp)
            {
                Console.WriteLine(temp +  " Number is armstrong");
            }
            else
            {
                Console.WriteLine(temp + " Number is not armstrong");
            }
            
            Console.ReadLine();
        }
        
    }
}
