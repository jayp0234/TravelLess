using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelLess_App.Data
{
	public class InvalidFlightCodeException: Exception
	{
		public InvalidFlightCodeException() : base("Invalid flight code") { }

		public InvalidFlightCodeException(string message) : base(message) { }
	}
}
