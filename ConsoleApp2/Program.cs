using System;
using System.Collections;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCollection myCollection = new UserCollection();

            foreach(Element element in myCollection) 
            {
                Console.WriteLine("Name: {0} Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }

            //myCollection.Reset();

            Console.Write(new string('-', 29) + "\n");

            foreach(Element element in myCollection)
            {
                Console.WriteLine("Name: {0} Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }
            Console.Write(new string('-', 29) + "\n");



            /****************************************/
            // Так работает foreach

            UserCollection myElementCollection = new UserCollection();
            IEnumerable enumerable = myElementCollection as IEnumerable;
            IEnumerator enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Element element = enumerator.Current as Element;

                Console.WriteLine("Name: {0} Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }

            enumerator.Reset();

            Console.ReadKey();

        }
    }
}
