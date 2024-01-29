using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicgrammar
{
    //이벤트는 직접적으로 호출 할 수 없다.
    //Observer Pattern
    class MyEvent
    {
    }

    class InputManager
    {
        public delegate void OnInputKey();
        public event OnInputKey InputKey;

        public void Update()
        {
            if(Console.KeyAvailable == false) return;

            ConsoleKeyInfo info = Console.ReadKey();
            if(info.Key == ConsoleKey.A)
            {
                // 사용자가 A 키를 눌렀을 때 모두한테 알려준다.
                // InputKey 에 등록된 함수가 실행된다.
                InputKey();
            }
        }
    }
}
