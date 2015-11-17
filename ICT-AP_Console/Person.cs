// /** 
//  *  Class to demo Class definition, State, Behaviour
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


	public class Person
	{
		// State
		private string Name;
		private string DateOfBirth; //Date
		private double Height;
		private string PPS;
		private char Gender;

		//Setter / Mutator
		public void SetName(string newName)
		{
			Name = newName;
		}

		//Getter / Accessor
		public string GetName()
		{
			return Name;
		}

		public void SetHeight(double NewHeight)
		{
			Height = NewHeight;
		}

		public double GetHeight()
		{
			return Height;
		}

	}
}

