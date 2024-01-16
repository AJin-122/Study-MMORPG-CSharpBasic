namespace TextRPG
{
    internal class Program
    {
        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3
        }

        struct Player
        {
            public int hp;
            public int attack;
        }

        static void Main(string[] args)
        {
            ClassType choice = ClassType.None;

            while (true)
            {
                choice = ChooseClass();

                if(choice != ClassType.None )
                {
                    // 캐릭터 생성
                    Player player;
                    
                    CreatePlayer(choice, out player);

                    Console.WriteLine($"HP{player.hp} Attack{player.attack}");
                    // 기사 (100/10) 궁수 (75/12) 법사(50/15)

                    //필드로 나가서 몬스터랑 싸운다.
                }
            }
        }

        static void EnterGame()
        {
            Console.WriteLine("게임에 접속했습니다!");
            Console.WriteLine("[1] 필드로 간다");
            Console.WriteLine("[2] 로비로 돌아가기");

            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":

                    break;
                case "2":

                    break;
            }
        }

        static void CreatePlayer(ClassType choice, out Player player)
        {
            switch(choice)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }
        }

        static ClassType ChooseClass()
        {
            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            ClassType choice = ClassType.None;
            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Archer;
                    break;
                case "3":
                    choice = ClassType.Mage;
                    break;
            }

            return choice;
        }
    }
}