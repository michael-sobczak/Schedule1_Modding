using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Levelling;
using UnityEngine;

namespace S1API.Leveling;

public static class LevelManager
{
	private static LevelManager? _hookedManager;

	public static bool Exists => (Object)(object)Internal != (Object)null;

	public static Rank Rank => ((Object)(object)Internal != (Object)null) ? ((Rank)Internal.Rank) : Rank.StreetRat;

	public static int Tier
	{
		get
		{
			LevelManager? obj = Internal;
			return (obj == null) ? 1 : obj.Tier;
		}
	}

	public static int XP
	{
		get
		{
			LevelManager? obj = Internal;
			return (obj != null) ? obj.XP : 0;
		}
	}

	public static int TotalXP
	{
		get
		{
			LevelManager? obj = Internal;
			return (obj != null) ? obj.TotalXP : 0;
		}
	}

	public static float XPToNextTier
	{
		get
		{
			LevelManager? obj = Internal;
			return (obj != null) ? obj.XPToNextTier : 0f;
		}
	}

	public static FullRank CurrentRank => ((Object)(object)Internal != (Object)null) ? FullRank.FromNative(Internal.GetFullRank()) : new FullRank(Rank.StreetRat, 1);

	private static LevelManager? Internal
	{
		get
		{
			LevelManager instance = NetworkSingleton<LevelManager>.Instance;
			if ((Object)(object)instance != (Object)null)
			{
				TryHookEvents(instance);
			}
			return instance;
		}
	}

	public static event Action<FullRank, FullRank>? OnXPChanged;

	public static event Action<FullRank, FullRank>? OnRankUp;

	public static void AddXP(int amount)
	{
		LevelManager? obj = Internal;
		if (obj != null)
		{
			obj.AddXP(amount);
		}
	}

	public static int GetXPForTier(Rank rank)
	{
		return ((Object)(object)Internal != (Object)null) ? Internal.GetXPForTier((ERank)rank) : 0;
	}

	public static FullRank GetFullRankForXP(int totalXp)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		return ((Object)(object)Internal != (Object)null) ? FullRank.FromNative(Internal.GetFullRank(totalXp)) : new FullRank(Rank.StreetRat, 1);
	}

	public static int GetTotalXPForRank(FullRank rank)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return ((Object)(object)Internal != (Object)null) ? Internal.GetTotalXPForRank(rank.ToNative()) : 0;
	}

	public static float GetOrderLimitMultiplier(FullRank rank)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return LevelManager.GetOrderLimitMultiplier(rank.ToNative());
	}

	public static void AddUnlockable(Unlockable unlockable)
	{
		if (unlockable == null)
		{
			throw new ArgumentNullException("unlockable");
		}
		LevelManager? obj = Internal;
		if (obj != null)
		{
			obj.AddUnlockable(unlockable.Native);
		}
	}

	public static IEnumerable<Unlockable> GetUnlockables(FullRank rank)
	{
		LevelManager manager = Internal;
		if (!((Object)(object)manager == (Object)null) && manager.Unlockables.TryGetValue(rank.ToNative(), out var unlockables) && unlockables != null)
		{
			for (int i = 0; i < unlockables.Count; i++)
			{
				yield return new Unlockable(unlockables[i]);
			}
		}
	}

	private static void TryHookEvents(LevelManager manager)
	{
		if (_hookedManager != manager)
		{
			manager.onRankChanged = (Action<FullRank, FullRank>)Delegate.Combine(manager.onRankChanged, new Action<FullRank, FullRank>(HandleRankChanged));
			manager.onRankUp = (Action<FullRank, FullRank>)Delegate.Combine(manager.onRankUp, new Action<FullRank, FullRank>(HandleRankUp));
			_hookedManager = manager;
		}
	}

	private static void HandleRankChanged(FullRank before, FullRank after)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		LevelManager.OnXPChanged?.Invoke(FullRank.FromNative(before), FullRank.FromNative(after));
	}

	private static void HandleRankUp(FullRank before, FullRank after)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		LevelManager.OnRankUp?.Invoke(FullRank.FromNative(before), FullRank.FromNative(after));
	}
}
