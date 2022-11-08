using System;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        //public delegate void MessageDelegate(string message);
        //public delegate int AnotherDelegate(MyType m, long mem);

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // GetDelegate();

            // GetSubstring();

            GetPatternMatching();
        }

        // 무명메서드란 (delegate)
        // 일회용으로 단순한 명령어 구문으로 구성된 메서드들을 별도의 메서드를 정의하지 않고,
        // 델리게이트를 이용해 일회성 메서드를 정의할 수 있다.메서드명이 없는 메서드로 무명 메서드라 한다
        public static void GetDelegate()
        {
        //Func<int, int, int> sum = delegate (int a, int b) { return a + b; };
        //Console.WriteLine(sum(3,4));

        // 람다 식을 이용하여 간결하게 무명메서드 처리
        //Func<int, int, int> sum = (x, y) => x + y;
        //Console.WriteLine(sum(3,4));

        // Delegate 연산자를 사용하는 경우 매개 변수 목록 생략 가능
        // Action greet = delegate { Console.WriteLine("Hello"); };
        // greet();

        // Action<int, double> introduce = delegate { Console.WriteLine("This is world"); };
        // introduce(42, 2.7);

        // C# 9.0부터는 무시 항목를 사용하여 무명 메서드에서 사용하지 않는 입력 매개 변수를 두 개 이상 지정
        // https://learn.microsoft.com/ko-kr/dotnet/csharp/fundamentals/functional/discards
        // Func<int, int, int> constant = delegate (int _, int _) { return 42; };
        // Console.WriteLine(constant(3,4));

        // C# 9.0부터 static 한정자 사용가능
        //Func<int, int, int> sum = static delegate (int a, int b) { return a + b; };
        //Console.WriteLine(sum(10, 4));

        // C# 11.0부터  
        // https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/operators/delegate-operator
        }

        public static void GetSubstring()
        {
            string? word = "Taeho Jeong";
            char c = word[^5]; // => J  (뒤에서 5번째)
            //char c = word[5]; // => o (앞에서 5번째)
            string s = word[^5..^1]; // => Jeon //word[^5..]; => Jeong
            //string s = word[0..10]; // word[0..10]; => Taeho Jeong

            Console.WriteLine($"{c}, {s}");
        }



        public static void GetPatternMatching()
        {
            CheckCustomer(216);
        }

        public static void CheckCustomer(int id)
        {
            List<int> vip = new List<int> { 1, 3, 5, 9 };
            List<int> active = new List<int> { 10, 15, 16, 18 };
            List<int> blackList = new List<int> { 7, 14, 12, 133 };

            switch (id)
            {
                case var _id when (vip.Contains(_id)):
                    Console.WriteLine("VIP");
                    break;
                case var _id when (active.Contains(_id)):
                    Console.WriteLine("Active");
                    break;
                case var _id when (blackList.Contains(_id)):
                    Console.WriteLine("blackList");
                    break;
                default:
                    Console.WriteLine("No");
                    break;
            }
        }

    }
}


