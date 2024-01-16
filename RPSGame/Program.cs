namespace RPSGame
{
    internal class Program
    {
        //열거형
        enum Choice
        {
            Rock = 1,
            Paper = 2,
            Scissors = 0
        }

        static void Main(string[] args)
        {
            //const 상수 지정 이후 수정 불가
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 0;

            Random rand = new Random();
            int aiChoice = rand.Next(0, 3);

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case (int)Choice.Scissors:
                    Console.WriteLine("당신의 선택은 가위입니다.");
                    break;
                case ROCK:
                    Console.WriteLine("당신의 선택은 바위입니다.");
                    break;
                case PAPER:
                    Console.WriteLine("당신의 선택은 보입니다.");
                    break;
            }

            switch (aiChoice)
            {
                case 0:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다.");
                    break;
                case ROCK:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다.");
                    break;
                case PAPER:
                    Console.WriteLine("컴퓨터의 선택은 보입니다.");
                    break;
            }

            // 승리 무승부 패배
/*            if (choice ==0)
            {
                if (aiChoice == 0)
                {
                    Console.WriteLine("무승부입니다.");
                }
                else if (aiChoice == 1)
                {

                }
                else
                {

                }
            }
            else if(choice == 1)
            {
                if (aiChoice == 0)
                {

                }
                else if (aiChoice == 1)
                {

                }
                else
                {

                }
            }
            else
            {
                if (aiChoice == 0)
                {

                }
                else if (aiChoice == 1)
                {

                }
                else
                {

                }
            }*/

            //다른 방식
            if (choice == aiChoice)
            {
                Console.WriteLine("무승부입니다.");
            }
            else if (choice == SCISSORS && aiChoice == PAPER)
            {
                Console.WriteLine("승리입니다.");
            }
            else if (choice == ROCK && aiChoice == SCISSORS)
            {
                Console.WriteLine("승리입니다.");
            }
            else if (choice == PAPER && aiChoice == ROCK)
            {
                Console.WriteLine("승리입니다.");
            }
            else
            {
                Console.WriteLine("패배입니다.");
            }
        }
    }
}
