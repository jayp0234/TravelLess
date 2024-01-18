using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TravelLess_App.Data
{
	public class AirportManager
	{
		private const string path = @"C:\Users\Yashp\OneDrive\Desktop\Jay Code\TravelLess_App\TravelLess_App\TravelLess_App\Files\airports.csv";
		public static List<Airport> info = new List<Airport>();

		public AirportManager()
		{
			ReadAirportdata();
		}

		public void ReadAirportdata()
		{
			Airport air;
			foreach(string lines in File.ReadAllLines(path))
			{
				string[] sep=lines.Split(',');
				string code = sep[0];
				string airportname = sep[1];
				air =new Airport(code,airportname);
				info.Add(air);
			}
		}
		public static List <Airport> GetAirports()
		{
			return info;
		}
	}
}
