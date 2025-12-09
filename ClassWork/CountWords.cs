using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class CountWords
    {
        static void Main(string[] args)
        {

             

            string sentence = "Hey im Prathamesh";

           string[] words = sentence.Split(' ');

            int wordscount = words.Length;

            Console.WriteLine("Words count in a sentence is : "+wordscount);
            
            Console.ReadLine();



        }
                  
        

    }
}
