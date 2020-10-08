using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {

        static void Main(string[] args)
        {            
            Product apples = Product.DefConstructor();  //создание первого объекта
            Console.WriteLine(apples.ToString());

            Product nails = new Product("Гвозди", 3546452784556, 100);
            Console.WriteLine($"Тип объекта nails - {nails.GetType()}");
            nails.ProdPrice = 0.05;
            Console.WriteLine($"Общая сумма товара {nails.ProdName} составляет {nails.GetSumPrice()}");

            Product milk = new Product("Молоко домашнее", 354655477754);
            Console.WriteLine($"Цена товара {milk.ProdName} в долларах составляет {milk.GetCostInDollars(out _)}");

            Console.WriteLine($"Введите скидку на товар:");
            double discount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Исходная скидка: {discount}");
            milk.ChangeDisc(ref discount);
            Console.WriteLine($"Скидка после изменения: {discount}");

            Console.WriteLine(apples.Equals(milk) ? "Объекты равны" : "Объекты не равны");
            milk.SomeMethodDoing();
            milk.SomeMethod();

            Product.Info();
            Console.WriteLine(new string('~', 20));

            // 2 задание - массив объектов

            Product[] products = new Product[3] { apples, nails, milk};
            Console.WriteLine("Задание а)вывести список товаров для заданного наименования\nВведите наименование товара");
            string prod = Console.ReadLine();
            bool flag = false;
            int n = 1;
            foreach (Product product in products)
            {
                if (prod.Equals(product.ProdName))
                {
                    Console.WriteLine($"{n}. {product.ProdName}");
                    n++;
                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Совпадений не найдено.");
            }

            Console.WriteLine("Задание б)вывести список товаров для заданного наименования, цена которых не превышает" +
                " заданную\nВведите наименование товара");
            prod = Console.ReadLine();
            Console.WriteLine("Введите цену");
            double price = Convert.ToDouble(Console.ReadLine());
            flag = false;
            n = 1;
            foreach (Product product in products)
            {
                if (prod.Equals(product.ProdName) && product.ProdPrice <= price)
                {
                    Console.WriteLine($"{n}. {product.ProdName}");
                    n++;
                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Совпадений не найдено.");
            }

            // задание 3 - создание анонимного типа

            Console.WriteLine(new string('~', 20));
            var someProd = new { prodName = "Кабачки", prodPrice = 0.5, prodLife = "14 дней" };
            Console.WriteLine($"Тип объекта someProd - {someProd.GetType()}");
            Console.WriteLine($"Наименование товара - {someProd.prodName}, цена составляет {someProd.prodPrice} рублей, " +
                $"срок хранения составляет {someProd.prodLife}");
            Console.ReadKey();
        }
    }
}
