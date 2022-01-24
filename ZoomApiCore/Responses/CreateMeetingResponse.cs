using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace ZoomApiCore.Responses
{
	public class CreateMeetingResponse
	{
		public int Id { get; set; }
		public string HostEmail { get; set; }
		public string Topic { get; set; }
		public int Type { get; set; }
		public string StartTime { get; set; }
	}
}
