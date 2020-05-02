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
           
                
                    
                
        }
    }
}
