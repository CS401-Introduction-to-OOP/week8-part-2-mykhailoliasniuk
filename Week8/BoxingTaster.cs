namespace Week8;

public class BoxingTaster
{
    public static void Test()
    {
        int a = 10;
        object b = a;//boxing, creates reference to value a
        int c = (int)b;//unboxing, gets value
        Console.WriteLine($"a - {a}, b - {b}, c - {c}");
    }
}