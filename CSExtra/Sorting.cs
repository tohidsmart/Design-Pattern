using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExtra
{
	public class Sorting
	{
		public class BubleSort<T> where T : IComparable
		{
			public BubleSort(List<T> objects)
			{
				Objects = objects;
			}

			public List<T> Objects { get; set; }
			public void Sort()
			{
				int numberOfObjects = Objects.Count;

				for (int i = 0; i < numberOfObjects; i++)
				{
					for (int j = 0; j < numberOfObjects - 1; j++)
					{
						if (CompareTo(j) > 0)
						{
							T temp = Objects[j];
							Objects[j] = Objects[j + 1];
							Objects[j + 1] = temp;
						}
					}

				}


			}

			public int CompareTo(int index)
			{
				T values = Objects[index];
			return values.CompareTo(Objects[index+1]);
			}
		}


		public class SelectionSort 
		{
			public List<int> Collection { get; set; }
			public SelectionSort(List<int> collection)
			{
				Collection = collection;
			}

			public void Sort()
			{
				for (int i = 0; i < Collection.Count; i++)
				{
					int index_of_min = i;
					for (int j = i; j < Collection.Count; j++)
					{
						if(Collection[index_of_min]>Collection[j])
						{
							index_of_min = j;
						}
					}
					int temp = Collection[i];
					Collection[i] = Collection[index_of_min];
					Collection[index_of_min] = temp;

				}
			}
		}
		}

		
}
