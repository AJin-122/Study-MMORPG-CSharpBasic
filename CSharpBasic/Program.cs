namespace CSharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            // 데이터 형식
            // int      정수형 (-1 0 1 2 3 4)
            // float    실수형 (3.14)
            // string   문자형 ("Rookiss")
            // bool     불리언 (true/false)

            // [데이터 타입] [이름];
            //int hp;
            //int maxHp;
            // 1) 할당    int hp;
            // 2) write   hp = 100;
            // 3) read    hp;

            // [이름] = ?
            //hp = 100;

            // TODO
            //maxHp = hp;


            // 십진법 0    1    2    3    4     5 6 7 8 9
            // 이진법 0b00 0b01 0b10 0b11 0b100
            // 16진법 0    1    2    3    4     5 6 7 8 9 A B C D E F

            //16진법 대입
            //hp = 0x12FFB2;

            //이진법 대입
            //hp = 0b1010;

            //실수는 근사치로 저장됨 유의 필요
            //float a;

            //a = 3.51231231f;

            //string -> int
            //string input = "123123";
            //int number = int.Parse(input);

            //int -> string
            //string message = string.Format("당신의 HP는 {0}/{1}입니다.", hp, maxHp);

            //string message = $"당신의 HP는 {hp}/{maxHp}입니다.";

            //Console.WriteLine(message);

            //논리연산 AND OR NOT && || !
            //bool isTall = true;
            //bool isSmart = false;

            //bool aa = (isTall && isSmart);

            //삼항 연산자

            int number = 25;

            bool isPair = ((number % 2) == 0 ? true : false);
        }
    }
}