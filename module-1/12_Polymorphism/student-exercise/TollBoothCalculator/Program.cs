using System;
using System.Collections.Generic;
using TollBoothCalculator.Classes;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> allVehicles = new List<IVehicle>();
            allVehicles.Add(new Car(true));
            allVehicles.Add(new Car(false));
            allVehicles.Add(new Truck(4));
            allVehicles.Add(new Truck(6));
            allVehicles.Add(new Truck(8));
            allVehicles.Add(new Truck(9));
            allVehicles.Add(new Tank());


            Random random = new Random();

            Console.WriteLine("Vehicle                       Distance Traveled                       Toll $");
            Console.WriteLine("----------------------------------------------------------------------------");

            foreach (IVehicle vehicle in allVehicles)
            {
                int distance = random.Next(10, 500);
                double toll = vehicle.CalculateToll(distance);
                Console.Write(vehicle.ToString().PadRight(30));
                Console.Write(distance.ToString().PadRight(30));
                Console.WriteLine(toll.ToString("C").PadLeft(15));
            }

            Console.ReadLine();
        }
    }
}
