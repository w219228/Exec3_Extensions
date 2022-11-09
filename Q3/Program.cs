using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int result = "s".ToInt(0);
			Console.WriteLine(result);
		}
	}
	public static class StringExensions
	{
		public static int ToInt(this string value, int defaultValue)
		{
			bool isInt = int.TryParse(value, out int num);
			return isInt ? num : defaultValue;
		}
	}
}
