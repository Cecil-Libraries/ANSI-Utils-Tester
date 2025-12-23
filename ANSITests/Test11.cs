using Cecil_Libraries.ANSI_Utils.Objects;
using Cecil_Libraries.ANSI_Utils.Util;

namespace ANSI_Utils_Tester.ANSITests
{
	public class Test11
	{
		/// <summary>
		/// This was a Test to see if Hex to RGB was working.
		/// </summary>
		public static void Test()
		{
			Console.WriteLine("Test 11");
			
			(int r, int g, int b) = ConvertFromXToRGB.ConverToRGBFromHex("#aa55cb");
			
			ColorRGB hex = new ColorRGB("Regular", r, g, b);
			ColorRGB dehex = new ColorRGB("Regular", r, g, b, reset: true);
			
			Console.WriteLine($"Let's give this {hex.Format()}hex (#aa55cb){dehex.Format()} conversion a test. Resultants; {r}, {g}, {b}");
			Console.ReadLine();
		}
	}
}