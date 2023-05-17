using System;

namespace CombineLists2way
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstList = Console.ReadLine();
            string[] firstListArray = firstList.Split(',');
            string[] secondListAray = Console.ReadLine().Split(',');
            string[] result = new string[firstListArray.Length + secondListAray.Length];

            int position = 0;

            for (int i = 0; i < firstListArray.Length; i++)
            {
                result[position] = firstListArray[i];
                position++;
                result[position] = secondListAray[i];
                position++;
            }
            Console.WriteLine(string.Join(",", result));
        }
    }
}
