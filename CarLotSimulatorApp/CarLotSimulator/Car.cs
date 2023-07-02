using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car() { }    
       
        
        public Car(string make, string model, int year,string enginenoise, string honknoise, bool isdriveable)
        {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = enginenoise;
            HonkNoise = honknoise;
            IsDriveable = isdriveable;


        }
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }   

        public bool IsDriveable { get; set;}


        public void MakeEngineNoise()
        {
            Console.WriteLine($"My friend's car makes this noise {EngineNoise}");
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine($"My car's honk sounds like this {HonkNoise}");       
        }




    }
}

