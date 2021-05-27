/*Создайте метод, который в качестве аргумента принимает массив 
 * целых чисел и возвращает коллекцию всех четных чисел массива. 
 * Для формирования коллекции используйте оператор yield.  */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Аdditional_task
{
    class Program
    {
        static void Main(string[] args)
        {  
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            IEnumerable enumerable = ElementCollection.GetArray(array);

            foreach(var item in enumerable)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
