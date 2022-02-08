/**
 * Author: Shashank Iyer
 * Date: 07 Feb, 2022
 * Application Purpose: 3 Random numbers between 1-9 are added to form a
 *                      lottery number, the user is then prompted to guess the 
 *                      number with 5 chances.
 */

using System;

namespace Shashank_Iyer_Ex_02
{
    internal class Lotto
    {
        //Instance variable for three random lotto numbers
        private int[] lottoNumber = new int[3];

        //Constructor that assings a random number between 1-9 to
        //each lottoNumber array
        public Lotto()
        {
            //Instantiating a random object
            Random variable = new Random();

            //For loop that stores random number between 1-9 to each
            //cell in the lottoNumber array
            for (int i = 0; i < 3; i++)
            {
                lottoNumber[i] = variable.Next(1, 10);
            }
        }

        //method to return the summed number from the array
        public int WinningNumber()
        {
            return lottoNumber[0] + lottoNumber[1] + lottoNumber[2];
        }
    }//End of Class
}//End of namespace
