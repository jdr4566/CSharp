/*  Programmer : John-David Rodriguez
    Course: ITSE-1430
    Date: 3/27/2022
    IDE: Microsoft Visual Studio
    Description:   8.12 (Duplicate Elimination) Use a one-dimensional array to solve the following problem: Write an app that inputs five numbers, 
                   each between 10 and 100, inclusive. As each number is read, display it only if it’s not a duplicate of a number already read. 
                   Provide for the “worst case,” in which all five numbers are different. 
                   Use the smallest possible array to solve this problem. Display the complete set of unique values input after the user inputs each new value.
*/

using System;
using System.Linq;

namespace Module_08_Assignment_Rodriguez
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            for (int i = 0; i < 5; i++) //create an for loop to accept input into the array of numbers
            {
                Console.WriteLine("Enter a number between 10 to 100");
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            var result = arr.Distinct();
            Console.WriteLine("The distinct values are ");      
            foreach (int value in result)           //output the distinct values
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}