using System;

namespace Pre_work_Code_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            arrayMaxResult();
        }
        //PROBLEM 1: Array Max Result: Guessing game!
        private static void arrayMaxResult()
        {
            Random random = new Random();
            //range we want the numbers to be in we need to go to 11 so that 10 is included in this range
            int randomNum = random.Next(1, 11);
            int userGuess;
            int numGuesses = 5;
            bool gameOver = false;
            Console.WriteLine("Let's play a guessing game. I am thinking of a number between 1 & 10, what is the number? ");


            // use a while loop to run until gameOver is true
            while (gameOver == false)
                {
                     userGuess = Convert.ToInt32(Console.ReadLine());
                    numGuesses--;
                //both need to be true
                if (userGuess != randomNum && numGuesses == 0)
                {
                    Console.WriteLine("Sorry, you did not guess the number I was thinking of.");
                    // to exit while loop to break out of the game 
                    gameOver = true;

                }
                else if (numGuesses == randomNum)
                {
                    Console.WriteLine("You guessed right! You're amazing");
                    //For this instance we also want to break out of the loop since the user guessed correctly
                    gameOver = true;
                }
                else if (userGuess > randomNum)
                    Console.WriteLine("Try again, my number is a bit lower than that!");
                else if (userGuess < randomNum)
                    Console.WriteLine("Nice try, but my number is a bit higher than that!");
                    
                }
        }
    }
}
