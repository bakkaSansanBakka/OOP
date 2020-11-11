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
            ((IManipulate)document1).Burning(); // вызывается метод интерфейса
            Console.WriteLine(document1.ToString());

            Receipt receipt1 = new Receipt("ООО \"Белгород\"", 12, 12, 2020, true, "квитанция");
            Console.WriteLine(receipt1.ToString());
            Console.ReadKey();
        }
    }
}
