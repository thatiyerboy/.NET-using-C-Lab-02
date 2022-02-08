/**
 * Author: Shashank Iyer
 * Date: 07 Feb, 2022
 * Application Purpose: To test the SortValues class by randomly choosing sets
 *                      of random numbers and calling the SortNumbers() method.
 */


using System;
namespace Shashank_Iyer_Ex_03
{
    internal class SortTest
    {
        //Executes the main method
        static void Main(string[] args)
        {
            //4 sets of random numbers to be sorted in descending order
            Console.WriteLine("Sorting 12, 15, 6, 87 in descending order:");
            SortValues.SortNumbers(12, 15, 6, 87);

            Console.WriteLine("\nSorting 10, 7, 25, 22, 13 in descending order:");
            SortValues.SortNumbers(10, 7, 25, 22, 13);

            Console.WriteLine("\nSorting 524, 293, 115, 1056, 131, 14 in descending order:");
            SortValues.SortNumbers(524, 293, 115, 1056, 131, 14);

            Console.WriteLine("\nSorting 416, 290, 999, 867 in descending order:");
            SortValues.SortNumbers(416, 290, 999, 867);
        }
    }
}
