using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TravelLess_App.Data
{
	public class Flights
	{
		

        public string Flightno { get; set; }
		public string Flightname { get; set; }

		public string Departairport { get; set; }

		public string Destairport { get; set; }

		public string Day { get; set; }

		public string Time { get; set; }

		public string Cost { get; set; }

		public string Seats { get; set; }
		public Flights(string flightno, string flightname, string departairport, string destairport, string day, string time, string seats, string cost)
		{
			this.Flightno = flightno;
			this.Flightname = flightname;
			this.Departairport = departairport;
			this.Destairport = destairport;
			this.Day = day;
			this.Time = time;
			this.Seats = seats;
			this.Cost = cost;
		}


	}
}
