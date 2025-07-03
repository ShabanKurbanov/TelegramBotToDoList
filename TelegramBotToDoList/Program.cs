using System;
using Otus.ToDoList.ConsoleBot;
using Otus.ToDoList.ConsoleBot.Types;
namespace TelegramBotToDoList
{
	class Program
	{
		public static void Main()
		{
			ITelegramBotClient consoleBot = new ConsoleBotClient();
			IUpdateHandler updateHandler = new HandlerUpdate();
			consoleBot.StartReceiving(updateHandler);

		}
	}
}