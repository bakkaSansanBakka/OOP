using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document1 = new Document("ООО \"Белгород\"", 11, 11, 2020, true);
            document1.Burning();    // вызывается метод абстрактного класса
            ((IManipulate)document1).Burning(); //вызывается метод интерфейса

            Console.ReadKey();
        }
    }
}
