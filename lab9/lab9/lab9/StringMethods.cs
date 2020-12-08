using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public delegate void Action<T>(StringBuilder str);
    static class StringMethods
    {
        public static void RemovePunctuation(StringBuilder str)
        {
            str.Replace(',', ' ');
            str.Replace('.', ' ');
        }
        public static void RemoveSpaces(StringBuilder str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == ' ' && str[i + 1] == ' ')
                {
                    str.Remove(i, 1);
                }
            }
            if (str[str.Length - 1] == ' ')
                str = str.Remove(str.Length - 1, 1);
        }
        public static void AppendQuestionMark(StringBuilder str) => str.Append('?');
        public static void StringToUppercase(StringBuilder str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = char.ToUpper(str[i]);
            }
        }
        public static void ToEnglishLetter(StringBuilder str)
        {
            str.Replace('с', 's');
            str.Replace('С', 'S');
            str.Replace('н', 'n');
        }
    }
}
