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


        static void Main(string[] args)
        {
            ///* 일반화
            MyList<int> myIntList = new MyList<int>();
            int item = myIntList.GetItem(0);
            MyList<short> myShortList = new MyList<short>();
             //*/
        }
    }
}
