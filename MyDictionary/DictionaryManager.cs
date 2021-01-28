using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class DictionaryManager<T, D>
    {
        T[] keys;
        D[] values;

        T[] tempArrayKeys;
        D[] tempArrayValues;
        
        public DictionaryManager()
        {
            keys = new T[0];
            values = new D[0];
        }

        public void Add(T key, D value)
        {
            tempArrayKeys = keys;
            tempArrayValues = values;

            keys = new T[keys.Length + 1];
            values = new D[values.Length + 1];

            for (int i = 0; i <tempArrayKeys.Length; i++)
            {
                keys[i] = tempArrayKeys[i];
            }
            for (int a = 0; a < tempArrayValues.Length; a++)
            {
                values[a] = tempArrayValues[a];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;


        }
        
        public void ShowAll()
        {
            for (int i = 0; i <keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " = " + values[i]);
            }
        }
    }
}
