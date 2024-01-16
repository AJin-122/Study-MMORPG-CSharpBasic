namespace OOPTest
{
    // TextRPG 를 객체로 생성
    // Knight
    // 속성 : hp, attack, pos
    // 기능 : Move, Attack, Die

    //ref 참조
    class Knight
    {
        public int hp;
        public int attack;

        public Knight()
        {
            this.hp = 100;
            this.attack = 10;
            Console.WriteLine("생성자 호출!");
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
        }
    }
}
