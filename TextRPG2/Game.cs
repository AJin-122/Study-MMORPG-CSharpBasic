using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextRPG2
{
    public enum GameMode
    {
        None = 0,
        Lobby,
        Town,
        Field
    }

    class Game
    {
        private GameMode _mode = GameMode.Lobby;
        private Player? _player = null;
        private Monster? _monster = null;
        private Random _rand = new Random();

        public void Process()
        {
            switch(_mode)
            {
                case GameMode.Lobby:
                    ProcessLobby();
                    break;
                case GameMode.Town:
                    ProcessTown();
                    break;
                case GameMode.Field:
                    ProcessField();
                    break;
                default:
                    return;
            }
        }

        private void CreateRandomMonster()
        {
            //1~3 랜덤 숫자
            int randValue = _rand.Next(1, sizeof(MonsterType));
            switch (randValue)
            {
                case (int)MonsterType.Slime:
                    Console.WriteLine("슬라임이 스폰되었습니다!");
                    _monster = new Slime();
                    break;
                case (int)MonsterType.Orc:
                    Console.WriteLine("오크가 스폰되었습니다!");
                    _monster = new Orc();
                    break;
                case (int)MonsterType.Skeleton:
                    Console.WriteLine("스켈레톤이 스폰되었습니다!");
                    _monster = new Skeleton();
                    break;
            }
        }

        private void ProcessField()
        {
            Console.WriteLine("필드에 접속했습니다!");
            Console.WriteLine("[1] 전투 모드로 돌입");
            Console.WriteLine("[2] 일정 확률로 마을로 도망");

            CreateRandomMonster();

            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    //싸우는 함수
                    ProcessFight();
                    break;
                case "2":
                    TryEscape();
                    break;
                default:
                    return;
            }
        }

        private void TryEscape()
        {
            //33% 확률로 마을로 도망
            int randValue = _rand.Next(0, 100);
            if (randValue < 33)
            {
                Console.WriteLine("도망치는데 성공했습니다!");
            }
            else
            {
                Console.WriteLine("도망치는데 실패했습니다!");
                ProcessFight();
            }
        }

        private void ProcessFight()
        {
            while(true)
            {
                int damage = _player.GetAttack();
                _monster.OnDamaged(damage);
                if(_monster.IsDead())
                {
                    Console.WriteLine("승리했습니다.");
                    Console.WriteLine($"남은 체력 : {_player.GetHp()}");
                    break;
                }

                //몬스터 반격
                damage = _monster.GetAttack();
                _player.OnDamaged(damage);
                if (_player.IsDead())
                {
                    Console.WriteLine("패배했습니다.");
                    _mode = GameMode.Lobby;
                    break;
                }
            }
        }

        private void ProcessTown()
        {
            Console.WriteLine("게임에 접속했습니다!");
            Console.WriteLine("[1] 필드로 간다");
            Console.WriteLine("[2] 로비로 돌아가기");

            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    _mode = GameMode.Field;
                    break;
                case "2":
                    _mode = GameMode.Lobby;
                    break;
                default:
                    return;
            }
        }

        private void ProcessLobby()
        {
            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    _player = new Knight();
                    _mode = GameMode.Town;
                    break;
                case "2":
                    _player = new Archer();
                    _mode = GameMode.Town;
                    break;
                case "3":
                    _player = new Mage();
                    _mode = GameMode.Town;
                    break;
            }
        }
    }
}
