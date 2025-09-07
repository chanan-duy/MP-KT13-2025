namespace MP_KT13_2025;

public static class Helpers
{
    public static T Max<T>(T x, T y) where T : IComparable<T>
    {
        return x.CompareTo(y) >= 0 ? x : y;
    }
}
