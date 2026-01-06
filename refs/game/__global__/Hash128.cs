public struct Hash128 : IComparable, IComparable<Hash128>, IEquatable<Hash128> // TypeDefIndex: 11733
{
	// Fields
	internal ulong u64_0; // 0x0
	internal ulong u64_1; // 0x8
	private const ulong kConst = 16045690984833335023;

	// Methods

	// RVA: 0x2CA6100 Offset: 0x2CA4B00 VA: 0x182CA6100
	public void .ctor(uint u32_0, uint u32_1, uint u32_2, uint u32_3) { }

	// RVA: 0xC41170 Offset: 0xC3FB70 VA: 0x180C41170
	public void .ctor(ulong u64_0, ulong u64_1) { }

	// RVA: 0x2CA5E40 Offset: 0x2CA4840 VA: 0x182CA5E40 Slot: 5
	public int CompareTo(Hash128 rhs) { }

	// RVA: 0x2CA60C0 Offset: 0x2CA4AC0 VA: 0x182CA60C0 Slot: 3
	public override string ToString() { }

	[FreeFunction("StringToHash128", IsThreadSafe = True)]
	// RVA: 0x2CA6070 Offset: 0x2CA4A70 VA: 0x182CA6070
	public static Hash128 Parse(string hashString) { }

	[FreeFunction("Hash128ToString", IsThreadSafe = True)]
	// RVA: 0x2CA5FE0 Offset: 0x2CA49E0 VA: 0x182CA5FE0
	private static string Hash128ToStringImpl(Hash128 hash) { }

	// RVA: 0x2CA5E90 Offset: 0x2CA4890 VA: 0x182CA5E90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CA5F40 Offset: 0x2CA4940 VA: 0x182CA5F40 Slot: 6
	public bool Equals(Hash128 obj) { }

	// RVA: 0x2CA5F70 Offset: 0x2CA4970 VA: 0x182CA5F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CA5D60 Offset: 0x2CA4760 VA: 0x182CA5D60 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x1E2CD60 Offset: 0x1E2B760 VA: 0x181E2CD60
	public static bool op_Equality(Hash128 hash1, Hash128 hash2) { }

	// RVA: 0x2CA6160 Offset: 0x2CA4B60 VA: 0x182CA6160
	public static bool op_LessThan(Hash128 x, Hash128 y) { }

	// RVA: 0x2CA6130 Offset: 0x2CA4B30 VA: 0x182CA6130
	public static bool op_GreaterThan(Hash128 x, Hash128 y) { }

	// RVA: 0x2CA6020 Offset: 0x2CA4A20 VA: 0x182CA6020
	private static void Parse_Injected(string hashString, out Hash128 ret) { }

	// RVA: 0x2CA5FA0 Offset: 0x2CA49A0 VA: 0x182CA5FA0
	private static string Hash128ToStringImpl_Injected(ref Hash128 hash) { }
}
