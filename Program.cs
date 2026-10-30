using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block106SampleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Block 106");
            Console.WriteLine("Hello Block 106");
            Console.WriteLine("Hello po - Rio");

            Console.WriteLine("Test");

            string gcashLink = "https://drive.google.com/drive/folders/1hH4QPs4izb-cUJTIHn4yTodezOnEH34-?usp=sharing";

            Console.WriteLine();
            Console.WriteLine("Gcash link: " + gcashLink);
            Console.WriteLine("Any amount will do");
            Console.WriteLine("Charity Purpose");

            Console.WriteLine("\nLets play a game!");

            int lives = 5;

            while (lives > 0)
            {
                string question1 = ("\nWhat gas do plants absorb from the air for photosynthesis?" +
                    "\nEnter your answer here: ");

                Console.Write($"\n{question1}");
                var answer = Console.ReadLine().Trim().ToLower();

                if (answer == "carbon dioxide" || answer == "co2")
                {
                    Console.WriteLine("Correct! You win!");
                    break;
                }
                else
                {
                    lives--;
                    Console.WriteLine($"\nINCORRECT! You have {lives} lives left.");

                }

            }

            if (lives == 0)
            {
                Console.WriteLine("\nYou have no lives left. Game over!");
            }

            Console.WriteLine("\n===================================================================================");

            Console.Write("\nEnter number of vehicles: ");
            int numberOfVehicles = Convert.ToInt32(Console.ReadLine());

            double totalTollFee = 0;
            for (int i = 1; i <= numberOfVehicles; i++)
            {
                string vehicleType = ($"\nVehicle #{i}" +
                    "\n1 - Motorcycle" +
                    "\n2 - Car" +
                    "\n3 - Bus" +
                    "\n4 - Truck" +
                    "\nEnter vehicle type: ");

                Console.Write(($"\n{vehicleType}"));
                var vehicleTypeInput = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter distance traveled (km): ");
                var distanceTraveled = Convert.ToInt32(Console.ReadLine());

                switch (vehicleTypeInput)
                {
                    case 1:
                        totalTollFee = CalculateTollFee(distanceTraveled, 10, totalTollFee);
                        break;
                    case 2:
                        totalTollFee = CalculateTollFee(distanceTraveled, 20, totalTollFee);
                        break;
                    case 3:
                        totalTollFee = CalculateTollFee(distanceTraveled, 30, totalTollFee);
                        break;
                    case 4:
                        totalTollFee = CalculateTollFee(distanceTraveled, 40, totalTollFee);
                        break;
                    default:
                        Console.WriteLine("Invalid vehicle type. Please enter a number between 1 and 4.");
                        i--;
                        break;
                }
            }
            Console.WriteLine($"\nTotal Toll Collection: {totalTollFee:F2}");
            Console.WriteLine("===================================================================================");

            DifferentMethod();

        }
        static double CalculateTollFee(int distanceTravled, int TollRate, double totalTollFee)
        {

            if (distanceTravled < 100)
            {

                double tollFee = distanceTravled * TollRate;
                Console.WriteLine("No discount applied.");
                DisplayTollFee(distanceTravled, tollFee);

                totalTollFee += tollFee;
                return totalTollFee;
            }
            else
            {
                Console.WriteLine("10% discount applied.");
                double tollFee = ((distanceTravled * TollRate) * 0.9);
                DisplayTollFee(distanceTravled, tollFee);

                totalTollFee += tollFee;
                return totalTollFee;
            }
        }

        static void DisplayTollFee(int distanceTraveled, double tollFee)
        {
            Console.WriteLine($"Distance: {distanceTraveled} km");
            Console.WriteLine($"Toll fee: {tollFee:F2}");
        }

        static void DifferentMethod()
        {
            Console.WriteLine("\n===================================================================================");

            Console.Write("\nEnter number of vehicles: ");
            int numberOfVehicles = Convert.ToInt32(Console.ReadLine());

            double totalTollFee = 0;
            double tollFee = 0;
            for (int i = 1; i <= numberOfVehicles; i++)
            {
                string vehicleType = ($"\nVehicle #{i}" +
                    "\n1 - Motorcycle" +
                    "\n2 - Car" +
                    "\n3 - Bus" +
                    "\n4 - Truck" +
                    "\nEnter vehicle type: ");

                Console.Write(($"\n{vehicleType}"));
                var vehicleTypeInput = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter distance traveled (km): ");
                var distanceTraveled = Convert.ToInt32(Console.ReadLine());
            
                switch (vehicleTypeInput)
                {
                    case 1:
                        tollFee = distanceTraveled * 10;
                        break;
                    case 2:
                        tollFee = distanceTraveled * 20;
                        break;
                    case 3:
                        tollFee = distanceTraveled * 30;
                        break;
                    case 4:
                        tollFee = distanceTraveled * 40;
                        break;
                    default:
                        Console.WriteLine("Invalid vehicle type. Please enter a number between 1 and 4.");
                        i--;
                        break;
                }

                if (distanceTraveled < 100)
                {
                    Console.WriteLine("No discount applied.");
                    DisplayTollFee(distanceTraveled, tollFee);
                    totalTollFee+= tollFee;
                }
                else
                {
                    tollFee *= 0.9;
                    Console.WriteLine("10% discount applied.");
                    DisplayTollFee(distanceTraveled, tollFee);
                    totalTollFee+= tollFee;
                }
            }
            Console.WriteLine($"\nTotal Toll Collection: {totalTollFee:F2}");
            Console.WriteLine("===================================================================================");




        }

    }
}
