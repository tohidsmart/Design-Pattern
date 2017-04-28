using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Liskov;

namespace TestProject
{
	[TestClass]
	public class LiskovTest
	{
		[TestMethod]
		public void Rectangle6for2x3Area()
		{
			Rectangle r=new Rectangle(){Width=3 ,Height=2};
			Assert.AreEqual(6, ShapeCalculator.CalculateArea(r));
		}

		public void Square9for3x3Area()
		{
			Square s = new Square() { Width = 3 };
			Assert.AreEqual(9, ShapeCalculator.CalculateArea(s));
		}

	}
}
