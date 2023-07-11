namespace Collection
{
    public class Program
    {
        //Collection is a class that means we can create an object
        //can be create or declared instance of a class ,so we can add a data in collections
        //collection types - are designed to store ,manage similar data
        //We can used to adding ,remove,find and sorting data in collection
        //two types - Generic and Non-Generic collections
        //Non-generic - arrayList , Hashtable, sortedlist, stack and Queue
        //Generic - List ,dictionary,Sortedlist,stack and queue
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter 1 for List");
                Console.WriteLine("Enter 2 for Array");
                Console.WriteLine("Enter 3 for ArrayList");
                Console.WriteLine("Enter 4 for Dictionary");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        List_Demo list_Demo = new List_Demo();
                        list_Demo.Adding();
                        break;
                    case 2:
                        Array_Demo array_Demo = new Array_Demo();
                        array_Demo.Array_Ops();
                        break;
                    case 3:
                        ArrayList_Demo arrayList = new ArrayList_Demo();
                        arrayList.Array_List();
                        break;
                    case 4:
                        Dictionary_Demo dictionary_Demo = new Dictionary_Demo();
                        dictionary_Demo.Dictionary_Op();
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}