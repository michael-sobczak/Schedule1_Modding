public struct uint4x2 : IEquatable<uint4x2>, IFormattable // TypeDefIndex: 10954
{
	// Fields
	public uint4 c0; // 0x0
	public uint4 c1; // 0x10
	public static readonly uint4x2 zero; // 0x0

	// Properties
	public uint4 Item { get; }

	// Methods

	// RVA: 0x1330B70 Offset: 0x132F570 VA: 0x181330B70
	public void .ctor(uint4 c0, uint4 c1) { }

	// RVA: 0x28EE310 Offset: 0x28ECD10 VA: 0x1828EE310
	public void .ctor(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21, uint m30, uint m31) { }

	// RVA: 0x28EE260 Offset: 0x28ECC60 VA: 0x1828EE260
	public void .ctor(uint v) { }

	// RVA: 0x2888AD0 Offset: 0x28874D0 VA: 0x182888AD0
	public void .ctor(bool v) { }

	// RVA: 0x28EE360 Offset: 0x28ECD60 VA: 0x1828EE360
	public void .ctor(bool4x2 v) { }

	// RVA: 0x28EE260 Offset: 0x28ECC60 VA: 0x1828EE260
	public void .ctor(int v) { }

	// RVA: 0x28EE2A0 Offset: 0x28ECCA0 VA: 0x1828EE2A0
	public void .ctor(int4x2 v) { }

	// RVA: 0x2888C20 Offset: 0x2887620 VA: 0x182888C20
	public void .ctor(float v) { }

	// RVA: 0x2888CE0 Offset: 0x28876E0 VA: 0x182888CE0
	public void .ctor(float4x2 v) { }

	// RVA: 0x2888B60 Offset: 0x2887560 VA: 0x182888B60
	public void .ctor(double v) { }

	// RVA: 0x28889E0 Offset: 0x28873E0 VA: 0x1828889E0
	public void .ctor(double4x2 v) { }

	// RVA: 0x28A93D0 Offset: 0x28A7DD0 VA: 0x1828A93D0
	public static uint4x2 op_Implicit(uint v) { }

	// RVA: 0x28EEF30 Offset: 0x28ED930 VA: 0x1828EEF30
	public static uint4x2 op_Explicit(bool v) { }

	// RVA: 0x28A9560 Offset: 0x28A7F60 VA: 0x1828A9560
	public static uint4x2 op_Explicit(bool4x2 v) { }

	// RVA: 0x28A93D0 Offset: 0x28A7DD0 VA: 0x1828A93D0
	public static uint4x2 op_Explicit(int v) { }

	// RVA: 0x28A9410 Offset: 0x28A7E10 VA: 0x1828A9410
	public static uint4x2 op_Explicit(int4x2 v) { }

	// RVA: 0x28EEFE0 Offset: 0x28ED9E0 VA: 0x1828EEFE0
	public static uint4x2 op_Explicit(float v) { }

	// RVA: 0x28EEEF0 Offset: 0x28ED8F0 VA: 0x1828EEEF0
	public static uint4x2 op_Explicit(float4x2 v) { }

	// RVA: 0x28EEFB0 Offset: 0x28ED9B0 VA: 0x1828EEFB0
	public static uint4x2 op_Explicit(double v) { }

	// RVA: 0x28EEF60 Offset: 0x28ED960 VA: 0x1828EEF60
	public static uint4x2 op_Explicit(double4x2 v) { }

	// RVA: 0x28F0220 Offset: 0x28EEC20 VA: 0x1828F0220
	public static uint4x2 op_Multiply(uint4x2 lhs, uint4x2 rhs) { }

	// RVA: 0x28F0100 Offset: 0x28EEB00 VA: 0x1828F0100
	public static uint4x2 op_Multiply(uint4x2 lhs, uint rhs) { }

	// RVA: 0x28F0190 Offset: 0x28EEB90 VA: 0x1828F0190
	public static uint4x2 op_Multiply(uint lhs, uint4x2 rhs) { }

	// RVA: 0x28EE400 Offset: 0x28ECE00 VA: 0x1828EE400
	public static uint4x2 op_Addition(uint4x2 lhs, uint4x2 rhs) { }

	// RVA: 0x28EE540 Offset: 0x28ECF40 VA: 0x1828EE540
	public static uint4x2 op_Addition(uint4x2 lhs, uint rhs) { }

	// RVA: 0x28EE4C0 Offset: 0x28ECEC0 VA: 0x1828EE4C0
	public static uint4x2 op_Addition(uint lhs, uint4x2 rhs) { }

	// RVA: 0x28F0500 Offset: 0x28EEF00 VA: 0x1828F0500
	public static uint4x2 op_Subtraction(uint4x2 lhs, uint4x2 rhs) { }

	// RVA: 0x28F03F0 Offset: 0x28EEDF0 VA: 0x1828F03F0
	public static uint4x2 op_Subtraction(uint4x2 lhs, uint rhs) { }

	// RVA: 0x28F0470 Offset: 0x28EEE70 VA: 0x1828F0470
	public static uint4x2 op_Subtraction(uint lhs, uint4x2 rhs) { }

	// RVA: 0x28EEA60 Offset: 0x28ED460 VA: 0x1828EEA60
	public static uint4x2 op_Division(uint4x2 lhs, uint4x2 rhs) { }

	// RVA: 0x28EE910 Offset: 0x28ED310 VA: 0x1828EE910
	public static uint4x2 op_Division(uint4x2 lhs, uint rhs) { }

	// RVA: 0x28EE9B0 Offset: 0x28ED3B0 VA: 0x1828EE9B0
	public static uint4x2 op_Division(uint lhs, uint4x2 rhs) { }

	// RVA: 0x28EFF80 Offset: 0x28EE980 VA: 0x1828EFF80
	public static uint4x2 op_Modulus(uint4x2 lhs, uint4x2 rhs) { }

	// RVA: 0x28EFEE0 Offset: 0x28EE8E0 VA: 0x1828EFEE0
	public static uint4x2 op_Modulus(uint4x2 lhs, uint rhs) { }

	// RVA: 0x28F0050 Offset: 0x28EEA50 VA: 0x1828F0050
	public static uint4x2 op_Modulus(uint lhs, uint4x2 rhs) { }

	// RVA: 0x28EF590 Offset: 0x28EDF90 VA: 0x1828EF590
	public static uint4x2 op_Increment(uint4x2 val) { }

	// RVA: 0x28EE890 Offset: 0x28ED290 VA: 0x1828EE890
	public static uint4x2 op_Decrement(uint4x2 val) { }

	// RVA: 0x28EFD00 Offset: 0x28EE700 VA: 0x1828EFD00
	public static bool4x2 op_LessThan(uint4x2 lhs, uint4x2 rhs) { }

	// RVA: 0x28EFE20 Offset: 0x28EE820 VA: 0x1828EFE20
	public static bool4x2 op_LessThan(uint4x2 lhs, uint rhs) { }

	// RVA: 0x28EFC20 Offset: 0x28EE620 VA: 0x1828EFC20
	public static bool4x2 op_LessThan(uint lhs, uint4x2 rhs) { }

	// RVA: 0x28EFB00 Offset: 0x28EE500 VA: 0x1828EFB00
	public static bool4x2 op_LessThanOrEqual(uint4x2 lhs, uint4x2 rhs) { }

	// RVA: 0x28EFA40 Offset: 0x28EE440 VA: 0x1828EFA40
	public static bool4x2 op_LessThanOrEqual(uint4x2 lhs, uint rhs) { }

	// RVA: 0x28EF960 Offset: 0x28EE360 VA: 0x1828EF960
	public static bool4x2 op_LessThanOrEqual(uint lhs, uint4x2 rhs) { }

	// RVA: 0x28EF3B0 Offset: 0x28EDDB0 VA: 0x1828EF3B0
	public static bool4x2 op_GreaterThan(uint4x2 lhs, uint4x2 rhs) { }

	// RVA: 0x28EF4D0 Offset: 0x28EDED0 VA: 0x1828EF4D0
	public static bool4x2 op_GreaterThan(uint4x2 lhs, uint rhs) { }

	// RVA: 0x28EF2D0 Offset: 0x28EDCD0 VA: 0x1828EF2D0
	public static bool4x2 op_GreaterThan(uint lhs, uint4x2 rhs) { }

	// RVA: 0x28EF010 Offset: 0x28EDA10 VA: 0x1828EF010
	public static bool4x2 op_GreaterThanOrEqual(uint4x2 lhs, uint4x2 rhs) { }

	// RVA: 0x28EF130 Offset: 0x28EDB30 VA: 0x1828EF130
	public static bool4x2 op_GreaterThanOrEqual(uint4x2 lhs, uint rhs) { }

	// RVA: 0x28EF1F0 Offset: 0x28EDBF0 VA: 0x1828EF1F0
	public static bool4x2 op_GreaterThanOrEqual(uint lhs, uint4x2 rhs) { }

	// RVA: 0x28F05C0 Offset: 0x28EEFC0 VA: 0x1828F05C0
	public static uint4x2 op_UnaryNegation(uint4x2 val) { }

	// RVA: 0x28F0640 Offset: 0x28EF040 VA: 0x1828F0640
	public static uint4x2 op_UnaryPlus(uint4x2 val) { }

	// RVA: 0x28EF8D0 Offset: 0x28EE2D0 VA: 0x1828EF8D0
	public static uint4x2 op_LeftShift(uint4x2 x, int n) { }

	// RVA: 0x28F0360 Offset: 0x28EED60 VA: 0x1828F0360
	public static uint4x2 op_RightShift(uint4x2 x, int n) { }

	// RVA: 0x28EECD0 Offset: 0x28ED6D0 VA: 0x1828EECD0
	public static bool4x2 op_Equality(uint4x2 lhs, uint4x2 rhs) { }

	// RVA: 0x28EEC10 Offset: 0x28ED610 VA: 0x1828EEC10
	public static bool4x2 op_Equality(uint4x2 lhs, uint rhs) { }

	// RVA: 0x28EEB30 Offset: 0x28ED530 VA: 0x1828EEB30
	public static bool4x2 op_Equality(uint lhs, uint4x2 rhs) { }

	// RVA: 0x28EF6F0 Offset: 0x28EE0F0 VA: 0x1828EF6F0
	public static bool4x2 op_Inequality(uint4x2 lhs, uint4x2 rhs) { }

	// RVA: 0x28EF810 Offset: 0x28EE210 VA: 0x1828EF810
	public static bool4x2 op_Inequality(uint4x2 lhs, uint rhs) { }

	// RVA: 0x28EF610 Offset: 0x28EE010 VA: 0x1828EF610
	public static bool4x2 op_Inequality(uint lhs, uint4x2 rhs) { }

	// RVA: 0x28F02E0 Offset: 0x28EECE0 VA: 0x1828F02E0
	public static uint4x2 op_OnesComplement(uint4x2 val) { }

	// RVA: 0x28EE6D0 Offset: 0x28ED0D0 VA: 0x1828EE6D0
	public static uint4x2 op_BitwiseAnd(uint4x2 lhs, uint4x2 rhs) { }

	// RVA: 0x28EE5D0 Offset: 0x28ECFD0 VA: 0x1828EE5D0
	public static uint4x2 op_BitwiseAnd(uint4x2 lhs, uint rhs) { }

	// RVA: 0x28EE650 Offset: 0x28ED050 VA: 0x1828EE650
	public static uint4x2 op_BitwiseAnd(uint lhs, uint4x2 rhs) { }

	// RVA: 0x270BB30 Offset: 0x270A530 VA: 0x18270BB30
	public static uint4x2 op_BitwiseOr(uint4x2 lhs, uint4x2 rhs) { }

	// RVA: 0x28EE810 Offset: 0x28ED210 VA: 0x1828EE810
	public static uint4x2 op_BitwiseOr(uint4x2 lhs, uint rhs) { }

	// RVA: 0x28EE790 Offset: 0x28ED190 VA: 0x1828EE790
	public static uint4x2 op_BitwiseOr(uint lhs, uint4x2 rhs) { }

	// RVA: 0x270D1E0 Offset: 0x270BBE0 VA: 0x18270D1E0
	public static uint4x2 op_ExclusiveOr(uint4x2 lhs, uint4x2 rhs) { }

	// RVA: 0x28EEE70 Offset: 0x28ED870 VA: 0x1828EEE70
	public static uint4x2 op_ExclusiveOr(uint4x2 lhs, uint rhs) { }

	// RVA: 0x28EEDF0 Offset: 0x28ED7F0 VA: 0x1828EEDF0
	public static uint4x2 op_ExclusiveOr(uint lhs, uint4x2 rhs) { }

	// RVA: 0xF6D000 Offset: 0xF6BA00 VA: 0x180F6D000
	public ref uint4 get_Item(int index) { }

	// RVA: 0x28EDA30 Offset: 0x28EC430 VA: 0x1828EDA30 Slot: 4
	public bool Equals(uint4x2 rhs) { }

	// RVA: 0x28ED940 Offset: 0x28EC340 VA: 0x1828ED940 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x28EDAA0 Offset: 0x28EC4A0 VA: 0x1828EDAA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x28EDB40 Offset: 0x28EC540 VA: 0x1828EDB40 Slot: 3
	public override string ToString() { }

	// RVA: 0x28EDEE0 Offset: 0x28EC8E0 VA: 0x1828EDEE0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
