using Cecil_Libraries.ANSI_Utils.Objects;

namespace ANSI_Utils_Tester.ANSITests
{
	public class Test8
	{
		/// <summary>
		/// This is a test to check if resets for Foreground worked with the Object, and to see if RGB was indeed a thing, yes we coded the object before checking that.
		/// </summary>
		public static void Test()
		{
			Console.WriteLine("Test 8");
			
			ColorRGB gray = new ColorRGB("Regular", 64, 56, 56);
			ColorRGB degray = new ColorRGB("Regular", 64, 56, 56, reset:true);
			ColorRGB highlightGray = new ColorRGB("Highlight", 64, 56, 56);
			ColorRGB delightGray = new ColorRGB("Highlight", 64, 56, 56, reset:true);
			
			Console.WriteLine($"{gray.Format()}This is a {highlightGray.Format()}ANSI{delightGray.Format()} Test{degray.Format()}, test complete");
			Console.ReadLine();
		}
	}
}