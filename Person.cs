using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
	//abstract prevents developers from
	//directly instantiating this class
	public abstract class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }

		//abstract method - 
		//no default to this method.
		//doing it this way makes it required to
		//implement and overwrite in
		//the classes that inherit from this class.
		//can be limiting in some situations.
		public abstract float ComputeGradeAverage();

		//virtual method -
		//implement a default method and
		//give the option to overwrite it in
		//a specific class later.
		public virtual string SendMessage(string message)
		{
			var sb = new StringBuilder();
			var timeStamp = string.Format("Sent on {0:D} at {0:t}", DateTime.Now);
			sb.AppendLine(timeStamp);
			sb.AppendLine("");
			sb.AppendLine($"Dear {FirstName} ,");
			sb.AppendLine(message);
			return sb.ToString();
		}
	}
}
