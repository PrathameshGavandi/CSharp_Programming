using System;

namespace Test
{
    // 1) Interface
    public interface IEngine
    {
        void Start();
    }

    // 2) PetrolEngine - Interface implement करणारा class
    public class PetrolEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Petrol Engine Started!");
        }
    }

    // 3) DieselEngine - दुसरा class implement करणारा
    public class DieselEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Diesel Engine Started!");
        }
    }

    // 4) Car - ज्याला engine ची गरज आहे
    public class Car
    {
        private IEngine engine;   // Dependency ठेवण्यासाठी जागा

        // Constructor Injection
        public Car(IEngine eng)
        {
            engine = eng;  // Dependency inject केली जाते
        }

        public void Drive()
        {
            engine.Start();
            Console.WriteLine("Car is driving...");
        }
    }

    // 5) Main class (startup point)
    public class DependancyInjection
    {
        public static void Main(string[] args)
        {
            // Petrol Engine वापरायचं असेल तर:
            IEngine petrol = new PetrolEngine();
            Car car1 = new Car(petrol);
            car1.Drive();

            Console.WriteLine();

            // Diesel Engine वापरायचं असेल तर:
            IEngine diesel = new DieselEngine();
            Car car2 = new Car(diesel);
            car2.Drive();

            Console.ReadLine();
        }
    }
}
