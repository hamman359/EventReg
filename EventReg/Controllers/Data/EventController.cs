using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EventReg.Models;

namespace EventReg.Controllers.Data {

	public class EventController : ApiController {

		public EventInstance GetEvent(int id) {
			//TODO: Update this to lookup in DB.
			return new EventInstance {
				name = "Angular Boot Camp",
				date = "1/1/2014",
				time = "10:30 am",
				location = new Location {
					address = "Google Headquarters",
					city = "Mountain View",
					province = "CA"
				},
				imageUrl = "/Content/Images/angularjs-large.png",
				sessions = new List<Session> {
					new Session {
						name = "Directives Masterclass",
						creatorName = "Bob Smith",
						duration = 1,
						level = "Advanced",
						_abstract = "In this session you will learn the ins and outs of directives!",
						upVoteCount = 0
					},
					new Session {
						name = "Scopes for fun and profit",
						creatorName = "John Doe",
						duration = 2,
						level = "Introductory",
						_abstract = "This session will take a closer look at scopes. Learn what they do, how they do it, and how to get them to do it for you.",
						upVoteCount = 0
					},
					new Session {
						name = "Well Behaved Controllers",
						creatorName = "Jane Doe",
						duration = 4,
						level = "Intermediate",
						_abstract = "Controllers are the beginning of everything Angular does. Learn how to craft controllers that will win the respect of your friends and neighbors.",
						upVoteCount = 0
					}
				}
			};
		}

		public bool PostEvent(EventInstance instance) {
			//TODO: Add EF and make this save to DB.
			return true;
		}
	}
}
