using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Liskov
{
	public class ShapeCalculator
	{
		public static int CalculateArea(Rectangle r)=> r.Height * r.Width;
		

		public static int CalculateArea(Square r)=> r.Width * r.Height;
		


		

	}
}
