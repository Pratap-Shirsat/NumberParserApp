﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberParser
{
	internal interface IPersistData
	{
		List<int> numberLst { get; set; }
		string persistNumberData();
	}
}
