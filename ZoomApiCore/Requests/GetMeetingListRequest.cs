using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace ZoomApiCore.Requests
{
	public class GetMeetingListRequest
	{
		public string Type { get; set; } = "live";

		[JsonProperty("page_size")]
		public int PageSize { get; set; } = 30;

		[JsonProperty("next_page_token")]
		public string NextPageToken { get; set; }

		[JsonProperty("page_number")]
		public string PageNumber { get; set; } = "1";
	}
}
