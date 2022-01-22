using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http.Extensions;

using ZoomApiCore.Requests;
using ZoomApiCore.Responses;

namespace ZoomApiCore.Services
{
	public class MeetingsService
	{
		private readonly HttpService httpService;

		public MeetingsService(HttpService httpService)
		{
			this.httpService = httpService;
		}

		public async Task<CreateMeetingResponse> CreateMeeting(string userId, CreateMeetingRequest request)
		{
			return await httpService.PostAsync<CreateMeetingRequest, CreateMeetingResponse>($"users/{userId}/meetings", request);
		}

		public async Task<CreateMeetingResponse> CreateMeeting(CreateMeetingRequest request)
		{
			return await CreateMeeting("me", request);
		}

		public async Task<GetMeetingListResponse> GetMeetings(string userId, GetMeetingListRequest request)
		{
			var query = new QueryBuilder();

			query.Add("type", request.Type);
			query.Add("page_size", request.PageSize.ToString());
			query.Add("page_number", request.PageNumber);
			query.Add("next_page_token", request.NextPageToken);

			var url = $"users/{userId}/meetings?" + query.ToString();

			return await httpService.GetAsync<GetMeetingListResponse>(url);
		}

		public async Task<GetMeetingListResponse> GetMeetings(GetMeetingListRequest request)
		{
			return await GetMeetings("me", request);
		}
	}
}
