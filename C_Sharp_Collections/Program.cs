using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\n--------------List---------------\n");
            var NamesList = new List<String>();
            NamesList.Add("sahil");
            NamesList.Add("Rishit");
            NamesList.Add("Raj");
            NamesList.Add("Dev");
            NamesList.Add("Jay");
            NamesList.Add("Deep");
            NamesList.Add("Neel");
            NamesList.Add("Karan");
            NamesList.Add("Rutvik");

            NamesList.Reverse();
            NamesList.Remove("Raj");
            //NamesList.Sort();

            //Console.WriteLine(NamesList.Count);
            //Console.WriteLine(NamesList.Capacity);
            //foreach (var item in NamesList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("\n--------------HashSet---------------\n");
            //var NamesHashSet = new HashSet<String>();

            //foreach (var item in NamesList)
            //{
            //    NamesHashSet.Add(item);
            //}

            //// NamesHashSet.Add("sahil");
            //NamesHashSet.Remove("Neel");
            //Console.WriteLine(NamesHashSet.Max() + "\n");

            //foreach (var item in NamesHashSet)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("\n--------------SortedSet---------------\n");
            //var NamesSortedSet = new SortedSet<String>();

            //foreach (var item in NamesList)
            //{
            //    NamesSortedSet.Add(item);
            //}

            //NamesSortedSet.Remove("Karan");

            //foreach (var item in NamesSortedSet)
            //{
            //    Console.WriteLine(item); 
            //}

            Console.WriteLine("\n--------------Stack---------------\n");
            Stack<String> NamesStack = new Stack<string>();

            foreach (String item in NamesList)
            {
                NamesStack.Push(item);
            }

            NamesStack.Pop();
            Console.WriteLine(NamesStack.Min());
            Console.WriteLine(NamesStack.GetHashCode());
            Console.WriteLine(NamesStack.Peek() + "\n");

            foreach (String item in NamesStack)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
