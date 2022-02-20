/*  Programmer : John-David Rodriguez
    Course: ITSE-1430
    Date: 2/12/2022
    IDE: Microsoft Visual Studio
    Description:   Create an app that compares two integers inputted by a user
*/


using System;

namespace Module_03_Assignment_Rodriguez
{
    class Compare
    {
        static void Main()
        {   
            //Ask user for first integer
            Console.Write("This program will compare two integers\n\n\t");
            Console.Write("Please enter the first integer: \n");
            int number1 = int.Parse(Console.ReadLine());


            //Ask user for second integer
            Console.Write("\tNow enter the second integer: \n");
            int number2 = int.Parse(Console.ReadLine());

            //if statement to display "is larger"
            if (number1 > number2)
            {
                Console.Write($"\n{number1} The First Integer Is Larger than the second integer {number2}\n");
            }
            //if statement to display "is larger"
            if (number2 > number1)
            {
                Console.Write($"\n{number2} The Second Integer Is Larger than the first integer {number1}\n");
            }
            //if statement to display "these numbers are equal"
            if (number1 == number2)
            {
                Console.Write($"\n{number1} these numbers are equal {number2}\n");
            }
            //first if statement checking if number is ==
            if (number1 == number2)
            {
                Console.Write($"\n{number1} == {number2}\n");
            }
            //second if statement checking if number is !=
            if (number1 != number2)
            {
                Console.Write($"\n{number1} != {number2}\n");
            }
            //third if statement checking if number is <
            if (number1 <  number2)
            {
                Console.Write($"\n{number1} < {number2}\n");
            }
            //fourth if statement checking if number is >
            if (number1 > number2)
            {
                Console.Write($"\n{number1} > {number2}\n");
            }
            //fifth if statement checking if number is <=
            if (number1 <= number2)
            {
                Console.Write($"\n{number1} <= {number2}\n");
            }
            //sixth if statement checking if number is >=
            if (number1 >= number2)
            {
                Console.Write($"\n{number1} >= {number2}\n");
            }

        }
    }   //end main program
}       //end the class Compare
