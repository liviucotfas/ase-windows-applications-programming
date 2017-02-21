using System;

namespace ExceptionHandling
{
	internal class Program
	{
		private static void Main()
		{
			AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

			//http://msdn.microsoft.com/en-us/library/gg145035.aspx

			var p = new Person("name1", 21);

			try
			{
				p.Age = -1;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			Console.WriteLine(e.ExceptionObject);
			//throw new NotImplementedException();
		}
	}
}
