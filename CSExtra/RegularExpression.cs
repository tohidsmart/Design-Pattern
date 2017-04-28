using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSExtra
{
	[TestClass]
	class RegularExpression
	{
		[TestMethod]
		public void IsCatFound()
		{
			//Arrange
			string Text = "Two cat fight against dog";
			string Pattern = "cat";
			//Act
			Regex regex = new Regex(Pattern);
			Match match = regex.Match(Text);

			//Assert
			Assert.IsTrue(match.Success);
			Console.WriteLine("{0},{1},{2}",match.Success, match.Index, match.Length);

			
		}
	}
}
