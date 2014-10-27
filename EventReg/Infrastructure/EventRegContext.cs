using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EventReg.Models;

namespace EventReg.Infrastructure 
{
	public class EventRegContext : DbContext {

		public EventRegContext() {

		}

		public DbSet<EventInstance> Events { get; set; }
	}
}