using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_5_7_2019
{
    class Collections
    {
        //simple array syntax
        double[] doublesArray = { 5, 2, 7, 3.5, 6.5, 8, 1, 9, 1, 3 }; //the array's element numbers are the index

        //accumulate the values in the array into the variable sum.
        double sum = 0;
        for (int i = 0; i< 10; i++)
            {
            sum = sum + doublesArray[i];
            }
    
        //accumulate the values into an array
        for (int i = 0; i<numElements; i++)
        {
            .....
        }

        //preferable way to accumulate the values into an array
        for (int i = 0; i < doublesArray.Length; i++)
        {
            .....
        }

        


        double[] doublesArray1 = new double[6];   //this allocates space for 6 doubles but doesn't initialize them

        doublesArray[0] //corresponds to d0 (that is, 5)
        doublesArray[1] //corresponds to d1 (that is, 2)

        //list syntax
        List<int> intList = new List<int>();

        List<MP3> myMP3s = new List<MP3>();    //an empty list
        myMP3s.Add(new MP3("Avril Lavigne");   //add an MP3 to the list

//instantiate for string type

    List<string> nameList = new List<string>();
    nameList.Add("one");
    nameList.Add("two");
    nameList.Add("three");
    Console.WriteLine("Printing nameList:" );
    foreach(string i in nameList)
    {
        Console.WriteLine("string i = " + i);
    }
}
    
