using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace ZoomApiCore.Requests
{
	public class CreateMeetingRequest
	{
		/// <summary>
		/// The meeting's topic
		/// </summary>
		[JsonProperty("topic")]
		public string Topic { get; set; }

		/// <summary>
		/// The type of meeting
		/// </summary>
		public int Type { get; set; }

		/// <summary>
		/// The meeting’s start time. This field is only used for scheduled and/or recurring meetings with a fixed time. 
		/// This supports local time and GMT formats.
		/// <list type="bullet">
		///		<item>
		///			To set a meeting’s start time in GMT, use the <c>yyyy-MM-ddTHH:mm:ssZ</c> date-time format. 
		///			For example, <code>2020-03-31T12:02:00Z</code>
		///		</item>
		///		<item>
		///			To set a meeting’s start time using a specific timezone, use the <c>yyyy-MM-ddTHH:mm:ss</c> date-time format and specify the
		///			TimeZone ID in the <see cref="Timezone"/> field.
		///			If you do not specify a timezone, the TimeZone value defaults to your Zoom account’s timezone. 
		///			You can also use <c>UTC</c> for the TimeZone value.
		///		</item>
		/// </list>
		/// </summary>
		[JsonProperty("start_time")]
		public string StartTime { get; set; }

		/// <summary>
		/// The meeting’s scheduled duration, in minutes. This field is only used for scheduled meetings.
		/// </summary>
		public int Duration { get; set; }

		public string Timezone { get; set; }

		public string Password { get; set; }
	}
}
