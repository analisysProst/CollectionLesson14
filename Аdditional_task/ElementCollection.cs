using System;
using System.Collections;

namespace Аdditional_task
{
    class ElementCollection
    {
        public static IEnumerable GetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    yield return array[i];
                }
            }
        }
    }
}
