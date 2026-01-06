public struct int4x3 : IEquatable<int4x3>, IFormattable // TypeDefIndex: 10934
{
	// Fields
	public int4 c0; // 0x0
	public int4 c1; // 0x10
	public int4 c2; // 0x20
	public static readonly int4x3 zero; // 0x0

	// Properties
	public int4 Item { get; }

	// Methods

	// RVA: 0x133AD50 Offset: 0x1339750 VA: 0x18133AD50
	public void .ctor(int4 c0, int4 c1, int4 c2) { }

	// RVA: 0x28F12B0 Offset: 0x28EFCB0 VA: 0x1828F12B0
	public void .ctor(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22, int m30, int m31, int m32) { }

	// RVA: 0x28F1330 Offset: 0x28EFD30 VA: 0x1828F1330
	public void .ctor(int v) { }

	// RVA: 0x296C8F0 Offset: 0x296B2F0 VA: 0x18296C8F0
	public void .ctor(bool v) { }

	// RVA: 0x2884900 Offset: 0x2883300 VA: 0x182884900
	public void .ctor(bool4x3 v) { }

	// RVA: 0x28F1330 Offset: 0x28EFD30 VA: 0x1828F1330
	public void .ctor(uint v) { }

	// RVA: 0x28F1380 Offset: 0x28EFD80 VA: 0x1828F1380
	public void .ctor(uint4x3 v) { }

	// RVA: 0x296C9B0 Offset: 0x296B3B0 VA: 0x18296C9B0
	public void .ctor(float v) { }

	// RVA: 0x296C9E0 Offset: 0x296B3E0 VA: 0x18296C9E0
	public void .ctor(float4x3 v) { }

	// RVA: 0x296C930 Offset: 0x296B330 VA: 0x18296C930
	public void .ctor(double v) { }

	// RVA: 0x296CAA0 Offset: 0x296B4A0 VA: 0x18296CAA0
	public void .ctor(double4x3 v) { }

	// RVA: 0x28A96E0 Offset: 0x28A80E0 VA: 0x1828A96E0
	public static int4x3 op_Implicit(int v) { }

	// RVA: 0x28A9A30 Offset: 0x28A8430 VA: 0x1828A9A30
	public static int4x3 op_Explicit(bool v) { }

	// RVA: 0x28A9810 Offset: 0x28A8210 VA: 0x1828A9810
	public static int4x3 op_Explicit(bool4x3 v) { }

	// RVA: 0x28A96E0 Offset: 0x28A80E0 VA: 0x1828A96E0
	public static int4x3 op_Explicit(uint v) { }

	// RVA: 0x28A99B0 Offset: 0x28A83B0 VA: 0x1828A99B0
	public static int4x3 op_Explicit(uint4x3 v) { }

	// RVA: 0x28A97E0 Offset: 0x28A81E0 VA: 0x1828A97E0
	public static int4x3 op_Explicit(float v) { }

	// RVA: 0x28A9A70 Offset: 0x28A8470 VA: 0x1828A9A70
	public static int4x3 op_Explicit(float4x3 v) { }

	// RVA: 0x28A9660 Offset: 0x28A8060 VA: 0x1828A9660
	public static int4x3 op_Explicit(double v) { }

	// RVA: 0x28A9730 Offset: 0x28A8130 VA: 0x1828A9730
	public static int4x3 op_Explicit(double4x3 v) { }

	// RVA: 0x28F3AA0 Offset: 0x28F24A0 VA: 0x1828F3AA0
	public static int4x3 op_Multiply(int4x3 lhs, int4x3 rhs) { }

	// RVA: 0x28F38E0 Offset: 0x28F22E0 VA: 0x1828F38E0
	public static int4x3 op_Multiply(int4x3 lhs, int rhs) { }

	// RVA: 0x28F39C0 Offset: 0x28F23C0 VA: 0x1828F39C0
	public static int4x3 op_Multiply(int lhs, int4x3 rhs) { }

	// RVA: 0x28F15E0 Offset: 0x28EFFE0 VA: 0x1828F15E0
	public static int4x3 op_Addition(int4x3 lhs, int4x3 rhs) { }

	// RVA: 0x28F1430 Offset: 0x28EFE30 VA: 0x1828F1430
	public static int4x3 op_Addition(int4x3 lhs, int rhs) { }

	// RVA: 0x28F1510 Offset: 0x28EFF10 VA: 0x1828F1510
	public static int4x3 op_Addition(int lhs, int4x3 rhs) { }

	// RVA: 0x28F3EA0 Offset: 0x28F28A0 VA: 0x1828F3EA0
	public static int4x3 op_Subtraction(int4x3 lhs, int4x3 rhs) { }

	// RVA: 0x28F4000 Offset: 0x28F2A00 VA: 0x1828F4000
	public static int4x3 op_Subtraction(int4x3 lhs, int rhs) { }

	// RVA: 0x28F3DB0 Offset: 0x28F27B0 VA: 0x1828F3DB0
	public static int4x3 op_Subtraction(int lhs, int4x3 rhs) { }

	// RVA: 0x296CD30 Offset: 0x296B730 VA: 0x18296CD30
	public static int4x3 op_Division(int4x3 lhs, int4x3 rhs) { }

	// RVA: 0x296CB50 Offset: 0x296B550 VA: 0x18296CB50
	public static int4x3 op_Division(int4x3 lhs, int rhs) { }

	// RVA: 0x296CC30 Offset: 0x296B630 VA: 0x18296CC30
	public static int4x3 op_Division(int lhs, int4x3 rhs) { }

	// RVA: 0x296D970 Offset: 0x296C370 VA: 0x18296D970
	public static int4x3 op_Modulus(int4x3 lhs, int4x3 rhs) { }

	// RVA: 0x296DAF0 Offset: 0x296C4F0 VA: 0x18296DAF0
	public static int4x3 op_Modulus(int4x3 lhs, int rhs) { }

	// RVA: 0x296D870 Offset: 0x296C270 VA: 0x18296D870
	public static int4x3 op_Modulus(int lhs, int4x3 rhs) { }

	// RVA: 0x28F2C70 Offset: 0x28F1670 VA: 0x1828F2C70
	public static int4x3 op_Increment(int4x3 val) { }

	// RVA: 0x28F1D40 Offset: 0x28F0740 VA: 0x1828F1D40
	public static int4x3 op_Decrement(int4x3 val) { }

	// RVA: 0x296D6B0 Offset: 0x296C0B0 VA: 0x18296D6B0
	public static bool4x3 op_LessThan(int4x3 lhs, int4x3 rhs) { }

	// RVA: 0x296D600 Offset: 0x296C000 VA: 0x18296D600
	public static bool4x3 op_LessThan(int4x3 lhs, int rhs) { }

	// RVA: 0x296D7C0 Offset: 0x296C1C0 VA: 0x18296D7C0
	public static bool4x3 op_LessThan(int lhs, int4x3 rhs) { }

	// RVA: 0x296D390 Offset: 0x296BD90 VA: 0x18296D390
	public static bool4x3 op_LessThanOrEqual(int4x3 lhs, int4x3 rhs) { }

	// RVA: 0x296D550 Offset: 0x296BF50 VA: 0x18296D550
	public static bool4x3 op_LessThanOrEqual(int4x3 lhs, int rhs) { }

	// RVA: 0x296D4A0 Offset: 0x296BEA0 VA: 0x18296D4A0
	public static bool4x3 op_LessThanOrEqual(int lhs, int4x3 rhs) { }

	// RVA: 0x296D280 Offset: 0x296BC80 VA: 0x18296D280
	public static bool4x3 op_GreaterThan(int4x3 lhs, int4x3 rhs) { }

	// RVA: 0x296D1D0 Offset: 0x296BBD0 VA: 0x18296D1D0
	public static bool4x3 op_GreaterThan(int4x3 lhs, int rhs) { }

	// RVA: 0x296D120 Offset: 0x296BB20 VA: 0x18296D120
	public static bool4x3 op_GreaterThan(int lhs, int4x3 rhs) { }

	// RVA: 0x296CEB0 Offset: 0x296B8B0 VA: 0x18296CEB0
	public static bool4x3 op_GreaterThanOrEqual(int4x3 lhs, int4x3 rhs) { }

	// RVA: 0x296D070 Offset: 0x296BA70 VA: 0x18296D070
	public static bool4x3 op_GreaterThanOrEqual(int4x3 lhs, int rhs) { }

	// RVA: 0x296CFC0 Offset: 0x296B9C0 VA: 0x18296CFC0
	public static bool4x3 op_GreaterThanOrEqual(int lhs, int4x3 rhs) { }

	// RVA: 0x28F40D0 Offset: 0x28F2AD0 VA: 0x1828F40D0
	public static int4x3 op_UnaryNegation(int4x3 val) { }

	// RVA: 0x28F4190 Offset: 0x28F2B90 VA: 0x1828F4190
	public static int4x3 op_UnaryPlus(int4x3 val) { }

	// RVA: 0x28F2FC0 Offset: 0x28F19C0 VA: 0x1828F2FC0
	public static int4x3 op_LeftShift(int4x3 x, int n) { }

	// RVA: 0x296DBD0 Offset: 0x296C5D0 VA: 0x18296DBD0
	public static int4x3 op_RightShift(int4x3 x, int n) { }

	// RVA: 0x28F2240 Offset: 0x28F0C40 VA: 0x1828F2240
	public static bool4x3 op_Equality(int4x3 lhs, int4x3 rhs) { }

	// RVA: 0x28F2350 Offset: 0x28F0D50 VA: 0x1828F2350
	public static bool4x3 op_Equality(int4x3 lhs, int rhs) { }

	// RVA: 0x28F2190 Offset: 0x28F0B90 VA: 0x1828F2190
	public static bool4x3 op_Equality(int lhs, int4x3 rhs) { }

	// RVA: 0x28F2E00 Offset: 0x28F1800 VA: 0x1828F2E00
	public static bool4x3 op_Inequality(int4x3 lhs, int4x3 rhs) { }

	// RVA: 0x28F2D50 Offset: 0x28F1750 VA: 0x1828F2D50
	public static bool4x3 op_Inequality(int4x3 lhs, int rhs) { }

	// RVA: 0x28F2F10 Offset: 0x28F1910 VA: 0x1828F2F10
	public static bool4x3 op_Inequality(int lhs, int4x3 rhs) { }

	// RVA: 0x28F3C10 Offset: 0x28F2610 VA: 0x1828F3C10
	public static int4x3 op_OnesComplement(int4x3 val) { }

	// RVA: 0x28F1810 Offset: 0x28F0210 VA: 0x1828F1810
	public static int4x3 op_BitwiseAnd(int4x3 lhs, int4x3 rhs) { }

	// RVA: 0x28F1740 Offset: 0x28F0140 VA: 0x1828F1740
	public static int4x3 op_BitwiseAnd(int4x3 lhs, int rhs) { }

	// RVA: 0x28F1970 Offset: 0x28F0370 VA: 0x1828F1970
	public static int4x3 op_BitwiseAnd(int lhs, int4x3 rhs) { }

	// RVA: 0x28F1B10 Offset: 0x28F0510 VA: 0x1828F1B10
	public static int4x3 op_BitwiseOr(int4x3 lhs, int4x3 rhs) { }

	// RVA: 0x28F1A40 Offset: 0x28F0440 VA: 0x1828F1A40
	public static int4x3 op_BitwiseOr(int4x3 lhs, int rhs) { }

	// RVA: 0x28F1C70 Offset: 0x28F0670 VA: 0x1828F1C70
	public static int4x3 op_BitwiseOr(int lhs, int4x3 rhs) { }

	// RVA: 0x28F24D0 Offset: 0x28F0ED0 VA: 0x1828F24D0
	public static int4x3 op_ExclusiveOr(int4x3 lhs, int4x3 rhs) { }

	// RVA: 0x28F2400 Offset: 0x28F0E00 VA: 0x1828F2400
	public static int4x3 op_ExclusiveOr(int4x3 lhs, int rhs) { }

	// RVA: 0x28F2630 Offset: 0x28F1030 VA: 0x1828F2630
	public static int4x3 op_ExclusiveOr(int lhs, int4x3 rhs) { }

	// RVA: 0xF6D000 Offset: 0xF6BA00 VA: 0x180F6D000
	public ref int4 get_Item(int index) { }

	// RVA: 0x28F06C0 Offset: 0x28EF0C0 VA: 0x1828F06C0 Slot: 4
	public bool Equals(int4x3 rhs) { }

	// RVA: 0x296BDA0 Offset: 0x296A7A0 VA: 0x18296BDA0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x296BEC0 Offset: 0x296A8C0 VA: 0x18296BEC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x296C3E0 Offset: 0x296ADE0 VA: 0x18296C3E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x296BEF0 Offset: 0x296A8F0 VA: 0x18296BEF0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
