using System;

namespace CarLotSimulator
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list. - DONE

            CarLot lot = new CarLot();

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            Car car1 = new Car();
            car1.Year = 2018;
            car1.Model = "CX9";
            car1.Make = "Mazda";
            car1.IsDriveable = true;
            car1.EngineNoise = "noise1";
            car1.HonkNoise = "honk1";

            var car2 = new Car()
            {
                Make = "Jeep",
                Model = "Wrangler",
                Year = 2019,
                EngineNoise = "noise2",
                HonkNoise = "honk2",
                IsDriveable = true
            };

            //Car car2 = new Car();
            //car2.Year = 2019;
            //car2.Model = "Wrangler";
            //car2.Make = "Jeep";
            //car2.IsDriveable = true;
            //car2.EngineNoise = "noise2";
            //car2.HonkNoise = "honk2";

            //Car car3 = new Car();
            //car3.Year = 2016;
            //car3.Model = "Grand Cherokee";
            //car3.Make = "Jeep";
            //car3.IsDriveable = true;
            //car3.EngineNoise = "noise3";
            //car3.HonkNoise = "honk3";


            Car car3 = new Car(2016, "Jeep", "Grand Cherokee", "noise3", "honk3", false);


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            car3.MakeEngineNoise("vrooom\n");
            car2.MakeHonkNoise("honk honk\n");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class - DONE
            //It should have at least one property: a List of cars - DONE

            //instance name . property name . method name
            //"lot" instantiated at the beginning of the main program.
            //"Cars" is the list created in the CarLot class
            //"Add" is the built in method that adds value to the list
            //(car1)  instantiated from the Cars class with its properties declared
            lot.Cars.Add(car1);
            lot.Cars.Add(car2);
            lot.Cars.Add(car3);

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


            //get each value with properties declared from the list 
            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}\n");
            }



        }
    }
}
