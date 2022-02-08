    /**
    * Author: Shashank Iyer
    * Date: 07 Feb, 2022
    * Application Purpose: Main test method that uses the Lotto.cs class to run a
    *                      a game where the user guesses the Lotto Number, the user
    *                      has 5 tries, and if they fail the program displays an 
    *                      error message.
    */

    using System;
    namespace Shashank_Iyer_Ex_02
    {
        internal class LottoTest
        {
            //Executes the Main Method
            static void Main(string[] args)
            {
                //Instantiating a new lotto object
                Lotto lottery = new Lotto();

                //Prompt that greets the user and explains the working of the game
                Console.WriteLine("Welcome to Georgian Lotto! Grand Prize is: $100,000"
                    + "\nRules of the game are simple:\nYou have to guess the Lotto number. " +
                    "\nYou get 5 tries for 10$. Press any key to charge your card for $10!");
                Console.ReadLine();
                Console.WriteLine("...Transaction Processing..." + "\n" +
                    "\nThank you for the payment! Let's start! (Press any key to start!)");
                Console.ReadLine();

                int attempt = 0;
                int tries = 5;

                while (attempt<6)//(quit == false)
                {
                    ++attempt;
                    --tries;

                    //Try and Catch to handle exceptions for faulty inputs
                    try
                    {
                        Console.WriteLine("Enter you guess! (Remember the lotto number" +
                        " lies between 3 & 27!)");
                        Console.WriteLine($"Attempt no. {attempt}");
                        int answer = int.Parse(Console.ReadLine());
                     
                        //If loop that checks the validity of the input
                        if (answer <= 3 || answer >= 27)
                        {
                            throw new IndexOutOfRangeException("\nNot a valid number! " +
                                  "Please enter a number between 3 & 27");
                        }

                        //If loop that dictates what happens when the user guesses the answer
                        if (answer == lottery.WinningNumber())
                        {
                            Console.WriteLine($"\n****{answer} is the correct guess!****" +
                                $"\nCongratulations you just won $100,000!!!" +
                                $"\nTrasferring to your initial mode" +
                                $" of payment, please wait!" + $"\nTransaction Completed!");
                            //This ends the code
                            attempt = 10;
                        }

                        //Prompts a failed message in case incorrect answer
                        else
                        {
                            Console.WriteLine($"\nIncorrect, you have {tries} more tries left!\n");
                        }

                        //If the user exceeds the number of tries the program displays
                        //a prompt and ends the program
                        if (attempt == 5)
                        { 
                            Console.WriteLine($"Sorry! You loose! The correct answer was " +
                                $"{lottery.WinningNumber()}. \nThanks for Playing!");
                            //This ends the code
                            attempt = 10;
                        }
                    }

                    //Catches the exception and prints an error message
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Please enter a number between 3 & 27!!!");

                        //Removes the attempt as it is default
                        --attempt;
                    }
                }
            }//End of main
        }//End of Class
    }//End of Namespace

