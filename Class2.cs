using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_Module3
{
    internal class Class2
    {
        private static int result = 0;
        public delegate int MyDelegatePow(int x, int y);
        public delegate bool MyDelegatResult(int x);
        public static MyDelegatResult Calc(MyDelegatePow pow, int x, int y)
        {
            result = pow(x, y);
            MyDelegatResult res = Result;
            return res;
        }

        public static bool Result(int z)
        {
            if (result % z == 0)
            {
                return true;
            }

            return false;
        }
    }
}
