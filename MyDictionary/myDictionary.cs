using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tkey,Tvalue>
    {
        Tkey[] keys;
        Tvalue[] values;

        public MyDictionary()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }

        public void Add(Tkey key, Tvalue value)
        {
            Tkey[] temp_key = keys;
            Tvalue[] temp_value = values;

            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[values.Length + 1];


            for (int i = 0; i < temp_key.Length; i++)
            {
                keys[i] = temp_key[i];
            }

            for (int j = 0; j < temp_key.Length; j++)
            {
                values[j] = temp_value[j];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }


        public void ShowItems()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " , " + values[i]);
            }
        }



    }
}
