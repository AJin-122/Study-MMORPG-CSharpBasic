namespace OOPTest
{
    // OOP(은닉성 / 상속성 / 다형성)
    // TextRPG 를 객체로 생성
    // Knight
    // 속성 : hp, attack, pos
    // 기능 : Move, Attack, Die

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
        public Archer() : base(100) // 부모의 특정 상속자로 생성
        {
            base.hp = 100; // 필드가 딸려옴
            Console.WriteLine("Archer 생성자 호출!");
        }
    }

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
        }
    }
}
