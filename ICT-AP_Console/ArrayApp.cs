// /** 
//  *  Class to demonstrate array declaration, construction, initialisation
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
	public class ArrayApp
	{
		public static void Main2 (string[] args)
		{
			Console.WriteLine ("Welcome to ArrayApp");

			//int num = 9;
			//Console.WriteLine ("Num is " + num);

			//DCI the array
			int[] numArray = new int[15];

			//Output all elements of array
			for (int i = 0; i < numArray.Length; ++i) {
				int number = numArray [i];
				Console.Write (number);
			}

			//Assign values to elements of array
			numArray[0] = 9;
			numArray[4] = 12;
			Console.WriteLine ();

			for (int i = 0; i < numArray.Length; ++i) {
				numArray [i] = i;
			}

			//Output all elements of array
			for (int i = 0; i < numArray.Length; ++i) {
				int number = numArray [i];
				Console.WriteLine (number);
			}

			int num = 7 / 5;
			Console.WriteLine ("Answer is " + num);


			Console.Write ("\nPress RETURN to continue");
			Console.Read ();
		}

	}
}

