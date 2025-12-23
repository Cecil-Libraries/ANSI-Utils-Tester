using Cecil_Libraries.ANSI_Utils.Objects;

namespace ANSI_Utils_Tester.ANSITests
{
	public class Test6
	{
		/// <summary>
		/// This is a test to check if resets for Foreground worked with the Object, and to see if 255 was indeed a thing, yes we coded the object before checking that.
		/// </summary>
		public static void Test()
		{
			Console.WriteLine("Test 6");
			
			Color256 testingWhite = new Color256("Regular", 255);
			Color256 detestingWhite = new Color256("Regular", 255, reset:true);
			Color256 highlightTestingWhite = new Color256("Highlight", 255);
			Color256 delightTestingWhite = new Color256("Highlight", 255, reset:true);
			
			Console.WriteLine($"{testingWhite.Format()}This is a {highlightTestingWhite.Format()}ANSI{delightTestingWhite.Format()} Test{detestingWhite.Format()}, test complete");
			Console.ReadLine();
		}
	}
}