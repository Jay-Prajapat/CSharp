using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListEXample
{
    public class Employee
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(100);
            arrayList.Add("jay");
            arrayList.Add(true);
            arrayList.Add(null);
            arrayList.Add(50);
            foreach (var arrlst in arrayList)
            {
                Console.WriteLine(arrlst);
            }
            arrayList.Insert(2, 300);
            arrayList.Remove(50);
            arrayList.RemoveAt(2);
            arrayList.RemoveRange(0, 2);
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);

            }
            arrayList.Clear();

            string[] arr = { "hi", "hello" };
            Console.WriteLine(arr);

            Employee employee = new Employee();

            var type = typeof(Employee);
            if (typeof(Employee) == employee.GetType())
            {
                Console.WriteLine(type);
                Console.WriteLine(employee.GetType());
                Console.WriteLine("true");

            }

            ArrayList arr1 = new ArrayList();
            arr1.Add(1);
            arr1.Add("hi");
            arr1.Add(2);
            Console.WriteLine("---------------------------------");

            foreach (var arrElement in arr1)
            {
                Console.WriteLine(arrElement);
            }
            Console.WriteLine("---------------------------------");


            ArrayList arr2 = (ArrayList)arr1.Clone();
            foreach (var arrElement in arr2)
            {
                Console.WriteLine(arrElement);
            }
            Console.WriteLine("---------------------------------");

            arr2.Add("hello");
            foreach (var arrElement in arr1)
            {
                Console.WriteLine(arrElement);
            }
            Console.WriteLine("---------------------------------");

            foreach (var arrElement in arr2)
            {
                Console.WriteLine(arrElement);
            }
            Console.WriteLine("---------------------------------");

            arr1[1] = "hello world";
            foreach (var arrElement in arr1)
            {
                Console.WriteLine(arrElement);
            }
            Console.WriteLine("---------------------------------");

            foreach (var arrElement in arr2)
            {
                Console.WriteLine(arrElement);
            }

            // ArrayList l1 = null;
            //arr1.InsertRange(2, l1); give runtime error 
            Stack st = new Stack();
            st.Push(12);
            st.Push(1);
            Console.WriteLine(st.Peek());
            SortedList<int,string> sl = new SortedList<int,string>();
            sl.Add(1, "abc");
            sl.Add(2, "abc");
            sl.Add(5, "pqr");
            sl.Add(4, "sd");
            sl.Add(3, null);
            foreach(var item in sl)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            SortedDictionary<int, string> sd = new SortedDictionary<int, string>();
            sd.Add(1, "abd");
            sd.Add(2, "abd");
            sd.Add(3, null);
            sd.Add(4, "pqr");
            sd.Add(5, "fgh");
            Console.WriteLine("-----------------");
            foreach(var item in sd)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            HashSet<int> hs = new HashSet<int>();
            hs.Add(2);
            hs.Add(3);
            hs.Add(1);
            hs.Add(1);
            hs.Add(5);

            Console.WriteLine("-------------");
            foreach(int item in hs)
            {
                Console.WriteLine(item);
            }

        }
    }
}
