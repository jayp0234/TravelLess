using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace TravelLess_App.Data
{
	public class ReservationManager
	{
		private const string path = @"C:\Users\Yashp\OneDrive\Desktop\Jay Code\TravelLess_App\TravelLess_App\TravelLess_App\Files\reservation.csv";
		public static List<Reservation> info = new List<Reservation>();

        public static List<Reservation> ReadFromFile()
        {
            var reservations = new List<Reservation>();

            using (var stream = new FileStream(path, FileMode.Open))
            {
                using (var reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        var reservation = new Reservation();
                        reservation.reservationcode = values[0];
                        reservation.flightcode = values[1];
                        reservation.airlinename = values[2];
                        reservation.costOfFlight = values[3];
                        reservation.name = values[4];
                        reservation.citizenship = values[5];
                        reservation.status = values[6];

                        reservations.Add(reservation);
                    }
                }
            }

            return reservations;
        }

        public void UpdateInBinaryFile(string reservationCode, string newName, string newcitizen, string newstatus)
		{
			List<Reservation> reservations = ReadFromFile();

			foreach (var reservation in reservations)
			{
				if (reservation.reservationcode == reservationCode)
				{
					reservation.name = newName;
					reservation.citizenship = newcitizen;
					reservation.status = newstatus;
					break;
				}
			}
			Reservation reservation1 = new Reservation();
			reservation1.writetofile(reservations);
		}
	}
}
