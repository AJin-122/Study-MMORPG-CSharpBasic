using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    public class MyDelegate
    {
        //대리자 선언
        public delegate int OnClicked();
        //형식은 형식인데, 함수 자체를 인자로 넘겨주는 그런 형식
        //반환 : int, 입력 : void
        //OnClicked 이 delegate 형식의 이름

        public void ButtonPressed(OnClicked clickedFunction)
        {
            clickedFunction();
        }

        public int TestDelegate()
        {
            Console.WriteLine("Hello Delegate");
            return 0;
        }
        public int TestDelegate2()
        {
            Console.WriteLine("Hello Delegate2");
            return 0;
        }
    }
}
