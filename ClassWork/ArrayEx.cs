using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class ArrayEx
    {
        // write a function to find sum of array element
        //public void Arraysum()
        //{
        //    int[] arr = { 5, 5, 5, 5, 5 };

        //    int sum = 0;

        //    for (int i = 0; i <= arr.Length - 1; i++)
        //    {
        //        sum = sum + arr[i];

        //    }
        //    Console.WriteLine("The sum of an array element is : " + sum);
        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    ArrayEx obj = new ArrayEx();
        //    obj.Arraysum();
        //}





        // write a function to find index of greatest value element in an array


        //int MaxValueIndex(out int maxValue)
        //{
        //    int[] arr = { 25, 75, 80, 15, 27 };
        //    int maxIndex = 0;
        //    maxValue = arr[0]; 

        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] > maxValue)
        //        {
        //            maxValue = arr[i];
        //            maxIndex = i;
        //        }
        //    }
        //    return maxIndex;
        //}

        //static void Main(string[] args)
        //{
        //    ArrayEx obj = new ArrayEx();
        //    int maxValue;
        //    int maxIndex = obj.MaxValueIndex(out maxValue); 

        //    Console.WriteLine("Greatest Value: " + maxValue);
        //    Console.WriteLine("Index of Greatest Value: " + maxIndex);
        //    Console.ReadLine();
        //}





        // write a function to rotate an array elements by one position towords right
        //public void ArrayRotate()
        //{
        //    int[] arr = { 25, 75, 80, 15, 27 };

        //    int i,temp;

        //    temp = arr[arr.Length - 1];


        //    for ( i = arr.Length-2; i >= 0; i--)
        //    {
        //        arr[i + 1] = arr[i];
        //        arr[0] = temp;
        //    }
        //    for(i=0;i<=4;i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //        Console.WriteLine(" ");

        //    }

        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    ArrayEx obj = new ArrayEx();
        //    obj.ArrayRotate();
        //}



        public void ArrayRotate()
        {
            int[] arr = { 25, 75, 80, 15, 27 };
            int access = arr[4];

            Console.WriteLine("Access : " + access);
        }

        static void Main(string[] args)
        {
            ArrayEx obj = new ArrayEx();
            obj.ArrayRotate();
            Console.ReadLine();
        }




    }

}

