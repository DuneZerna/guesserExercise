using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guesser
{
    class Guesser
    {
        // the "const" keyword makes the value of the variable final, meaning it can never be modified
        // a variable with "const" acts also as if it had the "static" modifier, meaning it can be accessed without needing to instantiate an object
        const int MaxTrials = 10;
        const int dots = 4;
        public static int remainingGuesses = 10;

        static void Main(string[] args)
        {

            for (int i = 0; i < dots; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(1500);
            }

            Console.WriteLine("Welcome to the guessing game");

            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("In this game, you have to guess the correct name I want you to guess...");

            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("I'll start you off with a hint");

            System.Threading.Thread.Sleep(4000);

            Console.WriteLine("The hint is: The Creator");

            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("Go ahead, type a name");


            for (int i = 0; i < MaxTrials; i++)
            {


                switch (Console.ReadLine())
                {
                    case "Dune":
                        Console.WriteLine("The supreme leader is happy, you have done well");
                        System.Threading.Thread.Sleep(10000);
                        Environment.Exit(0);
                        break;

                    default:
                        int j = 1 + i;

                        Console.WriteLine("Please wait...");


                        System.Threading.Thread.Sleep(5000);

                        if (j == MaxTrials)
                        {
                            Console.WriteLine("WRONG! YOU LOSE!");
                            System.Threading.Thread.Sleep(5000);
                            Environment.Exit(0);
                        }

                        break;


                }

                Console.WriteLine("You have guesses wrong! You have " + (remainingGuesses = remainingGuesses - 1) + " remaining tries!");
                

                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}
