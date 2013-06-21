using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Screen = System.Console;

namespace BoxingUnboxing
{
	class Program
	{
		// This is a single line comment
		/*
		 * This is a multi-line comment
		 */
		public static int Main (string[] args)
		{
			int[] x = new int[10];
			Array.Sort(x);
			ArrayList List = new ArrayList();
			List.Add("Hello");
			List.Add("World");
			return (0);
		}
	}

	class TestClass
	{
		public TestClass (string s)
		{
			Console.WriteLine("TestClass class says: " + s);
		}
	}
}
