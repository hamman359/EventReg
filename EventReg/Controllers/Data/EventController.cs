using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EventReg.Models;
using Newtonsoft.Json;

namespace EventReg.Controllers.Data {

	public class EventController : ApiController {

		public EventInstance GetEvent(int id) {

			var path = ConfigurationManager.AppSettings["DataFolder"] + id + ".json";

			string json = System.IO.File.ReadAllText(path);

			var _event = JsonConvert.DeserializeObject<EventInstance>(json);

			return _event;
		}

		public bool PostEvent(EventInstance instance) {

			var output = JsonConvert.SerializeObject(instance);

			var path = ConfigurationManager.AppSettings["DataFolder"] + instance.id + ".json";

			System.IO.File.WriteAllText(path, output);

			return true;
		}

		public EventInstance[] GetAll()
		{
			var path = ConfigurationManager.AppSettings["DataFolder"];

			var events = new List<EventInstance>();

			string[] files = Directory.GetFiles(path, "*.json");

			foreach (string file in files)
			{
				string json = System.IO.File.ReadAllText(file);

				events.Add(JsonConvert.DeserializeObject<EventInstance>(json));
			}

			return events.ToArray();
		}

	}
}
