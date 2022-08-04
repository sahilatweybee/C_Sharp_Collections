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
            Console.WriteLine("\n--------------List<T>---------------\n");
            var NamesList = new List<string>();
            NamesList.Add("sahil");
            NamesList.Add("Rishit");
            NamesList.Add("Raj");
            NamesList.Add("Dev");
            NamesList.Add("Jay");
            NamesList.Add("Deep");
            NamesList.Add("Neel");
            NamesList.Add("Karan");
            NamesList.Add("Rutvik");
            NamesList.Add("");

            NamesList.Reverse();
            var NamesList1 = NamesList.AsReadOnly();
            NamesList.Remove("Raj");

            NamesList.Sort();
            Console.WriteLine(NamesList.Count);
            Console.WriteLine(NamesList.Capacity);
            foreach (var item in NamesList) //.ToArray())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--------------HashSet<T>---------------\n");
            var NamesHashSet = new HashSet<String>();

            foreach (var item in NamesList)
            {
                NamesHashSet.Add(item);
            }

            // NamesHashSet.Add("sahil");
            NamesHashSet.Remove("Neel");
            Console.WriteLine(NamesHashSet.Max() + "\n");

            foreach (var item in NamesHashSet)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--------------SortedSet<T>---------------\n");
            var NamesSortedSet = new SortedSet<String>();

            foreach (var item in NamesList)
            {
                NamesSortedSet.Add(item);
            }

            NamesSortedSet.Remove("Karan");
            NamesSortedSet.Add("Raj"); //Append doesn't work
            Console.WriteLine(NamesSortedSet.Count);
            NamesSortedSet.RemoveWhere(x => x == "sahil");

            foreach (var item in NamesSortedSet)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--------------Stack<T>---------------\n");
            Stack<String> NamesStack = new Stack<string>(NamesList);

            //foreach (String item in NamesList)
            //{
            //    NamesStack.Push(item);
            //}

            NamesStack.Pop();
            Console.WriteLine(NamesStack.Equals(NamesList));
            Console.WriteLine(NamesStack.Contains("Rishit"));
            Console.WriteLine(NamesStack.Min());
            Console.WriteLine(NamesStack.GetHashCode());
            Console.WriteLine(NamesStack.Peek() + "\n");

            foreach (String item in NamesStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--------------Queue<T>---------------\n");
            Queue<String> NamesQueue = new Queue<string>();

            foreach (String item in NamesList)
            {
                NamesQueue.Enqueue(item);
            }

            NamesQueue.Dequeue();
            Console.WriteLine(NamesQueue.Peek());
            //Console.WriteLine(NamesQueue.GetHashCode());
            Console.WriteLine(NamesQueue.Contains("Deep") + "\n");

            foreach (String item in NamesQueue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--------------LinkedList<T>---------------\n");
            var NamesLinkedList = new LinkedList<string>(NamesList);

            NamesLinkedList.AddBefore(NamesLinkedList.Find("Neel"), "Ravi");
            NamesLinkedList.RemoveFirst();
            Console.WriteLine(NamesLinkedList.First());
            Console.WriteLine(NamesLinkedList.Last() + "\n");

            foreach (var item in NamesLinkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--------------Dictionary<T, U>---------------\n");

            Dictionary<int, String> NamesDictionary = new Dictionary<int, String>();
            int count = 0;

            foreach (var item in NamesList)
            {
                count++;
                NamesDictionary.Add(count, item);
            }

            Console.WriteLine(NamesDictionary.Count);
            Console.WriteLine(NamesDictionary.Keys);
            Console.WriteLine(NamesDictionary.Values);
            Console.WriteLine(NamesDictionary.Comparer + "\n");


            foreach (var item in NamesDictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--------------SortedDictionary<T, U>---------------\n");
            SortedDictionary<int, String> NamesSortedDictionary = new SortedDictionary<int, String>();
            int cnt = 0;
            NamesList.Sort();
            foreach (var item in NamesList)
            {
                cnt++;
                NamesSortedDictionary.Add(cnt, item);
            }

            NamesSortedDictionary.Remove(3);
            Console.WriteLine(NamesSortedDictionary.Count + "\n");

            foreach (var item in NamesSortedDictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--------------SortedList<T, U>---------------\n");
            SortedList<int, string> NamesSortedList = new SortedList<int, string>(NamesDictionary);

            NamesSortedList.Remove(9);
            NamesSortedList.Remove(8);
            NamesSortedList.Remove(2);
            NamesSortedList.TrimExcess();
            Console.WriteLine(NamesSortedList.Capacity + "\n");

            foreach (var item in NamesSortedList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
