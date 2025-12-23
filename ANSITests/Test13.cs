using Cecil_Libraries.ANSI_Utils.Objects;
using Cecil_Libraries.ANSI_Utils.Util;

namespace ANSI_Utils_Tester.ANSITests
{
	public class Test13
	{
		/// <summary>
		/// This was a test to see if Hue Saturation Lightness to RGB was working, which from testing it works mostly with some rounding errors.
		/// </summary>
		public static void Test()
		{
			Console.WriteLine("Test 13");
			(int r, int g, int b) = ConvertFromXToRGB.ConvertToRGBFromHueSaturationLightness(283, 53, 56);
			ColorRGB hsl = new ColorRGB("Regular", r, g, b);
			ColorRGB dehsl = new ColorRGB("Regular", r, g, b, reset: true);
			Console.WriteLine($"Let's give this {hsl.Format()}hsl (283, 53, 56){dehsl.Format()} conversion a test. Resultants; {r}, {g}, {b}");
			Console.ReadLine();
		}
	}
}