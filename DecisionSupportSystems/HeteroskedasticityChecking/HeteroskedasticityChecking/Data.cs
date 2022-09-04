
namespace HeteroskedasticityChecking
{
    internal class Data
    {
        public static class BeforeRetreating
        {
            public static double[] Manpower = { 200, 300, 100, 300, 300, 300, 300, 200, 300, 300, 200, 400, 200, 100 };
            public static double[] Tanks = { 4, 6, 16, 10, 22, 11, 8, 13, 31, 14, 7, 4, 11, 8 };
            public static double[] Ifv = { 60, 13, 22, 17, 48, 21, 22, 19, 28, 15, 24, 30, 16, 13 };
        }

        public static class AfterRetreating
        {
            public static double[] Manpower = { 200, 400, 200, 100, 200, 300, 400, 200, 200, 300, 300, 400, 300, 200 };
            public static double[] Tanks = { 9, 16, 19, 11, 34, 21, 31, 16, 22, 18, 22, 14, 15, 15 };
            public static double[] Ifv = { 44, 43, 33, 20, 50, 34, 47, 29, 27, 26, 48, 48, 43, 41 };
        }
    }
}
