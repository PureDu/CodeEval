
using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string,int> wordToDigit = new Dictionary<string, int>()
        {
            {"zero", 0},
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9},
        };
        using (StreamReader reader = File.OpenText(args[0]))
        {
            
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;
                // do something with line

                string[] words = line.Split(';');

                foreach (string word in words)
                {
                    Console.Write(wordToDigit[word]);
                }
                Console.WriteLine();
            }
        }
    }
}