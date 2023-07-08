using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class ArrayList_Demo
    {
        //Its a Non-generic collectiom
        //It is Same as Array except it size increase dynamically
        //it shows the element of multiple data type.
        public void Array_List()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Amit");
            arrayList.Add(3);
            arrayList.Add(" ");
            arrayList.Insert(0, 50);
            arrayList.Insert(1, "car");
            arrayList.Insert(2, 39);
            Console.WriteLine("ForEach Loop");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("For Loop");
            Console.WriteLine("Remove element");
            arrayList.Remove(1);
            arrayList.RemoveAt(1);
            for (var item = 0; item < arrayList.Count; item++)
            {
                Console.WriteLine(arrayList[item]);
            }
            Console.WriteLine("Length of Array list is : "+arrayList.Count);
        }
    }
}
