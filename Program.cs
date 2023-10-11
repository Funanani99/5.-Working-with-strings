using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_with_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will write same line");
            Console.WriteLine("This will \n wrap to next line");
            Console.WriteLine("This will \" print out the quotation mark.");

            string firstName ="Funi";
            string lastName="Raphulu";

            //concationation
            Console.WriteLine(firstName + " " + lastName);

            //function with strings
            Console.WriteLine(lastName.Length);
            //method on strings
            Console.WriteLine(firstName.ToUpper());
            //method with a parameter eg the contains() its case sensitive
           // Console.WriteLine(lastName.Contains(Ra));
            //access characters using index
            Console.WriteLine(firstName[0]);
            //index of will tell ou if the value is there and at what position
            Console.Write("index of h is ");
            Console.WriteLine(lastName.IndexOf('h'));

            Console.WriteLine(firstName.Substring(1));
            
            Console.WriteLine(firstName.Substring(1, 2));
            Console.ReadLine();


        }
    }
}
