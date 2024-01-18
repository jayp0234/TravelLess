using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelLess_App.Data
{
	public class InvalidCitizenshipException: Exception
	{
		public InvalidCitizenshipException() : base("Invalid Citizenship") { }


		public InvalidCitizenshipException(string message) : base(message) { }
	}
}
