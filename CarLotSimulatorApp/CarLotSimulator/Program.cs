using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            var carLotOne = new CarLOt();


            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars

            var ryansCar = new Car();
            ryansCar.Make = "Lamborghini";
            ryansCar.Model = "Gallardo";
            ryansCar.Year = 2024;
            ryansCar.EngineNoise = "vroooooom";
            ryansCar.HonkNoise = "beeeeep";
            ryansCar.IsDriveable = true;


            carLotOne.ParkingLot.Add(ryansCar);


            var richardsCar = new Car()
            {
                Make = "Tesla",
                Model = "CyberTruck",
                Year = 2024,
                EngineNoise = "...",
                HonkNoise = "beep",
                IsDriveable = false
            };

            carLotOne.ParkingLot.Add(richardsCar);

            var timsCar = new Car(2013, "Bmw", "335i", "vroooom", "beep", true);

            carLotOne.ParkingLot.Add(timsCar);

            carLotOne.CheckCars();

            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


            Console.WriteLine($"Number of cars created: {CarLOt.numberOfCars}");
        }
    }
}
