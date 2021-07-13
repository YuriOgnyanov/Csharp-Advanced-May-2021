using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line, you will be given a sequence of strings, separated by a comma and a white space
            string[] sequenceOfMusic = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> playList = new Queue<string>(sequenceOfMusic);

            //On the next lines you will be given commands until there are no songs in the queue
            while (playList.Any())
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];
                string nameOfSong = string.Empty;
                for (int i = 1; i < cmdArgs.Length; i++)
                {
                    nameOfSong += cmdArgs[i] + " ";
                }
                
                switch (command)
                {
                    case "Play":
                        playList.Dequeue();
                        break;

                    case "Add":
                        if (playList.Contains(nameOfSong.TrimEnd()))
                        {
                            Console.WriteLine($"{nameOfSong.TrimEnd()} is already contained!");
                        }
                        else
                        {
                            playList.Enqueue(nameOfSong.TrimEnd());
                        }
                        break;

                    case "Show":
                        Console.WriteLine(string.Join(", ", playList));
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
