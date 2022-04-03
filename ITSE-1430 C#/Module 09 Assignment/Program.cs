/*  Programmer : John-David Rodriguez
    Course: ITSE-1430
    Date: 4/2/2022
    IDE: Microsoft Visual Studio
    Description:   9.5 (Sorting Letters and Removing Duplicates) Write a console app that inserts 30 random letters into a List<char>. 
                   Perform the following queries on the List and display your results: 
                   [Hint: Strings can be indexed like arrays to access a character at a specific index.]

                    A.Use LINQ to sort the List in ascending order.

                    B.Use LINQ to sort the List in descending order.

                    C.Display the List in ascending order with duplicates removed.
*/

using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Module_09_Assignment_Rodriguez
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> letters = new List<char>();  //create list
            Random rand = new Random();
            char letter = ' ';

            //creating random letters
            for(int i=0; i<30; i++)
            {
                letter = (char)rand.Next(65, 91);
                letters.Add(letter);
            }
            //output elements
            Console.WriteLine("Original List Of 30 Random Letters: \n");
            foreach (var element in letters)
            Console.Write(element + " ");
            Console.WriteLine();

            //sort letters in ascending order
            var order = from it in letters
                        orderby it ascending
                        select it;
            Console.WriteLine("\n***********************************************************");
            Console.WriteLine("List In Ascending Order: \n");
            foreach (var e in order)
            Console.Write(e + " ");
            Console.WriteLine();

            //now sort in descending order
            var order2 = from it in letters
                         orderby it descending
                         select it;
            Console.WriteLine("\n***********************************************************");
            Console.WriteLine("List In Descending Order: \n");
            foreach (var e in order2)
            Console.Write(e + " ");
            Console.WriteLine();

            //get rid of duplicates
            var order3 = (from it in letters
                          orderby it ascending
                          select it).Distinct();
            //output updated list
            Console.WriteLine("\n***********************************************************");
            Console.WriteLine("List With Duplicates Removed: \n");
            foreach (var e in order3)
            Console.Write(e + " ");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
