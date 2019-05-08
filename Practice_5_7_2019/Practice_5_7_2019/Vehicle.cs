using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleDataOnly
{
    public class Vehicle
    {
        public string model;
        public string manufacturer;
        public int numofDoors;
        public int numofWheels;
    }
    public class Program
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("Enter the properties of your vehicle");

            //create an instance of Vehicle
            Vehicle myCar = new Vehicle();

            //populate a data member via a temporary variable
            Console.Write("Model name = ");
            myCar.manufacturer = Console.ReadLine();

            //enter the remainder of the data
            //a temp is useful for reading ints.
            Console.Write("Number of doors = ");
            string s = Console.ReadLine();
            myCar.numofDoors = Convert.ToInt32(s);
            Console.Write("Number of wheels = ");
            string t = Console.ReadLine();
            myCar.numofWheels = Convert.ToInt32(t);

            //now display the results
            Console.WriteLine("Your vehicle is a");
            Console.WriteLine(myCar.manufacturer + " " + myCar.model);
            Console.WriteLine("with " + myCar.numofDoors + " doors, " + "riding on " + myCar.numofWheels + " wheels. ");

        }
    }
}
