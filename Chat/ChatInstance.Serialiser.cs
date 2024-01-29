namespace BotTest;

// this will take our messages and string them into a format the LLM can understand
public partial class ChatInstance
{
	private string SendResponseRequest(ChatPersona persona)
	{
		var prompt = SerialiseIntoPrompt(persona);

		var result = API.Generate(prompt, Parameters);
		return result.Result;
	}

	public string SerialiseIntoPrompt(ChatPersona persona)
	{
		string prompt = "";
		foreach (var message in Messages)
		{
			var a = $"{message.Sender.Name}: {message.Message}\n";
			prompt += a;
		}
		// we want the chat to complete as the following
		var b = $"{persona.Name}: ";
		prompt += b;
		return prompt;
	}
}
