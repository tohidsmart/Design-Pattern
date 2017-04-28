using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExtra
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false, AllowMultiple = true)]
	sealed class CommentAttribute : Attribute
	{

		public CommentAttribute(string title,string author)
		{
			Title = title;
			Author = author;
		}
		public string Title { get; set; }
		public string Author { get; set; }

		
	}

}

