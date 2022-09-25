using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {   //Here I ask the user to guess a number.
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            CheckGuess();//Here the program is going to run the codes som are in the method called "Check guess"
        }
        static void  CheckGuess() //Here I have created a method "CheckGuess".
        {
            Random random = new Random();    //Here I have created a new random number
            int number = random.Next(1, 20); // with the min and max value,
            int numberOfguesses = 0; //Here I have declared a variable with the value 0.

            for (int i = 0; i < 5; i++) //The for loop which is going to run 5 times because the user have
                                        //5 tries to guess the number.
            {
                int guess = Convert.ToInt32(Console.ReadLine());//The user´s number will be converted to Int 32.

                if (guess > number) //if the number that user will give is greater than the random number.
                {
                    Console.WriteLine("Tyvärr du gissade för högt!"); //the message that will be show in the console window.
                }
                else if (guess < number)//if the number that user will give is lower than the random number.
                {
                    Console.WriteLine("Tyvärr du gissade för lågt!");//the message that will be show in the console window.
                }
                else if (guess == number)//if the number that user will give is equal than the random number.
                {
                    Console.WriteLine("Woho! Du gjorde det!"); //the message that will be show in the console window.
                    break;
                }
                numberOfguesses++;

                if (numberOfguesses == 5)//if the user has tried 5 times but has not succeeded
                {
                    Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");//the message that will be show
                                                                                            //in the console window.
                    break; //a break point.
                    
                }
            }

            Console.WriteLine();
        }
        
    }
}
