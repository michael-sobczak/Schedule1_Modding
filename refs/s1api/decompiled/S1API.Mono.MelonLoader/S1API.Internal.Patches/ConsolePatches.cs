using System;
using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using S1API.Console;
using S1API.Internal.Utils;
using S1API.Logging;
using ScheduleOne;
using UnityEngine;

namespace S1API.Internal.Patches;

[HarmonyPatch]
internal static class ConsolePatches
{
	private static readonly Log Logger = new Log("Console");

	private static FieldInfo? _monoCommandsField;

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
	private static bool RouteCustomCommandsMono(List<string> args)
	{
		try
		{
			if (args == null || args.Count == 0)
			{
				return true;
			}
			string text = args[0];
			if (string.IsNullOrEmpty(text))
			{
				return true;
			}
			string key = text.ToLowerInvariant();
			if ((object)_monoCommandsField == null)
			{
				_monoCommandsField = typeof(Console).GetField("commands", BindingFlags.Static | BindingFlags.NonPublic);
			}
			if (_monoCommandsField?.GetValue(null) is IDictionary<string, ConsoleCommand> dictionary && dictionary.ContainsKey(key))
			{
				return true;
			}
			if (CustomConsoleRegistry.TryExecuteManaged(args))
			{
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			Logger.Warning("[Console] Custom command routing failed (Mono): " + ex.Message);
			return true;
		}
	}
}
