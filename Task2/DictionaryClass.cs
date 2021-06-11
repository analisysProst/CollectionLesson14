using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class DictionaryClass<TKey, TValue> : IEnumerable<object>, IEnumerator<object>
    {
        public TKey[] key = null;
        public TValue[] value = null;
        public int position = -1;
        public int temp = 0;
                
        //// Конструктор
        //public DictionaryClass(int n)
        //{
        //    key = new TKey[n];
        //    value = new TValue[n];
        //    lenght = n;
        //}
        
        /// Индексатор
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                return "Попытка обращения за пределы массива.";
            }
        }

        // Метод добавления пары ключ-значение в коллекцию
        //public void Add(int i, TKey k, TValue l)
        //{
        //    key[i] = k;
        //    value[i] = l;
        //}
        
        /// Метод добавления пары ключ-значение в коллекцию
        public void Add(TKey k, TValue v)
        {
            this.temp++;

            Array.Resize(ref key, temp);
            key[temp - 1] = k;
            Array.Resize(ref value, temp);
            value[temp - 1] = v;
        }

        /// Метод подсчета общего количества элементов в коллекции
        public int Count
        {
            get
            {
                if (key == null) { return 0; }
                else return key.Length;
            }
        }


        // Реализация интерфейса IEnumerator<T>
        public bool MoveNext()
        {
            if (position < key.Length - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get { return key[position] + " " + value[position]; }
        }

        object IEnumerator.Current
        {
            get { return key[position] + " " + value[position]; }
        }

        // Реализация интерфейса IEnumerable<T>
        public IEnumerator<object> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public void Dispose()
        {
            Reset();
        }
    }
}
