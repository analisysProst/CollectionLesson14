using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string element in UserCollection.Power())
                Console.WriteLine(element);

            Console.ReadLine();
        }
    }
}
