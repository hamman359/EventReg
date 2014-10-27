using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventReg.Models {

	public class EventInstance {

		public int id { get; set; }
		public string name { get; set; }
		public string date { get; set; }
		public string time { get; set; }
		public Location location { get; set; }
		public string imageUrl { get; set; }
		public List<Session> sessions { get; set; }
	}
}