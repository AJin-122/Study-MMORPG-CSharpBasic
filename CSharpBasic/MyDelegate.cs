using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class MyDelegate
    {
        //대리자 선언
        delegate int OnClicked();
        //형식은 형식인데, 함수 자체를 인자로 넘겨주는 그런 형식
        //반환 : int, 입력 : void
        //OnClicked 이 delegate 형식의 이름

        static void ButtonPressed(OnClicked clickedFunction)
        {
            clickedFunction();
        }

        static int TestDelegate()
        {
            Console.WriteLine("Hello Delegate");
            return 0;
        }
    }
}
