/*
 Author: Gregory Gauthier
 Date: 1/17/2019
 Comments: This C# Console application code demonstrates the use 
 of conditional statements after getting input from users
 */


using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Grade you think You Will Earn in ISM 4300");

            /*
             Here we will be using a try-catch block 
             In order to validate the users input.
             This will handle any errors and display a message.
             */

            try
            {
                //this variable will be gathering the users input

                string UserInput = Console.ReadLine();
                int ExpectedGrade = int.Parse(UserInput);

                if ((ExpectedGrade > 79) && (ExpectedGrade < 90))
                    Console.WriteLine("You Will Earn a B");

                else if (ExpectedGrade > 89)
                    Console.WriteLine("You Will Earn an A");

                else if ((ExpectedGrade < 80) && (ExpectedGrade > 69))
                    Console.WriteLine("You Will Earn a C");

                else if (ExpectedGrade < 70)
                    Console.WriteLine("You Will Earn a D");

                Console.ReadKey(true);
            }

            catch
            {
                Console.WriteLine("Please make sure to use a Number Value for your expected grade");
                Console.ReadKey(true);
            }

            

                    
            
        }
    }
}
