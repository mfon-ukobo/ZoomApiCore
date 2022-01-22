using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

using Microsoft.Extensions.DependencyInjection;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using ZoomApiCore.Models;

namespace ZoomApiCore
{
	public static class ZoomClientFactory
	{
		public static void AddZoom(this IServiceCollection services, string token)
		{
			services.AddHttpClient<ZoomClient>(options =>
			{
				options.BaseAddress = new Uri("https://api.zoom.us/v2/");
				options.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
			});

			JsonConvert.DefaultSettings = () => new JsonSerializerSettings
			{
				ContractResolver = new DefaultContractResolver
				{
					NamingStrategy = new SnakeCaseNamingStrategy()
				}
			};
		}
	}
}
