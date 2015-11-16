// /** 
//  *  Class to demo ...
//  *  
//  * @author Alan Cowap 
//  * @version 1.0  
//  * @dependencies None
//  *  
//  */
//
using System;

namespace ICTAP_Console
{
	public class MethodApp
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Welcome to MethodApp");
			int[] data = {1,2,3,4,5};
			int min = CalculateMin (data);
			Console.WriteLine ("Min is {0} ", min);

			DisplayNumbers (data);
			data [3] = 10;
			min = CalculateMin (data);
			DisplayNumbers (data);
			Console.WriteLine ("Min is {0} ", min);

			Console.Write ("\nPress RETURN to continue");
			Console.Read ();

		}

		public static void DisplayNumbers(int[] numbers)
		{
			//display 5 numbers to user
			for (int i = 0; i < 5; ++i) 
			{
				Console.WriteLine (numbers[i]);
			}
		}

		public static int CalculateMin(int[] numbers)
		{
			Console.WriteLine ("You are in calculateMin");
			int min = numbers[0];
			for (int i = 1; i < 5; ++i) 
			{
				if(numbers[i] < min)
				{
					min = numbers[i];
				}
			}
			return min;
		}

	}
}

