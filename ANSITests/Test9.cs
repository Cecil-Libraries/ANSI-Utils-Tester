using Cecil_Libraries.ANSI_Utils.Objects;

namespace ANSI_Utils_Tester.ANSITests
{
	public class Test9
	{
		/// <summary>
		/// This is a test to check if resets for Background worked with the Object, and to see if RGB was indeed a thing, yes we coded the object before checking that.
		/// </summary>
		public static void Test()
		{
			Console.WriteLine("Test 9");
			ColorRGB grayBG = new ColorRGB("Regular", 64, 56, 56, background:true);
			ColorRGB degrayBG = new ColorRGB("Regular", 64, 56, 56, reset: true, background:true);
			ColorRGB highlightGrayBG = new ColorRGB("Highlight", 64, 56, 56, background:true);
			ColorRGB delightGrayBG = new ColorRGB("Highlight", 64, 56, 56, reset: true, background:true);
			Console.WriteLine($"{grayBG.Format()}This is a {highlightGrayBG.Format()}ANSI{delightGrayBG.Format()} Test{degrayBG.Format()}, test complete");
			Console.ReadLine();
		}
	}
}