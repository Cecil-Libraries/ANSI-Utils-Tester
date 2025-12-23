using ANSI_Utils_Tester.ANSITests;

namespace ANSI_Utils_Tester
{
    public class ANSI_Utils_Tester
    {
        /// <summary>
        /// Runs the Tests Associated with ANSI Utils Tester in order.
        /// </summary>
        public static void Main()
        {
            // Lists
            Test1.Test();
            // Color
            Test2.Test();
            Test3.Test();
            Test4.Test();
            Test5.Test();
            // 255 Color
            Test6.Test();
            Test7.Test();
            // 24-Bit Color
            Test8.Test();
            Test9.Test();
            // Conversion Tests
            Test10.Test();
            Test11.Test();
            Test12.Test();
            Test13.Test();
        }
    }
}