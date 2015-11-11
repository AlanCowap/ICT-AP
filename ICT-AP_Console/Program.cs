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
		public static void Main2 (string[] args)
		{

			// prompt user for name
			Console.WriteLine ("Please enter your name ");

			// store users name
			string name = Console.ReadLine ();

			// Get number of times to print name
			Console.WriteLine ("How many times do you want your name printed? ");
			string numTimes = Console.ReadLine();
			int number;
			Int32.TryParse(numTimes, out number);
			++number;

			//Conditional statement - if
			if (number > 11)
			{
				Console.WriteLine ("That's a lot of times!");
			}
			else if (number < 6)
			{
				Console.WriteLine ("That's not many times");
			}
			else
			{
				Console.WriteLine ("That's about right");	
			}

			// print users name 
			for (int i = 1; i < number; i++)
			{
				Console.WriteLine (i + " Your name is " + name);
			}


			//hack to keep command window open
			Console.WriteLine ("\n\nHit RETURN to Exit");
			Console.Read ();
		}



	}
}
