using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                string[] tokens = line.Split();
                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexToRemove);
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                    default:
                        break;
                    case "Contains":
                        int numberContains = int.Parse(tokens[1]);
                        if (numbers.Contains(numberContains))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        List<int> even = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                even.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", even));
                        break;
                    case "PrintOdd":
                        List<int> odd = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                odd.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", odd));
                        break;
                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = tokens[1];
                        int number = int.Parse(tokens[2]);
                        int biggerNumber = 0;
                        if (condition == ">")
                        {
                            List<int> bigOrSmallNum = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                biggerNumber = numbers[i];
                                if (biggerNumber > number)
                                {
                                    bigOrSmallNum.Add(biggerNumber);
                                }
                            }
                            Console.WriteLine(string.Join(" ", bigOrSmallNum));
                        }
                        else if (condition == ">=")
                        {
                            List<int> bigOrSmallNum = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                biggerNumber = numbers[i];
                                if (biggerNumber >= number)
                                {
                                    bigOrSmallNum.Add(biggerNumber);
                                }
                            }
                            Console.WriteLine(string.Join(" ", bigOrSmallNum));
                        }
                        else if (condition == "<")
                        {
                            List<int> bigOrSmallNum = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                biggerNumber = numbers[i];
                                if (biggerNumber < number)
                                {
                                    bigOrSmallNum.Add(biggerNumber);
                                }
                            }
                            Console.WriteLine(string.Join(" ", bigOrSmallNum));
                        }

                        else if (condition == "<=")
                        {
                            List<int> bigOrSmallNum = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {                             
                                biggerNumber = numbers[i];
                                if (biggerNumber <= number)
                                {
                                    bigOrSmallNum.Add(biggerNumber);
                                }
                            }
                            Console.WriteLine(string.Join(" ", bigOrSmallNum));
                        }
                        break;                  
                }
               
            }
        }
    }
}
