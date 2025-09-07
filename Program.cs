namespace MP_KT13_2025;

public static class MainLogic
{
    private static void PrintNewLine()
    {
        Console.Write(Environment.NewLine);
    }

    private static void TestMax()
    {
        const int i1 = 123;
        const int i2 = 321;
        Console.WriteLine(Helpers.Max(i1, i2));

        const string s1 = "123";
        const string s2 = "1234";
        Console.WriteLine(Helpers.Max(s1, s2));

        var d1 = new DateTime(123);
        var d2 = new DateTime(10 * 10_000_000);
        Console.WriteLine(Helpers.Max(d1, d2));
    }


    private static void TestSwap()
    {
        var i1 = 123;
        var i2 = 321;
        Helpers.Swap(ref i1, ref i2);
        Console.WriteLine($"i1 = {i1} ; i2 = {i2}");

        var s1 = "123";
        var s2 = "1234";
        Helpers.Swap(ref s1, ref s2);
        Console.WriteLine($"s1 = {s1} ; s2 = {s2}");

        var person1 = new Person("p1");
        var person2 = new Person("p2");
        Helpers.Swap(ref person1, ref person2);
        Console.WriteLine($"p1 = {person1} ; p2 = {person2}");
    }

    private static void TestHelpers()
    {
        TestMax();
        PrintNewLine();
        TestSwap();
        PrintNewLine();
    }

    public static void RunLogic()
    {
        TestHelpers();
    }
}

public static class Program
{
    public static void Main(string[] _)
    {
        MainLogic.RunLogic();
    }
}
