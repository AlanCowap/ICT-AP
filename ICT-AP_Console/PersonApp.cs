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
	public class PersonApp
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Welcome to PersonApp");	

			//create a Person and change state
			Person p = new Person (); 
			p.SetName("John Doe");
			string name = p.GetName ();
			Console.WriteLine ("Name is {0}", name);
			p.SetHeight (180);
			double height = p.GetHeight ();
			Console.WriteLine ("Height is {0}", height);

			//create a second Person
			Person q = new Person();
			q.SetName("Jane Doe");
			q.SetHeight (170);

			name = q.GetName ();
			Console.WriteLine ("Name is {0}", name);
			height = q.GetHeight ();
			Console.WriteLine ("Height is {0}", height);


			Console.Write ("\nPress RETURN to continue");
			Console.Read ();
		}

	}
}

