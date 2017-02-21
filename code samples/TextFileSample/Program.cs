using System;
using System.IO;

namespace TextFileSample
{
	internal class Program
	{
		static void Main()
		{
			DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();

			// Write each directory name to a file.
			using (StreamWriter sw = new StreamWriter("CDriveDirs.txt"))
			{
				foreach (DirectoryInfo dir in cDirs)
				{
					sw.WriteLine(dir.Name);
				}
			}

			// Read and show each line from the file.
			using (StreamReader sr = new StreamReader("CDriveDirs.txt"))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					Console.WriteLine(line);
				}
			}
		}
	}
}
