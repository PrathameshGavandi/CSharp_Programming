using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Firstlargest
    {
        static void Main(string[] args)
        {
            int[] arr = { 35, 42, 38, 76, 68, 22, 67 };

            int max1 = arr[0];
            int max2 = arr[0];


            for (int i = 0; i < arr.Length; i++)
            {


                if (arr[i] > max1)//
                {


                    max1 = arr[i];
                }
                if (max2 > arr[i] && arr[i] < max1)
                {
                    max2 = arr[i];
                }



            }
            Console.WriteLine("The gretest number is : " + max1);
            Console.WriteLine("The second gretest number is : " + max2);

            for (int i = 0; i < arr.Length; i++)//(arr[i] < )
            {
                if (arr[i] < max1)
                {
                    if (max1 >= max2)
                    {
                        max2 = arr[i];
                    }
                }
            }


            Console.ReadLine();
        }


        //static void Main(string[] args)
        //{
        //string input = "heyy";
        //string reversed = "";

        //for (int i = input.Length - 1; i >= 0; i--)
        //{
        //    reversed += input[i];
        //}
        //Console.WriteLine(reversed);


        //    int input = 123;
        //    int temp = input;
        //    int rem,sum=0;

        //    while(input>0)
        //    {
        //        rem = input % 10;
        //        sum = sum *10+rem;
        //        input = input / 10;

        //    }
        //    Console.WriteLine(sum);
        //    Console.ReadLine();
        //}


    }
    
}
