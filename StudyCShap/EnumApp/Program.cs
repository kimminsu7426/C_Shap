using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumApp
{
    class Program
    {
        enum DialogResult       // enum은문자열로 표현될뿐이지 int 정수형임(숫자임)
        {
            YES = 10,           //0 값을 지정하지않을시
            NO = 20,            //1
            CANCEL = 30,        //2
            CONFIRM = 40,       //3
            OK = 50             //4
        } 
        static void Main(string[] args)
        {
            //Console.WriteLine(DialogResult.OK);
            //Console.WriteLine((int)DialogResult.OK);
            DialogResult result = DialogResult.YES;
            if (result == DialogResult.YES)
            {   
                Console.WriteLine("YES를 선택했습니다.");
            } 
        }
    }
}
