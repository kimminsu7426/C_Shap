using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace IntegralType
{
    class Program
    {
        static void Main(string[] args)
        {
            
            sbyte a = sbyte.MaxValue; // sbyte -128 ~ 128
            byte b = byte.MinValue; // byte 0 ~ 255

            short c = short.MinValue; 
            ushort d = ushort.MaxValue; 

            int e = int.MaxValue;
            uint f = uint.MaxValue;

            long g = long.MaxValue;
            ulong h = ulong.MaxValue;

            ulong i = 20_000_000_000;
            Console.WriteLine(i); 

            byte a = 255;
            WriteLine($"a={a}");
            byte b = 0b1111_1111;
            WriteLine($"b={b}");
            byte c = 0xFF;
            WriteLine($"c={c}");

            byte d = byte.MaxValue;
            d += 1;
            WriteLine($"d={d}");
            d += 1;
            WriteLine($"d={d}");

            float f = float.MaxValue;
            double g = double.MaxValue; 

        }
    }
}
