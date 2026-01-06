using System;
using System.Collections.Generic;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.Dialogue;
using Il2CppSystem.Collections.Generic;
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
		//IL_0051: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		DialogueDatabase val = ScriptableObject.CreateInstance<DialogueDatabase>();
		List<Entry> list = new List<Entry>();
		foreach (var genericEntry in _genericEntries)
		{
			string item = genericEntry.key;
			string[] item2 = genericEntry.lines;
			DialogueChain val2 = new DialogueChain
			{
				Lines = Il2CppStringArray.op_Implicit(item2 ?? Array.Empty<string>())
			};
			Entry val3 = new Entry();
			val3.Key = item;
			val3.Chains = Il2CppReferenceArray<DialogueChain>.op_Implicit((DialogueChain[])(object)new DialogueChain[1] { val2 });
			list.Add(val3);
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
				DialogueChain val4 = new DialogueChain
				{
					Lines = Il2CppStringArray.op_Implicit(item4 ?? Array.Empty<string>())
				};
				Entry val3 = new Entry();
				val3.Key = item3;
				val3.Chains = Il2CppReferenceArray<DialogueChain>.op_Implicit((DialogueChain[])(object)new DialogueChain[1] { val4 });
				list3.Add(val3);
			}
			list2.Add(new ModuleSpec(module.Key, list3));
		}
		return new BuildResult(val, list2);
	}

	private static List<T> ToIl2CppList<T>(List<T> source)
	{
		List<T> val = new List<T>();
		if (source == null)
		{
			return val;
		}
		for (int i = 0; i < source.Count; i++)
		{
			val.Add(source[i]);
		}
		return val;
	}
}
