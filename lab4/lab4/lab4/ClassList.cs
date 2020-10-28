using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public partial class List
    {
        private int[] container;
        private int size;
        private int capacity;
        // конструктор
        public List(int initialCapacity = 0)
        {
            capacity = initialCapacity;
            container = new int[initialCapacity];
        }

        // индексатор
        public int this[int index]
        {
            get => container[index];
            set => container[index] = value;
        }

        // свойства

        public int Size
        {
            get => size;
            set
            {
                if (size == capacity)
                {
                    capacity++;
                    Array.Resize(ref container, capacity);
                }
            }
        }

        public int[] GetContainer() => container;

        // методы
        public void Add(int elem)   //добавить элемент в конец
        {
            if (size == capacity)
            {
                capacity++;
                Array.Resize(ref container, capacity);

            }
            container[size] = elem;
            size++;
        }
        public void Remove()    // удаление с конца списка
        {
            if (size == 0)
            {
                Console.WriteLine("Список не содержит элементов");
            }
            else
            {
                size--;
                Array.Resize(ref container, container.Length - 1);
            }
        }
        public void Prepend(int elem)   //вспомогательный метод по вставке элемента в начало списка
        {
            int[] newContainer = new int[size + 1];
            newContainer[0] = elem;
            Array.Copy(container, 0, newContainer, 1, size);
            container = newContainer;
            size++;
        }
        public override bool Equals(object obj)
        {
            if (obj is List list)
            {
                return container.Equals(list.container);
            }
            else
            {
                return false;
            }
        }
        public int indexOf(int elem) => Array.IndexOf(container, elem); //индекс элемента списка

        //перегрузка операторов 
        public static List operator +(int item, List list)  //добавление в начало списка
        {
            list.Prepend(item);
            return list;
        }
        public static List operator --(List list)   //удаление первого элемента из списка
        {
            Array.Copy(list.container, 1, list.container, 0, list.Size - 1);
            list.size--;
            return list;
        }
        public static bool operator ==(List list1, List list2) => list1.Equals(list2);
        public static bool operator !=(List list1, List list2) => !(list1 == list2);
        public static List operator *(List list1, List list2)   //объединение двух списков
        {
            for (int i = 0; i < list2.container.Length; i++)
            {
                list1.Add(list2.container[i]);
            }
            return list1;
        }
        public void ListPrint() // вывод списка
        {
            for(int i = 0; i < container.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {container[i]}");
            }
        }
    }
}
