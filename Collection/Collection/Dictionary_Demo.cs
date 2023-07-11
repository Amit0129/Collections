using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    //It is a Generic Collection
    //It will store key value pair.
    //Define under System.Collection.Generic Namespace
    //It is Dyanamic in nature.
    //In Dictionary key can not be null but value can be.
    //The key must be Unique.Duplicate key are not allow.
    //We can store only same data type value.
    public class Dictionary_Demo
    {
        public void Dictionary_Op()
        {
            Dictionary<string,string> strDic = new Dictionary<string,string>();
            strDic.Add("1", "Amit");
            strDic.Add("2", "Kumar");
            strDic.Add("3", "Nayak");
            strDic.Add("4", "Manit");
            strDic.Add("5", "Kumar");
            Console.WriteLine(strDic["3"]);
            Console.WriteLine("Changing a data");
            strDic["2"] = "Ford";
            Console.WriteLine(strDic["2"]);
            Console.WriteLine("Using foreach loop for Printing Dictionary ");
            foreach (KeyValuePair<string,string> item in strDic)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            Console.WriteLine();
            strDic.Remove("1");
            strDic.Clear();
            Console.WriteLine("Using For loop for printing Dictionary");
            for (int i = 0; i < strDic.Count; i++)
            {
                var item = strDic.ElementAt(i);
                Console.WriteLine(item.Key + ":" + item.Value);
            }
        }
    }
}
