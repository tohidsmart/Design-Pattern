using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	public	class ClientConcreteImplementation
	{
		ISimpleInterface InterfaceRefrence;
		public ClientConcreteImplementation(ISimpleInterface interfaceRefrence,ConcreteImplement Implementator)
		{
			
			InterfaceRefrence = interfaceRefrence;
			var s=InterfaceRefrence.Property1;
			InterfaceRefrence.ThisMethodRequireImplementation();
		}

		 
	}
}
