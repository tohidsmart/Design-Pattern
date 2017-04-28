using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	public class SingletonNoThreadSafe
	{


		private SingletonNoThreadSafe()
		{

		}

		private static SingletonNoThreadSafe instance;

		public static SingletonNoThreadSafe Instance
		{
			get
			{
				if (instance == null) instance = new SingletonNoThreadSafe();
				return instance;
			}
		}


	}

	public class SingletonThreadSafeWithLock
	{
		private static SingletonThreadSafeWithLock instance = null;
		private static readonly object lockObj = new Object();

		private SingletonThreadSafeWithLock()
		{

		}

		public static  SingletonThreadSafeWithLock Instance
		{
			get
			{
				lock (lockObj)
				{
					if (instance == null) return new SingletonThreadSafeWithLock();
				}
				return instance;
			}
		}

	}


	public  class SingleTonThreadSafeWithStaticConstructor
	{
		//Static constructor are specified to create object when only instance of object created or refrenced and only once per AppDomain
		private static readonly SingleTonThreadSafeWithStaticConstructor singleton = 
			new SingleTonThreadSafeWithStaticConstructor();

		public static SingleTonThreadSafeWithStaticConstructor Instance = singleton;

		static SingleTonThreadSafeWithStaticConstructor() { }
		private SingleTonThreadSafeWithStaticConstructor() { }

	}


}
