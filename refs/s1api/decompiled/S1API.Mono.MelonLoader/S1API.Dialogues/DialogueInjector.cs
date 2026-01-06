using System;
using System.Collections;
using System.Collections.Generic;
using MelonLoader;
using S1API.Entities;
using ScheduleOne.Dialogue;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Schedules;
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
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
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
				list.AddRange(val.choices);
			}
			list.Add(val3);
			val.choices = list.ToArray();
			NodeLinkData item = new NodeLinkData
			{
				BaseDialogueOrBranchNodeGuid = injection.FromNodeGuid,
				BaseChoiceOrOptionGUID = val3.Guid,
				TargetNodeGuid = injection.ToNodeGuid
			};
			DialogueContainer val4 = dialogueOverride;
			if (val4.NodeLinks == null)
			{
				val4.NodeLinks = new List<NodeLinkData>();
			}
			dialogueOverride.NodeLinks.Add(item);
			DialogueChoiceListener.Register(component, injection.ChoiceLabel, injection.OnConfirmed);
		}
	}
}
