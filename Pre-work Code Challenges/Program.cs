using System;
using System.Dynamic;

namespace Pre_work_Code_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge 1: Array Max Result");
            arrayMaxResult();
        }
        //PROBLEM 1: Array Max Result: Not a guessing game after all! 
        private static void arrayMaxResult()
        {
            // 1st step: Request 5 numbers between 1-10 from User
            // set array length
            int arrayLength = 5;
            int[] userInputArray = new int[arrayLength];
            //Use for loop to ask user for 5 inputs 
            for(int i = 0; i <arrayLength; i++)
            {
                //ask user for input
                Console.WriteLine("Please enter a number between 1-10, we will ask you this question 5 times. ");
                // Next we need to put those numbers into the array- we will need to parse into integer for this
                userInputArray[i] = int.Parse(Console.ReadLine());
            }
            //2nd step: Ask the user for a number to check for.
            Console.WriteLine("Please enter a number to check: ");
            int numberCheck = int.Parse(Console.ReadLine());

            //3rd step is to hceck how many times that number appeaars and sum them (Addition) Sample inout includes two 4's and the user checks for 4 so the output is 8.
            int returnVariable = 0;
            //use a for loop to iterate through the users input array length
            for(int i = 0; i < arrayLength; i++)
            {
                returnVariable += numberCheck;
            }
            //Tell the user their score!
            Console.WriteLine($"You have a score of {returnVariable}!");



        }
    }

}
