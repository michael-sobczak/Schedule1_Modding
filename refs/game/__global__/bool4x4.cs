public struct bool4x4 : IEquatable<bool4x4> // TypeDefIndex: 10883
{
	// Fields
	public bool4 c0; // 0x0
	public bool4 c1; // 0x4
	public bool4 c2; // 0x8
	public bool4 c3; // 0xC

	// Properties
	public bool4 Item { get; }

	// Methods

	// RVA: 0x1E0BAA0 Offset: 0x1E0A4A0 VA: 0x181E0BAA0
	public void .ctor(bool4 c0, bool4 c1, bool4 c2, bool4 c3) { }

	// RVA: 0x2900B00 Offset: 0x28FF500 VA: 0x182900B00
	public void .ctor(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23, bool m30, bool m31, bool m32, bool m33) { }

	// RVA: 0x2900BB0 Offset: 0x28FF5B0 VA: 0x182900BB0
	public void .ctor(bool v) { }

	// RVA: 0x288CC30 Offset: 0x288B630 VA: 0x18288CC30
	public static bool4x4 op_Implicit(bool v) { }

	// RVA: 0x2901380 Offset: 0x28FFD80 VA: 0x182901380
	public static bool4x4 op_Equality(bool4x4 lhs, bool4x4 rhs) { }

	// RVA: 0x2901290 Offset: 0x28FFC90 VA: 0x182901290
	public static bool4x4 op_Equality(bool4x4 lhs, bool rhs) { }

	// RVA: 0x29014D0 Offset: 0x28FFED0 VA: 0x1829014D0
	public static bool4x4 op_Equality(bool lhs, bool4x4 rhs) { }

	// RVA: 0x2901A00 Offset: 0x2900400 VA: 0x182901A00
	public static bool4x4 op_Inequality(bool4x4 lhs, bool4x4 rhs) { }

	// RVA: 0x2901B50 Offset: 0x2900550 VA: 0x182901B50
	public static bool4x4 op_Inequality(bool4x4 lhs, bool rhs) { }

	// RVA: 0x2901910 Offset: 0x2900310 VA: 0x182901910
	public static bool4x4 op_Inequality(bool lhs, bool4x4 rhs) { }

	// RVA: 0x2901C40 Offset: 0x2900640 VA: 0x182901C40
	public static bool4x4 op_LogicalNot(bool4x4 val) { }

	// RVA: 0x2900DF0 Offset: 0x28FF7F0 VA: 0x182900DF0
	public static bool4x4 op_BitwiseAnd(bool4x4 lhs, bool4x4 rhs) { }

	// RVA: 0x2900C10 Offset: 0x28FF610 VA: 0x182900C10
	public static bool4x4 op_BitwiseAnd(bool4x4 lhs, bool rhs) { }

	// RVA: 0x2900D00 Offset: 0x28FF700 VA: 0x182900D00
	public static bool4x4 op_BitwiseAnd(bool lhs, bool4x4 rhs) { }

	// RVA: 0x2901140 Offset: 0x28FFB40 VA: 0x182901140
	public static bool4x4 op_BitwiseOr(bool4x4 lhs, bool4x4 rhs) { }

	// RVA: 0x2900F40 Offset: 0x28FF940 VA: 0x182900F40
	public static bool4x4 op_BitwiseOr(bool4x4 lhs, bool rhs) { }

	// RVA: 0x2901040 Offset: 0x28FFA40 VA: 0x182901040
	public static bool4x4 op_BitwiseOr(bool lhs, bool4x4 rhs) { }

	// RVA: 0x29016C0 Offset: 0x29000C0 VA: 0x1829016C0
	public static bool4x4 op_ExclusiveOr(bool4x4 lhs, bool4x4 rhs) { }

	// RVA: 0x2901810 Offset: 0x2900210 VA: 0x182901810
	public static bool4x4 op_ExclusiveOr(bool4x4 lhs, bool rhs) { }

	// RVA: 0x29015C0 Offset: 0x28FFFC0 VA: 0x1829015C0
	public static bool4x4 op_ExclusiveOr(bool lhs, bool4x4 rhs) { }

	// RVA: 0xF6C6B0 Offset: 0xF6B0B0 VA: 0x180F6C6B0
	public ref bool4 get_Item(int index) { }

	// RVA: 0x28FB3F0 Offset: 0x28F9DF0 VA: 0x1828FB3F0 Slot: 4
	public bool Equals(bool4x4 rhs) { }

	// RVA: 0x2900380 Offset: 0x28FED80 VA: 0x182900380 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2900420 Offset: 0x28FEE20 VA: 0x182900420 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2900440 Offset: 0x28FEE40 VA: 0x182900440 Slot: 3
	public override string ToString() { }
}
