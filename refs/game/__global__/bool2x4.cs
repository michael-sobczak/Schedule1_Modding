public struct bool2x4 : IEquatable<bool2x4> // TypeDefIndex: 10873
{
	// Fields
	public bool2 c0; // 0x0
	public bool2 c1; // 0x2
	public bool2 c2; // 0x4
	public bool2 c3; // 0x6

	// Properties
	public bool2 Item { get; }

	// Methods

	// RVA: 0x2712A80 Offset: 0x2711480 VA: 0x182712A80
	public void .ctor(bool2 c0, bool2 c1, bool2 c2, bool2 c3) { }

	// RVA: 0x28D8DE0 Offset: 0x28D77E0 VA: 0x1828D8DE0
	public void .ctor(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13) { }

	// RVA: 0x28D8E40 Offset: 0x28D7840 VA: 0x1828D8E40
	public void .ctor(bool v) { }

	// RVA: 0x288C500 Offset: 0x288AF00 VA: 0x18288C500
	public static bool2x4 op_Implicit(bool v) { }

	// RVA: 0x28D9660 Offset: 0x28D8060 VA: 0x1828D9660
	public static bool2x4 op_Equality(bool2x4 lhs, bool2x4 rhs) { }

	// RVA: 0x28D94A0 Offset: 0x28D7EA0 VA: 0x1828D94A0
	public static bool2x4 op_Equality(bool2x4 lhs, bool rhs) { }

	// RVA: 0x28D9580 Offset: 0x28D7F80 VA: 0x1828D9580
	public static bool2x4 op_Equality(bool lhs, bool2x4 rhs) { }

	// RVA: 0x28D9C30 Offset: 0x28D8630 VA: 0x1828D9C30
	public static bool2x4 op_Inequality(bool2x4 lhs, bool2x4 rhs) { }

	// RVA: 0x28D9A70 Offset: 0x28D8470 VA: 0x1828D9A70
	public static bool2x4 op_Inequality(bool2x4 lhs, bool rhs) { }

	// RVA: 0x28D9B50 Offset: 0x28D8550 VA: 0x1828D9B50
	public static bool2x4 op_Inequality(bool lhs, bool2x4 rhs) { }

	// RVA: 0x28D9D40 Offset: 0x28D8740 VA: 0x1828D9D40
	public static bool2x4 op_LogicalNot(bool2x4 val) { }

	// RVA: 0x28D9050 Offset: 0x28D7A50 VA: 0x1828D9050
	public static bool2x4 op_BitwiseAnd(bool2x4 lhs, bool2x4 rhs) { }

	// RVA: 0x28D8F70 Offset: 0x28D7970 VA: 0x1828D8F70
	public static bool2x4 op_BitwiseAnd(bool2x4 lhs, bool rhs) { }

	// RVA: 0x28D8E90 Offset: 0x28D7890 VA: 0x1828D8E90
	public static bool2x4 op_BitwiseAnd(bool lhs, bool2x4 rhs) { }

	// RVA: 0x28D9360 Offset: 0x28D7D60 VA: 0x1828D9360
	public static bool2x4 op_BitwiseOr(bool2x4 lhs, bool2x4 rhs) { }

	// RVA: 0x28D9180 Offset: 0x28D7B80 VA: 0x1828D9180
	public static bool2x4 op_BitwiseOr(bool2x4 lhs, bool rhs) { }

	// RVA: 0x28D9270 Offset: 0x28D7C70 VA: 0x1828D9270
	public static bool2x4 op_BitwiseOr(bool lhs, bool2x4 rhs) { }

	// RVA: 0x28D9860 Offset: 0x28D8260 VA: 0x1828D9860
	public static bool2x4 op_ExclusiveOr(bool2x4 lhs, bool2x4 rhs) { }

	// RVA: 0x28D9770 Offset: 0x28D8170 VA: 0x1828D9770
	public static bool2x4 op_ExclusiveOr(bool2x4 lhs, bool rhs) { }

	// RVA: 0x28D9980 Offset: 0x28D8380 VA: 0x1828D9980
	public static bool2x4 op_ExclusiveOr(bool lhs, bool2x4 rhs) { }

	// RVA: 0xF6D060 Offset: 0xF6BA60 VA: 0x180F6D060
	public ref bool2 get_Item(int index) { }

	// RVA: 0x28D89D0 Offset: 0x28D73D0 VA: 0x1828D89D0 Slot: 4
	public bool Equals(bool2x4 rhs) { }

	// RVA: 0x28D8900 Offset: 0x28D7300 VA: 0x1828D8900 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x28D8A30 Offset: 0x28D7430 VA: 0x1828D8A30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x28D8A40 Offset: 0x28D7440 VA: 0x1828D8A40 Slot: 3
	public override string ToString() { }
}
