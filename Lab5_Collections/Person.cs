using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Collections
{
    class Person
    {
        string firstName;
        string lastName;

        //public properties with get and set functions
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //constructor with default parameters ==> serves as default and overloaded
        public Person(string name = "[name]") //assuming new person will be added w 1 str
        {
            string[] full = name.Split();
            firstName = full[0];
            lastName = full[1];
        }

        public void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        

        
    }
}
