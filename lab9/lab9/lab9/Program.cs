using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{

    class Program
    {
        static void Main(string[] args)
        {
            var strArray1 = new List() { "every", "moment", "of", "the", "year" };
            var strArray2 = new List() { "I", "love", "Paris" };

            LambdaHandler consoleOutFormat = () => Console.WriteLine("");

            ClassProgrammer progger = new ClassProgrammer();
            progger.Delete += strArray1.DisplayList;
            progger.Delete += strArray1.RemoveAt;
            progger.Delete += strArray1.DisplayList;
            progger.DeleteItem(2);
            consoleOutFormat();
            progger.Mutate += strArray2.DisplayList;
            progger.Mutate += strArray2.ChangeRandomItem;
            progger.Mutate += i => strArray2[i] += "OOOOOOOOOOOOOOOOOOOOOOOOOO";
            progger.Mutate += strArray2.DisplayList;

            progger.ChangeList(2);

            StringBuilder str = new StringBuilder("синее, синее  небо.,");
            Console.WriteLine($"Исходная строка: {str}");
            Action<StringBuilder> action = StringMethods.RemovePunctuation;
            action += StringMethods.RemoveSpaces;
            action += StringMethods.StringToUppercase;
            action += StringMethods.AppendQuestionMark;
            action += StringMethods.ToEnglishLetter;
            action(str);
            Console.WriteLine($"Строка после преобразований: {str}");

            Console.Read();
        }
    }
}
