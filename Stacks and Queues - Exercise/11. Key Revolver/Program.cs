using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line of input, you will receive the price of each bullet – an integer in the range[0 - 100]
            int pricePerBullet = int.Parse(Console.ReadLine());
            //On the second line, you will receive the size of the gun barrel – an integer in the range[1 - 5000]
            int sizeBarrel = int.Parse(Console.ReadLine());
            //On the third line, you will receive the bullets – a space-separated integer sequence with[1 - 100] integers
            int[] bullets = ReadSequenceFromConsole();
            //On the fourth line, you will receive the locks – a space-separated integer sequence with[1 - 100] integers
            int[] locks = ReadSequenceFromConsole();
            //On the fifth line, you will receive the value of the intelligence – an integer in the range[1 - 100000]
            int budget = int.Parse(Console.ReadLine());

            Stack<int> stackBullets = new Stack<int>(bullets);

            Queue<int> queueLocks = new Queue<int>(locks);

            int counter = 0; //Bullets Pop
            int reloadingBulets = sizeBarrel;

            while (true)
            {
                if (!stackBullets.Any())
                {
                    break;
                }

                if (!queueLocks.Any())
                {
                    break;
                }

                int bullet = stackBullets.Pop();

                if (bullet <= queueLocks.Peek())
                {
                    queueLocks.Dequeue();
                    Console.WriteLine("Bang!");
                    sizeBarrel--;
                }
                else
                {
                    Console.WriteLine("Ping!");
                    sizeBarrel--;
                }

                if (sizeBarrel == 0 && stackBullets.Any())
                {
                    sizeBarrel = reloadingBulets; ;
                    Console.WriteLine("Reloading!");
                }

                counter++;
            }

            int priceForPopBullets = counter * pricePerBullet;

            if (queueLocks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queueLocks.Count}");
                return;
            }

            if (stackBullets.Any())
            {
                Console.WriteLine($"{stackBullets.Count} bullets left. Earned ${budget - priceForPopBullets}");
            }
            else
            {
                Console.WriteLine($"{stackBullets.Count} bullets left. Earned ${budget - priceForPopBullets}");
            }

        }

        static int[] ReadSequenceFromConsole() 
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
