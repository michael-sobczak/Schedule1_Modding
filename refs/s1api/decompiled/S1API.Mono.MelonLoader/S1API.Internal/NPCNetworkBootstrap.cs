using System;
using System.Collections;
using System.Collections.Generic;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Managing.Object;
using FishNet.Managing.Server;
using FishNet.Object;
using MelonLoader;
using S1API.Entities;
using S1API.Logging;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace S1API.Internal;

internal static class NPCNetworkBootstrap
{
	private sealed class PendingSpawn
	{
		internal readonly NPC Owner;

		internal readonly NetworkObject NetObject;

		internal readonly float ActivateAt;

		internal readonly float SpawnAt;

		internal bool ActivationApplied;

		internal PendingSpawn(NPC owner, NetworkObject netObject, float activateAt, float spawnAt)
		{
			Owner = owner;
			NetObject = netObject;
			ActivateAt = activateAt;
			SpawnAt = spawnAt;
			ActivationApplied = false;
		}
	}

	private static readonly Log Logger = new Log("NPCNetworkBootstrap");

	private static bool mainSceneInitialized;

	private static bool networkObserved;

	private static bool clientsReady;

	private static bool connectionObjectsReady;

	private static bool prefabsWarmupScheduled;

	private static float mainSceneInitTime;

	private static readonly List<PendingSpawn> PendingSpawns = new List<PendingSpawn>();

	private static bool readinessLogInitialized;

	private static bool lastLogInMain;

	private static bool lastLogServerUp;

	private static bool lastLogClientUp;

	private static bool lastLogRemoteReady;

	private static bool lastLogHasRemote;

	private static bool lastLogClientsReady;

	private static float lastStateLogTime;

	private static bool pendingSpawnBlockedLogged;

	public static bool ClientsReadyToSpawnNpcs => mainSceneInitialized && NPC.PrefabsConfiguredForLocalProcess && connectionObjectsReady && clientsReady;

	public static void ResetFlags()
	{
		mainSceneInitialized = false;
		networkObserved = false;
		clientsReady = false;
		connectionObjectsReady = false;
		prefabsWarmupScheduled = false;
		mainSceneInitTime = 0f;
		PendingSpawns.Clear();
		readinessLogInitialized = false;
		pendingSpawnBlockedLogged = false;
	}

	public static void EnsurePrefabsWarmup()
	{
		if (!NPC.PrefabsConfiguredForLocalProcess && !prefabsWarmupScheduled)
		{
			prefabsWarmupScheduled = true;
			MelonCoroutines.Start(PrefabWarmupCoroutine());
		}
	}

	internal static void RegisterPendingNetworkSpawn(NPC owner, NetworkObject netObject, float activationDelay, float spawnDelay)
	{
		if (owner == null || (Object)(object)netObject == (Object)null)
		{
			return;
		}
		try
		{
			NetworkManager networkManager = InstanceFinder.NetworkManager;
			if ((Object)(object)networkManager != (Object)null && !networkManager.IsServer)
			{
				return;
			}
			EnsurePrefabsWarmup();
			for (int num = PendingSpawns.Count - 1; num >= 0; num--)
			{
				PendingSpawn pendingSpawn = PendingSpawns[num];
				if (pendingSpawn == null || (Object)(object)pendingSpawn.NetObject == (Object)null || (Object)(object)pendingSpawn.NetObject == (Object)(object)netObject)
				{
					PendingSpawns.RemoveAt(num);
				}
			}
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			float activateAt = realtimeSinceStartup + Math.Max(0f, activationDelay);
			float spawnAt = realtimeSinceStartup + Math.Max(spawnDelay, activationDelay);
			PendingSpawns.Add(new PendingSpawn(owner, netObject, activateAt, spawnAt));
			object obj = owner?.S1NPC?.ID;
			if (obj == null)
			{
				if (owner == null)
				{
					obj = null;
				}
				else
				{
					GameObject gameObject = owner.gameObject;
					obj = ((gameObject != null) ? ((Object)gameObject).name : null);
				}
				if (obj == null)
				{
					obj = "<unknown>";
				}
			}
			string text = (string)obj;
			TryProcessPendingSpawns();
		}
		catch (Exception ex)
		{
			MelonLogger.Warning("[S1API] Failed to register pending NPC spawn: " + ex.Message);
		}
	}

	public static void OnMainSceneInitialized()
	{
		ResetFlags();
		mainSceneInitialized = true;
		mainSceneInitTime = Time.realtimeSinceStartup;
		try
		{
			NetworkManager networkManager = InstanceFinder.NetworkManager;
			PrefabObjects val = ((networkManager != null) ? networkManager.SpawnablePrefabs : null);
			if ((Object)(object)val != (Object)null)
			{
				NPC.PreRegisterAllNpcPrefabs();
			}
			else
			{
				EnsurePrefabsWarmup();
			}
		}
		catch
		{
			EnsurePrefabsWarmup();
		}
		MelonCoroutines.Start(ReadinessMonitor());
	}

	private static IEnumerator PrefabWarmupCoroutine()
	{
		float start = Time.realtimeSinceStartup;
		float timeout = 20f;
		while (!NPC.PrefabsConfiguredForLocalProcess && Time.realtimeSinceStartup - start < timeout)
		{
			PrefabObjects spawnables = null;
			try
			{
				NetworkManager nm = InstanceFinder.NetworkManager;
				spawnables = ((nm != null) ? nm.SpawnablePrefabs : null);
			}
			catch
			{
			}
			if ((Object)(object)spawnables != (Object)null)
			{
				try
				{
					NPC.PreRegisterAllNpcPrefabs();
				}
				catch (Exception ex)
				{
					Exception ex2 = ex;
					MelonLogger.Warning("[S1API] Prefab warmup failed: " + ex2.Message);
				}
				break;
			}
			yield return (object)new WaitForSeconds(0.25f);
		}
		prefabsWarmupScheduled = false;
		TryProcessPendingSpawns();
	}

	private static IEnumerator ReadinessMonitor()
	{
		NetworkManager nm = null;
		float start = Time.realtimeSinceStartup;
		while ((Object)(object)nm == (Object)null)
		{
			nm = InstanceFinder.NetworkManager;
			if ((Object)(object)nm != (Object)null)
			{
				break;
			}
			if (Time.realtimeSinceStartup - start > 10f)
			{
				yield break;
			}
			yield return (object)new WaitForSeconds(0.1f);
		}
		if ((Object)(object)nm != (Object)null && !nm.IsServer)
		{
			yield break;
		}
		if (!networkObserved)
		{
			networkObserved = true;
			try
			{
				_ = nm.ClientManager;
				_ = nm.ServerManager;
				_ = nm.SceneManager;
				MelonCoroutines.Start(PeriodicEvaluate());
			}
			catch
			{
			}
		}
		float maxWait = 12f;
		while (!clientsReady && Time.realtimeSinceStartup - start < maxWait)
		{
			EvaluateReadiness();
			yield return (object)new WaitForSeconds(0.25f);
		}
		EvaluateReadiness();
		TryProcessPendingSpawns();
	}

	private static IEnumerator PeriodicEvaluate()
	{
		while (true)
		{
			EvaluateReadiness();
			TryProcessPendingSpawns();
			yield return (object)new WaitForSeconds(0.25f);
		}
	}

	private static void EvaluateReadiness()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		NetworkManager networkManager = InstanceFinder.NetworkManager;
		if ((Object)(object)networkManager == (Object)null)
		{
			clientsReady = false;
			connectionObjectsReady = false;
			return;
		}
		if (!NPC.PrefabsConfiguredForLocalProcess)
		{
			clientsReady = false;
			connectionObjectsReady = false;
			return;
		}
		bool hasRemoteClients;
		bool flag = (connectionObjectsReady = AreRemoteConnectionsReady(networkManager, out hasRemoteClients));
		bool flag2 = false;
		try
		{
			Scene activeScene = SceneManager.GetActiveScene();
			flag2 = ((Scene)(ref activeScene)).name == "Main";
		}
		catch
		{
		}
		bool flag3 = networkManager.IsServer && (Object)(object)networkManager.ServerManager != (Object)null && networkManager.ServerManager.Started;
		bool flag4 = !networkManager.IsServer || networkManager.IsClient || hasRemoteClients;
		clientsReady = flag2 && flag3 && flag4 && flag;
		LogReadinessState(flag2, flag3, flag4, flag, hasRemoteClients);
	}

	private static bool HasRemoteClients()
	{
		try
		{
			NetworkManager networkManager = InstanceFinder.NetworkManager;
			if ((Object)(object)networkManager == (Object)null)
			{
				return false;
			}
			if (!networkManager.IsServer)
			{
				return false;
			}
			Dictionary<int, NetworkConnection> dictionary = networkManager.ServerManager?.Clients;
			if (dictionary == null)
			{
				return false;
			}
			int num = 0;
			foreach (KeyValuePair<int, NetworkConnection> item in dictionary)
			{
				NetworkConnection value = item.Value;
				if (!(value == (NetworkConnection)null) && !value.IsLocalClient)
				{
					num++;
				}
			}
			return num > 0;
		}
		catch
		{
			return false;
		}
	}

	private static bool AreRemoteConnectionsReady(NetworkManager nm, out bool hasRemoteClients)
	{
		hasRemoteClients = false;
		try
		{
			if ((Object)(object)nm == (Object)null)
			{
				return false;
			}
			ServerManager serverManager = nm.ServerManager;
			if ((Object)(object)serverManager == (Object)null)
			{
				return false;
			}
			Dictionary<int, NetworkConnection> clients = serverManager.Clients;
			if (clients == null)
			{
				return true;
			}
			foreach (KeyValuePair<int, NetworkConnection> item in clients)
			{
				NetworkConnection value = item.Value;
				if (!(value == (NetworkConnection)null) && value.IsValid && !value.IsLocalClient)
				{
					hasRemoteClients = true;
					if (!value.Authenticated)
					{
						return false;
					}
					if ((Object)(object)value.FirstObject == (Object)null)
					{
						return false;
					}
				}
			}
			if (hasRemoteClients)
			{
				float num = Time.realtimeSinceStartup - mainSceneInitTime;
				if (num < 5f)
				{
					return false;
				}
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	private static void TryProcessPendingSpawns()
	{
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		if (PendingSpawns.Count == 0)
		{
			pendingSpawnBlockedLogged = false;
			return;
		}
		NetworkManager networkManager = InstanceFinder.NetworkManager;
		if ((Object)(object)networkManager == (Object)null || !networkManager.IsServer)
		{
			return;
		}
		if (!ClientsReadyToSpawnNpcs)
		{
			if (!pendingSpawnBlockedLogged)
			{
				pendingSpawnBlockedLogged = true;
			}
			return;
		}
		pendingSpawnBlockedLogged = false;
		ServerManager serverManager = networkManager.ServerManager;
		if ((Object)(object)serverManager == (Object)null)
		{
			return;
		}
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		for (int num = PendingSpawns.Count - 1; num >= 0; num--)
		{
			PendingSpawn pendingSpawn = PendingSpawns[num];
			if (pendingSpawn == null)
			{
				PendingSpawns.RemoveAt(num);
				continue;
			}
			NetworkObject netObject = pendingSpawn.NetObject;
			NPC owner = pendingSpawn.Owner;
			object obj = owner?.S1NPC?.ID;
			if (obj == null)
			{
				if (owner == null)
				{
					obj = null;
				}
				else
				{
					GameObject gameObject = owner.gameObject;
					obj = ((gameObject != null) ? ((Object)gameObject).name : null);
				}
				if (obj == null)
				{
					obj = "<unknown>";
				}
			}
			string text = (string)obj;
			if ((Object)(object)netObject == (Object)null)
			{
				PendingSpawns.RemoveAt(num);
				continue;
			}
			GameObject gameObject2 = ((Component)netObject).gameObject;
			if ((Object)(object)gameObject2 == (Object)null)
			{
				PendingSpawns.RemoveAt(num);
				continue;
			}
			if (netObject.IsSpawned)
			{
				PendingSpawns.RemoveAt(num);
				continue;
			}
			if (!pendingSpawn.ActivationApplied && realtimeSinceStartup >= pendingSpawn.ActivateAt)
			{
				pendingSpawn.ActivationApplied = true;
			}
			if (!(realtimeSinceStartup < pendingSpawn.SpawnAt))
			{
				try
				{
					owner?.PrepareForNetworkSpawn();
				}
				catch (Exception ex)
				{
					Logger.Warning("[NPCNetworkBootstrap] PrepareForNetworkSpawn threw for '" + text + "': " + ex.Message);
				}
				try
				{
					serverManager.Spawn(netObject, (NetworkConnection)null, default(Scene));
				}
				catch (Exception ex2)
				{
					MelonLogger.Warning("[S1API] Failed to spawn pending NPC '" + ((Object)gameObject2).name + "': " + ex2.Message);
					Logger.Warning("[NPCNetworkBootstrap] Spawn exception stack: " + ex2.StackTrace);
					continue;
				}
				try
				{
					owner?.FinalizeNetworkSpawn();
				}
				catch (Exception ex3)
				{
					Logger.Warning("[NPCNetworkBootstrap] FinalizeNetworkSpawn threw for '" + text + "': " + ex3.Message);
				}
				PendingSpawns.RemoveAt(num);
			}
		}
	}

	private static NetworkConnection GetHostConnection(NetworkManager nm)
	{
		try
		{
			if ((Object)(object)nm == (Object)null)
			{
				return null;
			}
			ServerManager serverManager = nm.ServerManager;
			if ((Object)(object)serverManager == (Object)null)
			{
				return null;
			}
			Dictionary<int, NetworkConnection> clients = serverManager.Clients;
			if (clients == null)
			{
				return null;
			}
			foreach (KeyValuePair<int, NetworkConnection> item in clients)
			{
				NetworkConnection value = item.Value;
				if (value == (NetworkConnection)null || !value.IsValid || !value.IsLocalClient)
				{
					continue;
				}
				return value;
			}
		}
		catch
		{
		}
		return null;
	}

	private static void LogReadinessState(bool inMain, bool serverUp, bool clientUpIfHost, bool remoteConnectionsReady, bool hasRemoteClients)
	{
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		if (!readinessLogInitialized || lastLogInMain != inMain || lastLogServerUp != serverUp || lastLogClientUp != clientUpIfHost || lastLogRemoteReady != remoteConnectionsReady || lastLogHasRemote != hasRemoteClients || lastLogClientsReady != clientsReady || (!clientsReady && realtimeSinceStartup - lastStateLogTime >= 5f))
		{
			readinessLogInitialized = true;
			lastLogInMain = inMain;
			lastLogServerUp = serverUp;
			lastLogClientUp = clientUpIfHost;
			lastLogRemoteReady = remoteConnectionsReady;
			lastLogHasRemote = hasRemoteClients;
			lastLogClientsReady = clientsReady;
			lastStateLogTime = realtimeSinceStartup;
		}
	}
}
