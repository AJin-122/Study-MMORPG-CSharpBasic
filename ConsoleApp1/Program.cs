namespace ConsoleApp1
{
    internal class Program
    {
        // 메소드 호출
        static int Factorial(int x)
        {
            /*int ret = 1;
            
            for(int i = 1; i <= x; i++)
            {
                ret *= i;
            }
            return ret
             */

            //재귀
            if (x <= 1) return 1;
            return x * Factorial(x-1);
        }

        static void Main(string[] args)
        {
            //별찍기

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine(Factorial(5));
        }
    }
}