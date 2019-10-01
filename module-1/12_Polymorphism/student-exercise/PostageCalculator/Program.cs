using System;
using System.Collections.Generic;
using PostageCalculator.Classes;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //new list
            List<IDeliveryDriver> postageList = new List<IDeliveryDriver>();
            postageList.Add(new FirstClass());
            postageList.Add(new SecondClass());
            postageList.Add(new ThirdClass());
            postageList.Add(new Fexed());
            postageList.Add(new Spu4());
            postageList.Add(new Spu2());
            postageList.Add(new SpuNext());

            //Entry
            Console.Write("Please enter the weight of the package? ");
            string packageWeightInput = Console.ReadLine();
            double packageWeightDouble = double.Parse(packageWeightInput);
            Console.Write("(P)ounds or (O)unces? ");
            string weightLbOz = Console.ReadLine().ToUpper();
            Console.Write("What distance will it be traveling? ");
            string distanceInput = Console.ReadLine();
            int distanceInt = int.Parse(distanceInput);
            Console.WriteLine();

            Console.WriteLine("Delivery Method                      $ cost");
            Console.WriteLine("-------------------------------------------");
            //Output
            foreach (IDeliveryDriver entry in postageList)
            {
                if (weightLbOz == "O" || weightLbOz == "o")
                {
                    Console.WriteLine($"{entry.TypeOfDelivery} + {entry.CalculateRate(distanceInt, packageWeightDouble)}");
                }
                else if (weightLbOz == "P" || weightLbOz == "p")
                {
                    Console.WriteLine($"{entry.TypeOfDelivery} + {entry.CalculateRate(distanceInt, packageWeightDouble*16)}");
                }
                else Console.WriteLine("Please enter \"O\" or \"P\": ");
            }
            Console.ReadLine();
        

        }
    }
}
