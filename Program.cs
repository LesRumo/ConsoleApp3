using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "Lesedi";
            string lastName = "Shirami";

            Console.WriteLine(name + " " + lastName);

            //function with strings
            Console.WriteLine(lastName.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(lastName.Contains("Sh"));
            Console.WriteLine(name[0]);
            Console.WriteLine("index of a is");
            Console.WriteLine(lastName.IndexOf('a'));
            Console.WriteLine(name.Substring(1));
            Console.WriteLine(name.Substring(0,2));
            
            Console.ReadLine();
        }
    }
}
