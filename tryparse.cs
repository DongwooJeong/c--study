using System;
					
public class Program
{
	public static void Main()
	{
		
		int retval = 0;
		Console.Write("Enter: ");
		string strVal = Console.ReadLine();
		bool bl = Int32.TryParse(strVal, out retval);
		Console.WriteLine("bl: {0}", bl);		
		Console.WriteLine("ret: {0}", retval);
		
	}
}