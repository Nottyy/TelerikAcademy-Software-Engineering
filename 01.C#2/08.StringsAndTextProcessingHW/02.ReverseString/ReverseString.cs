﻿//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

using System;

class ReverseString
{
    static void Main()
    {
        char[] str = Console.ReadLine().ToCharArray();
        Array.Reverse(str);
        Console.WriteLine(str);
        
    }
}
