using System;

namespace DataStructures
{
    public class Dictionary<TKey, TValue>
    {
        private object[] myObject;

        public Dictionary(int size)
        {
            myObject = new object[size];
        }

        public void Add(TKey key, TValue value)
        {
            myObject[GetHashPosition(key)] = value;
        }

        public void Contains(TKey key)
        {

        }

        public int GetHashPosition(TKey key)
        {
            return key.GetHashCode() % 1000;
        }

    }
}
