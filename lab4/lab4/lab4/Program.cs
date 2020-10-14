using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{   //объединение двух списков через *
    public class List
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
                    capacity *= 2;
                    Array.Resize(ref container, capacity);
                }
            }
        }

        // методы
        public void Add(int elem)   //добавить элемент в конец
        {
            if (size == capacity)
            {
                capacity *= 2;
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
        /*public static List operator *(List list1, List list2)   //объединение двух списков
        {
            for (int i = 0; i < list2.container.Length; i++)
            {
                list1.Add(list2.container[i]);
            }
            return list1;
        }*/
        /*public static List operator *(List list1, List list2)   //объединение двух списков
        {
            /*int[] newContainer = new int[list1.size + list2.size];
            Array.Copy(list1.container, 0, newContainer, 0, list1.size);
            Array.Copy(list2.container, 0, newContainer, list1.size, list2.size);
            list1.Size = newContainer.Length;
            list1.container = newContainer;
            list1.Add(list2.container[0]);
            return list1;
        }*/

        //вложенный класс

        public class Owner
        {
            private uint id;
            private string name;
            private string organisation;

            public int ID { get; set; }
            public string Name { get; set; }
            public string Organisation { get; set; }

            public Owner (uint ownerId, string ownerName, string ownerOrg)
            {
                id = ownerId;
                name = ownerName;
                organisation = ownerOrg;
            }

            public override string ToString()
            {
                return $"ID – {id}, имя создателя – {name}, организация создателя – {organisation}.";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List firstList = new List(5);

            Console.WriteLine("~~~~~~~~Добавление элементов в конец списка~~~~~~~~");
            firstList.Add(2);
            firstList.Add(1);
            firstList.Add(15);
            firstList.Add(18);
            firstList.Add(19);
            firstList.Add(26);
            Console.WriteLine("Вывод списка");
            for (int i = 0; i < firstList.Size; i++)
            {
                Console.WriteLine($"{i + 1}. {firstList[i]}");
            }

            Console.WriteLine("~~~~~~~~Удаление элементов из конца списка~~~~~~~~");
            firstList.Remove();
            Console.WriteLine("Вывод списка");
            for (int i = 0; i < firstList.Size; i++)
            {
                Console.WriteLine($"{i + 1}. {firstList[i]}");
            }

            Console.WriteLine("~~~~~~~~Добавление элемента в начало списка~~~~~~~~");
            firstList = 256 + firstList;
            Console.WriteLine("Вывод списка");
            for (int i = 0; i < firstList.Size; i++)
            {
                Console.WriteLine($"{i + 1}. {firstList[i]}");
            }

            Console.WriteLine("~~~~~~~~Удаление первого элемента в списке~~~~~~~~");
            firstList--;
            Console.WriteLine("Вывод списка");
            for (int i = 0; i < firstList.Size; i++)
            {
                Console.WriteLine($"{i + 1}. {firstList[i]}");
            }

            Console.WriteLine("~~~~~~~~Проверка двух списков на равенство~~~~~~~~");
            List secondList = new List(3);
            secondList.Add(4);
            secondList.Add(15);
            //secondList = firstList;
            Console.WriteLine("Вывод первого списка");
            for (int i = 0; i < firstList.Size; i++)
            {
                Console.WriteLine($"{i + 1}. {firstList[i]}");
            }
            Console.WriteLine("Вывод второго списка");
            for (int i = 0; i < secondList.Size; i++)
            {
                Console.WriteLine($"{i + 1}. {secondList[i]}");
            }
            Console.WriteLine(firstList == secondList ? "Списки равны" : "Списки не равны");

            /*Console.WriteLine("~~~~~~~~Объединение двух списков~~~~~~~~");
            firstList = firstList * secondList;
            Console.WriteLine("Вывод списка");
            for (int i = 0; i < firstList.Size; i++)
            {
                Console.WriteLine($"{i + 1}. {firstList[i]}");
            }*/

            List.Owner info = new List.Owner(70703567, "bakkaSansanBakka", "BSTU");
            info.ToString();


            Console.ReadLine();
        }
    }
}
