using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberParser
{
	internal class PersistDataToText : IPersistData
	{
		public List<int> numberLst { get; set; }

		public PersistDataToText(List<int> numbers)
		{
			numberLst = numbers;
		}

		public string persistNumberData()
		{
			var textData = string.Join(",", numberLst);
			File.WriteAllText("persistData.txt", textData);
			return "Data saved to text file -> persistData.txt";
		}
	}
}
