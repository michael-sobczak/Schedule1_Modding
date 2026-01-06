using System;
using HarmonyLib;
using Il2CppScheduleOne.Messaging;
using Il2CppSystem.Collections.Generic;
using S1API.Logging;
using UnityEngine;

namespace S1API.Internal.Patches;

[HarmonyPatch]
internal class MessagingPatches
{
	private static readonly Log Logger = new Log("MessagingPatches");

	[HarmonyPatch(typeof(MSGConversation), "CreateUI")]
	[HarmonyPrefix]
	private static void MSGConversation_CreateUI_Prefix(MSGConversation __instance)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (!((Object)(object)__instance.sender != (Object)null))
			{
				return;
			}
			List<EConversationCategory> conversationCategories = __instance.sender.ConversationCategories;
			if (conversationCategories == null || conversationCategories.Count <= 0)
			{
				return;
			}
			bool flag = false;
			if (__instance.Categories == null || __instance.Categories.Count != conversationCategories.Count)
			{
				flag = true;
			}
			else
			{
				for (int i = 0; i < conversationCategories.Count; i++)
				{
					if (i >= __instance.Categories.Count || __instance.Categories[i] != conversationCategories[i])
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				__instance.SetCategories(conversationCategories);
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in MSGConversation_CreateUI_Prefix: " + ex.Message);
		}
	}
}
