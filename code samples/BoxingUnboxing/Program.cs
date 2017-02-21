namespace BoxingUnboxing
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			int i = 123;
			object o = i; // Box the int

			int y = (int)o; // Unbox the int

			long zLong = (long)o; // InvalidCastException
			string zString = (string)o; // InvalidCastException

			byte w = (byte)(int)o; //succeeds
		}
	}
}
