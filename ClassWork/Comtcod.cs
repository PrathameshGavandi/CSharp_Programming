using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Comtcod
    {

        //program for finding max takes something returns nothing
        //static  void maxoffour(int a,int b, int c,int d)
        //{
        //    if(a>b && a > c && a>d)
        //    {
        //        Console.WriteLine(a);

        //    }
        //    if (b > a && b > c && b > d)
        //    {

        //        Console.WriteLine(b);
        //    }
        //    if (c > a && c > b && c > d)
        //    {

        //        Console.WriteLine(c);
        //    }
        //    if (d > a && d > b && d > c)
        //    {

        //        Console.WriteLine(d);
        //    }


        //}

        //static void Main(string[] args)
        //{
        //    int a, b, c, d;

        //    Console.WriteLine("Enter first number");
        //    a = int.Parse(Console.ReadLine());



        //    Console.WriteLine("Enter second number");
        //    b = int.Parse(Console.ReadLine());


        //    Console.WriteLine("Enter third number");
        //    c = int.Parse(Console.ReadLine());


        //    Console.WriteLine("Enter fourth number");
        //    d = int.Parse(Console.ReadLine());


        //    Comtcod.maxoffour(a, b, c, d);
        //    //Console.WriteLine(maxoffour);

        //    Console.ReadLine();

        //}


        //write a function to check wheather a given number is prime or not(Take Something Returns Something)

        //public static bool prime(int input)
        //{

        //    for(int i = 2; i < input; i++)
        //    {
        //        if(input%i==0)
        //        {
        //            return false;
        //        }

        //    }
        //    return true;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter a number");
        //    int input = int.Parse(Console.ReadLine());
        //    if (prime(input))
        //    {
        //        Console.WriteLine("prime number ");
        //    }
        //    else
        //    {
        //        Console.WriteLine("not prime number");
        //    }
        //    Console.ReadLine();
        //}



        // write a function to print all prime numbers from a to b, where values of a and b are taken as an arguments


        //public static bool prime(int input)
        //{

        //    for (int i = 2; i < input; i++)
        //    {
        //        if (input % i == 0)
        //        {
        //            return false;
        //        }

        //    }
        //    return true;
        //}

        //void printprime(int a, int b)
        //{
        //    int x; 
        //    for (x = a;  x <= b;x++)
        //    {


        //        if (prime(x))
        //        {
        //            Console.WriteLine(x);
        //        }
        //    }

        //}

        //static void Main(string[] args)
        //{


        //    Console.WriteLine("Enter first number");
        //    int a = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Enter second number");
        //    int b = int.Parse(Console.ReadLine());


        //        Comtcod obj = new Comtcod();

        //    obj.printprime(a, b);
        //    Console.ReadLine();
        //}



        //write a function to find next prime number of a given number


        //public static bool prime(int input)
        //{

        //    for (int i = 2; i < input; i++)
        //    {
        //        if (input % i == 0)
        //        {
        //            return false;
        //        }

        //    }
        //    return true;
        //}

        //void nextprime(int a)
        //{

        //   int Count = 0;
        //    while (Count<2)
        //    {
        //        if (prime(a))
        //        {
        //            Console.WriteLine(a);
        //            Count++;

        //        }
        //        a++;


        //    }

        //}

        //static void Main(string[] args)
        //{

        //    Comtcod obj = new Comtcod();

        //    Console.WriteLine("Enter a number");
        //    int a = int.Parse(Console.ReadLine());
        //    obj.nextprime(a);        
        //    Console.ReadLine();
        //}



        // write a recursion function to print first N natural numbers.

        //void printN(int n)
        //{
        //    if (n > 0)
        //    {
        //        printN(n - 1);
        //        Console.WriteLine(n);
        //    }

        //}

        //static void Main(string[] args)
        //{
        //    Comtcod obj = new Comtcod();
        //    int x;
        //    Console.WriteLine("Enter a number");
        //    x = int.Parse(Console.ReadLine());

        //    obj.printN(x);
        //    Console.ReadLine();
        //}



        // write a recursion function t print first N natural numbers in reverse order.

        //void printNReverse(int n)
        //{
        //    if (n > 0)
        //    {

        //        Console.WriteLine(n);//only changed in this lines exchange upper lower statments
        //        printNReverse(n - 1);
        //    }

        //}

        //static void Main(string[] args)
        //{
        //    Comtcod obj = new Comtcod();
        //    int x;
        //    Console.WriteLine("Enter a number");
        //    x = int.Parse(Console.ReadLine());

        //    obj.printNReverse(x);
        //    Console.ReadLine();
        //}




        // write a recursion function to print square of first N natural numbers.

        //void printNSquare(int n)
        //{
        //    if (n > 0)
        //    {
        //        printNSquare(n - 1);
        //        int square = n*n;
        //        Console.WriteLine($" square of { n} is : { square}");
        //    }

        //}

        //static void Main(string[] args)
        //{
        //    Comtcod obj = new Comtcod();
        //    int n;
        //    Console.WriteLine("Enter a number");
        //    n = int.Parse(Console.ReadLine());

        //    obj.printNSquare(n);
        //    Console.ReadLine();
        //}




        //write a recursive function to print n even natural numbers



        //void printNEven(int n)
        //{

        //    if (n > 0)
        //    {
        //        printNEven(n - 1);
        //        if (n % 2 == 0)
        //        {
        //            //int Even = n;

        //            Console.WriteLine(n);
        //        }

        //    }

        //}

        //static void Main(string[] args)
        //{
        //    Comtcod obj = new Comtcod();
        //    int n;
        //    Console.WriteLine("Enter a number");
        //    n = int.Parse(Console.ReadLine());

        //    obj.printNEven(n);
        //    Console.ReadLine();
        //}




        //write a recursive function to print n odd natural numbers



        //void printNOdd(int n)
        //{
        //    if (n > 0)
        //    {
        //        printNOdd(n - 1);
        //        if (n % 2 != 0)
        //        {
        //            int Even = n;
        //            Console.WriteLine(Even);
        //        }

        //    }

        //}

        //static void Main(string[] args)
        //{
        //    Comtcod obj = new Comtcod();
        //    int n;
        //    Console.WriteLine("Enter a number");
        //    n = int.Parse(Console.ReadLine());

        //    obj.printNOdd(n);
        //    Console.ReadLine();
        //}


    }
}
