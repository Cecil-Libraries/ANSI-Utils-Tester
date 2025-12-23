using Cecil_Libraries.ANSI_Utils.Objects;

namespace ANSI_Utils_Tester.ANSITests
{
	public class Test5
	{
		/// <summary>
		/// This is a test to check if resets for Background High Intensity worked with the Object.
		/// </summary>
		public static void Test()
		{
			Console.WriteLine("Test 5");
			
			Color highlightRedBGHI = new Color("Highlight", "Red", background:true, highIntensity:true);
			Color delightRedBGHI = new Color("Highlight", "Red", reset:true, background:true, highIntensity:true);
			Color redBGHI = new Color("Regular", "Red", background:true, highIntensity:true);
			Color deredBGHI = new Color("Regular", "Red", reset:true, background:true, highIntensity:true);
			
			Console.WriteLine($"{redBGHI.Format()}This is a {highlightRedBGHI.Format()}ANSI{delightRedBGHI.Format()} Test{deredBGHI.Format()}, test complete");
			Console.ReadLine();
		}
	}
}