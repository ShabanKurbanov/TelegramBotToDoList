using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otus.ToDoList.ConsoleBot;
using Otus.ToDoList.ConsoleBot.Types;

namespace TelegramBotToDoList
{
	class HandlerUpdate : IUpdateHandler
	{
		List<string> _items = new List<string>();
		private string commandList = "/add, /remove, /complete ";

		public void HandleUpdateAsync(ITelegramBotClient botClient, Update update)
		{
			botClient.SendMessage(update.Message.Chat, "Введите команду: ");
			string? command = Console.ReadLine();

			switch (command)
			{
				case "/addtask":
					CommandSave(botClient, update);
					break;
			}
		}

		private void CommandSave(ITelegramBotClient botClient, Update update)
		{
			botClient.SendMessage(update.Message.Chat, "Введите задачу: ");

			string? task = Console.ReadLine();
			if(task != null)
				_items.Add(task);

			botClient.SendMessage(update.Message.Chat, "Задача успешно добавлена!");



		}
	}
}
