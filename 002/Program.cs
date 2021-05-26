using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable enumerl = UserCollection.Power();
            foreach (string element in enumerl)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(new string('-', 12));


            IEnumerable enumerable = UserCollection.Power();
            IEnumerator enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                String element = enumerator.Current as String;

                Console.WriteLine(element);
            }

            Console.ReadKey();
        }
    }
}
