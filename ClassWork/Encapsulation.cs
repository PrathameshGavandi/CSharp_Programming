using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Encapsulation
    {
        private string name;

        public void SetName(string username)
        {
            this.name = username;
        }
        public string GetName()
        {
            return name;
        }


        static void Main(string[] args)
        {
            Encapsulation obj = new Encapsulation();
            obj.SetName("prathamesh");
            // obj.GetName();

            Console.WriteLine("Your name is " + obj.GetName());
            Console.ReadLine();
        }

    }
    




}

