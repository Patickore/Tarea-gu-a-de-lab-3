using System;

namespace App3
{
    internal class List<T>
    {
        public int Count { get; internal set; }
        public int Capacity { get; internal set; }

        internal void Add(string v)
        {
            throw new NotImplementedException();
        }

        internal void RemoveRange(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        internal void Insert(int v1, string v2)
        {
            throw new NotImplementedException();
        }

        internal void Clear()
        {
            throw new NotImplementedException();
        }
    }
}