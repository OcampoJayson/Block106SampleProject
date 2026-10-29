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







        }
        
    }
}
