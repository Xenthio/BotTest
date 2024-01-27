namespace BotTest;

class Program
{
	public static void Main()
	{
		//This is a discord bot! we should hop directly into the bot stuff! it's seperated just incase this ever becomes something else

		string APIKey = File.ReadAllText("D:\\Key.txt");

		var b = new DiscordBot(APIKey);
	}
}