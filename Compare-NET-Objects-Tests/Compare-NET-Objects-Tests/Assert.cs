using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;

namespace Compare_NET_Objects_Tests.Compare_NET_Objects_Tests
{
	public static class Assert
	{
		public static void That(bool param)
		{}
		public static void IsTrue(bool param)
		{}
		
		public static void IsTrue(bool param1, string param2)
		{}

		public static void IsFalse(bool param)
		{}

		public static void IsFalse(bool param, string param2)
		{}

		public static void Fail(string param)
		{}

		public static void AreEqual(int param1, int param2)
		{}

		public static void AreEqual(string param1, string param2)
		{}

		public static void AreNotEqual(object param1, object param2)
		{}
	}
}