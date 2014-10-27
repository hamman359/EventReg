using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventReg.Models {

	public class Session {

		public string name { get; set; }
		public string creatorName { get; set; }
		public int duration { get; set; }
		public string level { get; set; }
		public string _abstract { get; set; }
		public int upVoteCount { get; set; }
	}
}
