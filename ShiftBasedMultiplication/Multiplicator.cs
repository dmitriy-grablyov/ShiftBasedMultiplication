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
            for (sbyte i = 0; i < 64; i++)
            {
                ulong mask = ((operandB >> i) & 0x1) == 0x1 ? 0xffffffffffffffff : 0x0;
                result += (operandA << i) & mask;
            }
            return result;
        }
    }
}
