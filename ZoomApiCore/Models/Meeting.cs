using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace ZoomApiCore.Models
{
	public class Meeting
	{
		public string Uuid { get; set; }
		public long Id { get; set; }
		public string HostId { get; set; }
		public string Topic { get; set; }
		public int Type { get; set; }
		public string StartTime { get; set; }
		public int Duration { get; set; }
		public string TimeZone { get; set; }
		public string CreatedAt { get; set; }
		public string JoinUrl { get; set; }
		public string Agenda { get; set; }
		public string Pmi { get; set; }
	}
}
