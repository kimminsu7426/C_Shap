using System;

namespace StringNumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FIXVAL = 20;

            object trans = FIXVAL;
            




            int a = 12345;
            string b = a.ToString(); // 문자열b = 12345가 들어가있음
            Console.WriteLine($"b={b}");

            float c = 3.141592f;
            string d = c.ToString();
            Console.WriteLine($"d={d}");

            string g = "3.141592";
            float h;
            if (float.TryParse(g, out h))
            {
                Console.WriteLine($"h={h}");
            }
            else
            {
                Console.WriteLine("g형 변환시 에러발생, 문자열 확인요망");
            }
            // bool 논리형식 True, False로 표현됌
        }
    }
}
