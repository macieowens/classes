using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Car myCar = new Car();
            myCar.Make = "Tesla";
            myCar.Model = "Plaid";
            myCar.Year = 2022;

            var chevy = new Car("Chevy", "Impala", 2002);

            var carList = new List<Car>() { myCar, chevy, new Car(), new Car() };

            Console.WriteLine(carList.Capacity);
        }
    }
}
