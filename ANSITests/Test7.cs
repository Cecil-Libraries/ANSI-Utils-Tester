using Cecil_Libraries.ANSI_Utils.Objects;

namespace ANSI_Utils_Tester.ANSITests
{
	public class Test7
	{
		/// <summary>
		/// This is a test to check if resets for Background worked with the Object, and to see if 255 was indeed a thing, yes we coded the object before checking that.
		/// </summary>
		public static void Test()
		{
			Console.WriteLine("Test 7");
			
			Color256 testingWhiteBG = new Color256("Regular", 255, background:true);
			Color256 detestingWhiteBG = new Color256("Regular", 255, reset:true, background:true);
			Color256 highlightTestingWhiteBG = new Color256("Highlight", 255, background:true);
			Color256 delightTestingWhiteBG = new Color256("Highlight", 255, reset:true, background:true);
			
			Console.WriteLine($"{testingWhiteBG.Format()}This is a {highlightTestingWhiteBG.Format()}ANSI{delightTestingWhiteBG.Format()} Test{detestingWhiteBG.Format()}, test complete");
			Console.ReadLine();
		}
	}
}