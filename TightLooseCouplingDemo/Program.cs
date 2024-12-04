using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TightLooseCouplingDemo
{
    //Tight coupling Demo

    class Car
    {
        PetrolEngine engine;
        //DieselEngine engine;
        //ElectricEngine engine;
        public Car()
        {
            engine = new PetrolEngine();
            //engine = new DieselEngine();
            //engine = new ElectricEngine();
        }
        public void StartCar()
        {
            engine.Start();
            Console.WriteLine("Car started...");
        }

    }

    class PetrolEngine
    {
        public void Start()
        {
            Console.WriteLine("Petrol Engine Started...");
        }
    
    }

    class DieselEngine
    {
        public void Start()
        {
            Console.WriteLine("Diesel Engine Started...");
        }

    }

    class ElectricEngine
    {
        public void Start()
        {
            Console.WriteLine("Electric Engine Started...");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myPetrolCar = new Car();
            myPetrolCar.StartCar();

           /* Car myDieselCar = new Car();
            myDieselCar.StartCar();

            Car myEVCar = new Car();
            myEVCar.StartCar();*/
            Console.ReadKey();
        }
    }
}
