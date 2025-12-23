using Cecil_Libraries.ANSI_Utils.Objects;
using Cecil_Libraries.ANSI_Utils.Util;

namespace ANSI_Utils_Tester.ANSITests
{
	public class Test10
	{
		/// <summary>
		/// This was a test to see if Grayscale to RGB conversion was working.
		/// </summary>
		public static void Test()
		{
			Console.WriteLine("Test 10");
			
			(int r, int g, int b) = ConvertFromXToRGB.ConvertToRGBFromGrayscale(134);
			
			ColorRGB grayscale = new ColorRGB("Regular", r, g, b);
			ColorRGB degrayscale = new ColorRGB("Regular", r, g, b, reset: true);
			
			Console.WriteLine($"Let's give this {grayscale.Format()}grayscale (134){degrayscale.Format()} conversion a test. Resultants; {r}, {g}, {b}");
			Console.ReadLine();
		}
	}
}