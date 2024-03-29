﻿//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Diagnostics;

class CountDifferentWords
{
    static void Main()
    {
        string text = "i will try to explain, what is dictionary and how to use dictionary.";
        string[] allWordsArr = text.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> rechnik = new Dictionary<string, int>();

        foreach (var word in allWordsArr)
        {
            if (rechnik.ContainsKey(word))
            {
                rechnik[word] = rechnik[word] + 1;
            }
            else //(!rechnik.ContainsKey(word))
            {
                rechnik.Add(word, 1);
            }
        }

        foreach (var word in rechnik)
        {
            Console.WriteLine("{0,-15} - {1} times", word.Key, word.Value);
        }
    }
}