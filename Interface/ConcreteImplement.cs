using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	public class ConcreteImplement : ISimpleInterface, ISecondInterface
	{

		void ISecondInterface.SecondInterfaceMethod()
		{
			Console.WriteLine("This is second method from second interface");
		}


		void ISimpleInterface.ThisMethodRequireImplementation()
		{
			Console.WriteLine("This is first method from simple interface");
		}

		int ISimpleInterface.ThisSecondMethodRequireImplementation()
		{
			Console.WriteLine("This is second method calling from Simple Interface");
			return Environment.ExitCode;
		}


		public readonly int ISimpleInterface.Property1
		{
			get
			{
				return 10;
			}

		}

		public readonly string ISimpleInterface.StringProperty
		{
			get
			{
				return string.Empty;
			}
			
		}
	}
}
