using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DesignPatterns
{
	class MachineFactory
	{
		Dictionary<string, Type> Types;

		public IMachine GetMachine(string description)
		{
			Type t=GetTypeToCreate(description);
			if (t != null)
				return Activator.CreateInstance(t) as IMachine;
			return null;
		}

		public Type GetTypeToCreate(string description)
		{
			if (Types.ContainsKey(description))
				return Types[description];
			return null;
		}

		public MachineFactory()
		{

			LoadTypes();
		}

		public void LoadTypes()
		{
			Types = new Dictionary<string, System.Type>();
			Type[] CurrentTypesInAssembly = Assembly.GetExecutingAssembly().GetTypes();

			foreach (var type in CurrentTypesInAssembly)
			{
				if (type.GetInterface("IMachine") != null)
				{
					Types.Add(type.Name.ToLower(), type);
				}
			}
		}

	}
}
