
//Michael Goltra's Mission 2 Assignment
using System;

namespace MissionTwoAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declarations
            Random rand = new Random();
            int rollCount = 0;
            decimal twos = 0;
            decimal threes = 0;
            decimal fours = 0;
            decimal fives = 0;
            decimal sixes = 0;
            decimal sevens = 0;
            decimal eights = 0;
            decimal nines = 0;
            decimal tens = 0;
            decimal elevens = 0;
            decimal tweleves = 0;

            Console.WriteLine("Welcome to the dice throwing simulator!" + "\n");
            Console.WriteLine("How many dice rolls would you like to simulate? ");

            // input the number of rolls to make and changing the string input to an integer
            rollCount = int.Parse(Console.ReadLine());

            //array for how many instances of each roll
            int[] results = new int[rollCount];

            for (int i = 0; i < rollCount; i++)
            {
                //dice roll simulation for two die
                results[i] = ((rand.Next(0, 6) + 1) + (rand.Next(0, 6) + 1));

                if (results[i] == 2)
                {
                    twos++;
                }

                if (results[i] == 3)
                {
                    threes++;
                }

                if (results[i] == 4)
                {
                    fours++;
                }

                if (results[i] == 5)
                {
                    fives++;
                }

                if (results[i] == 6)
                {
                    sixes++;
                }

                if (results[i] == 7)
                {
                    sevens++;
                }

                if (results[i] == 8)
                {
                    eights++;
                }

                if (results[i] == 9)
                {
                    nines++;
                }

                if (results[i] == 10)
                {
                    tens++;
                }

                if (results[i] == 11)
                {
                    elevens++;
                }

                if (results[i] == 12)
                {
                    tweleves++;
                }
            }

            // percent conversion for each result instance
            decimal[] numAsterisks = {Math.Round((decimal)(twos / rollCount) * 100, 0), Math.Round((decimal)(threes / rollCount) * 100, 0), Math.Round((decimal)(fours / rollCount) * 100, 0), Math.Round((decimal)(fives / rollCount) * 100, 0), Math.Round((decimal)(sixes / rollCount) * 100, 0), Math.Round((decimal)(sevens / rollCount) * 100, 0), Math.Round((decimal)(eights / rollCount) * 100, 0), Math.Round((decimal)(nines / rollCount) * 100, 0), Math.Round((decimal)(tens / rollCount) * 100, 0), Math.Round((decimal)(elevens / rollCount) * 100, 0), Math.Round((decimal)(tweleves / rollCount) * 100, 0) };

            //output result phrases
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each " + "*" + " represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + rollCount + ".");

            //these for loops create the histogram
            for (int i = 0; i <= 10; i++)
            {
                string output = (i + 2) + ": ";

                for (int z = 0; z < numAsterisks[i]; z++)
                {
                    output += "*";
                }

                Console.WriteLine(output);
            }

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}