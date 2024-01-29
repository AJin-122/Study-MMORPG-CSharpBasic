using CSharpBasic;

namespace basicgrammar
{
    internal class Program
    {
        class MyList<T> //where T : struct 등 으로 T 사항을 제한 걸수 있다.
        {
            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return arr[i];
            }

            public void SetItem(int i, T item)
            {
                arr[i] = item;
            }
        }

        //이벤트 발생 시 실행 할 함수
        static void OnInputTest()
        {
            Console.WriteLine("Input Received!");
        }

        static void Main(string[] args)
        {
            /* 일반화
            MyList<int> myIntList = new MyList<int>();
            int item = myIntList.GetItem(0);
            MyList<short> myShortList = new MyList<short>();
            */
            /* 대리자
            MyDelegate myDelegate = new MyDelegate();
            myDelegate.ButtonPressed(myDelegate.TestDelegate);

            //올바른 구현 방법
            //여러 함수를 연달아서 실행 하게 끔 할 수 있다.
            MyDelegate.OnClicked clicked = new MyDelegate.OnClicked(myDelegate.TestDelegate);
            clicked += myDelegate.TestDelegate2;
            clicked();
            */
            ///* 이벤트
            InputManager inputManager = new InputManager();

            inputManager.InputKey += OnInputTest;

            while (true)
            {
                inputManager.Update();
            }
            
            // */
        }
    }
}
