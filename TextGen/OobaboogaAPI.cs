using Newtonsoft.Json;
using System.Text;

namespace BotTest;

public class OobaboogaAPI : ITextgenAPI
{
	public string URL { get; set; } = "127.0.0.1";
	public string Port { get; set; } = "7861";
	public string Endpoint { get; set; } = "v1/completions";

	HttpClient _HttpClient = new HttpClient();
	public async Task<string> Generate(string prompt, object parameters)
	{
		//OpenAI Style API
		var FULLURL = $"http://{URL}:{Port}/{Endpoint}";

		var serialisedParams = new StringContent(JsonConvert.SerializeObject(parameters), Encoding.UTF8, "application/json");
		var httpResponse = await _HttpClient.PostAsync(FULLURL, serialisedParams);
		var result = await httpResponse.Content.ReadAsStringAsync();
		return result;
	}
}
