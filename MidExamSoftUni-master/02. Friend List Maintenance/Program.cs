using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Friend_List_Maintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> friends = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            int blacklistedNames = 0;
            int lostNames = 0;

            while (input != "Report")
            {
                string[] allCommands = input.Split();
                string command = allCommands[0];

                switch (command)
                {
                    case "Blacklist": //Mike, John, Eddie
                        string name = allCommands[1];

                        for (int i = 0; i < friends.Count; i++)
                        {
                            if (!friends.Contains(name))
                            {
                                Console.WriteLine($"{name} was not found.");
                                break;
                            }
                            if (friends[i] == name)
                            {
                                blacklistedNames++;
                                Console.WriteLine($"{friends[i]} was blacklisted.");
                                friends[i] = "Blacklisted";
                                break;
                            }
                        }
                        break;
                    case "Error":
                        int index = int.Parse(allCommands[1]);
                        if (index >= 0 && index < friends.Count && friends[index] != "Blacklisted" && friends[index] != "Lost")
                        {
                            Console.WriteLine($"{friends[index]} was lost due to an error.");
                            friends[index] = "Lost";
                            lostNames++;
                        }
                        break;
                    case "Change":
                        int ind = int.Parse(allCommands[1]);
                        string newName = allCommands[2];

                        if (ind >= 0 && ind < friends.Count)
                        {
                            string currName = friends[ind];
                            friends[ind] = newName;
                            Console.WriteLine($"{currName} changed his username to {newName}.");
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Blacklisted names: { blacklistedNames}");
            Console.WriteLine($"Lost names: {lostNames}");
            Console.WriteLine(String.Join(" ", friends));
        }
    }
}
