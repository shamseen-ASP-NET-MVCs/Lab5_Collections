using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Collections
{
    class Product
    {
        string name;
        string description;
        string manufacturer;
        double cost;

        public Product(string [] line)
        {
            name = line[0];
            description = line[1];
            manufacturer = line[2];
            cost = Double.Parse(line[3]);
        }

        public void printEverything()
        {
            Console.WriteLine("--Name: {3} \n--Cost: {0:C} \n--Desc: {1} \n--Manufacturer: {2}", 
                cost, description, manufacturer, name);
        }

    }
}
