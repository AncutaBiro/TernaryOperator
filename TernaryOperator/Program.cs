﻿/*sa se citeasca 2 numere si sa se afiseze cel mai mare numar dintre ele
*/
using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            double a = (double) Convert.ToDouble (inputData);

            inputData = Console.ReadLine();
            double b = (double) Convert.ToDouble (inputData);

            double max = a < b ? b : a;

            Console.WriteLine(max);
            Console.Read();

        }
    }
}
