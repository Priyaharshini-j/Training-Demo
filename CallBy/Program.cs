using System.ComponentModel;

namespace CallBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9, b = 7;
            Console.WriteLine("Before call " + (a + b));
            Addition(ref a, ref b);
            Console.WriteLine("After call " + (a + b));

            ValueAdd(a,b);
        }
        static void Addition(ref int a, ref int b)
        {
            a = 10;
            b = 11;
            Console.WriteLine(a + b);
        }

        static void ValueAdd(int a, int b)
        {
            a = 10;b = 11;
            Console.WriteLine(a + b);
        }
    }
}