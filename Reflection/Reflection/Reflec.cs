using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Reflection
{
	class Reflec
	{

		public void GetAssemblyInfo()
		{
			Assembly info = Assembly.GetCallingAssembly();
			Console.WriteLine(info.ImageRuntimeVersion);
			
		
		}
	}
}
