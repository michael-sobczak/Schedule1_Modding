using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using S1API.Entities;
using UnityEngine;

namespace S1API.Dialogues;

public static class DialogueInjector
{
	private static List<DialogueInjection> _pendingInjections = new List<DialogueInjection>();

	private static bool _isHooked = false;

	public static void Register(DialogueInjection injection)
	{
		_pendingInjections.Add(injection);
		HookUpdateLoop();
	}

	private static void HookUpdateLoop()
	{
		if (!_isHooked)
		{
			_isHooked = true;
			MelonCoroutines.Start(WaitForNPCsAndInject());
		}
	}

	private static IEnumerator WaitForNPCsAndInject()
	{
		while (_pendingInjections.Count > 0)
		{
			for (int i = _pendingInjections.Count - 1; i >= 0; i--)
			{
				DialogueInjection injection = _pendingInjections[i];
				NPC target = null;
				foreach (NPC npc in NPC.All)
				{
					if (npc == null || !injection.AppliesTo(npc))
					{
						continue;
					}
					target = npc;
					break;
				}
				if (target != null)
				{
					TryInject(injection, target.S1NPC);
					_pendingInjections.RemoveAt(i);
				}
			}
			yield return null;
		}
	}

	private static void TryInject(DialogueInjection injection, NPC npc)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		DialogueHandler component = ((Component)npc).GetComponent<DialogueHandler>();
		NPCEvent_LocationDialogue componentInChildren = ((Component)npc).GetComponentInChildren<NPCEvent_LocationDialogue>(true);
		if (!Object.op_Implicit((Object)(object)componentInChildren) || !Object.op_Implicit((Object)(object)componentInChildren.DialogueOverride) || ((Object)componentInChildren.DialogueOverride).name != injection.ContainerName)
		{
			return;
		}
		DialogueContainer dialogueOverride = componentInChildren.DialogueOverride;
		if (dialogueOverride.DialogueNodeData == null)
		{
			return;
		}
		DialogueNodeData val = null;
		for (int i = 0; i < dialogueOverride.DialogueNodeData.Count; i++)
		{
			DialogueNodeData val2 = dialogueOverride.DialogueNodeData.ToArray()[i];
			if (val2 != null && !(val2.Guid != injection.FromNodeGuid))
			{
				val = val2;
				break;
			}
		}
		if (val != null)
		{
			DialogueChoiceData val3 = new DialogueChoiceData
			{
				Guid = Guid.NewGuid().ToString(),
				ChoiceLabel = injection.ChoiceLabel,
				ChoiceText = injection.ChoiceText
			};
			List<DialogueChoiceData> list = new List<DialogueChoiceData>();
			if (val.choices != null)
			{
				list.AddRange((IEnumerable<DialogueChoiceData>)val.choices);
			}
			list.Add(val3);
			val.choices = Il2CppReferenceArray<DialogueChoiceData>.op_Implicit(list.ToArray());
			NodeLinkData val4 = new NodeLinkData
			{
				BaseDialogueOrBranchNodeGuid = injection.FromNodeGuid,
				BaseChoiceOrOptionGUID = val3.Guid,
				TargetNodeGuid = injection.ToNodeGuid
			};
			DialogueContainer val5 = dialogueOverride;
			if (val5.NodeLinks == null)
			{
				List<NodeLinkData> val6 = (val5.NodeLinks = new List<NodeLinkData>());
			}
			dialogueOverride.NodeLinks.Add(val4);
			DialogueChoiceListener.Register(component, injection.ChoiceLabel, injection.OnConfirmed);
		}
	}
}
