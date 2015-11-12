// /** 
//  *  Class to demo arrays, for loops
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
	public class StatApp
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Welcome to ArrayApp");

			double d =  (10.0 / 3.0);
			Console.WriteLine (d);

			//prompt user to enter 5 numbers
			Console.WriteLine("Please enter 5 numbers:");

			//Note we don't like magic numbers, but for now...
			//read in 5 numbers
			int[] data = new int[5];

			for (int i = 0; i < 5; ++i) 
			{
				Console.WriteLine("Please enter number {0}", i+1);
				string numString = Console.ReadLine();
				int number;
				Int32.TryParse(numString, out number);
				data [i] = number;
			}

			//display 5 numbers to user
			for (int i = 0; i < 5; ++i) 
			{
				Console.WriteLine (data[i]);
			}

			//calculate the max, min, mean
			int min = data[0], max=min, total= min, mean=0;
			for (int i = 1; i < 5; ++i) 
			{
				//total
				total = total + data [i];
				//max
				if(data[i] > max)
				{
					max = data[i];
				}
				//min
				if(data[i] < min)
				{
					min = data[i];
				}

			}

			//calculate mean
			mean = total / 5;

			//display max, mean, min
			Console.WriteLine("Max: {0}, Mean: {1}, Min: {2}", max, mean, min);

			Console.Write ("\nPress RETURN to continue");
			Console.Read ();


		}
	}
}

