public struct BackgroundRepeat : IEquatable<BackgroundRepeat> // TypeDefIndex: 6170
{
	// Fields
	public Repeat x; // 0x0
	public Repeat y; // 0x4

	// Methods

	// RVA: 0x541AB0 Offset: 0x5404B0 VA: 0x180541AB0
	public void .ctor(Repeat repeatX, Repeat repeatY) { }

	// RVA: 0x12B9DB0 Offset: 0x12B87B0 VA: 0x1812B9DB0
	internal static BackgroundRepeat Initial() { }

	// RVA: 0x2DA90A0 Offset: 0x2DA7AA0 VA: 0x182DA90A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2DA9080 Offset: 0x2DA7A80 VA: 0x182DA9080 Slot: 4
	public bool Equals(BackgroundRepeat other) { }

	// RVA: 0x2DA9130 Offset: 0x2DA7B30 VA: 0x182DA9130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2DA9200 Offset: 0x2DA7C00 VA: 0x182DA9200
	public static bool op_Equality(BackgroundRepeat style1, BackgroundRepeat style2) { }

	// RVA: 0x2DA9220 Offset: 0x2DA7C20 VA: 0x182DA9220
	public static bool op_Inequality(BackgroundRepeat style1, BackgroundRepeat style2) { }

	// RVA: 0x2DA9170 Offset: 0x2DA7B70 VA: 0x182DA9170 Slot: 3
	public override string ToString() { }
}
