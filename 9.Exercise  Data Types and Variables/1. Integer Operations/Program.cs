﻿using System;

namespace _1._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());
            int sum = firstNumber+secondNumber;
            sum = sum / thirdNumber;
            sum = sum * fourthNumber;
            Console.WriteLine(sum);
        }
    }
}
