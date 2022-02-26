using HuffmanTest;
using System;
using System.Collections;
using System.Diagnostics;

namespace HuffmanTest
{
    class Program
    {
        public static void Main()
        {
            double i = 0;
            long sum = 0;
            while (true)
            {
                Generator temp = new Generator("Tom1.txt");

                string input = Generator.ParsingText();

                if (input != null)
                {
                    Stopwatch stopWatch = new Stopwatch();
                    HuffmanTree huffmanTree = new HuffmanTree();
                    stopWatch.Start();

                    huffmanTree.Build(input);

                    stopWatch.Stop();
                    long ts = stopWatch.ElapsedTicks;
                    i++;
                    sum += ts;
                    Console.WriteLine("RunTime " + ts);
                }
                else break;

            }
            Console.WriteLine("end " + (sum / i));
            Console.ReadLine();
        }

    }
}
