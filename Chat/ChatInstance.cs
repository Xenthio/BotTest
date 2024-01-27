namespace BotTest;

public class ChatInstance
{
	public ITextgenAPI API;
	public List<ChatMessage> Messages = new List<ChatMessage>();

	public void SendMessage(ChatMessage message)
	{

	}
	public ChatMessage ReceiveMessage(ChatPersona personality)
	{
		var msg = new ChatMessage()
		{
			Sender = ""
		};
		return msg;
	}
}
