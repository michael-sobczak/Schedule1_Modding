using Il2CppScheduleOne.Levelling;
using UnityEngine;

namespace S1API.Leveling;

public sealed class Unlockable
{
	internal Unlockable Native { get; }

	public FullRank Rank
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return FullRank.FromNative(Native.Rank);
		}
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			Native.Rank = value.ToNative();
		}
	}

	public string Title
	{
		get
		{
			return Native.Title;
		}
		set
		{
			Native.Title = value;
		}
	}

	public Sprite Icon
	{
		get
		{
			return Native.Icon;
		}
		set
		{
			Native.Icon = value;
		}
	}

	public Unlockable(FullRank rank, string title, Sprite icon)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Native = new Unlockable(rank.ToNative(), title, icon);
	}

	internal Unlockable(Unlockable unlockable)
	{
		Native = unlockable;
	}
}
