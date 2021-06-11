/*Создайте класс Dictionary<TKey, TValue>. Реализуйте в простейшем приближении возможность 
 * использования его экземпляра аналогично экземпляру класса Dictionary<TKey, TValue>. 
 * Минимально требуемый интерфейс взаимодействия с экземпляром, 
 * должен включать метод добавления элемента, индексатор для получения 
 * значения элемента по указанному индексу и свойство только для чтения 
 * для получения общего количества элементов.
 Реализуйте возможность перебора элементов коллекции в цикле foreach*/

using System;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DictionaryClass<int, int> dictionary = new DictionaryClass<int,int>();
            Console.WriteLine("My dictionary: " + dictionary.Count);
            dictionary.Add(1, 6);
            Console.WriteLine("My dictionary: " + dictionary.Count);
            dictionary.Add(5, 3);
            Console.WriteLine("My dictionary: " + dictionary.Count);
            dictionary.Add(2, 4);
            Console.WriteLine("My dictionary: " + dictionary.Count);

            Console.WriteLine("Element[0]: " + dictionary[0]);
            Console.WriteLine("Element[1]: " + dictionary[1]);
            Console.WriteLine("Element[2]: " + dictionary[2]);



            Console.ReadKey();
        }
    }
}
