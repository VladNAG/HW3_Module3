using static HW3_Module3.Class1;
using static HW3_Module3.Class2;

namespace HW3_Module3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Class2.Calc(Pow, 2, 2);
            Class1.Show(Class2.ResultD(3));
        }

        public static void Show(bool x)
        {
            Console.WriteLine(x);
        }
    }
}