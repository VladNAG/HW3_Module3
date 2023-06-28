using static HW3_Module3.Class1;
using static HW3_Module3.Class2;

namespace HW3_Module3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyDelegateShow show = Show;
            MyDelegatePow pow = Class1.Pow;
            var v = Class2.Calc(pow, 10, 5);
            show(v(2));
        }

        public static void Show(bool x)
        {
            Console.WriteLine(x);
        }
    }
}