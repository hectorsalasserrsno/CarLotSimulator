using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car--done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable-- done
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()-- done
            //The methods should take one string parameter: the respective noise property-- done
            Carlot  carLotInstance = new Carlot();

            //Now that the Car class is created we can instanciate 3 new cars-- done
            //Set the properties for each of the cars-- done
            //Call each of the methods for each car-- done
            Car car1 = new Car();
            {
                car1.Make = "Ford";
                car1.Model = "Explorer";
                car1.Year = 2004;
                car1.EngineNoise = "chaca chaca";
                car1.HonkNoise = "yahoo!!";
                car1.IsDriveable = true;
            };
            carLotInstance.ListOfCars.Add(car1);

            Car car2 = new Car() { Make = "Toyota", Model = "Corola", Year = 2015, EngineNoise = "Brooom", HonkNoise = "Fiu fiu", IsDriveable = true };

            carLotInstance.ListOfCars.Add(car2);


            Car car3 = new Car("Toyota", "Tacoma", 2019, "zoorr", "wiiiiuuu", false );
            carLotInstance.ListOfCars.Add(car3);
            
            
            car1.MakeEngineNoise();
            car1.MakeHonkNoise();
            car2.MakeEngineNoise();
            car2.MakeHonkNoise();
            car3.MakeEngineNoise();
            car3.MakeHonkNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car-- done

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (var item in carLotInstance.ListOfCars)
            {
                Console.WriteLine(item.Year);
                Console.WriteLine(item.Model);
                Console.WriteLine(item.Make);
            }
        }
    }
}
