using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelLess_App.Data
{
	public class Airport
	{
		public String code;
		public String airportname;

        public string Code { get; set; }
        public string Airportname { get; set; }
        public Airport(string code, string airportname)
		{
			this.Code = code;
			this.Airportname = airportname;
		}
	}
}
