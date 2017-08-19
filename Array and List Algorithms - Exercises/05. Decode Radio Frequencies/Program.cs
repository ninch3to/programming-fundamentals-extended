﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Decode_Radio_Frequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frequenciesInput = Console.ReadLine().Split(' ');
            List<char> endMessage = new List<char>();

            for (int i = 0; i < frequenciesInput.Length; i++)
            {
                string[] tokens = frequenciesInput[i].Split('.');
                int firstFreq = int.Parse(tokens[0]);
                int secondFreq = int.Parse(tokens[1]);

                char firstLetter = (char)firstFreq;
                char secondLetter = (char)secondFreq;

                if (firstFreq!=0)
                {
                    endMessage.Insert(i, firstLetter);
                }
                if (secondFreq != 0)
                {
                    endMessage.Insert(endMessage.Count - 1 - i, secondLetter);
                }
            }
            endMessage.Reverse();
            Console.WriteLine(string.Join("", endMessage));
        }
    }
}
