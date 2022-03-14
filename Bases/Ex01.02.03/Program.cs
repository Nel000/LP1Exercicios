using System;

namespace Exs123
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex1
            uint a = 0xFEDE;
            a &= 0x0F0F;

            /*     1111 1110 1101 1110
                &  0000 1111 0000 1111
                =  0000 1110 0000 1110 -> 0x0E0E

                Decimal: 
                    0x0E0E -> 0 * 16^3 + E * 16^2 + 0 * 16^1 + E * 16^0
                    = 14 * 16^2 + 14 * 16^0
                    =  14 * 256 + 14 = 3598d
            */

            // Ex2
            ulong b = 0xFEDE;
            b |= 0x0F0F;

            /*      1111 1110 1101 1110
                |   0000 1111 0000 1111
                =   1111 1111 1101 1111 -> 0xFFDF
            */

            // Ex3
            byte c = 0b1011_1100;
            c ^= 0x0F;

            /*      1011 1100
                ^   0000 1111
                =   1011 0011 -> 0xB3

                Decimal:
                    0xB3 = 11 * 16^1 + 3 * 16^0
                    = 11 * 16 + 3
                    = 179
            */
        }
    }
}
