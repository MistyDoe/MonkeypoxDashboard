using System;
using System.Collections.Generic;
using System.Linq;
using Web_API.Entities;

namespace Web_API.Services
{ 
	public class DataCleaningService
	{

		public int[] GetCaseCounts (List cases)
		{ 
			List data = List cases;
			data = data.SortBy(d => d.DateRep)
		}
	}
}
