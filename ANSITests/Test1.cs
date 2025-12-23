using Cecil_Libraries.ANSI_Utils.Lists;

namespace ANSI_Utils_Tester.ANSITests
{
	public class Test1
	{
		/// <summary>
		/// This was a test to see if there was a `6` in the mode slot, and there was indeed a `6` available its just not really functional it most prompts but its rapid blinking.
		/// </summary>
		public static void Test()
		{
			Console.WriteLine("Test 1");
			
			// How to read this; Turn Entry 7 or 7th color which is White on for the specified mode, say Hello World!, reset everything.
			Console.WriteLine(ANSICodeLists.ColorList[7] + "Hello World!" + ANSICodeLists.ResetColor);
			Console.WriteLine(ANSICodeLists.BoldColorList[7] + "Hello World!" + ANSICodeLists.ResetColor);
			Console.WriteLine(ANSICodeLists.DarkenedColorList[7] + "Hello World!" + ANSICodeLists.ResetColor);
			Console.WriteLine(ANSICodeLists.ItalicColorList[7] + "Hello World!" + ANSICodeLists.ResetColor);
			Console.WriteLine(ANSICodeLists.UnderlineColorList[7] + "Hello World!" + ANSICodeLists.ResetColor);
			Console.WriteLine(ANSICodeLists.FlashyColorList[7] + "Hello World!" + ANSICodeLists.ResetColor);
			Console.WriteLine("\u001b[6;37m" + "Hello World!" + ANSICodeLists.ResetColor);
			Console.WriteLine(ANSICodeLists.HighlighterColorText[7] + "Hello World!" + ANSICodeLists.ResetColor);
			Console.WriteLine(ANSICodeLists.InvisibleColorText[7] + "Hello World!" + ANSICodeLists.ResetColor);
			Console.WriteLine(ANSICodeLists.StrikethroughColorText[7] + "Hello World!" + ANSICodeLists.ResetColor);
			
			Console.ReadLine();
		}
	}
}