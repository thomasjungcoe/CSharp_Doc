class OverloadingExample
{
    static void F() => Console.Write("F()");
    static void F(int a) => Console.Write("F(int)");
    static void F(double a) => Console.WriteLine("F(double)");
    static void F<T> (T x) => Console.WriteLine($"F<{typeof(T).Name}>()");
    static void F(double x, double y) => Console.WriteLine("F(double, double)");

    public static void UsageExample() {
        F();
        F(1);
        F(1.0);
        F(1.0, 2.0);
        F("abd");
        F((double)1);
        F((object)1);
        F<int>(10);
        F(1,1);
    }
}