using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

using ZoomApiCore.Models;

namespace ZoomApiCore.Responses
{
	public class GetMeetingListResponse
	{
		[JsonProperty("page_count")]
		public int PageCount { get; set; }

		[JsonProperty("page_number")]
		public int PageNumber { get; set; }

		[JsonProperty("page_size")]
		public int PageSize { get; set; }

		[JsonProperty("total_records")]
		public int TotalRecords { get; set; }

		[JsonProperty("next_page_token")]
		public string NextPageToken { get; set; }

		public IEnumerable<Meeting> Meetings { get; set; }
	}
}
