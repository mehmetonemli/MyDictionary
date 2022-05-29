using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];

        }

        public void Add(K key,V value)
        {
            K[] tempkey = keys;
            keys = new K[keys.Length + 1];
            for (int i = 0; i < tempkey.Length; i++)
            {
                keys[i] = tempkey[i];
            }
            keys[keys.Length - 1] = key;


            V[] tempvalue = values;
            values = new V[values.Length + 1];
            for (int i = 0; i < tempvalue.Length; i++)
            {
                values[i] = tempvalue[i];
            }
            values[values.Length - 1] = value;


        }

        public K[] Key { get { return keys; } }

        public V[] Value { get { return values; } }
    }
}
