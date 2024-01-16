namespace OOPTest
{
    // OOP(은닉성 / 상속성 / 다형성)
    // TextRPG 를 객체로 생성
    // Knight
    // 속성 : hp, attack, pos
    // 기능 : Move, Attack, Die

    //상속성
    class Player // 부모, 기반 클래스, 각 캐릭터의 공통 부분을 묶을 수 있음
    {
        static public int counter = 1;
        public int id;
        public int hp;
        public int attack;

        public Player()
        {
            Console.WriteLine("Player 생성자 호출!");
        }

        public Player(int hp)
        {
            this.hp = hp;
            Console.WriteLine("Player hp 생성자 호출!");
        }

        public void Move()
        {
            Console.WriteLine("Player Move");
        }

        public void Attack()
        {
            Console.WriteLine("Player Attack");
        }
    }

    class Archer : Player // 자식, 파생 클래스
    {
        public int mp;

        public Archer() : base(100) // 부모의 특정 상속자로 생성
        {
            base.hp = 100; // 필드가 딸려옴
            Console.WriteLine("Archer 생성자 호출!");
        }

        //다형성

    }
    //상속성 끝
    
    // 은닉성, 접근 한정자
    // public private protected 등 설정 해야 한다.
    // 프로그램이 커지면 여러 사람들이 만들기 때문에
    // 이름으로 기능을 예측해서 사용하기 때문에
    // 보안 레벨 설정이 중요하다.
    // setter, getter 함수가 필요한 이유
    // 디버그 했을 때 호출 스택을 사용하여 추적이 가능하기 때문에 사용한다.

    //ref 참조
    class Knight
    {
        static public int counter = 1; //오로지 하나만 존재하는 값

        // 함수의 static 에서는 공용함수이기 때문에 클래스 각각의 인스턴트에 대해선
        // 참조가 되지 않는다.
        static public void Test()
        {
            //에러
            //this.id = 1;
            counter++;
        }

        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
        }

        // 필드
        public int id;
        public int hp;
        public int attack;

        public Knight()
        {
            id = counter++;

            this.hp = 100;
            this.attack = 10;
            Console.WriteLine("Knight 생성자 호출!");
        }

        public Knight(int hp) : this() //<- 클래스 자신의 빈 생성자 상속
        {
            this.hp = hp;
            Console.WriteLine("hp 생성자 호출!");
        }

        public Knight(int hp, int attack) : this(hp)
        {
            this.hp = hp;
            this.attack = attack;
            Console.WriteLine("hp attack 생성자 호출!");
        }

        public Knight Clone()
        {
            Knight knight2 = new Knight();
            knight2.hp = this.hp;
            knight2.attack = this.attack;
            return knight2;
        }

        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }

    //copy 복사
    struct Mage
    {
        public int hp;
        public int attack;
    }

    internal class Program
    {
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }

        static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }

        static void Main(string[] args)
        {
            Mage mage;
            mage.hp = 100;
            mage.attack = 50;
            KillMage(mage);

            Mage mage2 = mage;
            mage2.hp = 0;

            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;
            //KillKnight(knight);

            //Knight knight2 = knight;
            //knight2.hp = 0;

            //깊은 복사
            Knight Knight2 = knight.Clone();
            Knight2.hp = 0;

            Knight knight3 = new Knight(50);

            //knight.Move();
            //knight.Attack();

            Knight knight4 = Knight.CreateKnight(); // static 함수
            knight4.Move(); // 일반 함수

            Archer archer = new Archer();
            archer.Move();
            archer.Attack();

            // Archer 타입 -> Player 타입
            // Player 타입 -> Archer 타입 형변환 필요
            Player archerPlayer = archer;
            Archer archer2 = (Archer)archerPlayer;

            EnterGame(archer);
        }

        //클래스 형식 변환
        //형변환을 잘못 하면 컴파일에서 잡지 못하고 서비스 중에 발견될수 있기 때문에
        //굉장히 중요하게 다뤄야 한다.
        //부모 클래스를 매개변수로 설정하면
        //자식 클래스를 매개변수로 등록 가능
        static void EnterGame(Player player)
        {
            //매개변수 타입이 무엇인지 확인 bool
            bool isArcher = (player is Archer);
            if (isArcher)
            {
                Archer archer2 = (Archer)player;
                archer2.mp = 10;
            }
            //객체로 확인
            Archer? archer = (player as Archer);
            if (archer != null)
            {
                Archer archer2 = (Archer)player;
                archer2.mp = 10;
            }
        }
    }
}
