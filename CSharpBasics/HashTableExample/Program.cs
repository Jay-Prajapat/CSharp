using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable h1 = new Hashtable();
            h1.Add("Name", "Jay");
            h1.Add("Age", 21);
            h1.Add("Location", "Ahemadabad");
            Console.WriteLine("Value of h1");

            foreach (DictionaryEntry element in h1)
            {
                Console.WriteLine($"{element.Key} : {element.Value}");
            }

            Hashtable h2 = (Hashtable)h1.Clone();
            Console.WriteLine("Value of h2");
            foreach (DictionaryEntry element in h2)
            {
                Console.WriteLine($"{element.Key} : {element.Value}");
            }

            h1["Name"] = "Jayesh";
            Console.WriteLine("Value of h1 after update");
            foreach (DictionaryEntry element in h1)
            {
                Console.WriteLine($"{element.Key} : {element.Value}");
            }
            Console.WriteLine("Value of h2");
            foreach (DictionaryEntry element in h2)
            {
                Console.WriteLine($"{element.Key} : {element.Value}");
            }

            var key = h1.Keys;
        }
    }
}
