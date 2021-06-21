using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
	public interface IScored
	{
		//don't actually write logic or code 
		//in an interface, only define structure.
		//Java doesn't allow properties in an interface.
		//in C# properties are effectively methods
		float Score { get; set; }
		float MaximumScore { get; set; }
	}
}
