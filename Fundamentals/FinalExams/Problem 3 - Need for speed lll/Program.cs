using System;
using System.Collections.Generic;
using System.Linq;


namespace Problem_3___Need_for_Speed_III
{
    internal class Program
    {
        public class Car
        {
            public Car(string name, double mileage, double fuel)
            {
                this.Name = name;
                this.Mileage = mileage;
                this.Fuel = fuel;
            }
            public string Name { get; set; }
            public double Mileage { get; set; }
            public double Fuel { get; set; }

            public override string ToString()
            {
                return $"{this.Name} -> Mileage: {this.Mileage} kms, Fuel in the tank: {this.Fuel} lt.";
            }
        }
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);

                string carName = cmdArgs[0];
                double mileage = double.Parse(cmdArgs[1]);
                double fuel = double.Parse(cmdArgs[2]);

                Car newCar = new Car(carName, mileage, fuel);
                cars.Add(newCar);
            }

            string input = Console.ReadLine();
            while (input != "Stop")
            {
                string[] cmdArgs = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                if (action == "Drive")
                {
                    string carName = cmdArgs[1];
                    double distance = double.Parse(cmdArgs[2]);
                    double fuel = double.Parse(cmdArgs[3]);
                    Car drivenCar = cars.FirstOrDefault(x => x.Name == carName);
                    if (drivenCar.Fuel - fuel < 0)
                    {
                        Console.WriteLine($"Not enough fuel to make that ride");
                    }
                    else
                    {
                        drivenCar.Fuel -= fuel;
                        drivenCar.Mileage += distance;
                        Console.WriteLine($"{drivenCar.Name} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }
                    if (drivenCar.Mileage >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {carName}!");
                        cars.Remove(drivenCar);
                    }
                }
                else if (action == "Revert")
                {
                    string carName = cmdArgs[1];
                    double kilometers = double.Parse(cmdArgs[2]);
                    Car revertedCar = cars.FirstOrDefault(x => x.Name == carName);

                    if (revertedCar.Mileage - kilometers < 10000)
                    {
                        revertedCar.Mileage = 10000;
                    }
                    else
                    {
                        revertedCar.Mileage -= kilometers;
                        Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
                    }
                }
                else if (action == "Refuel")
                {
                    string carName = cmdArgs[1];
                    double fuel = double.Parse(cmdArgs[2]);
                    Car refueledCar = cars.FirstOrDefault(x => x.Name == carName);

                    if (refueledCar.Fuel+fuel>75)
                    {
                        double usedFuel = 75 - refueledCar.Fuel;
                        refueledCar.Fuel = 75;
                        Console.WriteLine($"{carName} refueled with {usedFuel} liters");
                    }else
                    {
                        Console.WriteLine($"{carName} refueled with {fuel} liters");
                        refueledCar.Fuel += fuel;
                    }
                }

                input = Console.ReadLine();
            }


            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
