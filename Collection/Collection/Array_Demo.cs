using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    //Arry is a collection of same data type.
    //Array Index Start with Zero.
    //We can store Only fix set of element in Array.

    public class Array_Demo
    {
        public void Array_Ops() 
        {
            int[] myArr = new int[5];
            string[] strArr = new string[5];
            int[] intArr2 = new int[] { 1, 2, 3 };
            int[] ints = { 1, 2, 3, 4 };

            string[] strArrOne = new string[5] { "Am", "it", "ku", "ma", "r" };
            foreach (var item in strArrOne)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("For loop");
            for (int val = 0; val < strArrOne.Length; val++)
            {
                Console.WriteLine(strArrOne[val]);
            }
            Console.WriteLine("While Condition");
            int value = 0;
            while (value < strArrOne.Length)
            {
                Console.WriteLine(strArrOne[value]);
                value++;
            }

            string[] strArrTwo = new string[] { "Am", "it", "ku", "ma" };
        }
    }
}
