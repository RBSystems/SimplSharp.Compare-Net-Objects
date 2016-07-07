using System;
using System.Text;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes

using KellermanSoftware.CompareNetObjects;

namespace Crestron.SimplSharp.Compare_NET_Objects
{
	public class SimpleSharpCompare
	{

		/// <summary>
		/// SIMPL+ can only execute the default constructor. If you have variables that require initialization, please
		/// use an Initialize method
		/// </summary>
		public SimpleSharpCompare()
		{
			var cl = new CompareLogic();
			var comparisonResult = cl.Compare(new string[] { "a", "b", }, new string [] { "a", "b"});
			CrestronConsole.PrintLine(comparisonResult.AreEqual.ToString());
		}
	}
}
