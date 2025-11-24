using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Abstraction
    {
        private void engine()
        {
            Console.WriteLine("The enginee was started");
        }
        public void car()
        {
            Console.WriteLine("The car was started");
            engine();
        }

        static void Main (string[] args)
        {
            Abstraction obj = new Abstraction();
            obj.car();
            Console.ReadLine();
        }
    }
}
