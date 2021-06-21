using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
	//extension methods add on to an already existing method
	//useful when we dont have access to the source code or original
	public static class ExtensionMethods
	{
		//using 'this' keyword attaches/extends this method to the string (or whatever) class
		public static int WordCount(this string str)
		{
			var wordCount = str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
			return wordCount;
		}
	}
}
