public struct bool3x3 : IEquatable<bool3x3> // TypeDefIndex: 10877
{
	// Fields
	public bool3 c0; // 0x0
	public bool3 c1; // 0x3
	public bool3 c2; // 0x6

	// Properties
	public bool3 Item { get; }

	// Methods

	// RVA: 0x28DC4B0 Offset: 0x28DAEB0 VA: 0x1828DC4B0
	public void .ctor(bool3 c0, bool3 c1, bool3 c2) { }

	// RVA: 0x28DC440 Offset: 0x28DAE40 VA: 0x1828DC440
	public void .ctor(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22) { }

	// RVA: 0x28DC400 Offset: 0x28DAE00 VA: 0x1828DC400
	public void .ctor(bool v) { }

	// RVA: 0x288C6E0 Offset: 0x288B0E0 VA: 0x18288C6E0
	public static bool3x3 op_Implicit(bool v) { }

	// RVA: 0x28DCA50 Offset: 0x28DB450 VA: 0x1828DCA50
	public static bool3x3 op_Equality(bool3x3 lhs, bool3x3 rhs) { }

	// RVA: 0x28DCB40 Offset: 0x28DB540 VA: 0x1828DCB40
	public static bool3x3 op_Equality(bool3x3 lhs, bool rhs) { }

	// RVA: 0x28DC9A0 Offset: 0x28DB3A0 VA: 0x1828DC9A0
	public static bool3x3 op_Equality(bool lhs, bool3x3 rhs) { }

	// RVA: 0x28DCFC0 Offset: 0x28DB9C0 VA: 0x1828DCFC0
	public static bool3x3 op_Inequality(bool3x3 lhs, bool3x3 rhs) { }

	// RVA: 0x28DCF10 Offset: 0x28DB910 VA: 0x1828DCF10
	public static bool3x3 op_Inequality(bool3x3 lhs, bool rhs) { }

	// RVA: 0x28DCE60 Offset: 0x28DB860 VA: 0x1828DCE60
	public static bool3x3 op_Inequality(bool lhs, bool3x3 rhs) { }

	// RVA: 0x28DD0B0 Offset: 0x28DBAB0 VA: 0x1828DD0B0
	public static bool3x3 op_LogicalNot(bool3x3 val) { }

	// RVA: 0x28DC590 Offset: 0x28DAF90 VA: 0x1828DC590
	public static bool3x3 op_BitwiseAnd(bool3x3 lhs, bool3x3 rhs) { }

	// RVA: 0x28DC670 Offset: 0x28DB070 VA: 0x1828DC670
	public static bool3x3 op_BitwiseAnd(bool3x3 lhs, bool rhs) { }

	// RVA: 0x28DC4E0 Offset: 0x28DAEE0 VA: 0x1828DC4E0
	public static bool3x3 op_BitwiseAnd(bool lhs, bool3x3 rhs) { }

	// RVA: 0x28DC7F0 Offset: 0x28DB1F0 VA: 0x1828DC7F0
	public static bool3x3 op_BitwiseOr(bool3x3 lhs, bool3x3 rhs) { }

	// RVA: 0x28DC730 Offset: 0x28DB130 VA: 0x1828DC730
	public static bool3x3 op_BitwiseOr(bool3x3 lhs, bool rhs) { }

	// RVA: 0x28DC8E0 Offset: 0x28DB2E0 VA: 0x1828DC8E0
	public static bool3x3 op_BitwiseOr(bool lhs, bool3x3 rhs) { }

	// RVA: 0x28DCD70 Offset: 0x28DB770 VA: 0x1828DCD70
	public static bool3x3 op_ExclusiveOr(bool3x3 lhs, bool3x3 rhs) { }

	// RVA: 0x28DCBF0 Offset: 0x28DB5F0 VA: 0x1828DCBF0
	public static bool3x3 op_ExclusiveOr(bool3x3 lhs, bool rhs) { }

	// RVA: 0x28DCCB0 Offset: 0x28DB6B0 VA: 0x1828DCCB0
	public static bool3x3 op_ExclusiveOr(bool lhs, bool3x3 rhs) { }

	// RVA: 0x28DB510 Offset: 0x28D9F10 VA: 0x1828DB510
	public ref bool3 get_Item(int index) { }

	// RVA: 0x28DBF50 Offset: 0x28DA950 VA: 0x1828DBF50 Slot: 4
	public bool Equals(bool3x3 rhs) { }

	// RVA: 0x28DBE50 Offset: 0x28DA850 VA: 0x1828DBE50 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x28DBFD0 Offset: 0x28DA9D0 VA: 0x1828DBFD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x28DC000 Offset: 0x28DAA00 VA: 0x1828DC000 Slot: 3
	public override string ToString() { }
}
