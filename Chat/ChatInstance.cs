namespace BotTest;

public partial class ChatInstance
{
	public ITextgenAPI API;
	public List<ChatMessage> Messages = new List<ChatMessage>();
	public TextGenerationParameters Parameters = new TextGenerationParameters()
	{
		max_new_tokens = 256,
		do_sample = true,
		seed = -1,
		top_k = 10
	};

	public void SendMessage(ChatMessage message)
	{
		Messages.Add(message);
	}
	public ChatMessage ReceiveMessage(ChatPersona personality)
	{
		string txtmsg = "";

		var message = new ChatMessage()
		{
			Sender = personality,
			Message = txtmsg
		};
		Messages.Add(message);
		return message;
	}
}
