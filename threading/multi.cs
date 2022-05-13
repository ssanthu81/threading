using System;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics
namespace threading
{
	 class EmptyClass11
	{
		public void EmptyClass()
		{
			long Count = 0;
			for (long i = 0; i <= 1000; i++)
				Count++;
			Console.WriteLine("EmptyClass:" + Count);

		}
		public void EmptyClass2()
		{
			long Count = 0;
			for (long i = 0; i <= 1000; i++)
				Count++;
			Console.WriteLine("EmptyClass2:" + Count);

		}
		static void Main()
        {
			EmptyClass ();
			EmptyClass2();
			Console.ReadLine(); 
        }
	}
}

