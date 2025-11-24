using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class AbstractionSimple
    {
        private void Engine()
        {
            Console.WriteLine("The engine is started");
        }
        public void Car()
        {
            Console.WriteLine("The car is starting");
            Engine();
        }

        static void Main(string[] args)
        {
            AbstractionSimple obj = new AbstractionSimple();
            obj.Car();
        }
        
    }
}
