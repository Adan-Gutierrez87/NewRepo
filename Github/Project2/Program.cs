using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new dictionary of strings, with string keys.
            //
            Dictionary<int, string> Students = new Dictionary<int, string>();
            /// Adding to a dictionary
           /// Students.Add(1234567, "Adan Gutierrez");
            ///Students.Add(1234567, "Katie Harris");

            //check if a key exist
            if(Students.ContainsKey(1234567))
            {
                Console.WriteLine($"{1234567} already exist");
                Students[1234567] = "Katie";
            }
            else
            {
                Console.WriteLine("key doesnt exist");
            }
            ///Getting a value
            Console.WriteLine(Students[1234567]);

            Console.ReadKey();
        }
    }
}
