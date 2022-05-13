using System;
using System.Threading;
namespace threading
{
	public class thread
	{
		public thread()
		{
			static void test1()
			{
				for (int i = 1; i <=100; i++)
					Console.WriteLine("test1:" + i);
			}

			static void test2()
			{
				for (int i = 1; i <=100; i++)
					Console.WriteLine("test2:" + i);
			}

			static void test3()
			{
				for (int i = 1; i <=100; i++)
					Console.WriteLine("test3:" + i);
			}

			static void Main()
			{
				test1();
				test2();
				test3();
			}
		}
	}
}


