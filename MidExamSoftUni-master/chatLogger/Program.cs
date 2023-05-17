using System;
using System.Collections.Generic;

namespace chatLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chat = new List<string>();

            string[] command = Console.ReadLine().Split(" ");

            while (command[0] != "end")
            {
                if (command[0] == "Chat")
                {
                    chat.Add(command[1]);
                }
                else if (command[0] == "Delete")
                {
                    chat.Remove(command[1]);

                }
                else if (command[0] == "Edit")
                {
                    int i = chat.IndexOf(command[1]);
                    chat.Remove(command[1]);
                    chat.Insert(i, command[2]);
                }
                else if (command[0] == "Pin")
                {
                    if (chat.Contains(command[1]))
                    {
                        chat.Remove(command[1]);
                        chat.Add(command[1]);
                    }
                }
                else if (command[0] == "Spam")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        chat.Add(command[i]);
                    }
                }

                command = Console.ReadLine().Split(" ");
            }

            //while end

            for (int i = 0; i < chat.Count; i++)
            {
                Console.WriteLine(chat[i]);
            }
        }
    }
}
