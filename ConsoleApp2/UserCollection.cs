using System;
using System.Collections;

namespace ConsoleApp2
{
    class UserCollection : IEnumerable, IEnumerator
    {
        public Element[] elementsArray = null;

        public UserCollection()
        {
            elementsArray = new Element[4];
            elementsArray[0] = new Element("A", 1, 10);
            elementsArray[1] = new Element("B", 2, 20);
            elementsArray[2] = new Element("C", 3, 30);
            elementsArray[3] = new Element("D", 4, 40);
        }

        // указатель текущей позиции элемента в массиве
        int position = -1;

        // реализация интерфейса IEnumerator

        // Передвинуть внутренний указатель position на одну позицию
        public bool MoveNext()
        {
            if (position < elementsArray.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        // сбрасываем позицию, устанавливаем перед началом набора
        public void Reset()
        {
            position = -1;
        }

        // возвращает текущий элемент набора
        public object Current
        {
            get { return elementsArray[position]; }
        }

        // реализация интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
    }
}
