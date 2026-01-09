namespace ANSI_Utils_Tester.ANSITests
{
	public class Test14
	{
		/// <summary>
		/// This was a test to see what Framed, Encircled and Overlined looked like and if the Reset Worked.
		/// </summary>
		public static void Test()
		{
			Console.WriteLine("Test 14");
			
			// How to read this; Turn Entry 7 or 7th color which is White on for the specified mode, say Hello World!, reset everything.
			Console.WriteLine("\u001b[6;51m" + "Hello World!" + "\u001b[6;54m");
			Console.WriteLine("\u001b[6;52m" + "Hello World!" + "\u001b[6;54m");
			Console.WriteLine("\u001b[6;53m" + "Hello World!" + "\u001b[6;55m");
			
			Console.ReadLine();
		}
	}
}