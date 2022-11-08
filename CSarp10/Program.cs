// https://www.csharpstudy.com/latest/CS10-file-scope-namespace.aspx
namespace MyApp; // C# 10 : File-scoped Namespace


internal class Program
{
    static void Main(string[] args)
    {
        //GetRamda();

        GetRamda3();
    }

    /// <summary>
    /// 향상된 람다식 유추
    /// </summary>
    static void GetRamda()
    { 
        Func<string, int> rtnInt = (string s) => int.Parse(s);
        int i = rtnInt("100");
        Console.WriteLine(i);
        Console.WriteLine($"i => Int ? {i is int}" );

        var rtnInt2 = (string s) => int.Parse(s);
        Console.WriteLine(rtnInt2("100"));
        Console.WriteLine($"i => Int ? {rtnInt2("100") is int}");
    }

    /// <summary>
    /// 람다식 리턴 타임 유추
    /// https://www.csharpstudy.com/latest/CS10-lambda-improve.aspx
    /// </summary>
    static void GetRamda2()
    {
        // (1) 에러: (CS8917) The delegate type could not be inferred.
        // var ex = (bool b) => b ? new ArgumentException() : new InvalidCastException();

        // (2) Fix: 리턴타입을 앞에 명시 
        var ex1 = Exception (bool b) => b ? new ArgumentException() : new InvalidCastException();
    }

    static void GetRamda3()
    {
        // Read 메서드 그룹으로부터 Func<int> 타입 유추.
        // Console.Read() 메서드는 입력 파라미터가 없고, int를 리턴함.
        var readOne = Console.Read;

        int c1 = readOne();
        int c2 = readOne();
        Console.WriteLine($"{c1},{c2}");
    }
}
