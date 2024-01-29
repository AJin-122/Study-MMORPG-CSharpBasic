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

        // 람다식을 사용하기 위한 사전 문법들
        static List<Item> _items = new List<Item>();

        delegate bool ItemSelector(Item item);
        //반환형식이 있고 매개변수가 있으면 MyFunc 으로 넘길수 있음
        delegate Return MyFunc<T, Return>(T item);
        delegate Return MyFunc<T1, T2, Return>(T1 item1, T2 item2);
        // 데리케이트를 직접 선언하지 않아도
        // Func<>, Action<> 으로 C# 에서 만들어져 있다.
        // 반환 타입이 있을 경우 Func
        // 반환 타입이 없을 경우 Action

        static Item FindItem(ItemSelector selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item)) return item;
            }

            return null;
        }

        static Item FindItem(MyFunc<Item, bool> selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item)) return item;
            }

            return null;
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
            /* 이벤트
            InputManager inputManager = new InputManager();

            inputManager.InputKey += OnInputTest;

            while (true)
            {
                inputManager.Update();
            }
            
             */
            /* 람다식
            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

            ItemSelector itemSelector = delegate (Item item) { return item.ItemType == ItemType.Weapon; };
            MyFunc<Item, bool> selector = (Item item) => { return item.ItemType == ItemType.Weapon; };

            // 재사용 하지 않을 함수인 경우 델리게이트로 선언하여 한번 사용한다.
            // 아래 방식은 Anonymous Function : 무명 함수 / 익명 함수
            Item item = FindItem(itemSelector);

            // 람다식 입력 => 출력 으로 구성
            Item item2 = FindItem(selector);

            
             */
        }
    }
}
