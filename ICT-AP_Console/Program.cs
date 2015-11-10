/** 
 *  Simple class to demo C#
 *  Basic input and output, for loop
 *  
 * @author Alan Cowap 
 * @version 1.0  
 * @dependencies None
 *  
 */

using System;

namespace ICTAP_Console
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// prompt user for name
			Console.WriteLine ("Please enter your name ");

			// store users name
			string name = Console.ReadLine ();

			// Get number of times to print name
			Console.WriteLine ("How many times... ");
			string numTimes = Console.ReadLine();
			int number;
			Int32.TryParse(numTimes, out number);
			++number;

			// print users name 
			for (int i = 1; i < number; i++)
			{
				Console.WriteLine (i + "Your name is " + name);
			}

			//hack to keep command window open
			Console.WriteLine ("\n\nHit RETURN to Exit");
			Console.Read ();
		}
	}
}
