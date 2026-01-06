using System;
using System.Collections.Generic;
using Il2CppSystem.Collections.Generic;
using S1API.Logging;

namespace S1API.Console;

internal static class CustomConsoleRegistry
{
	private static readonly Log Logger = new Log("Console");

	private static readonly Dictionary<string, BaseConsoleCommand> registry = new Dictionary<string, BaseConsoleCommand>(StringComparer.OrdinalIgnoreCase);

	internal static void Register(BaseConsoleCommand command)
	{
		if (command != null)
		{
			string text = (command.CommandWord ?? string.Empty).Trim();
			if (string.IsNullOrEmpty(text))
			{
				Logger.Warning("Skipping registration of command with empty CommandWord");
			}
			else
			{
				registry[text] = command;
			}
		}
	}

	internal static bool TryExecuteManaged(List<string> args)
	{
		if (args == null || args.Count == 0)
		{
			return false;
		}
		for (int i = 0; i < args.Count; i++)
		{
			if (args[i] != null)
			{
				args[i] = args[i].ToLowerInvariant();
			}
		}
		string text = args[0];
		if (!registry.TryGetValue(text, out BaseConsoleCommand value))
		{
			return false;
		}
		try
		{
			List<string> list = new List<string>(args);
			list.RemoveAt(0);
			value.ExecuteCommand(list);
			return true;
		}
		catch (Exception ex)
		{
			Logger.Warning("[Console] Error executing custom command '" + text + "': " + ex.Message);
			return false;
		}
	}

	internal static bool TryExecute(List<string> args)
	{
		if (args == null || args.Count == 0)
		{
			return false;
		}
		string text = (args[0] ?? string.Empty).ToLower();
		if (!registry.TryGetValue(text, out BaseConsoleCommand value))
		{
			return false;
		}
		try
		{
			List<string> list = new List<string>(Math.Max(args.Count - 1, 0));
			for (int i = 1; i < args.Count; i++)
			{
				string item = args[i];
				list.Add(item);
			}
			value.ExecuteCommand(list);
			return true;
		}
		catch (Exception ex)
		{
			Logger.Warning("[Console] Error executing custom command '" + text + "' (Il2Cpp): " + ex.Message);
			return false;
		}
	}
}
