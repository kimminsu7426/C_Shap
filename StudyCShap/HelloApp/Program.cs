using static System.Console; // include와 같은 개념 라이브러리
                             // using - C# 키워드 : C#언어의 규격에 미리 정의되어있는 특별한 단어
                             // System - 기본 클래스의 네임스페이스 
                             // using System : System 네임스페이스 안에 있는 클래스를 사용하겠다고 컴파일러에게 알림

namespace HelloApp
{
    class Program
    {   
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine("ex:helloApp.exe <이름>");
                return;
            }

            WriteLine($"Hello, {args[0]}!");
        }
    }
}
