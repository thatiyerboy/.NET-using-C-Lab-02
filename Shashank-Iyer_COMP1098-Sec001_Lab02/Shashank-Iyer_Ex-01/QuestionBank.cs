/**
 * Author: Shashank Iyer
 * Date: 07 Feb, 2022
 * Applicaiton Purpose: Set up a question bank with 5 questions, these questions
 *                      will be answered by the user, scores will be kept with 
 *                      relevant output or correct or incorrect answer.
 */



using System;
namespace Shashank_Iyer_Ex_01
{
    internal class QuestionBank
    {
        //Auto-implemented properties with setters and getters set to private
        public bool Condition { get; private set; }
        public string CorrectChoice { get; private set; }
        public string UserChoice { get; private set; }
        public float Result { get; private set; }

        //Creating a default constructor which takes no arguments
        public QuestionBank()
        {

        }

        //Constructor with three arguments
        public QuestionBank(bool condition, string correctChoice,
                            string userChoice, float result = 0)
        {
            Condition = condition;
            CorrectChoice = correctChoice;
            UserChoice = userChoice;
            Result = result;
        }


        /*This method holds an array of questions and loops through them
        while prompting the user to answer, it doesn't move to the next question
        unless the user has answered*/
        public void SimulateQuestion()
        {
            Console.WriteLine("Welcome to the .NET programming using C# MCQ " +
                "based test! \n Press Any Key to Begin!");
            Console.ReadLine();

            //Instantiating an array that holds 5 questions
            string[] question = new string[5];

            question[0] = "What IDE do we need to use for this course?" +
                "\n1. IntelliJ \n2. Visual Studio Code \n3. PHP Storm " +
                "\n4. Visual Studio 2019/2022";

            question[1] = "What is the correct way to write a multiple line comment?" +
                "\n1. //comment \n2. <!-comment-> \n3. /**Comment*/" +
                "\n4. <comment>";

            question[2] = "Which of these is similar to Java package?" +
                "\n1. package \n2. load.package \n3. namespace " +
                "\n4. .NET.util.package";

            question[3] = "How do you print to terminal/console?" +
                "\n1. Console.WriteLine\n2. Console.Display \n3. printf" +
                "\n4. System.out.println ";

            question[4] = "HThe Data members of the class by default are ________." +
                "\n1. Public \n2. Private\n3. Protected \n4. None of the above";



            /**
             * Now we print each question and assign the correct answer to 
             * 'CorrectChoice' variable
             * We call in the InputAnswer() method and,
             * Repeat the process 5 times
             */

            Console.WriteLine(question[0]);
            CorrectChoice = "4";
            InputAnswer();

            Console.WriteLine(question[1]);
            CorrectChoice = "3";
            InputAnswer();

            Console.WriteLine(question[2]);
            CorrectChoice = "3";
            InputAnswer();

            Console.WriteLine(question[3]);
            CorrectChoice = "1";
            InputAnswer();

            Console.WriteLine(question[4]);
            CorrectChoice = "2";
            InputAnswer();

        }//End of SimulateQuestion()

        /*Creating the InputAnswer() method that takes in user input, stores it
        to UserChoice, along with checking validity of input*/
        public void InputAnswer()
        {
            bool count = false;
            while (count == false)
            {
                try
                {
                    //Takes user input and stores it into UserChoice
                    UserChoice = Console.ReadLine();

                    //If loop that checks for validity, if the input is viable
                    //it changes the count to true else throws exception
                    if (UserChoice == "1" || UserChoice == "2" || UserChoice == "3"
                        || UserChoice == "4")
                    {
                        count = true;
                    }

                    else
                        throw new ArgumentOutOfRangeException("Enter a number " +
                                                                "between 1 to 4!");
                }

                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Enter a valid number between 1 & 4!");
                }

            }

            //Calling CheckAnswer Method
            CheckAnswer();
        }//End of InputAnswer()

        /**
         * Creating a CheckAnswer() method that will take user input from UserChoice
         * compare it to CorrectChoice and alter the boolean condition, after which
         * GenerateMessage() method will be called to display a message
         */
        public void CheckAnswer()
        {
            if (UserChoice == CorrectChoice)
            {
                Condition = true;
            }

            else if(UserChoice != CorrectChoice)
                Condition = false;

            //If the answer is correct then the result to be displayed will go up by 1
            if(Condition == true)
            {
                Result++;
            }

            //Calling the GenerateMessage() method to display output
            GenerateMessage();

        }//End of CheckAnswer()

        /**
         * This method has 8 total messages, based on correct or incorrect answer
         * this method will display a message that informs the user if they are correct
         * or incorrect
         */
        public void GenerateMessage()
        {
            //Instantiating a random variable to choose one of the 4 prompts randomly
            Random variable = new Random();

            //If loop that will display messages if the answer is correct
            if (Condition == true)
            {
                //using switch statements to print the messages
                switch(variable.Next(4))
                {
                    case 0:
                        Console.WriteLine("\nGood Job!\n");
                        break;

                    case 1:
                        Console.WriteLine("\nGreat going!\n");
                        break;

                    case 2:
                        Console.WriteLine("\nYou are doing really well!\n");
                        break;

                    case 3:
                        Console.WriteLine("\nPerfect!\n");
                        break;
                }               
            }

            //If loop that will display messages if the answer is incorrect
            else
            {
                switch(variable.Next(4))
                {
                    case 0:
                        Console.WriteLine("\nThat was the wrong answer!\n");
                        break;

                    case 1:
                        Console.WriteLine("\nIncorrect!\n");
                        break;

                    case 2:
                        Console.WriteLine("\nThis isn't right!\n");
                        break;

                    case 3:
                        Console.WriteLine("\nYou need to study harder!\n");
                        break;
                }
            }
        }//End of GenerateMessage() method
    }//End of class
}//End of namespace
