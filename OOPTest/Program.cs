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

            //knight.Move();
            //knight.Attack();
        }
    }
}
