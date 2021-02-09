using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K, T>
    {
        K[] keys;
        T[] items;

        public MyDictionary()
        {
            keys = new K[0];
            items = new T[0];
        }

        public void Add(K key, T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
            K[] tempArray2 = keys;
            keys = new K[keys.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                keys[i] = tempArray2[i];
            }

            keys[keys.Length - 1] = key;

        }

    }

}