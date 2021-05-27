/*Создайте класс MyList<T>. Реализуйте в простейшем приближении возможность 
 * использования его экземпляра аналогично экземпляру класса List<T>. 
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

namespace Task1
{
    //параметризированный класс Т (указатель места заполнения типа)
    class MyClass<T>
    {
        public T[] array;
        public int temp = 0;

        // метод для добавления элемента
        public void Add(T value)
        {
            if (array == null)
            {
                array = new T[1];
            }
            if (array.Length == temp)
                Array.Resize(ref array, array.Length + 1);
            array[temp] = value;
            temp++;

        }

        // индексатор для получения значения элемента по указаному индексу
        // имя индексатора заменено на this, индексаторы не имеют имен
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length) { return array[index]; }
                else throw new NotImplementedException();
            }
            set
            {
                if (index >= 0 && index < array.Length) { array[index] = value; }
                else throw new NotImplementedException();
            }
        }

        //метод для получения общего количества элементов
        public int Count
        {
            get
            {
                if (array == null) { return 0; }
                else return array.Length;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //создаем экземпляр класса MyClass и в качестве параметра типа передаем тип int
            MyClass<int> array = new MyClass<int>();
            int count = array.Count;
            Console.WriteLine("My collection: " + count);
            array.Add(4);
            int count1 = array.Count;
            Console.WriteLine("My collection: " + count1);
            Console.WriteLine("Element[0]: " + array[0]);
            array.Add(3);
            int count2 = array.Count;
            Console.WriteLine("My collection: " + count2);
            Console.WriteLine("Element[0]: " + array[0]);
            Console.WriteLine("Element[1]: " + array[1]);
        }
    }
}
