using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	public interface ISimpleInterface
	{
		void ThisMethodRequireImplementation ();
		int ThisSecondMethodRequireImplementation();
		 int Property1 { get; set; }
		 string StringProperty { get; set; }

	}

	public interface ISecondInterface
	{
		void SecondInterfaceMethod();
		string Property2 { get; set; }
	}
}
