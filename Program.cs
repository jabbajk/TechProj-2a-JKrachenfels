/*
  Author: Jared Krachenfels
  Class: ISM 3400 Fall 2020
  Date: 9/13/2020
  Assignment: Tech Project #2a
*/

using System;

namespace TechProj_2a_JKrachenfels
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.Write("Enter an Integer value between 1 and 25 to execute a while loop iterative statement:");
            
            // Use the try-catch block to make sure the user input an integer between 1-25.
            //Bad inputs sent and handled to catch block.
            try
            {
                // Determine variable to gather data from the user.
                string input = Console.ReadLine();
                // Input variable will be used to perform the loop statement and is parsed.
                int value_of_input = int.Parse(input);

                // The If/Else statement below is testing if the input value falls in the acceptable range. 
                // If the value does not, the else statement will execute requiring the user to try again
                // If the value of user is between 1 and 25, execute the While Loop.
                if((value_of_input>0) && (value_of_input <= 25))
                {
                    Console.WriteLine("Executing a While Loop!");
                    Console.WriteLine("The While loop will iterate " + value_of_input.ToString() + " times");
                    // Below is While Loop
                    // The while loop will check if the statement is true and will execute and loop until a value makes the statement false4
                    while (value_of_input > 0)
                    {
                        Console.WriteLine("The value of the interative statement is " + value_of_input.ToString());
                        value_of_input--;
                    }
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 25 and try again ...");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);
                }
            } // End of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            } // End of Catch
        } // End of Main
    } // End of Class
} // End of Namespace
