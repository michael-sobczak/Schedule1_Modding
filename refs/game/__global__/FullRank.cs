public struct FullRank // TypeDefIndex: 1273
{
	// Fields
	public const int TIER_COUNT = 5;
	public ERank Rank; // 0x0
	[Range(1, 5)]
	public int Tier; // 0x4

	// Methods

	// RVA: 0x541AB0 Offset: 0x5404B0 VA: 0x180541AB0
	public void .ctor(ERank rank, int tier) { }

	// RVA: 0x60F500 Offset: 0x60DF00 VA: 0x18060F500 Slot: 3
	public override string ToString() { }

	// RVA: 0x60F490 Offset: 0x60DE90 VA: 0x18060F490
	public FullRank NextRank() { }

	// RVA: 0x60F4E0 Offset: 0x60DEE0 VA: 0x18060F4E0
	public float ToFloat() { }

	// RVA: 0x60F320 Offset: 0x60DD20 VA: 0x18060F320
	public int GetRankIndex() { }

	// RVA: 0x60F330 Offset: 0x60DD30 VA: 0x18060F330
	public static string GetString(FullRank rank) { }

	// RVA: 0x60F6A0 Offset: 0x60E0A0 VA: 0x18060F6A0
	public static bool op_GreaterThan(FullRank a, FullRank b) { }

	// RVA: 0x60F720 Offset: 0x60E120 VA: 0x18060F720
	public static bool op_LessThan(FullRank a, FullRank b) { }

	// RVA: 0x60F6E0 Offset: 0x60E0E0 VA: 0x18060F6E0
	public static bool op_LessThanOrEqual(FullRank a, FullRank b) { }

	// RVA: 0x60F660 Offset: 0x60E060 VA: 0x18060F660
	public static bool op_GreaterThanOrEqual(FullRank a, FullRank b) { }

	// RVA: 0x50DD70 Offset: 0x50C770 VA: 0x18050DD70
	public static bool op_Equality(FullRank a, FullRank b) { }

	// RVA: 0x60F6C0 Offset: 0x60E0C0 VA: 0x18060F6C0
	public static bool op_Inequality(FullRank a, FullRank b) { }

	// RVA: 0x60F230 Offset: 0x60DC30 VA: 0x18060F230 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x60F2D0 Offset: 0x60DCD0 VA: 0x18060F2D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x60F1E0 Offset: 0x60DBE0 VA: 0x18060F1E0
	public int CompareTo(FullRank other) { }
}
