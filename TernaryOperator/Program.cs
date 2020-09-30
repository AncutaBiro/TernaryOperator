using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            int a = Convert.ToInt32(inputData);

            inputData = Console.ReadLine();
            int b = Convert.ToInt32(inputData);

            int max = a < b ? b : a;

            Console.WriteLine(max);
            Console.Read();
        }
    }
}
