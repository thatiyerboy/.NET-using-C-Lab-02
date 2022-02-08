/**
 * Author: Shashank Iyer
 * Date: 07 Feb, 2022
 * Application Purpose: To create a sorting method to sorts the numbers in 
 *                      descending order stored withing a static Array.
 */

using System;
namespace Shashank_Iyer_Ex_03
{
    internal class SortValues
    {
       /*
        * This static method takes variables numbers stores them in an array
        * and then sorts then access sorting methods and then prints them
        */
       public static void SortNumbers(params int[] numbers)
        {
            //Sort all the numbers using pre established functions of C#
            //Lowest to highest - ascending
            Array.Sort(numbers);

            //Reversing the sorted direction i.e. descending
            Array.Reverse(numbers);

            //Loops through the array of integers and prints them all in
            for(int i=0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }//End of class
}//End of namespace
