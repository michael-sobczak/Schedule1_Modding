public struct bool3x4 : IEquatable<bool3x4> // TypeDefIndex: 10878
{
	// Fields
	public bool3 c0; // 0x0
	public bool3 c1; // 0x3
	public bool3 c2; // 0x6
	public bool3 c3; // 0x9

	// Properties
	public bool3 Item { get; }

	// Methods

	// RVA: 0x28DD830 Offset: 0x28DC230 VA: 0x1828DD830
	public void .ctor(bool3 c0, bool3 c1, bool3 c2, bool3 c3) { }

	// RVA: 0x28DD7A0 Offset: 0x28DC1A0 VA: 0x1828DD7A0
	public void .ctor(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23) { }

	// RVA: 0x28DD750 Offset: 0x28DC150 VA: 0x1828DD750
	public void .ctor(bool v) { }

	// RVA: 0x288C840 Offset: 0x288B240 VA: 0x18288C840
	public static bool3x4 op_Implicit(bool v) { }

	// RVA: 0x28DDFD0 Offset: 0x28DC9D0 VA: 0x1828DDFD0
	public static bool3x4 op_Equality(bool3x4 lhs, bool3x4 rhs) { }

	// RVA: 0x28DE120 Offset: 0x28DCB20 VA: 0x1828DE120
	public static bool3x4 op_Equality(bool3x4 lhs, bool rhs) { }

	// RVA: 0x28DDEF0 Offset: 0x28DC8F0 VA: 0x1828DDEF0
	public static bool3x4 op_Equality(bool lhs, bool3x4 rhs) { }

	// RVA: 0x28DE640 Offset: 0x28DD040 VA: 0x1828DE640
	public static bool3x4 op_Inequality(bool3x4 lhs, bool3x4 rhs) { }

	// RVA: 0x28DE560 Offset: 0x28DCF60 VA: 0x1828DE560
	public static bool3x4 op_Inequality(bool3x4 lhs, bool rhs) { }

	// RVA: 0x28DE790 Offset: 0x28DD190 VA: 0x1828DE790
	public static bool3x4 op_Inequality(bool lhs, bool3x4 rhs) { }

	// RVA: 0x28DE870 Offset: 0x28DD270 VA: 0x1828DE870
	public static bool3x4 op_LogicalNot(bool3x4 val) { }

	// RVA: 0x28DD970 Offset: 0x28DC370 VA: 0x1828DD970
	public static bool3x4 op_BitwiseAnd(bool3x4 lhs, bool3x4 rhs) { }

	// RVA: 0x28DDAA0 Offset: 0x28DC4A0 VA: 0x1828DDAA0
	public static bool3x4 op_BitwiseAnd(bool3x4 lhs, bool rhs) { }

	// RVA: 0x28DD880 Offset: 0x28DC280 VA: 0x1828DD880
	public static bool3x4 op_BitwiseAnd(bool lhs, bool3x4 rhs) { }

	// RVA: 0x28DDDB0 Offset: 0x28DC7B0 VA: 0x1828DDDB0
	public static bool3x4 op_BitwiseOr(bool3x4 lhs, bool3x4 rhs) { }

	// RVA: 0x28DDCA0 Offset: 0x28DC6A0 VA: 0x1828DDCA0
	public static bool3x4 op_BitwiseOr(bool3x4 lhs, bool rhs) { }

	// RVA: 0x28DDB90 Offset: 0x28DC590 VA: 0x1828DDB90
	public static bool3x4 op_BitwiseOr(bool lhs, bool3x4 rhs) { }

	// RVA: 0x28DE200 Offset: 0x28DCC00 VA: 0x1828DE200
	public static bool3x4 op_ExclusiveOr(bool3x4 lhs, bool3x4 rhs) { }

	// RVA: 0x28DE340 Offset: 0x28DCD40 VA: 0x1828DE340
	public static bool3x4 op_ExclusiveOr(bool3x4 lhs, bool rhs) { }

	// RVA: 0x28DE450 Offset: 0x28DCE50 VA: 0x1828DE450
	public static bool3x4 op_ExclusiveOr(bool lhs, bool3x4 rhs) { }

	// RVA: 0x28DB510 Offset: 0x28D9F10 VA: 0x1828DB510
	public ref bool3 get_Item(int index) { }

	// RVA: 0x28D6040 Offset: 0x28D4A40 VA: 0x1828D6040 Slot: 4
	public bool Equals(bool3x4 rhs) { }

	// RVA: 0x28DD160 Offset: 0x28DBB60 VA: 0x1828DD160 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x28DD200 Offset: 0x28DBC00 VA: 0x1828DD200 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x28DD230 Offset: 0x28DBC30 VA: 0x1828DD230 Slot: 3
	public override string ToString() { }
}
