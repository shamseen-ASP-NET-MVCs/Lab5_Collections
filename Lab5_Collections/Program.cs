using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab5_Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n-------------------LIST OF PERSON OBJECTS--------------------");
            makeListOfPeople();

            Console.WriteLine("\n-------------------DICT OF PRODUCT OBJECTS-------------------");
            makeDictOfProducts();

        }

        static void makeListOfPeople()
        {
            List<Person> people = new List<Person>();
            string fullName = "";

            //defining variable that represents text file 
            StreamReader inFile = new StreamReader("ListOfNames.txt");

            //looping through lines of file, reading, then adding to list
            while (inFile.Peek() != -1)
            {
                fullName = inFile.ReadLine();      //reading whole line with full name
                people.Add(new Person(fullName));  //adding person with whole name
            }

            //printing each person's name from list
            for (int i = 0; i < people.Count; i++)
            {
                Console.Write(i + 1 + "   ");
                people[i].printFullName();
            }

            inFile.Close();
        }

        static void makeDictOfProducts()
        {
            Product p;
            Dictionary<string, Product> catalogue = new Dictionary<string, Product>();
            string[] line = new string[4];

            //defining variable that represents text file 
            StreamReader inFile = new StreamReader("ProductCatalogue.txt");
            //format: Name/Key---Description---Manufacturer---Cost

            //looping through, parsing line into array of strings, making product, adding to dict
            while (inFile.Peek() != -1)
            {
                line = inFile.ReadLine().Split(new string[] { "---" }, StringSplitOptions.None);
                //setting delimiter to string of "---"
                p = new Product(line);
                catalogue.Add(line[0], p);
            }

            //printing every item just to check it's working
            foreach (KeyValuePair<string, Product> item in catalogue)
            {
                Console.WriteLine("\n*************** Key: '{0}' ****************", item.Key);
                item.Value.printEverything();
            }

            inFile.Close();
        }

    }
}
