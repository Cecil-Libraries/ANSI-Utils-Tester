using Cecil_Libraries.ANSI_Utils.Objects;

namespace ANSI_Utils_Tester.ANSITests
{
	public class Test3
	{
		/// <summary>
		/// This is a test to check if resets for Background Low Intensity worked with the Object.
		/// </summary>
		public static void Test()
		{
			Console.WriteLine("Test 3");
			
			Color highlightRedBG = new Color("Highlight", "Red", background:true);
			Color delightRedBG = new Color("Highlight", "Red", reset:true, background:true);
			Color redBG = new Color("Regular", "Red", background:true);
			Color deredBG = new Color("Regular", "Red", reset:true, background:true);
			
			Console.WriteLine($"{redBG.Format()}This is a {highlightRedBG.Format()}ANSI{delightRedBG.Format()} Test{deredBG.Format()}, test complete");
			Console.ReadLine();
		}
	}
}