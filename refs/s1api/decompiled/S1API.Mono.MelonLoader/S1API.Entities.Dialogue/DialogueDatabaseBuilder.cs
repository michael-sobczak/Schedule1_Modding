using System;
using System.Collections.Generic;
using ScheduleOne.Dialogue;
using UnityEngine;

namespace S1API.Entities.Dialogue;

public sealed class DialogueDatabaseBuilder
{
	internal sealed class BuildResult
	{
		internal readonly DialogueDatabase Database;

		internal readonly List<ModuleSpec> ModuleSpecs;

		internal BuildResult(DialogueDatabase database, List<ModuleSpec> moduleSpecs)
		{
			Database = database;
			ModuleSpecs = moduleSpecs;
		}
	}

	internal sealed class ModuleSpec
	{
		internal readonly string ModuleName;

		internal readonly List<Entry> Entries;

		internal ModuleSpec(string moduleName, List<Entry> entries)
		{
			ModuleName = moduleName;
			Entries = entries;
		}
	}

	private readonly List<(string key, string[] lines)> _genericEntries = new List<(string, string[])>();

	private readonly Dictionary<string, List<(string key, string[] lines)>> _modules = new Dictionary<string, List<(string, string[])>>(StringComparer.OrdinalIgnoreCase);

	public DialogueDatabaseBuilder WithGeneric(string key, params string[] lines)
	{
		if (!string.IsNullOrEmpty(key) && lines != null)
		{
			_genericEntries.Add((key, lines));
		}
		return this;
	}

	public DialogueDatabaseBuilder WithModuleEntry(string moduleName, string key, params string[] lines)
	{
		if (string.IsNullOrEmpty(moduleName) || string.IsNullOrEmpty(key) || lines == null)
		{
			return this;
		}
		if (!_modules.TryGetValue(moduleName, out List<(string, string[])> value))
		{
			value = new List<(string, string[])>();
			_modules[moduleName] = value;
		}
		value.Add((key, lines));
		return this;
	}

	internal BuildResult BuildInternal()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		DialogueDatabase val = ScriptableObject.CreateInstance<DialogueDatabase>();
		List<Entry> list = new List<Entry>();
		foreach (var genericEntry in _genericEntries)
		{
			string item = genericEntry.key;
			string[] item2 = genericEntry.lines;
			DialogueChain val2 = new DialogueChain
			{
				Lines = (item2 ?? Array.Empty<string>())
			};
			list.Add(new Entry
			{
				Key = item,
				Chains = (DialogueChain[])(object)new DialogueChain[1] { val2 }
			});
		}
		val.GenericEntries = ToIl2CppList(list);
		List<ModuleSpec> list2 = new List<ModuleSpec>();
		foreach (KeyValuePair<string, List<(string, string[])>> module in _modules)
		{
			List<Entry> list3 = new List<Entry>();
			foreach (var item5 in module.Value)
			{
				string item3 = item5.Item1;
				string[] item4 = item5.Item2;
				DialogueChain val3 = new DialogueChain
				{
					Lines = (item4 ?? Array.Empty<string>())
				};
				list3.Add(new Entry
				{
					Key = item3,
					Chains = (DialogueChain[])(object)new DialogueChain[1] { val3 }
				});
			}
			list2.Add(new ModuleSpec(module.Key, list3));
		}
		return new BuildResult(val, list2);
	}

	private static List<T> ToIl2CppList<T>(List<T> source)
	{
		return source;
	}
}
