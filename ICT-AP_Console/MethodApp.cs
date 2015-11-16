// /** 
//  *  Class to demo method declarations, parameters, return types, and ArrayList
//  *  
//  * @author Alan Cowap 
//  * @version 1.0  
//  * @dependencies None
//  *  
//  */
//
using System;
using System.Collections;

namespace ICTAP_Console
{
	public class MethodApp
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Welcome to MethodApp");
			int[] data = {1,2,3,4,5};

			int min = CalculateMin (data);
			int max = CalculateMax (data);
			DisplayNumbers (data);
			Console.WriteLine ("Min is {0}, Max is {1} ", min, max);
			data [1] = -8;
			data [3] = 10;

			min = CalculateMin (data);
			max = CalculateMax (data);
			DisplayNumbers (data);
			Console.WriteLine ("Min is {0}, Max is {1} ", min, max);

			//ArrayList example
			ArrayList al = new ArrayList();
			Console.WriteLine ("\nArrayList size is {0}", al.Count);
			al.Add ("This");
			Console.WriteLine ("ArrayList size is {0}", al.Count);
			al.RemoveAt (0);
			Console.WriteLine ("ArrayList size is {0}", al.Count);
			al.Add ("This");
			al.Add ("That");
			al.Add ("Other");
			Console.WriteLine ("ArrayList size is {0}", al.Count);

			foreach(string str in al)
			{
				Console.Write (str + " ");
			}

			Console.Write ("\nPress RETURN to continue");
			Console.Read ();
		}

		public static void DisplayNumbers(int[] numbers)
		{
			//display numbers to user
			for (int i = 0; i < numbers.Length; ++i) 
			{
				Console.WriteLine (numbers[i]);
			}
		}

		public static int CalculateMin(int[] numbers)
		{
			//Console.WriteLine ("You are in calculateMin");
			int min = numbers[0];
			for (int i = 1; i < numbers.Length; ++i) 
			{
				if(numbers[i] < min)
				{
					min = numbers[i];
				}
			}
			return min;
		}

		public static int CalculateMax(int[] numbers)
		{
			//Console.WriteLine ("You are in calculateMin");
			int max = numbers[0];
			for (int i = 1; i < numbers.Length; ++i) 
			{
				if(numbers[i] > max)
				{
					max = numbers[i];
				}
			}
			return max;
		}


	}
}

