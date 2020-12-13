using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class ObservableCollection<T>
    {
        public delegate void EventHandler(string message);
        public event EventHandler CollectionChanged;

        List<T> list;
        public T this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
        public ObservableCollection()
        {
            list = new List<T>();
        }

        public void Add(T newEl)
        {
            list.Add(newEl);
            CollectionChanged?.Invoke($"Добавлен элемент: {newEl}");
        }
        public void Remove(T newEl)
        {
            list.Remove(newEl);
            CollectionChanged?.Invoke($"Удален элемент: {newEl}");
        }
    }
}
