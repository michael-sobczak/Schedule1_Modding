using System;
using System.Linq;
using HarmonyLib;
using S1API.Entities;
using S1API.Internal.Utils;
using S1API.Logging;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerScripts.Health;
using UnityEngine;

namespace S1API.Internal.Patches;

[HarmonyPatch]
internal class PlayerPatches
{
	private static readonly Log Logger;

	static PlayerPatches()
	{
		Logger = new Log("PlayerPatches");
		try
		{
			Type typeFromHandle = typeof(Player);
			SubscribeToStandardEvent(typeFromHandle, "onLocalPlayerSpawned", new Action(HandleLocalPlayerSpawned));
			SubscribeToStandardEvent(typeFromHandle, "onPlayerSpawned", new Action<Player>(HandlePlayerSpawned));
			SubscribeToStandardEvent(typeFromHandle, "onPlayerDespawned", new Action<Player>(HandlePlayerDespawned));
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to subscribe to game player events: " + ex.Message);
			Logger.Error("Stack trace: " + ex.StackTrace);
		}
	}

	private static void SubscribeToStandardEvent(Type targetType, string eventName, Delegate handler)
	{
		Delegate value = ((ReflectionUtils.TryGetStaticFieldOrProperty(targetType, eventName) is Delegate a) ? Delegate.Combine(a, handler) : handler);
		ReflectionUtils.TrySetStaticFieldOrProperty(targetType, eventName, value);
	}

	private static void HandleLocalPlayerSpawned()
	{
		try
		{
			Player player = Player.All.FirstOrDefault((Player p) => p.IsLocal);
			if (player != null)
			{
				Player.RaiseLocalPlayerSpawned(player);
			}
			else
			{
				Logger.Warning("Game fired onLocalPlayerSpawned but no API Player instance found in Player.All list");
			}
		}
		catch (Exception ex)
		{
			Logger.Error("Error handling local player spawned event: " + ex.Message);
			Logger.Error("Stack trace: " + ex.StackTrace);
		}
	}

	private static void HandlePlayerSpawned(Player gamePlayer)
	{
		try
		{
			if ((Object)(object)gamePlayer == (Object)null)
			{
				Logger.Warning("Game fired onPlayerSpawned with null player");
				return;
			}
			Player player = Player.All.FirstOrDefault((Player p) => (Object)(object)p.S1Player == (Object)(object)gamePlayer);
			if (player != null)
			{
				Player.RaisePlayerSpawned(player);
			}
			else
			{
				Logger.Warning($"Game fired onPlayerSpawned for {gamePlayer.PlayerName} but no API Player instance found in Player.All list (count: {Player.All.Count})");
			}
		}
		catch (Exception ex)
		{
			Logger.Error("Error handling player spawned event: " + ex.Message);
			Logger.Error("Stack trace: " + ex.StackTrace);
		}
	}

	private static void HandlePlayerDespawned(Player gamePlayer)
	{
		try
		{
			if ((Object)(object)gamePlayer == (Object)null)
			{
				Logger.Warning("Game fired onPlayerDespawned with null player");
				return;
			}
			Player player = Player.All.FirstOrDefault((Player p) => (Object)(object)p.S1Player == (Object)(object)gamePlayer);
			if (player != null)
			{
				Player.RaisePlayerDespawned(player);
			}
			else
			{
				Logger.Warning("Game fired onPlayerDespawned for " + gamePlayer.PlayerName + " but no API Player instance found in Player.All list");
			}
		}
		catch (Exception ex)
		{
			Logger.Error("Error handling player despawned event: " + ex.Message);
			Logger.Error("Stack trace: " + ex.StackTrace);
		}
	}

	[HarmonyPatch(typeof(Player), "Awake")]
	[HarmonyPostfix]
	private static void PlayerAwake(Player __instance)
	{
		try
		{
			new Player(__instance);
		}
		catch (Exception ex)
		{
			Logger.Error("Error in PlayerAwake: " + ex.Message);
			Logger.Error("Stack trace: " + ex.StackTrace);
		}
	}

	[HarmonyPatch(typeof(Player), "OnDestroy")]
	[HarmonyPostfix]
	private static void PlayerOnDestroy(Player __instance)
	{
		try
		{
			Player player = Player.All.FirstOrDefault((Player player2) => (Object)(object)player2.S1Player == (Object)(object)__instance);
			if (player != null)
			{
				Player.All.Remove(player);
			}
			else
			{
				Logger.Warning("OnDestroy called but API Player instance not found in Player.All list");
			}
		}
		catch (Exception ex)
		{
			Logger.Error("Error in PlayerOnDestroy: " + ex.Message);
			Logger.Error("Stack trace: " + ex.StackTrace);
		}
	}

	[HarmonyPatch(typeof(PlayerHealth), "TakeDamage")]
	[HarmonyPrefix]
	private static bool PlayerHealth_TakeDamage(PlayerHealth __instance, float damage, bool flinch = true, bool playBloodMist = true)
	{
		Player player = __instance.Player;
		if ((Object)(object)player != (Object)null && Player.IsPlayerInvincible(player))
		{
			return false;
		}
		return true;
	}
}
