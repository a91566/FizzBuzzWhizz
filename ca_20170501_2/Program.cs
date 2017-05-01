using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_20170501_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("请输入三个数（1-9）以逗号分隔：");
			string word = Console.ReadLine();
			string[] words = word.Split(new char[] { ',' });
			int[] nums = new int[3];
			try
			{
				for (int i = 0; i < 3; i++)
				{
					int.TryParse(words[i], out nums[i]);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			for (int i = 1; i < 101; i++)
			{
				Console.WriteLine(new Student(i, nums).Speak());
			}

			Console.ReadKey();
		}
	}
}
