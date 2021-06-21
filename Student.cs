using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
	public class Student : Person
	{
		public enum GradeLevels { Freshman, Sophmore, Junior, Senior }
		public GradeLevels GradeLevel { get; set; }

		//overriding the base class abstract method implementation
		public override float ComputeGradeAverage()
		{
			//TODO: fix implementation later
			return 4.0f;
		}


		//overriding the virtual method only in the student class,
		//not the teacher class, to add a disclaimer at the end.
		public override string SendMessage(string message)
		{
			var originalMessage = base.SendMessage(message);
			var sb = new StringBuilder(originalMessage);
			sb.AppendLine("This message is private and confidential.");
			return sb.ToString();
		}
	}
}
