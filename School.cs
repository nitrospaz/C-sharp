using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
	//this is a class library
	public class School
	{
		//short way of doing it
		//auto property variables
		public string Name { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string PhoneNumber { get; set; }

		//long way of doing it
		//backing variable with
		//private access modifier limits visibility outside of class
		//prevents direct manipulation of the variable
		private string _twitterAddress;

		//encapsulated logic property

		//property decleration exposes value
		//includes logic
		//to prevent improper data from being entered
		public string TwitterAddress
		{
			//make sure the twitter address starts with @
			get { return _twitterAddress; }
			set
			{
				if (value.StartsWith("@"))
				{
					_twitterAddress = value;
				}
				else
				{
					throw new Exception("The twitter address muct begin with @");
				}
			}
		}

		//use full namespace to call proper class
		//if multiple classes with same name

		//Elementary.Volume volume;	
		//HighSchool.Volume volume2;


		//constructor
		//needs to be named the same as the class
		//constructors dont have a return type
		//ctor + tab + tab magic
		//constructors job is usually to set initial values
		public School()
		{
			//default values
			Name = "Untitled School";
			PhoneNumber = "555-1234"; //fake phone number, there is no 555 exchange
		}

		//overloaded constructor
		//in parenthesis is the method signature or number of arguments
		//can make as many overloaded constructors as is practical for each variant
		public School(string SchoolName, string SchoolPhoneNumber)
		{
			Name = SchoolName;
			PhoneNumber = SchoolPhoneNumber;
		}

		//method or function
		//use access modifiers
		//specify return type, name, arguments
		public float AverageThreeScores(float a, float b, float c)
		{
			var result = (a + b + c) / 3;
			return result;
		}

		//overloaded method 
		//overloading is a type of polymorphism
		//same name, different signature (type or number of arguments)
		//static method makes it available outside the class without instantiating the class
		public static int AverageThreeScores(int a, int b, int c)
		{
			//method body
			var result = (a + b + c) / 3;
			return result; //if return type is void then do not need return here
		}

		//function bodied expression
		//different way of writing a method
		//similar to arrow function in JS
		//handy for simple things
		public static double AverageThreeScores(double a, double b, double c) => (a + b + c) / 3;

		//overriding base ToString
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine(Name);
			sb.AppendLine(Address);
			sb.Append(this.City);
			sb.Append(", ");
			sb.Append(State);
			sb.Append(" ");
			sb.Append(Zip);

			return sb.ToString();
		}
	}
}
