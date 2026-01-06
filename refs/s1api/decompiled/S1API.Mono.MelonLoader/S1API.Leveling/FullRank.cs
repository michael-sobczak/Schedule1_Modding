using System;
using ScheduleOne.Levelling;

namespace S1API.Leveling;

public readonly struct FullRank : IEquatable<FullRank>, IComparable<FullRank>
{
	public Rank Rank { get; }

	public int Tier { get; }

	public FullRank(Rank rank, int tier)
	{
		Rank = rank;
		Tier = Math.Max(1, tier);
	}

	public FullRank NextRank()
	{
		return (Rank == Rank.Kingpin) ? new FullRank(Rank.Kingpin, Tier + 1) : ((Tier < 5) ? new FullRank(Rank, Tier + 1) : new FullRank(Rank + 1, 1));
	}

	public float ToFloat()
	{
		return (float)Rank + (float)Tier / 5f;
	}

	public int GetRankIndex()
	{
		return (int)Rank * 5 + (Tier - 1);
	}

	public override string ToString()
	{
		Rank rank = Rank;
		if (1 == 0)
		{
		}
		string text = rank switch
		{
			Rank.StreetRat => "Street Rat", 
			Rank.ShotCaller => "Shot Caller", 
			Rank.BlockBoss => "Block Boss", 
			_ => Rank.ToString(), 
		};
		if (1 == 0)
		{
		}
		string text2 = text;
		int tier = Tier;
		if (1 == 0)
		{
		}
		text = tier switch
		{
			1 => "I", 
			2 => "II", 
			3 => "III", 
			4 => "IV", 
			5 => "V", 
			_ => Tier.ToString(), 
		};
		if (1 == 0)
		{
		}
		string text3 = text;
		return text2 + " " + text3;
	}

	public bool Equals(FullRank other)
	{
		return Rank == other.Rank && Tier == other.Tier;
	}

	public override bool Equals(object? obj)
	{
		return obj is FullRank other && Equals(other);
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(Rank, Tier);
	}

	public int CompareTo(FullRank other)
	{
		int num = Rank.CompareTo(other.Rank);
		if (num != 0)
		{
			return num;
		}
		return Tier.CompareTo(other.Tier);
	}

	public static bool operator >(FullRank a, FullRank b)
	{
		return a.CompareTo(b) > 0;
	}

	public static bool operator <(FullRank a, FullRank b)
	{
		return a.CompareTo(b) < 0;
	}

	public static bool operator >=(FullRank a, FullRank b)
	{
		return a.CompareTo(b) >= 0;
	}

	public static bool operator <=(FullRank a, FullRank b)
	{
		return a.CompareTo(b) <= 0;
	}

	public static bool operator ==(FullRank a, FullRank b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(FullRank a, FullRank b)
	{
		return !a.Equals(b);
	}

	internal static FullRank FromNative(FullRank rank)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		return new FullRank((Rank)rank.Rank, rank.Tier);
	}

	internal FullRank ToNative()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return new FullRank((ERank)Rank, Tier);
	}
}
