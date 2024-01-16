namespace Function
{
    internal class Program
    {
        //ref 변수 그대로 사용
        //기본은 값을 복사하여 반영
        static void AddOne(ref int number)
        {
            number = number + 1;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        //여러값을 반환 할 필요가 있을 때 사용
        static void Divide(int a,int b, out int result1, out int result2)
        {
            result1 = a / b;
            result2 = a % b;
        }

        //함수 사용시 매개변수의 순서를 맞춰야 한다.
        static int Add(int a, int b, int c = 0, float d = 1.0f, double e = 3.0f)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            int a = 0;
            Program.AddOne(ref a);

            Console.WriteLine(a);

            int num1 = 10;
            int num2 = 3;

            Program.Swap(ref num1, ref num2);
            Console.WriteLine($"{num1} : {num2}");

            int result1;
            int result2;

            Program.Divide(num1, num2, out result1, out result2);

            Console.WriteLine($"{result1} : {result2}");
        }
    }
}
