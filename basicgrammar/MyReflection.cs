using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace basicgrammar
{
    class Monster
    {
        //유니티에서 인스펙터에서 표시하게 해주는 기능
        [Important("Very Important")]
        public int hp;
        protected int attack;
        private float speed;

        void Attack() { }
    }

    // 런타임중에 주석 같은 메시지를 전달 한다.
    class Important : System.Attribute
    {
        string message;

        public Important(string message)
        {
            this.message = message;
        }
    }

    class MyReflection
    {
        public MyReflection()
        {
            // 해당 클래스의 모든 정보를 알수 있다.
            // 런타임 중에 타입을 알수 있어 다양하게 응용 가능하다.
            Monster monster = new Monster();
            Type type = monster.GetType();

            var fields = type.GetFields(System.Reflection.BindingFlags.Public
                | System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.Static
                | System.Reflection.BindingFlags.Instance);

            foreach ( FieldInfo field in fields )
            {
                string access = "protected";
                if (field.IsPublic) access = "public";
                else if (field.IsPrivate) access = "private";

                var attributes = field.GetCustomAttributes();

                Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");
            }
        }
    }
}
