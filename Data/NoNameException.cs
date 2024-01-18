using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelLess_App.Data
{
	public class NoNameException: Exception
	{
		public NoNameException() : base("Invalid Name") { }

		public NoNameException(string message) : base(message) { }
	}
}
