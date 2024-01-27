namespace BotTest;

public interface ITextgenAPI
{
	public string URL { get; set; }
	public string Port { get; set; }
	public string Endpoint { get; set; }

	public Task<string> Generate(string prompt, object parameters);
}
