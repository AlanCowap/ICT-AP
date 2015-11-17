// /** 
//  *  Class to demo File IO
//  *  
//  * @author Alan Cowap 
//  * @version 1.0  
//  * @dependencies None
//  *  
//  */
//
using System;
using System.IO;

namespace ICTAP_Console
{
	public class SimpleIO
	{
		private static string FileName = ".\\Test.txt";

		public static void Main (string[] args)
		{
			Console.WriteLine ("Welcome to SimpleIO");	

			writeFile ();
			readFile ();

			Console.Write ("\nPress RETURN to continue");
			Console.Read ();

		}

		private static void writeFile(){
			StreamWriter writer = new StreamWriter(FileName);
			writer.WriteLine("File created using StreamWriter class.");
			writer.Close();
			Console.WriteLine("File Written to " + FileName);
		}

		private static void readFile()
		{
			StreamReader reader = new StreamReader(FileName);
			try   
			{    
				do
				{
					Console.WriteLine(reader.ReadLine());
				}   
				while(reader.Peek() != -1);
			}
			catch 
			{ 
				Console.WriteLine("File is empty");
			}
			finally
			{
				reader.Close();
			}
		}

	}
}

