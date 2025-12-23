using Cecil_Libraries.ANSI_Utils.Objects;
using Cecil_Libraries.ANSI_Utils.Util;

namespace ANSI_Utils_Tester.ANSITests
{
	public class Test12
	{
		/// <summary>
		/// This was a Test to see if Hue Shade Value (HSV) to RGB was working, which from testing it works with some rounding errors.
		/// </summary>
		public static void Test()
		{
			Console.WriteLine("Test 12");
			
			(int r, int g, int b) = ConvertFromXToRGB.ConvertToRGBFromHueShadeValue(283, 58, 79);
			
			ColorRGB hsv = new ColorRGB("Regular", r, g, b);
			ColorRGB dehsv = new ColorRGB("Regular", r, g, b, reset: true);
			
			Console.WriteLine($"Let's give this {hsv.Format()}hsv (283, 58, 79){dehsv.Format()} conversion a test. Resultants; {r}, {g}, {b}");
			Console.ReadLine();
		}
	}
}