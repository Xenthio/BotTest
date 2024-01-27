namespace BotTest;

// the character the LLM should pretend to be.
public class ChatPersona
{
	public string Name = "Jim";
	public string Description = "";
	public string ExampleMessages = "";

	/// <summary>
	/// are we a user or are we the ai? not used for anything might be useful down the line, remove if not.
	/// </summary>
	public bool isUser = false;
}
