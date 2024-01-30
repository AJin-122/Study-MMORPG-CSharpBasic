using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicgrammar
{    
    //Nullable = Null + able
    //값 타입이 널을 사용 할수 있게 함
    class MyNullable
    {
        int? number = null;

        public MyNullable()
        {
            //number = 5;
            //Nullable 은 Value 로 값을 가져간다.
            if(number.HasValue) //Null 체크
            {
                int a = number.Value;
                Console.WriteLine(a);
            }

            // 널러블 Null 체크 약식 버전
            // Null 이면 3 입력, Null 이 아니면 number 값 대입
            int b = number ?? 3;
            Console.WriteLine(b);
            // 같은 표현
            int c = (number != null) ? number.Value : 0;

            // 클래스의 삼항연산자 응용
            Monster monster = null;

            // Null 체크 조건문을 사용 할수도 있지만
            if(monster != null)
            {
                int monsterId = monster.hp;
            }
            // Nullable 변수에 클래스변수?.변수명 을 사용하여 Null 체크와 대입도 가능하다.
            int? id = monster?.hp;
            // 풀어쓰면
            if (monster == null) { id = null; }
            else { id = monster.hp; }
            
        }

        int Find()
        {
            return 0;
        }
    }
}
