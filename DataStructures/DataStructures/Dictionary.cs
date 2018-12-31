using System;

namespace DataStructures
{
    public class Dictionary<TKey, TValue>
    {
        private const int _defaultCapacity = 4;

        private object[] myObject;

        public Dictionary()
        {
            myObject = new object[_defaultCapacity];
        }

        public void Add(TKey key, TValue value)
        {
            grow();
            myObject[GetHashPosition(key)] = value;
        }

        private void grow()
        {
            throw new NotImplementedException();
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
