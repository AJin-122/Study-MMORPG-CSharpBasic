namespace StringEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Harry Potter";

            //1. 찾기
            bool found = name.Contains("Harry");
            int index = name.IndexOf('z');

            //2. 변형
            name = name + " Junior";
            //소문자로 변경
            string lowerCaseName = name.ToLower();
            //대문자로 변경
            string upperCaseName = name.ToUpper();
            //문자 변경
            string newName = name.Replace('r', 'l');

            //3. 분활
            string[] names = name.Split(new char[] { ' ' });
            string substringName = name.Substring(5);
        }
    }
}
