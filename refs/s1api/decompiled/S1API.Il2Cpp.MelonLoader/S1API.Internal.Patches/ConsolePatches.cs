using System;
using System.Collections.Generic;
using HarmonyLib;
using Il2CppScheduleOne;
using Il2CppSystem.Collections.Generic;
using S1API.Console;
using S1API.Internal.Utils;
using S1API.Logging;
using UnityEngine;

namespace S1API.Internal.Patches;

[HarmonyPatch]
internal static class ConsolePatches
{
	private static readonly Log Logger = new Log("Console");

	[HarmonyPatch(typeof(Console), "Awake")]
	[HarmonyPostfix]
	private static void AddCommands(Console __instance)
	{
		if ((Object)(object)__instance == (Object)null)
		{
			return;
		}
		List<Type> derivedClasses = ReflectionUtils.GetDerivedClasses<BaseConsoleCommand>();
		foreach (Type item in derivedClasses)
		{
			Logger.Msg("Found console command: " + item.FullName);
			if (!(item.GetConstructor(Type.EmptyTypes) == null))
			{
				try
				{
					BaseConsoleCommand baseConsoleCommand = (BaseConsoleCommand)Activator.CreateInstance(item);
					CustomConsoleRegistry.Register(baseConsoleCommand);
					Logger.Msg("Registered custom command '" + baseConsoleCommand.CommandWord + "' into managed registry");
				}
				catch (Exception ex)
				{
					Logger.Warning("[Console] Failed to register " + item.FullName + ": " + ex.Message);
				}
			}
		}
	}

	[HarmonyPatch(typeof(Console), "SubmitCommand", new Type[] { typeof(List<string>) })]
	[HarmonyPrefix]
	private static bool RouteCustomCommandsIl2Cpp(List<string> args)
	{
		try
		{
			if (args == null || args.Count == 0)
			{
				return true;
			}
			string text = args[0];
			if (text == null)
			{
				return true;
			}
			string text2 = text.ToLower();
			Dictionary<string, ConsoleCommand> commands = Console.commands;
			if (commands != null && commands.ContainsKey(text2))
			{
				return true;
			}
			if (CustomConsoleRegistry.TryExecute(args))
			{
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			Logger.Warning("[Console] Custom command routing failed (Il2Cpp): " + ex.Message);
			return true;
		}
	}
}
