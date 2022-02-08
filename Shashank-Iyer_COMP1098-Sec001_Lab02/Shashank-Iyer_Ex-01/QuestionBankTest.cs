/**
 * Author: Shashank Iyer
 * Date: 07 Feb, 2022
 * Application Purpose: This class acts as the test class for the QuestionBank.cs Class
 *                      it will create an object of QuestionBank class and start the 
 *                      execution by calling the InputAnswer() Method.
 */
using System;
namespace Shashank_Iyer_Ex_01
{
    public class QuestionBankTest
    {
        //Execute the main method
        static void Main(string[] args)
        {
            //Instantiating a new QuestionBank object
            QuestionBank question = new QuestionBank();

            //Calling the SimulateQuestion() Method
            question.SimulateQuestion();

            // Tells the user how many questions were answered correctly
            Console.WriteLine("You answered " + question.Result + " questions correctly");

            //Tells the user how many questions were incorrect
            Console.WriteLine("You answered " + (5 - question.Result) + " questions incorrectly");

            // Tells the user their overall percentage
            Console.WriteLine("Your answers were " + (question.Result / 5) * 100 + "% correct.");

            //End Prompt
            Console.WriteLine("\nThanks for taking the test!");

        }//End of main 
    }//End of class
}//End of namespace
