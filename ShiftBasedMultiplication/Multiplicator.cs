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
    }
}
