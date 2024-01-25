using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    //추상 클래스
    abstract class MyInterface
    {
        public abstract void Shout();
    }

    //인터페이스
    interface IFlyable
    {
        void Fly();
    }

    //인터페이스는 내용이 없기 때문에 다중상속이 가능하다.
    //추상클래스와 동일하게 상속된 함수를 반드시 구현해야 한다.
    class Skeleton : MyInterface, IFlyable
    {
        //추상 클래스를 상속 받으면 내부 함수를 반드시 구현해야 한다.
        public override void Shout()
        {
            Console.WriteLine("");
        }

        public void Fly()
        {
            Console.WriteLine("날다");
        }
    }
    
    //다중 상속 할수 없음
    //죽음의 다이아몬드라는 상태가 됨
    //class FlyOrc : MyInterface, Skeleton

}
