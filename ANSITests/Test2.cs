using Cecil_Libraries.ANSI_Utils.Objects;

namespace ANSI_Utils_Tester.ANSITests
{
	public class Test2
	{
		/// <summary>
		/// This is a test to check if resets for Foreground Low Intensity worked with the Object.
		/// </summary>
		public static void Test() 
		{
			Console.WriteLine("Test 2");
			
			Color highlightRed = new Color("Highlight", "Red");
			Color delightRed = new Color("Highlight", "Red", reset:true);
			Color red = new Color("Regular", "Red");
			Color dered = new Color("Regular", "Red", reset:true);
			
			Console.WriteLine($"{red.Format()}This is a {highlightRed.Format()}ANSI{delightRed.Format()} Test{dered.Format()}, test complete");
			Console.ReadLine();
		}
	}
}