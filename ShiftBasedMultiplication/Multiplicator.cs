using System;
using System.Collections.Generic;
using System.Text;

namespace ShiftBasedMultiplication
{
    class Multiplicator
    {

        public static uint MultiplyUnsigned(uint operandA, uint operandB)
        {
            uint result = 0x00;
            do
            {
                uint mask = ((operandB) & 0x1) == 0x1 ? 0xffffffff : 0x0;
                result += operandA & mask;
                operandA <<= 1;
                operandB >>= 1;
            } while (operandB > 0);
            return result;
        }

        public uint MultiplyUnsignedExplained(uint operandA, uint operandB)
        {
            uint result = 0x00;
            Console.WriteLine();
            Console.WriteLine("Last bit of the right operand determines, whether current state of the left operand must be added to accumulator");
            Console.WriteLine("after each iteration, left operand is shifted left, and right one is shifted right");
            Console.WriteLine("A is :{0}, ({1})", getBitRepresentation(operandA), operandA);
            Console.WriteLine("B is :{0}, ({1})", getBitRepresentation(operandB), operandB);
            Console.WriteLine("{0,-35}{1,-37}{2,-35}{3,-35}", " Left operand", " Right Operand", " To add", " Accumulator");
            Console.WriteLine("".PadLeft(128, '='));
            do
            {
                Console.Write("{0,35}{1,37}", getBitRepresentation(operandA), getOperandBRepresentation(operandB));
                uint mask = ((operandB) & 0x1) == 0x1 ? 0xffffffff : 0x0;
                Console.Write("{0,35}", getBitRepresentation(operandA & mask));
                result += operandA & mask;
                Console.Write("{0,35} => {1}", getBitRepresentation(result), result);
                operandA <<= 1;
                operandB >>= 1;
                Console.WriteLine();
            } while (operandB > 0);
            return result;
        }

        private string getOperandBRepresentation(uint operand)
        {
            string convertedOperand = getBitRepresentation(operand);
            return convertedOperand.Substring(0, convertedOperand.Length - 1) + "{" + convertedOperand.Substring(convertedOperand.Length - 1) + "}";
        }

        private string getBitRepresentation(uint operand)
        {
            return "0b" + Convert.ToString(operand, 2).PadLeft(32, '0');
        }
    }
}
