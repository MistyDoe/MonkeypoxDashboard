using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Entities;



namespace Web_API
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            var data1 = new Case ()
			{
				id = 1,
				DataRep = 2022 - 01 - 12,
				CountryExp = 'Belgium',
				ConfCases = 20
			}

			var data2 = new Case ()
			{
				id = 2,
				DataRep = 2022 - 01 - 17,
				CountryExp = 'Belgium',
				ConfCases = 27
			}
			return List cases = new List<case>() { data1, data2 }
        
			Console.WriteLine(Cases);
        
        }
            
    }
}
