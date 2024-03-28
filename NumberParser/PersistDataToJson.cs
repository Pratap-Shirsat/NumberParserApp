using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NumberParser
{
	internal class PersistDataToJson : IPersistData
	{
		public List<int> numberLst { get; set; }

		public PersistDataToJson(List<int> numbers)
		{
			numberLst = numbers;
		}

		public string persistNumberData()
		{
			var jsonData = JsonSerializer.Serialize(numberLst);
			File.WriteAllText("persistData.json", jsonData);
			return "Saved number data to json file -> persistData.json";
		}
	}
}
