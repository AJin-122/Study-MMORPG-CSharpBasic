using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class MyList
    {
        public MyList()
        {
            //List <- 내부적으로 동적 배열로 되어 있음
            //동적배열은 크기가 커지면 새로 배열을 만들어서 값을 복사하고
            //그 값을 리스트 변수에 연결해주는 형식
            //선언
            List<int> list = new List<int>();
            //list[0] = 1; <- 선언만 하고 할당하지 않고 접근시 에러 발생
            for(int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            // 삽입
            list.Insert(2, 999);
            // 삭제
            list.Remove(3); //0 부터 검색하다 첫번째 찾은 숫자만 삭제
            list.RemoveAt(0); //인덱스 기분 삭제
            list.Clear(); //전체 삭제
            // 중간 삽입 삭제는 시간 복잡도에 의해 효율적이지 않다.
        }
    }
}
