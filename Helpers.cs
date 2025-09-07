namespace MP_KT13_2025;

public static class Helpers
{
    public static T Max<T>(T x, T y) where T : IComparable<T>
    {
        return x.CompareTo(y) >= 0 ? x : y;
    }

    public static void Swap<T>(ref T x, ref T y) where T : notnull
    {
        (x, y) = (y, x);
    }

    public static void Print<T>(T[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            var item = array[i];
            Console.Write(item?.ToString() ?? "null");

            if (i != array.Length - 1)
            {
                Console.Write(", ");
            }
        }

        Console.Write(Environment.NewLine);
    }
}
