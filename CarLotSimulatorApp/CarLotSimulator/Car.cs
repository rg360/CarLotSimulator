using System;
namespace CarLotSimulator
{
    public class Car
    {
        //properties - prop tabtab
        //no ; terminator needed
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        //constructor
        public Car()
        {

        }

        public Car(int year, string make, string model, string enginenoise, string honknoise, bool isdriveable)
        {
            //declare variables
            //properties = parameters declared inside the parameterized constructor
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = enginenoise;
            HonkNoise = honknoise;
            IsDriveable = isdriveable;

        }

        //methods
        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(HonkNoise);
        }


    }
}
