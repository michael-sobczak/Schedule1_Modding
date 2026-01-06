using System;
using System.Collections.Generic;
using System.Reflection;
using S1API.Entities.Dialogue;
using S1API.Internal.Abstraction;
using ScheduleOne.Dialogue;
using UnityEngine;

namespace S1API.Entities;

public sealed class NPCDialogue
{
	internal readonly NPC NPC;

	private FieldInfo dialogueContainersField = typeof(DialogueHandler).GetField("dialogueContainers", BindingFlags.Instance | BindingFlags.NonPublic);

	private PropertyInfo runtimeModulesProperty = typeof(DialogueHandler).GetProperty("runtimeModules", BindingFlags.Instance | BindingFlags.NonPublic);

	private readonly Dictionary<string, List<Action>> _choiceCallbacks = new Dictionary<string, List<Action>>(StringComparer.OrdinalIgnoreCase);

	private readonly Dictionary<string, List<Action>> _nodeCallbacks = new Dictionary<string, List<Action>>(StringComparer.OrdinalIgnoreCase);

	private readonly List<Action> _conversationStartCallbacks = new List<Action>();

	private bool _eventsHooked;

	public bool IsDialogueInProgress => (Object)(object)Handler != (Object)null && Handler.IsDialogueInProgress;

	internal DialogueHandler Handler => NPC.gameObject.GetComponentInChildren<DialogueHandler>(true);

	internal NPCDialogue(NPC npc)
	{
		NPC = npc;
	}

	public NPCDialogue OnChoiceSelected(string choiceLabel, Action callback)
	{
		if (string.IsNullOrEmpty(choiceLabel) || callback == null)
		{
			return this;
		}
		EnsureHandler();
		EnsureEventHooks();
		if (!_choiceCallbacks.TryGetValue(choiceLabel, out List<Action> value))
		{
			value = new List<Action>();
			_choiceCallbacks[choiceLabel] = value;
		}
		value.Add(callback);
		return this;
	}

	public NPCDialogue OnNodeDisplayed(string nodeLabel, Action callback)
	{
		if (string.IsNullOrEmpty(nodeLabel) || callback == null)
		{
			return this;
		}
		EnsureHandler();
		EnsureEventHooks();
		if (!_nodeCallbacks.TryGetValue(nodeLabel, out List<Action> value))
		{
			value = new List<Action>();
			_nodeCallbacks[nodeLabel] = value;
		}
		value.Add(callback);
		return this;
	}

	public NPCDialogue OnConversationStart(Action callback)
	{
		if (callback == null)
		{
			return this;
		}
		EnsureHandler();
		EnsureEventHooks();
		_conversationStartCallbacks.Add(callback);
		return this;
	}

	public void ClearCallbacks()
	{
		_choiceCallbacks.Clear();
		_nodeCallbacks.Clear();
		_conversationStartCallbacks.Clear();
	}

	public void Start(string containerName, bool enableBehaviour = true, string entryNodeLabel = "ENTRY")
	{
		if (!string.IsNullOrEmpty(containerName))
		{
			EnsureHandler();
			DialogueHandler handler = Handler;
			if (handler != null)
			{
				handler.InitializeDialogue(containerName, enableBehaviour, entryNodeLabel);
			}
		}
	}

	public void End()
	{
		DialogueHandler handler = Handler;
		if (handler != null)
		{
			handler.EndDialogue();
		}
	}

	public void ShowWorldText(string text, float durationSeconds)
	{
		if (!string.IsNullOrEmpty(text))
		{
			EnsureHandler();
			DialogueHandler handler = Handler;
			if (handler != null)
			{
				handler.ShowWorldspaceDialogue(text, durationSeconds);
			}
		}
	}

	public void PlayReaction(string key, float durationSeconds = -1f, bool network = false)
	{
		if (string.IsNullOrEmpty(key))
		{
			DialogueHandler handler = Handler;
			if (handler != null)
			{
				handler.HideWorldspaceDialogue();
			}
			return;
		}
		EnsureHandler();
		DialogueHandler handler2 = Handler;
		if (handler2 != null)
		{
			handler2.PlayReaction(key, durationSeconds, network);
		}
	}

	public void OverrideText(string text)
	{
		EnsureHandler();
		DialogueHandler handler = Handler;
		if (handler != null)
		{
			handler.OverrideShownDialogue(text);
		}
	}

	public void StopOverride()
	{
		DialogueHandler handler = Handler;
		if (handler != null)
		{
			handler.StopOverride();
		}
		DialogueHandler handler2 = Handler;
		if (handler2 != null)
		{
			((Component)handler2).GetComponent<DialogueController>().ClearOverrideContainer();
		}
	}

	internal void EnsureHandler()
	{
		if ((Object)(object)Handler == (Object)null)
		{
			NPC.gameObject.AddComponent<DialogueHandler>();
		}
	}

	private void EnsureEventHooks()
	{
		if (!((Object)(object)Handler == (Object)null) && !_eventsHooked)
		{
			_eventsHooked = true;
			EventHelper.AddListener<string>(Internal_OnChoice, Handler.onDialogueChoiceChosen);
			EventHelper.AddListener<string>(Internal_OnNode, Handler.onDialogueNodeDisplayed);
			EventHelper.AddListener(Internal_OnConversationStart, Handler.onConversationStart);
		}
	}

	internal void RebuildRuntimeModules(DialogueDatabase db)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)Handler == (Object)null || (Object)(object)db == (Object)null)
		{
			return;
		}
		try
		{
			db.Initialize(Handler);
		}
		catch
		{
		}
		EnsureRuntimeModulesList();
		try
		{
			Handler.runtimeModules.Clear();
		}
		catch
		{
		}
		DialogueModule[] components = ((Component)Handler).gameObject.GetComponents<DialogueModule>();
		for (int i = 0; i < components.Length; i++)
		{
			Object.Destroy((Object)(object)components[i]);
		}
		DialogueModule val = ((Component)Handler).gameObject.AddComponent<DialogueModule>();
		val.ModuleType = (EDialogueModule)0;
		val.Entries = db.GenericEntries;
		Handler.runtimeModules.Add(val);
		if (db.Modules == null)
		{
			return;
		}
		for (int j = 0; j < db.Modules.Count; j++)
		{
			try
			{
				Handler.runtimeModules.Add(db.Modules[j]);
			}
			catch
			{
			}
		}
	}

	public void BuildAndSetDatabase(Action<DialogueDatabaseBuilder> configure)
	{
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		if (configure == null)
		{
			return;
		}
		DialogueDatabaseBuilder dialogueDatabaseBuilder = new DialogueDatabaseBuilder();
		configure(dialogueDatabaseBuilder);
		DialogueDatabaseBuilder.BuildResult buildResult = dialogueDatabaseBuilder.BuildInternal();
		EnsureHandler();
		if ((Object)(object)Handler == (Object)null)
		{
			return;
		}
		if ((Object)(object)Handler.Database != (Object)null)
		{
			AppendIntoExistingDatabase(Handler.Database, buildResult.Database);
			AppendRuntimeModulesFromDatabase(buildResult.Database);
		}
		else
		{
			Handler.Database = buildResult.Database;
			RebuildRuntimeModules(buildResult.Database);
		}
		if (buildResult.ModuleSpecs != null)
		{
			foreach (DialogueDatabaseBuilder.ModuleSpec moduleSpec in buildResult.ModuleSpecs)
			{
				DialogueModule val = ((Component)Handler).gameObject.AddComponent<DialogueModule>();
				if (Enum.TryParse(typeof(EDialogueModule), moduleSpec.ModuleName, ignoreCase: true, out object result))
				{
					val.ModuleType = (EDialogueModule)result;
				}
				val.Entries = ToIl2CppEntryList(moduleSpec.Entries);
				EnsureRuntimeModulesList();
				try
				{
					Handler.runtimeModules.Add(val);
				}
				catch
				{
				}
			}
		}
		try
		{
			DialogueDatabase obj2 = Handler.Database ?? buildResult.Database;
			if (obj2 != null)
			{
				obj2.Initialize(Handler);
			}
		}
		catch
		{
		}
	}

	private void EnsureRuntimeModulesList()
	{
		try
		{
			if (Handler.runtimeModules == null)
			{
				runtimeModulesProperty?.SetValue(Handler, new List<DialogueModule>());
			}
		}
		catch
		{
		}
	}

	private void AppendIntoExistingDatabase(DialogueDatabase target, DialogueDatabase source)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)target == (Object)null || (Object)(object)source == (Object)null)
		{
			return;
		}
		try
		{
			if (source.GenericEntries != null)
			{
				for (int i = 0; i < source.GenericEntries.Count; i++)
				{
					target.GenericEntries.Add(source.GenericEntries[i]);
				}
			}
		}
		catch
		{
		}
		try
		{
			if (source.Modules != null)
			{
				if (target.Modules == null)
				{
					target.Modules = new List<DialogueModule>();
				}
				for (int j = 0; j < source.Modules.Count; j++)
				{
					target.Modules.Add(source.Modules[j]);
				}
			}
		}
		catch
		{
		}
		try
		{
			target.Initialize(Handler);
		}
		catch
		{
		}
	}

	private void AppendRuntimeModulesFromDatabase(DialogueDatabase db)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)Handler == (Object)null || (Object)(object)db == (Object)null)
		{
			return;
		}
		EnsureRuntimeModulesList();
		try
		{
			if (db.GenericEntries != null && db.GenericEntries.Count > 0)
			{
				DialogueModule val = ((Component)Handler).gameObject.AddComponent<DialogueModule>();
				val.ModuleType = (EDialogueModule)0;
				val.Entries = db.GenericEntries;
				Handler.runtimeModules.Add(val);
			}
		}
		catch
		{
		}
		if (db.Modules == null)
		{
			return;
		}
		for (int i = 0; i < db.Modules.Count; i++)
		{
			try
			{
				Handler.runtimeModules.Add(db.Modules[i]);
			}
			catch
			{
			}
		}
	}

	public void BuildAndRegisterContainer(string containerName, Action<DialogueContainerBuilder> configure)
	{
		if (string.IsNullOrEmpty(containerName) || configure == null)
		{
			return;
		}
		EnsureHandler();
		if ((Object)(object)Handler == (Object)null)
		{
			return;
		}
		DialogueContainerBuilder dialogueContainerBuilder = new DialogueContainerBuilder();
		configure(dialogueContainerBuilder);
		DialogueContainer val = dialogueContainerBuilder.Build(containerName);
		if (!(dialogueContainersField?.GetValue(Handler) is List<DialogueContainer> list))
		{
			return;
		}
		int num = -1;
		for (int i = 0; i < list.Count; i++)
		{
			DialogueContainer val2 = list[i];
			if ((Object)(object)val2 != (Object)null && ((Object)val2).name == containerName)
			{
				num = i;
				break;
			}
		}
		if (num >= 0)
		{
			list[num] = val;
		}
		else
		{
			list.Add(val);
		}
	}

	public bool UseContainerOnInteract(string containerName)
	{
		if (string.IsNullOrEmpty(containerName))
		{
			return false;
		}
		EnsureHandler();
		if ((Object)(object)Handler == (Object)null)
		{
			return false;
		}
		if (!(dialogueContainersField?.GetValue(Handler) is List<DialogueContainer> list))
		{
			return false;
		}
		DialogueContainer val = null;
		for (int i = 0; i < list.Count; i++)
		{
			DialogueContainer val2 = list[i];
			if ((Object)(object)val2 != (Object)null && ((Object)val2).name == containerName)
			{
				val = val2;
				break;
			}
		}
		if ((Object)(object)val == (Object)null)
		{
			return false;
		}
		DialogueController component = ((Component)Handler).GetComponent<DialogueController>();
		if ((Object)(object)component == (Object)null)
		{
			return false;
		}
		component.SetOverrideContainer(val);
		return true;
	}

	public bool UseContainerOnInteractOnce(string containerName)
	{
		if (string.IsNullOrEmpty(containerName))
		{
			return false;
		}
		EnsureHandler();
		if ((Object)(object)Handler == (Object)null)
		{
			return false;
		}
		if (!(dialogueContainersField?.GetValue(Handler) is List<DialogueContainer> list))
		{
			return false;
		}
		DialogueContainer val = null;
		for (int i = 0; i < list.Count; i++)
		{
			DialogueContainer val2 = list[i];
			if ((Object)(object)val2 != (Object)null && ((Object)val2).name == containerName)
			{
				val = val2;
				break;
			}
		}
		if ((Object)(object)val == (Object)null)
		{
			return false;
		}
		DialogueController controller = ((Component)Handler).GetComponent<DialogueController>();
		if ((Object)(object)controller == (Object)null)
		{
			return false;
		}
		controller.SetOverrideContainer(val);
		try
		{
			EventHelper.AddListener(ClearOnce, Handler.onConversationStart);
		}
		catch
		{
		}
		return true;
		void ClearOnce()
		{
			try
			{
				controller.ClearOverrideContainer();
			}
			catch
			{
			}
			try
			{
				EventHelper.RemoveListener(ClearOnce, Handler.onConversationStart);
			}
			catch
			{
			}
		}
	}

	public bool JumpTo(string containerName, string entryNodeLabel, bool enableBehaviour = false)
	{
		if (string.IsNullOrEmpty(containerName) || string.IsNullOrEmpty(entryNodeLabel))
		{
			return false;
		}
		EnsureHandler();
		if ((Object)(object)Handler == (Object)null)
		{
			return false;
		}
		if (!(dialogueContainersField?.GetValue(Handler) is List<DialogueContainer> list))
		{
			return false;
		}
		DialogueContainer val = null;
		for (int i = 0; i < list.Count; i++)
		{
			DialogueContainer val2 = list[i];
			if ((Object)(object)val2 != (Object)null && ((Object)val2).name == containerName)
			{
				val = val2;
				break;
			}
		}
		if ((Object)(object)val == (Object)null)
		{
			return false;
		}
		Handler.InitializeDialogue(val, enableBehaviour, entryNodeLabel);
		return true;
	}

	private void Internal_OnChoice(string choiceLabel)
	{
		if (string.IsNullOrEmpty(choiceLabel) || !_choiceCallbacks.TryGetValue(choiceLabel, out List<Action> value))
		{
			return;
		}
		for (int i = 0; i < value.Count; i++)
		{
			try
			{
				value[i]?.Invoke();
			}
			catch
			{
			}
		}
	}

	private void Internal_OnNode(string nodeLabel)
	{
		if (string.IsNullOrEmpty(nodeLabel) || !_nodeCallbacks.TryGetValue(nodeLabel, out List<Action> value))
		{
			return;
		}
		for (int i = 0; i < value.Count; i++)
		{
			try
			{
				value[i]?.Invoke();
			}
			catch
			{
			}
		}
	}

	private void Internal_OnConversationStart()
	{
		for (int i = 0; i < _conversationStartCallbacks.Count; i++)
		{
			try
			{
				_conversationStartCallbacks[i]?.Invoke();
			}
			catch
			{
			}
		}
	}

	private static List<Entry> ToIl2CppEntryList(List<Entry> source)
	{
		return source;
	}
}
