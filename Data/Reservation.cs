using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TravelLess_App.Data
{
    public class Reservation
    {
        public Reservation()
        {
        }

        public string reservationcode { get; set; }
        public string flightcode { get; set; }
        public string airlinename { get; set; }
        public string costOfFlight { get; set; }
        public string name { get; set; }
        public string citizenship { get; set; }
        public string status { get; set; }

		public Reservation(string reservationcode, string flightcode, string airlinename, string costOfFlight, string name, string citizenship, string status)
		{
			this.reservationcode = reservationcode;
			this.flightcode = flightcode;
			this.airlinename = airlinename;
			this.costOfFlight = costOfFlight;
			this.name = name;
			this.citizenship = citizenship;
			this.status = status;
		}

        public void writetofile(List<Reservation> res)
        {
            string path = @"C:\Users\Yashp\OneDrive\Desktop\Jay Code\TravelLess_App\TravelLess_App\TravelLess_App\Files\reservation.csv";

            using (var stream = new FileStream(path, FileMode.Append))
            {
                using (var writer = new StreamWriter(stream))
                {
                    foreach (var reservation in res)
                    {
                        writer.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6}",
                            reservation.reservationcode,
                            reservation.flightcode,
                            reservation.airlinename,
                            reservation.costOfFlight,
                            reservation.name,
                            reservation.citizenship,
                            reservation.status));
                    }
                }
            }
        }

    }
}
