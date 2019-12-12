using System;
using System.Collections.Generic;
using System.Text;

namespace ShiftBasedMultiplication
{
    class Multiplicator
    {

        public static ulong MultiplyUnsigned(ulong operandA, ulong operandB)
        {
            ulong result = 0x00;
            do
            {
                ulong mask = ((operandB) & 0x1) == 0x1 ? 0xffffffffffffffff : 0x0;
                result += operandA & mask;
                operandA <<= 1;
                operandB >>= 1;
            } while (operandB > 0);
            return result;
        }
    }
}
