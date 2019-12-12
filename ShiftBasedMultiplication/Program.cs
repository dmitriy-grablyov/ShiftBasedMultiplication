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
                uint operandA = UInt32.Parse(inputA);
                Console.Write("enter operand B: ");
                string inputB = Console.ReadLine();
                uint operandB = UInt32.Parse(inputB);
                uint result = Multiplicator.MultiplyUnsigned(operandA, operandB);
                Console.WriteLine("multiplication result is {0}, and should be {1}", result, operandA * operandB);
            }
        }
    }
}
