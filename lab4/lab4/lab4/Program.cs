using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{   //объединение двух списков через *
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
            firstList.ListPrint();

            Console.WriteLine("~~~~~~~~Удаление элементов из конца списка~~~~~~~~");
            firstList.Remove();
            firstList.ListPrint();

            Console.WriteLine("~~~~~~~~Добавление элемента в начало списка~~~~~~~~");
            firstList = 256 + firstList;
            Console.WriteLine("Вывод списка");
            firstList.ListPrint();

            Console.WriteLine("~~~~~~~~Удаление первого элемента в списке~~~~~~~~");
            firstList--;
            Console.WriteLine("Вывод списка");
            firstList.ListPrint();

            Console.WriteLine("~~~~~~~~Проверка двух списков на равенство~~~~~~~~");
            List secondList = new List(3);
            secondList.Add(4);
            secondList.Add(15);
            secondList.Add(144);
            //secondList = firstList;
            Console.WriteLine("Вывод первого списка");
            firstList.ListPrint();
            Console.WriteLine("Вывод второго списка");
            secondList.ListPrint();
            Console.WriteLine(firstList == secondList ? "Списки равны" : "Списки не равны");

            Console.WriteLine("~~~~~~~~Объединение двух списков~~~~~~~~");
            firstList *= secondList;
            Console.WriteLine("Вывод списка");
            firstList.ListPrint();

            List.Owner info = new List.Owner(70703567, "bakkaSansanBakka", "BSTU");
            info.ToString();

            List.Date date = new List.Date(15, 10, 2020);
            date.ToString();

            Console.WriteLine($"Сумма элементов списка - {StatisticOperation.Sum(firstList)}");
            Console.WriteLine($"Количество элементов списка - {StatisticOperation.ElementsAmount(firstList)}");
            Console.WriteLine($"Разница между максимальным и минимальным элементами списка - " +
                $"{StatisticOperation.GetDiff(firstList)}");

            string str = "Здравствуй, как Твои дела?";
            Console.WriteLine($"Количество слов с заглавной буквы - {str.UpperLetterCount()}");

            Console.WriteLine(secondList.RepeatingElements() ? "В списке есть повторяющиеся элементы" :
                "В списке нет повторяющихся элементов");

            Console.ReadLine();
        }
    }
}
