using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Dict<K, V>
    {
        List<K> keys = new List<K>();
        public K Get<K>(K key)
        {
            foreach (var item in keys)
            {
                if (item.Equals(key))
                {
                    return key;
                }
            }
            throw new Exception("Key not found.");
        }
        void Put<K,V>(K key, V value)
        {

        }
    }
}
