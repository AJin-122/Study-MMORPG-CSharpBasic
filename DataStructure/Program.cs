namespace DataStructure
{
    class Program
    {
        static int GetHighestScore(int[] scores)
        {
            scores = MergeSort(scores.ToList<int>()).ToArray();

            return scores[0];
        }

        static int GetAverageScore(int[] scores)
        {
            if(scores.Length == 0) return 0;
            
            int sum = 0;

            foreach (int score in scores)
            {
                sum += score;
            }

            return sum/scores.Length;
        }

        static int GetIndexOf(int[] scores, int value)
        {
            for(int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == value) return i;
            }

            return -1;
        }

        static int[] Sort(int[] scores)
        {
            return MergeSort(scores.ToList<int>()).ToArray();
        }

        static List<int> MergingArrays(List<int> list1, List<int> list2)
        {
            List<int> result = new List<int>();

            int i = 0;
            int j = 0;

            while (i < list1.Count && j < list2.Count)
            {
                //부호를 바꾸면 내림차순, 오름차순으로 변경된다.
                if (list1[i] > list2[j])
                {
                    result.Add(list1[i]);
                    i++;
                }
                else
                {
                    result.Add(list2[j]);
                    j++;
                }
            }

            while (i < list1.Count)
            {
                result.Add(list1[i]);
                i++;
            }

            while (j < list2.Count)
            {
                result.Add(list2[j]);
                j++;
            }

            return result;
        }

        static List<int> MergeSort(List<int> list)
        {
            if (list.Count <= 1) return list;

            int mid = list.Count / 2;

            List<int> left = MergeSort(list.GetRange(0, mid));
            List<int> right = MergeSort(list.GetRange(mid, list.Count - mid));

            return MergingArrays(left, right);
        }

        static void Main(string[] args)
        {
            /* 배열
            //배열 선언 : 선언한 크기만큼 초기화 해야됨
            //선언 하지 않으면 초기화 된것 만큼 할당 됨
            int[] scores = new int[5] { 10, 20, 30, 40, 50 };
            int[] scores2 = { 10, 20, 30, 40, 50 };

            //배열은 참조 타입
            scores2 = scores;
            scores2[0] = 9999;

            //배열 입력
            //scores[0] = 10;
            scores[1] = 20;
            scores[2] = 30;
            scores[3] = 40;
            scores[4] = 50;

            //배열 for문 접근
            for(int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

            //배열 foreach 문 접근
            foreach(int socre in scores)
            {
                Console.WriteLine(socre);
            }
            */
            /* 배열 관련 함수
            int[] scores = new int[5] { 30, 10, 20, 50, 40 };

            Console.WriteLine(GetHighestScore(scores));
            Console.WriteLine(GetAverageScore(scores));
            Console.WriteLine(GetIndexOf(scores, 20));
            
            scores = Sort(scores);

            foreach (int i in scores) Console.Write(i + " ");
            */
            /* 이차원 배열
            Map map = new Map();
            map.Render();
            */
            /* 리스트
            MyList list = new MyList();
            */
            ///* 사전
            MyDictionary dictionary = new MyDictionary();
        }
    }
}
