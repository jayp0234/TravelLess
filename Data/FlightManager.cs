using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TravelLess_App.Data
{
	public class FlightManager
	{
		private const string path = @"C:\Users\Yashp\OneDrive\Desktop\Jay Code\TravelLess_App\TravelLess_App\TravelLess_App\Files\flights.csv";
		public static List<Flights> info = new List<Flights>();

		public FlightManager()
		{
			Readflightdata();
		}
		private void Readflightdata()
		{
			Flights flight;
			foreach (string lines in File.ReadLines(path))
			{
				string[] sep = lines.Split(',');
				string flightNo = sep[0];
				string flightName = sep[1];
				string departAirport = sep[2];
				string destAirport = sep[3];
				string day = sep[4];
				string time = sep[5];
				string seats = sep[6];
				string cost = sep[7];

				flight = new Flights(flightNo,flightName,departAirport,destAirport,day,time,seats,cost);
				info.Add(flight);
			}
		}
		public static List<Flights> GetFlights()
		{ return info; }
	}
}
