using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xunit;

using ZoomApiCore;
using ZoomApiCore.Requests;

namespace Tests.Meetings
{
	public class CreateMeeting
	{
		private readonly ZoomClient zoomClient;

		public CreateMeeting()
		{
			zoomClient = new ZoomClient(new HttpService(new HttpClient()));
		}

		[Fact]
		public async Task NullRequestModel()
		{
			await Assert.ThrowsAsync<ArgumentNullException>(async () =>
			{
				await zoomClient.Meetings.CreateMeeting(null);
			});
		}

		[Fact]
		public async Task NullUserId()
		{
			await Assert.ThrowsAsync<ArgumentException>(async () =>
			{
				await zoomClient.Meetings.CreateMeeting(null, new CreateMeetingRequest());
			});
		}
	}
}
