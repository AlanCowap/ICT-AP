/** 
 *  Simple class to demo if statement, do-while loop
 *  
 * @author Alan Cowap 
 * @version 1.0  
 * @dependencies None
 *  
 */

using System;

namespace ICTAP_Console
{
	public class GradeApp
	{
		public static void Main2(string[] args)
		{
			Console.WriteLine ("Welcome to GradeApp");

			// get user input
			bool isInvalidInput = false;
			int score = -1;
			do{
				isInvalidInput = false;
				Console.WriteLine ("Please enter a score in the range 0..100 inclusive:");
				string userChoice = Console.ReadLine ();
				bool isValidType = Int32.TryParse (userChoice, out score); //Type Check
				isInvalidInput = !isValidType;
				// Console.WriteLine ("You chose " + score);

				//validate user input is 0..100 Range Check
				if(score > 100 || score < 0)
				{
					isInvalidInput = true;
					Console.WriteLine ("Score is invalid");
				}
			}while(isInvalidInput);


			//calculate grade
			string grade = "Unknown";
			if(score > 84)
			{
				grade = "A";
			}
			else if(score > 69)
			{
				grade = "B";
			}
			else if(score > 54)
			{
				grade = "C";
			}
			else if(score > 39)
			{
				grade = "D";
			}
			else
			{
				grade = "Fail";
			}
				
				


			
			//output result
			Console.WriteLine("Your grade is: " + grade);

			//hack to keep command window open
			Console.WriteLine ("\n\nHit RETURN to Exit");
			Console.Read ();

		}
	}
}

