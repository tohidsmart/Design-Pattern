using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExtra
{
	class Delegate
	{

		public class ListProcessor<TA, TB>
		{

			public static List<string> StringListProcessor(List<string> lstString)
			{
				lstString.ForEach(x => x.Replace(x.First(), x.Last()));
				return lstString;

			}


			internal delegate string StringProcessor(string str);

			internal delegate bool StringAcceptor(string str);

			public static List<string> StringListProcessor(List<string> lstString, StringProcessor processor)
			{
				lstString.ForEach(x => processor(x));
				return lstString;

			}

			public List<string> StringListProcessor(List<string> lstString, StringProcessor processor, StringAcceptor acceptor)
			{
				lstString.Where(x => acceptor(x)).ToList().ForEach(x => processor(x));
				return lstString;
			}

			public delegate TB ListProcessorer<in TA, out TB>(TA list);
			public delegate bool ListAcceptor<in TA>(TA list);


			public List<TA> ProcessList(List<TA> list, ListProcessorer<TA, TB> processor, ListAcceptor<TA> acceptor)
			{
				list.Where(x => acceptor(x)).ToList().ForEach(x => processor(x));
				return list;
			}

		}





		//public class ListProcessor
		//{
		//	// This is equivalent to the built-in Predicate delegate
		//	// http://msdn.microsoft.com/en-us/library/bfcke1bz.aspx
		//	public delegate bool Acceptor<in TA>(TA obj);

		//	public delegate TB Processor<in TA, out TB>(TA obj);

		//	public static List<TB> ProcessList(
		//					List<TA> objects,
		//					Acceptor<TA> acceptor,
		//					Processor<TA, TB> processor)
		//	{
		//		List<TB> newList = new List<TB>();
		//		foreach (TA obj in objects)
		//		{
		//			if (!acceptor(obj))
		//			{
		//				continue;
		//			}
		//			newList.Add(processor(obj));
		//		}
		//		return newList;
		//	}
		//}


		public class ListProcessorTest
		{
			
			static List<string> lstTest = new List<string>{
				"This is Test string 1",
				"This is Test string 2",
				"This isgenerated random string"
			};

			//static void Main(string[] args)
			//{
				//ListProcessor<string,string> processor = new ListProcessor<string,string>();
				//List<string> strings=processor.ProcessList(lstTest,str=>str.Replace(str.First(),str.Last()),str=>!str.StartsWith("#"));

				//ListProcessor<Uri, Uri> processor2 = new ListProcessor<Uri, Uri>();

				//List<int> numbers =new List<int> { 34, 56, 78, 93, 45, 21, 87, 11, 1, 33 };
				//Sorting.BubleSort<int> Sorter = new Sorting.BubleSort<int>(numbers);
				//Sorter.Sort();

			//	Sorting.SelectionSort SelectionSorter = new Sorting.SelectionSort(numbers);
			//	SelectionSorter.Sort();

			//	int i = 0;
						
			//}

		

			
		
		  
		}
	}
}
