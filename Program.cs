using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
	class Program
	{
		static void Main(string[] args)
		{
			Random Engine = new Random();
			int Scrt = Engine.Next(100) + 1;
			int Usr = 0;
			int i = 0;

			while (Usr != Scrt)
			{
				Console.WriteLine("Please Pick a Number");
				Usr = Convert.ToInt32(Console.ReadLine());
				if (Usr < Scrt)
					{
					Console.WriteLine("The picked number is less than the random number");
				}
				else
				{
					if (Usr > Scrt)
					{
						Console.WriteLine("The picked number is Greater than the random number");
					}
				}
				i++;

			}
			Console.WriteLine($"Done!, you make {i} trials");


		}
	}
}
