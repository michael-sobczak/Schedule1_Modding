using System;
using System.Collections.Generic;
using System.Reflection;
using S1API.Logging;
using S1API.Map;
using UnityEngine.SceneManagement;

namespace S1API.Internal.Map;

internal static class DeferredMapResolver
{
	private static readonly Log Logger = new Log("DeferredMapResolver");

	private static readonly List<DeferredLookup> PendingLookups = new List<DeferredLookup>();

	private static bool MainSceneLoaded = false;

	public static void RegisterDeferredLookup(DeferredLookup lookup)
	{
		if (lookup == null)
		{
			return;
		}
		lock (PendingLookups)
		{
			if (MainSceneLoaded && !lookup.IsResolved)
			{
				TryResolveLookup(lookup);
			}
			else if (!PendingLookups.Contains(lookup))
			{
				PendingLookups.Add(lookup);
			}
		}
	}

	public static void ResolveAll()
	{
		if (MainSceneLoaded)
		{
			return;
		}
		MainSceneLoaded = true;
		List<DeferredLookup> list;
		lock (PendingLookups)
		{
			list = new List<DeferredLookup>(PendingLookups);
		}
		int num = 0;
		int num2 = 0;
		foreach (DeferredLookup item in list)
		{
			if (item.IsResolved)
			{
				continue;
			}
			try
			{
				if (TryResolveLookup(item))
				{
					num++;
				}
				else
				{
					num2++;
				}
			}
			catch (Exception ex)
			{
				Logger.Warning("Failed to resolve deferred lookup: " + ex.Message);
				num2++;
			}
		}
		lock (PendingLookups)
		{
			PendingLookups.RemoveAll((DeferredLookup l) => l.IsResolved);
		}
	}

	private static bool TryResolveLookup(DeferredLookup lookup)
	{
		object obj = null;
		if (lookup.IdentifierType != null)
		{
			obj = ResolveTypedLookup(lookup.IdentifierType);
		}
		else if (!string.IsNullOrEmpty(lookup.IdentifierName))
		{
			lookup.MarkResolved();
			return false;
		}
		if (obj != null)
		{
			try
			{
				lookup.Callback(obj);
				lookup.MarkResolved();
				return true;
			}
			catch (Exception ex)
			{
				Logger.Warning("Callback failed for deferred lookup: " + ex.Message);
				lookup.MarkResolved();
				return false;
			}
		}
		return false;
	}

	private static object ResolveTypedLookup(Type identifierType)
	{
		try
		{
			MethodInfo method = typeof(ParkingLotRegistry).GetMethod("Get", BindingFlags.Static | BindingFlags.Public);
			if (method != null)
			{
				MethodInfo methodInfo = method.MakeGenericMethod(identifierType);
				object obj = methodInfo.Invoke(null, null);
				if (obj is ParkingLotWrapper parkingLotWrapper && parkingLotWrapper != null)
				{
					return parkingLotWrapper;
				}
			}
			MethodInfo method2 = typeof(global::S1API.Map.Building).GetMethod("Get", BindingFlags.Static | BindingFlags.Public);
			if (method2 != null)
			{
				MethodInfo methodInfo2 = method2.MakeGenericMethod(identifierType);
				object obj2 = methodInfo2.Invoke(null, null);
				if (obj2 is global::S1API.Map.Building building && building != null)
				{
					return building;
				}
			}
			MethodInfo method3 = typeof(DeliveryLocation).GetMethod("Get", BindingFlags.Static | BindingFlags.Public);
			if (method3 != null)
			{
				MethodInfo methodInfo3 = method3.MakeGenericMethod(identifierType);
				object obj3 = methodInfo3.Invoke(null, null);
				if (obj3 is DeliveryLocation deliveryLocation && deliveryLocation != null)
				{
					return deliveryLocation;
				}
			}
		}
		catch
		{
		}
		return null;
	}

	public static void Clear()
	{
		lock (PendingLookups)
		{
			PendingLookups.Clear();
		}
		MainSceneLoaded = false;
	}

	public static void TryResolve(DeferredLookup lookup)
	{
		if (lookup != null && !lookup.IsResolved)
		{
			TryResolveLookup(lookup);
		}
	}

	public static bool IsMainScene()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Scene activeScene = SceneManager.GetActiveScene();
			return string.Equals(((Scene)(ref activeScene)).name, "Main", StringComparison.OrdinalIgnoreCase);
		}
		catch
		{
			return false;
		}
	}

	public static bool IsMenuScene()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Scene activeScene = SceneManager.GetActiveScene();
			return !string.Equals(((Scene)(ref activeScene)).name, "Main", StringComparison.OrdinalIgnoreCase);
		}
		catch
		{
			return true;
		}
	}
}
