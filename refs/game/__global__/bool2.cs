public struct bool2 : IEquatable<bool2> // TypeDefIndex: 10865
{
	// Fields
	public bool x; // 0x0
	public bool y; // 0x1

	// Properties
	[EditorBrowsable(1)]
	public bool4 xxxx { get; }
	[EditorBrowsable(1)]
	public bool4 xxxy { get; }
	[EditorBrowsable(1)]
	public bool4 xxyx { get; }
	[EditorBrowsable(1)]
	public bool4 xxyy { get; }
	[EditorBrowsable(1)]
	public bool4 xyxx { get; }
	[EditorBrowsable(1)]
	public bool4 xyxy { get; }
	[EditorBrowsable(1)]
	public bool4 xyyx { get; }
	[EditorBrowsable(1)]
	public bool4 xyyy { get; }
	[EditorBrowsable(1)]
	public bool4 yxxx { get; }
	[EditorBrowsable(1)]
	public bool4 yxxy { get; }
	[EditorBrowsable(1)]
	public bool4 yxyx { get; }
	[EditorBrowsable(1)]
	public bool4 yxyy { get; }
	[EditorBrowsable(1)]
	public bool4 yyxx { get; }
	[EditorBrowsable(1)]
	public bool4 yyxy { get; }
	[EditorBrowsable(1)]
	public bool4 yyyx { get; }
	[EditorBrowsable(1)]
	public bool4 yyyy { get; }
	[EditorBrowsable(1)]
	public bool3 xxx { get; }
	[EditorBrowsable(1)]
	public bool3 xxy { get; }
	[EditorBrowsable(1)]
	public bool3 xyx { get; }
	[EditorBrowsable(1)]
	public bool3 xyy { get; }
	[EditorBrowsable(1)]
	public bool3 yxx { get; }
	[EditorBrowsable(1)]
	public bool3 yxy { get; }
	[EditorBrowsable(1)]
	public bool3 yyx { get; }
	[EditorBrowsable(1)]
	public bool3 yyy { get; }
	[EditorBrowsable(1)]
	public bool2 xx { get; }
	[EditorBrowsable(1)]
	public bool2 xy { get; set; }
	[EditorBrowsable(1)]
	public bool2 yx { get; set; }
	[EditorBrowsable(1)]
	public bool2 yy { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0xD73E50 Offset: 0xD72850 VA: 0x180D73E50
	public void .ctor(bool x, bool y) { }

	// RVA: 0x28D6B30 Offset: 0x28D5530 VA: 0x1828D6B30
	public void .ctor(bool2 xy) { }

	// RVA: 0x28D6B40 Offset: 0x28D5540 VA: 0x1828D6B40
	public void .ctor(bool v) { }

	// RVA: 0x288C310 Offset: 0x288AD10 VA: 0x18288C310
	public static bool2 op_Implicit(bool v) { }

	// RVA: 0x28D6FC0 Offset: 0x28D59C0 VA: 0x1828D6FC0
	public static bool2 op_Equality(bool2 lhs, bool2 rhs) { }

	// RVA: 0x28D6FE0 Offset: 0x28D59E0 VA: 0x1828D6FE0
	public static bool2 op_Equality(bool2 lhs, bool rhs) { }

	// RVA: 0x28D6FA0 Offset: 0x28D59A0 VA: 0x1828D6FA0
	public static bool2 op_Equality(bool lhs, bool2 rhs) { }

	// RVA: 0x28D7060 Offset: 0x28D5A60 VA: 0x1828D7060
	public static bool2 op_Inequality(bool2 lhs, bool2 rhs) { }

	// RVA: 0x28D7080 Offset: 0x28D5A80 VA: 0x1828D7080
	public static bool2 op_Inequality(bool2 lhs, bool rhs) { }

	// RVA: 0x28D70A0 Offset: 0x28D5AA0 VA: 0x1828D70A0
	public static bool2 op_Inequality(bool lhs, bool2 rhs) { }

	// RVA: 0x28D70C0 Offset: 0x28D5AC0 VA: 0x1828D70C0
	public static bool2 op_LogicalNot(bool2 val) { }

	// RVA: 0x28D6F00 Offset: 0x28D5900 VA: 0x1828D6F00
	public static bool2 op_BitwiseAnd(bool2 lhs, bool2 rhs) { }

	// RVA: 0x28D6F20 Offset: 0x28D5920 VA: 0x1828D6F20
	public static bool2 op_BitwiseAnd(bool2 lhs, bool rhs) { }

	// RVA: 0x28D6EE0 Offset: 0x28D58E0 VA: 0x1828D6EE0
	public static bool2 op_BitwiseAnd(bool lhs, bool2 rhs) { }

	// RVA: 0x28D6F60 Offset: 0x28D5960 VA: 0x1828D6F60
	public static bool2 op_BitwiseOr(bool2 lhs, bool2 rhs) { }

	// RVA: 0x28D6F80 Offset: 0x28D5980 VA: 0x1828D6F80
	public static bool2 op_BitwiseOr(bool2 lhs, bool rhs) { }

	// RVA: 0x28D6F40 Offset: 0x28D5940 VA: 0x1828D6F40
	public static bool2 op_BitwiseOr(bool lhs, bool2 rhs) { }

	// RVA: 0x28D7020 Offset: 0x28D5A20 VA: 0x1828D7020
	public static bool2 op_ExclusiveOr(bool2 lhs, bool2 rhs) { }

	// RVA: 0x28D7040 Offset: 0x28D5A40 VA: 0x1828D7040
	public static bool2 op_ExclusiveOr(bool2 lhs, bool rhs) { }

	// RVA: 0x28D7000 Offset: 0x28D5A00 VA: 0x1828D7000
	public static bool2 op_ExclusiveOr(bool lhs, bool2 rhs) { }

	// RVA: 0x28D6B90 Offset: 0x28D5590 VA: 0x1828D6B90
	public bool4 get_xxxx() { }

	// RVA: 0x28D6BB0 Offset: 0x28D55B0 VA: 0x1828D6BB0
	public bool4 get_xxxy() { }

	// RVA: 0x28D6BF0 Offset: 0x28D55F0 VA: 0x1828D6BF0
	public bool4 get_xxyx() { }

	// RVA: 0x28D6C10 Offset: 0x28D5610 VA: 0x1828D6C10
	public bool4 get_xxyy() { }

	// RVA: 0x28D6C70 Offset: 0x28D5670 VA: 0x1828D6C70
	public bool4 get_xyxx() { }

	// RVA: 0x28D6C90 Offset: 0x28D5690 VA: 0x1828D6C90
	public bool4 get_xyxy() { }

	// RVA: 0x28D6CE0 Offset: 0x28D56E0 VA: 0x1828D6CE0
	public bool4 get_xyyx() { }

	// RVA: 0x28D6D00 Offset: 0x28D5700 VA: 0x1828D6D00
	public bool4 get_xyyy() { }

	// RVA: 0x28D6D60 Offset: 0x28D5760 VA: 0x1828D6D60
	public bool4 get_yxxx() { }

	// RVA: 0x28D6D80 Offset: 0x28D5780 VA: 0x1828D6D80
	public bool4 get_yxxy() { }

	// RVA: 0x28D6DC0 Offset: 0x28D57C0 VA: 0x1828D6DC0
	public bool4 get_yxyx() { }

	// RVA: 0x28D6DF0 Offset: 0x28D57F0 VA: 0x1828D6DF0
	public bool4 get_yxyy() { }

	// RVA: 0x28D6E50 Offset: 0x28D5850 VA: 0x1828D6E50
	public bool4 get_yyxx() { }

	// RVA: 0x28D6E70 Offset: 0x28D5870 VA: 0x1828D6E70
	public bool4 get_yyxy() { }

	// RVA: 0x28D6EA0 Offset: 0x28D58A0 VA: 0x1828D6EA0
	public bool4 get_yyyx() { }

	// RVA: 0x28D6EC0 Offset: 0x28D58C0 VA: 0x1828D6EC0
	public bool4 get_yyyy() { }

	// RVA: 0x28D6B80 Offset: 0x28D5580 VA: 0x1828D6B80
	public bool3 get_xxx() { }

	// RVA: 0x28D6BD0 Offset: 0x28D55D0 VA: 0x1828D6BD0
	public bool3 get_xxy() { }

	// RVA: 0x28D6C50 Offset: 0x28D5650 VA: 0x1828D6C50
	public bool3 get_xyx() { }

	// RVA: 0x28D6CC0 Offset: 0x28D56C0 VA: 0x1828D6CC0
	public bool3 get_xyy() { }

	// RVA: 0x28D6D40 Offset: 0x28D5740 VA: 0x1828D6D40
	public bool3 get_yxx() { }

	// RVA: 0x28D6DA0 Offset: 0x28D57A0 VA: 0x1828D6DA0
	public bool3 get_yxy() { }

	// RVA: 0x28D6E30 Offset: 0x28D5830 VA: 0x1828D6E30
	public bool3 get_yyx() { }

	// RVA: 0x28D6E90 Offset: 0x28D5890 VA: 0x1828D6E90
	public bool3 get_yyy() { }

	// RVA: 0x28D6B60 Offset: 0x28D5560 VA: 0x1828D6B60
	public bool2 get_xx() { }

	// RVA: 0x28D6C30 Offset: 0x28D5630 VA: 0x1828D6C30
	public bool2 get_xy() { }

	// RVA: 0x28D6B30 Offset: 0x28D5530 VA: 0x1828D6B30
	public void set_xy(bool2 value) { }

	// RVA: 0x28D6D20 Offset: 0x28D5720 VA: 0x1828D6D20
	public bool2 get_yx() { }

	// RVA: 0x28D70E0 Offset: 0x28D5AE0 VA: 0x1828D70E0
	public void set_yx(bool2 value) { }

	// RVA: 0x28D6E10 Offset: 0x28D5810 VA: 0x1828D6E10
	public bool2 get_yy() { }

	// RVA: 0x28D6B50 Offset: 0x28D5550 VA: 0x1828D6B50
	public bool get_Item(int index) { }

	// RVA: 0xF72E60 Offset: 0xF71860 VA: 0x180F72E60
	public void set_Item(int index, bool value) { }

	// RVA: 0x28D6980 Offset: 0x28D5380 VA: 0x1828D6980 Slot: 4
	public bool Equals(bool2 rhs) { }

	// RVA: 0x28D69A0 Offset: 0x28D53A0 VA: 0x1828D69A0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x28D6A30 Offset: 0x28D5430 VA: 0x1828D6A30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x28D6AA0 Offset: 0x28D54A0 VA: 0x1828D6AA0 Slot: 3
	public override string ToString() { }
}
