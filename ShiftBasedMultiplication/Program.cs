using System;

namespace ShiftBasedMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("enter operand A: ");
                string inputA = Console.ReadLine();
                ulong operandA = UInt64.Parse(inputA);
                Console.Write("enter operand B: ");
                string inputB = Console.ReadLine();
                ulong operandB = UInt64.Parse(inputB);
                ulong result = Multiplicator.MultiplyUnsigned(operandA, operandB);
                Console.WriteLine("multiplication result is {0}, and should be {1}", result, operandA * operandB);
            }
        }
    }
}
