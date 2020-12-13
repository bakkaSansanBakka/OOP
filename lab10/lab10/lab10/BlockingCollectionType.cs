using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class BlockingCollectionType<T> : BlockingCollection<T>
    {
        BlockingCollection<T> collection;
        public BlockingCollectionType()
        {
            collection = new BlockingCollection<T>();
        }
        new public void Add(T item) => collection.Add(item);

        public void Display()
        {
            foreach (T elem in collection)
                Console.WriteLine(elem);
        }
        new public T Take()
        {
            T elemOut = collection.Take();
            return elemOut;
        }
        new public int Count => collection.Count;
        public IEnumerable<T> GetConsumingEnumerable() => collection.GetConsumingEnumerable();
    }
}
