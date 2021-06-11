/*Создайте класс Dictionary<TKey, TValue>. Реализуйте в простейшем приближении возможность 
 * использования его экземпляра аналогично экземпляру класса Dictionary<TKey, TValue>. 
 * Минимально требуемый интерфейс взаимодействия с экземпляром, 
 * должен включать метод добавления элемента, индексатор для получения 
 * значения элемента по указанному индексу и свойство только для чтения 
 * для получения общего количества элементов.
 Реализуйте возможность перебора элементов коллекции в цикле foreach*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //параметризированный класс Т (указатель места заполнения типа)
    class MyDictionaryClass<TKey, TValue>
    {
        public TKey[] keys = null; // массив ключей
        public TValue[] values = null;// массив значений
        public int temp = 0;

        // метод для добавления элемента
        public void Add(TKey key, TValue value)
        {
            if(keys == null)
                keys = new TKey[1];

            if (values == null)
                values = new TValue[1];

            if (keys.Length == temp)
                Array.Resize(ref keys, keys.Length + 1);
            keys[temp] = key;

            if(values.Length == temp)
                Array.Resize(ref values, values.Length + 1);
            values[temp] = value;

            this.temp++;

        }

        // индексатор для получения значения элемента по указаному индексу (ключу)
        // индексаторы друг от друга отличаются типом или количеством индексов
        public TValue this[TKey key]
        {
            get
            {
                
            }
        }

        //метод для получения общего количества элементов
        public int Count
        {
            get
            {
                if (keys == null) { return 0; }
                else return keys.Length;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaryClass<int, int> dict = new MyDictionaryClass<int, int>();
            Console.WriteLine("My dictionary: " + dict.Count);
            dict.Add(5, 10);
            Console.WriteLine("My dictionary: " + dict.Count);
            Console.WriteLine("Element[0]: " + dict[0]);
            dict.Add(9, 11);
            Console.WriteLine("My dictionary: " + dict.Count);
            Console.WriteLine("Element[1]: " + dict[1]);

            //// Получить коллекцию ключей
            //ICollection<int> keys = dict.keys;

            //foreach (int j in keys)
            //    Console.WriteLine("Key -> {0}  Value -> {1}", j, dict[j]);

        }
    }
}
