using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public static class StatisticOperation
    {
        public static int Sum(List list)
        {
            int sum = 0;
            for (int i = 0; i < list.Size; i++)
            {
                sum += list[i];
            }
            return sum;
        }
        public static int GetDiff(List list)
        {
            int[] contain = list.GetContainer();
            int min = contain.Min();
            int max = contain.Max();
            int diff = max - min;
            return diff;
        }
        public static int ElementsAmount(List list) => list.Size;
        public static int UpperLetterCount (this string str)
        {
            int counter = 0;
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (word[0] >= 'А' && word[0] <= 'Я')
                    counter++;
            }
            return counter;
        }
        public static bool RepeatingElements(this List list)
        {
            bool flag = false;
            if (list.GetContainer().Distinct().Count() != list.Size)
            {
                flag = true;
            }
            return flag;
        }
    }
}
