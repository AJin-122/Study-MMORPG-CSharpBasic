using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class MyDictionary
    {
        public MyDictionary()
        {
            // Key -> Value
            // 키를 가지고 빠르게 작동함

            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();

            dic.Add(1, new Slime());
            dic[5] = new Orc();

            // 존재하지 않는 키로 바로 접근하면 에러 발생
            // 미리 키에 해당하는 값이 있는지 확인 진행
            Monster mon;
            bool found = dic.TryGetValue(2000, out mon);

            // 키 기반 삭제
            dic.Remove(5);

            // 해쉬테이블을 사용하기 때문에
            // 메모리가 많이 사용되지만 성능이 좋다.
        }
    }
}
