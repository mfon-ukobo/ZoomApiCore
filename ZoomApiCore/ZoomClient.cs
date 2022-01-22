using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

using ZoomApiCore.Services;

namespace ZoomApiCore
{
	public class ZoomClient
	{
		private readonly HttpService httpService;

		public ZoomClient(HttpService httpService)
		{
			this.httpService = httpService;
		}

		public MeetingsService Meetings => new MeetingsService(httpService);
	}
}
