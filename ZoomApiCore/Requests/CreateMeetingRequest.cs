using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

using ZoomApiCore.Models;

namespace ZoomApiCore.Requests
{
	public class CreateMeetingRequest
	{
		public string Topic { get; set; }
		public int Type { get; set; }
		public bool PreSchedule { get; set; }
		public string StartTime { get; set; }
		public int Duration { get; set; }
		public string ScheduleFor { get; set; }
		public string Timezone { get; set; }
		public string Password { get; set; }
		public bool DefaultPassword { get; set; }
		public string Agenda { get; set; }
		public IEnumerable<MeetingTrackingField> TrackingFields { get; set; }
		public MeetingRecurrence Recurrence { get; set; }
		public MeetingSettings Settings { get; set; }
		public string TemplateId { get; set; }
	}
}
