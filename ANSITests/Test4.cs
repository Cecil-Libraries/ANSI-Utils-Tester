using Cecil_Libraries.ANSI_Utils.Objects;

namespace ANSI_Utils_Tester.ANSITests
{
	public class Test4
	{
		/// <summary>
		/// This is a test to check if resets for Foreground High Intensity worked with the Object.
		/// </summary>
		public static void Test()
		{
			Console.WriteLine("Test 4");
			
			Color highlightRedHI = new Color("Highlight", "Red", highIntensity:true);
			Color delightRedHI = new Color("Highlight", "Red", reset:true, highIntensity:true);
			Color redHI = new Color("Regular", "Red", highIntensity:true);
			Color deredHI = new Color("Regular", "Red", reset:true, highIntensity:true);
			
			Console.WriteLine($"{redHI.Format()}This is a {highlightRedHI.Format()}ANSI{delightRedHI.Format()} Test{deredHI.Format()}, test complete");
			Console.ReadLine();
		}
	}
}