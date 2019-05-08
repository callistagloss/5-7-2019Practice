using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Practice_5_7_2019
{
    class Program
    {
        private static object name;

        static void Main(string[] args)
        {
            //help with strings
            //strings are treated like user-defined classes

            //string s = "This is a phrase." + " So is this.";
            //Console.WriteLine(s);
            //Console.WriteLine();

            //string s2 = "abcd";
            //int lengthofString = s2.Length;

            //string name = "Randy";
            //Console.WriteLine("His name is " + name); // + means concatenate
            //Console.WriteLine();

            //don't forget about built in String methods, i.e. String.Compare();


            //distinguishing between uppercase and lowercase strings

            //switch (line)
            //{
            //    case "EXIT":
            //    case "exit":
            //    case "QUIT":
            //    case "quit":
            //        return true;
            //}
            //return false;

            //string lowcase = "armadillo";
            //string upcase = lowcase.ToUpper();
            //Console.WriteLine(upcase);
            //Console.WriteLine();

            //string favoriteFood = "crab rangoon";
            //foreach (char c in favoriteFood)
            //{
            //    Console.WriteLine(c); //prints all characters to the console on a separate line b/c of WriteLine
            //}
            //Console.WriteLine();

            ////finding a string, not sure why it's not printing 3 

            //int indexofLetterA = favoriteFood.IndexOf('a');
            //Console.WriteLine(indexofLetterA);
            //Console.WriteLine();

            //parsing

            //string s1 = Console.ReadLine();
            //int n = Convert.ToInt32(s1);
            //Console.WriteLine(s1);
            //Console.WriteLine();

            //using Trim() and Pad() methods

            List<string> names = new List<string> { "Chewy   ",
                                                    "Licky   ",
                                                    "Han Solo",
                                                    "Leia    " };
            //first output the names as they start out

            Console.WriteLine("The following names are of "
                              + "different lengths");

            foreach (string m in names)
            {
                Console.WriteLine("This is the name ' " + m + " ' before");
            }
            Console.WriteLine();

            List<string> stringsToAlign = new List<string>();

            for (int i = 0; i < names.Count; i++)
            {
                string trimmedName = names[i].Trim();     //left justified and trimmed
                stringsToAlign.Add(trimmedName);
                Console.WriteLine(names[i].Trim());
            }
            Console.WriteLine();
            //formatting strings precisely

            string myString = String.Format("{0} times {1} equals {2}", 2, 5, 2 * 5);
            Console.WriteLine(myString);












            Console.ReadKey();

        }
            
        
    }
}
