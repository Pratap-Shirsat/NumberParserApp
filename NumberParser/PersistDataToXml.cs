using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NumberParser
{
	internal class PersistDataToXml : IPersistData
	{
		public List<int> numberLst { get; set; }

		public PersistDataToXml(List<int> numbers)
		{
			numberLst = numbers;
		}

		public string persistNumberData()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(List<int>));
			using (StreamWriter writer = new StreamWriter("persistData.xml"))
			{
				serializer.Serialize(writer, numberLst);
			}
			return "Saved data to xml file -> persistData.xml";
		}
	}
}
