using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class QueueType<T> : Queue<T>
    {
        Queue<T> collection;
        public QueueType()
        {
            collection = new Queue<T>();
        }
        new public void Enqueue(T item) => collection.Enqueue(item);
        public void Display()
        {
            foreach (var elem in collection)
                Console.WriteLine(elem);
        }
        new public int Count => collection.Count;
        new public bool Contains(T elem) => collection.Contains(elem);
    }
}
