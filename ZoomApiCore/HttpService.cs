using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ZoomApiCore
{
	public class HttpService
	{
		private readonly HttpClient client;

		private const string MediaType = "application/json";

		public HttpService(HttpClient client)
		{
			this.client = client;
		}

		public async Task<TResponse> GetAsync<TResponse>(string uri)
		{
			var request = new HttpRequestMessage(HttpMethod.Get, uri);

			return await Execute<TResponse>(request);
		}

		public async Task<TResponse> PostAsync<TRequest, TResponse>(string uri, TRequest data)
		{
			var request = new HttpRequestMessage(HttpMethod.Post, uri);
			request.Content = new StringContent(JsonConvert.SerializeObject(data), Encoding.ASCII, MediaType);

			return await Execute<TResponse>(request);
		}

		private async Task<T> Execute<T>(HttpRequestMessage request)
		{
			var response = await client.SendAsync(request);

			response.EnsureSuccessStatusCode();

			var responseContent = await response.Content.ReadAsStringAsync();
			var responseObject = JsonConvert.DeserializeObject<T>(responseContent);

			return responseObject;
		}
	}
}
