public struct TextShadow : IEquatable<TextShadow> // TypeDefIndex: 6922
{
	// Fields
	public Vector2 offset; // 0x0
	public float blurRadius; // 0x8
	public Color color; // 0xC

	// Methods

	// RVA: 0x2DE20A0 Offset: 0x2DE0AA0 VA: 0x182DE20A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2DE2150 Offset: 0x2DE0B50 VA: 0x182DE2150 Slot: 4
	public bool Equals(TextShadow other) { }

	// RVA: 0x2DE2210 Offset: 0x2DE0C10 VA: 0x182DE2210 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2DE2520 Offset: 0x2DE0F20 VA: 0x182DE2520
	public static bool op_Equality(TextShadow style1, TextShadow style2) { }

	// RVA: 0x2DE2550 Offset: 0x2DE0F50 VA: 0x182DE2550
	public static bool op_Inequality(TextShadow style1, TextShadow style2) { }

	// RVA: 0x2DE2440 Offset: 0x2DE0E40 VA: 0x182DE2440 Slot: 3
	public override string ToString() { }

	// RVA: 0x2DE2300 Offset: 0x2DE0D00 VA: 0x182DE2300
	internal static TextShadow LerpUnclamped(TextShadow a, TextShadow b, float t) { }
}
