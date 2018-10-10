using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GC_lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numberOfSides, diceOne, diceTwo, rollNumber;
            string rollDiceInput;
            // ask the user to enter the number of sides for a pair of dice 
            Console.WriteLine("Welcome to the Grand Circus Casino!");



            // prompt the user to roll the dice 
            Console.WriteLine("Roll the dice? y/n : ");
            rollDiceInput = Console.ReadLine().ToLower();
            rollNumber = 0;

            while (rollDiceInput == "yes" || rollDiceInput == "y")
            {
                
            // display the results of each and ask if you want to roll again 
            Console.WriteLine("How many sides should each die have?");
            numberOfSides = int.Parse(Console.ReadLine());
            diceOne = getRoll(numberOfSides, rnd);
            diceTwo = getRoll(numberOfSides, rnd);
          

            Console.WriteLine("Roll " + ++rollNumber);
            Console.WriteLine(diceOne);
            Console.WriteLine(diceTwo);
            Console.WriteLine("Dare to roll again? Y/N");
            rollDiceInput = Console.ReadLine().ToLower();
                
            } 

            Console.WriteLine("Goodbye\nPress any key to close");
            Console.ReadKey();

            // use DiceRollerApp to display special messages for crpas, snake eyes and box cars 

        }
        static int getRoll(int sides, Random roll)
            {
               
                int dice = roll.Next(1, sides + 1);
                return dice;
            }


    }
}
