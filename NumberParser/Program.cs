using NumberParser;
using System;

class Program
{
	static void Main(string[] args)
	{
		try
		{
			string[] validFileFormats = ["JSON", "XML", "TEXT"];
			if (args.Length == 2)
			{
				string[] strNumberList = args[0].Split(',');
				var fileType = args[1];

				int[] numberList = new int[strNumberList.Length];
				for (int i = 0; i < strNumberList.Length; i++)
				{
					if (int.TryParse(strNumberList[i], out int num))
					{
						numberList[i] = num;
					}
					else
					{
						throw new Exception("Invalid number list provided as first argument!");
					}
				}

				List<int> sortedNumbers = numberList.OrderByDescending(n => n).ToList();

				if (!validFileFormats.Contains(fileType))
				{
					throw new Exception("Valid file formats JSON, XML or TEXT are supported by application passed as second argument!");
				}

				PersistDataFactory dataFactory = new PersistDataFactory(sortedNumbers, fileType);
				string factoryRes = dataFactory.persistNumberData();
				Console.WriteLine(factoryRes);
			}
			else
			{
				Console.WriteLine("Two arguments are required. string containing array and file format");
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
	}
}
