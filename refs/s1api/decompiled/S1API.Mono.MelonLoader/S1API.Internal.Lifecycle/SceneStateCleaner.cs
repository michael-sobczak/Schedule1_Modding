using System;
using S1API.Avatar;
using S1API.Entities;
using S1API.GameTime;
using S1API.Internal.Map;
using S1API.Internal.Patches;
using S1API.Logging;
using S1API.Map;
using S1API.Quests;
using S1API.Shops;
using UnityEngine;

namespace S1API.Internal.Lifecycle;

internal static class SceneStateCleaner
{
	private static readonly Log Logger = new Log("Lifecycle");

	private static bool ShouldResetForScene(string sceneName)
	{
		if (string.IsNullOrEmpty(sceneName))
		{
			return false;
		}
		string a = sceneName.Trim();
		return string.Equals(a, "Main", StringComparison.OrdinalIgnoreCase);
	}

	internal static void ResetForSceneChange(string sceneName, bool afterUnload)
	{
		if (!ShouldResetForScene(sceneName))
		{
			return;
		}
		try
		{
			if (afterUnload)
			{
				int count = NPC.All.Count;
				for (int i = 0; i < NPC.All.Count; i++)
				{
					NPC nPC = NPC.All[i];
					if (nPC != null && (Object)(object)nPC.gameObject != (Object)null)
					{
						try
						{
							Object.Destroy((Object)(object)nPC.gameObject);
						}
						catch
						{
						}
					}
				}
				NPC.All.Clear();
				NPCPatches.CustomNpcsReady = false;
				int count2 = QuestManager.Quests.Count;
				QuestManager.Quests.Clear();
				int count3 = global::S1API.Map.Building.All.Count;
				global::S1API.Map.Building.All.Clear();
				int count4 = DeliveryLocation.All.Count;
				DeliveryLocation.All.Clear();
				int count5 = Seat.Count;
				Seat.Clear();
				int count6 = ParkingLotRegistry.All.Count;
				ParkingLotRegistry.All.Clear();
				ShopManager.InvalidateCache();
				DeferredMapResolver.Clear();
				TimeManager.ResetBindings();
				return;
			}
			try
			{
				NPCNetworkBootstrap.EnsurePrefabsWarmup();
				if (string.Equals(sceneName, "Main", StringComparison.OrdinalIgnoreCase))
				{
					NPCNetworkBootstrap.OnMainSceneInitialized();
					try
					{
						SeatBootstrap.OnMainSceneInitialized();
					}
					catch
					{
					}
					try
					{
						DeferredMapResolver.ResolveAll();
					}
					catch (Exception ex)
					{
						Logger.Warning("[S1API] Failed to resolve deferred map lookups: " + ex.Message);
					}
					try
					{
						TimeManagerShim.Instance.AddDelegatesToReal();
					}
					catch
					{
					}
				}
				else
				{
					NPCNetworkBootstrap.ResetFlags();
					TimeManagerShim.Instance.DeleteDelegatesFromReal();
				}
			}
			catch
			{
			}
			try
			{
				TimeManager.TryBindToCurrentInstance();
			}
			catch
			{
			}
		}
		catch (Exception ex2)
		{
			Logger.Warning("[S1API] Scene cleanup encountered an error: " + ex2.Message);
		}
	}
}
