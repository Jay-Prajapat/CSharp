using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(112, "Jay");
            dic.Add(115, "Om");
            dic.Add(132, "Aum");

            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine($" key: {item.Key}, Value:{item.Value}");
            }
            int[] array = { 10, 20, 30, 65, 50, 45 };
            //array.GetLength();

            List<int> list = array.ToList();
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");
            Hashtable h = new Hashtable();
            h.Add(1, 1);
            h.Add(2, null);
            h.Add(4, 2);
            h.Add(3, "ss");
            Console.WriteLine("-------------HashTable-----------------");
            foreach(DictionaryEntry item in h)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine("-----------------------");

            Dictionary<int, string> dic2 = new Dictionary<int, string>(dic);

            foreach (KeyValuePair<int, string> item in dic2)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            dic2.Add(4, "Ram");
            Console.WriteLine("-----------------");
            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine($" key: {item.Key}, Value:{item.Value}");
            }
            Console.WriteLine("---------------");
            foreach (KeyValuePair<int, string> item in dic2)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
       
       

    }
}
