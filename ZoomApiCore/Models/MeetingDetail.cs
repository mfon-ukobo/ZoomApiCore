using System;
using System.Collections.Generic;
using System.Text;

namespace ZoomApiCore.Models
{
	public class MeetingDetail : Meeting
	{
		public string AssistantId { get; set; }
		public string HostEmail { get; set; }
		public bool PreSchedule { get; set; }
		public string Status { get; set; }
		public string StartUrl { get; set; }
		public string Password { get; set; }
		public string H323Password { get; set; }
		public string EncryptedPassword { get; set; }
		public MeetingTrackingField TrackingFields { get; set; }
		public IEnumerable<MeetingOccurrence> Occurrences { get; set; }
		public MeetingSettings Settings { get; set; }
		public MeetingRecurrence Recurrence { get; set; }
	}
}
