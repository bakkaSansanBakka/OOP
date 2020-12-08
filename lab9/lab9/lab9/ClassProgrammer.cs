using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public delegate void EventHandler(int index);
    public delegate void LambdaHandler();

    class ClassProgrammer
    {
        public event EventHandler Delete;
        public event EventHandler Mutate;
        
        public void DeleteItem(int index) => Delete?.Invoke(index);
        public void ChangeList(int index) => Mutate?.Invoke(index);

    }
    class List : IList<string>
    {
        List<string> list = new List<string>();

        
        public string this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }

        public void ChangeRandomItem(int index) => this[index] = this[new Random().Next(Count)];
        public void DisplayList(int index)
        {
            Console.WriteLine("Вывод списка~~~");
            foreach (string str in list)
                Console.WriteLine(str);
        }

        public int Count => list.Count;
        public bool IsReadOnly => ((ICollection<string>)list).IsReadOnly;

        public int IndexOf(string item) => list.IndexOf(item);
        public void Insert(int index, string item) => list.Insert(index, item);
        public void RemoveAt(int index) => list.RemoveAt(index);
        public void Add(string item) => list.Add(item);
        public void Clear() => list.Clear();
        public bool Contains(string item) => list.Contains(item);
        public void CopyTo(string[] array, int arrayIndex) => list.CopyTo(array, arrayIndex);
        public bool Remove(string item) => list.Remove(item);
        public IEnumerator<string> GetEnumerator() => ((IEnumerable<string>)list).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => list.GetEnumerator();
        
    }
}
