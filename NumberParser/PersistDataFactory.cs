using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberParser
{
	internal class PersistDataFactory
	{
		List<int> numberList { get; set; }
		string fileFormat { get; set; }
		public PersistDataFactory(List<int> numbers, string fileType)
		{
			numberList = numbers;
			fileFormat = fileType;
		}

		public string persistNumberData()
		{
			try
			{
				string fnResponse = String.Empty;
				switch (fileFormat)
				{
					case ("TEXT"):
						PersistDataToText dataToText = new PersistDataToText(numberList);
						fnResponse = dataToText.persistNumberData();
						break;
					case ("JSON"):
						PersistDataToJson dataToJson = new PersistDataToJson(numberList);
						fnResponse = dataToJson.persistNumberData();
						break;
					case ("XML"):
						PersistDataToXml dataToXml = new PersistDataToXml(numberList);
						fnResponse = dataToXml.persistNumberData();
						break;
					default:
						fnResponse = "File format did not matched";
						break;
				}
				return fnResponse;
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
	}
}
