using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelLess_App.Data
{
	public class NoMoreSeatsException:Exception
	{
		public NoMoreSeatsException() : base("No more seats available") { }

		public NoMoreSeatsException(string message) : base(message) { }
	}
}
