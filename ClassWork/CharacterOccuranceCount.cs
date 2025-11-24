using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class CharacterOccuranceCount
    {
        

        static void Main (string[] args)
        {
           
            Console.WriteLine("Enter String to Check ");
            string input=(Console.ReadLine());


            for (int i = 0; i < input.Length; i++)
            {
                int Count = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        Count++;
                    }
                   
                }
                
               // if (stored.)

                Console.WriteLine($"character : {input[i]} and Count : {Count}");
            }

        }
        
    }


}

