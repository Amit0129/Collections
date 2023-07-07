using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    //List<T> class represent the list pf object which can be accesed with index.
    //It is Dynamic, We can resize List.
    public class List_Demo
    {
        //Creating a list of integers.
        List<int> list= new List<int>();
        public void Adding()
        {
            list.Add(1);
            list.Add(2);
            list.Add(3);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Length of the List is " + list.Count);
            Console.WriteLine("Capacity of the List is " + list.Capacity);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Capacity of the List is " + list.Capacity);
            Console.WriteLine("is present " + list.Contains(2));
            Console.WriteLine("================");
            Console.WriteLine("Remove Element" + list.Remove(6));
            list.RemoveAt(0);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Reverse();
            Console.WriteLine("Reverse the list");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sorting List");
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Clear the list");
            list.Clear();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
