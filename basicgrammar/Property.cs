using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class Property
    {
        //get, set 선언
        protected int hp;

        // 함수 이지만 변수 처럼 사용가능
        public int Hp
        {
            get { return hp; }
            private set { hp = value;}
        }

        //변수 선언 없이 간략하게 선언시 내부적으로 아래 함수가 선언됨
        // private int _sp;
        // public int GetSp() { return _sp; }
        // public void SetSp(int value) { _sp = value; }
        // C# 7.0 부터 = 100 식으로 초기값 설정도 가능함
        public int Sp
        {
            get; set;
        } = 100;
    }

    class Exe
    { 
        public Exe()
        { 
            //get, set 으로 선언한 변수 명으로 사용 가능
            Property property = new Property();
            //set에 private 로 설정하면 사용 할 수 없음
            //property.Hp = 20;
        }
    }
}
