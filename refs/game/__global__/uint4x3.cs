public struct uint4x3 : IEquatable<uint4x3>, IFormattable // TypeDefIndex: 10955
{
	// Fields
	public uint4 c0; // 0x0
	public uint4 c1; // 0x10
	public uint4 c2; // 0x20
	public static readonly uint4x3 zero; // 0x0

	// Properties
	public uint4 Item { get; }

	// Methods

	// RVA: 0x133AD50 Offset: 0x1339750 VA: 0x18133AD50
	public void .ctor(uint4 c0, uint4 c1, uint4 c2) { }

	// RVA: 0x28F12B0 Offset: 0x28EFCB0 VA: 0x1828F12B0
	public void .ctor(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22, uint m30, uint m31, uint m32) { }

	// RVA: 0x28F1330 Offset: 0x28EFD30 VA: 0x1828F1330
	public void .ctor(uint v) { }

	// RVA: 0x28892A0 Offset: 0x2887CA0 VA: 0x1828892A0
	public void .ctor(bool v) { }

	// RVA: 0x2884900 Offset: 0x2883300 VA: 0x182884900
	public void .ctor(bool4x3 v) { }

	// RVA: 0x28F1330 Offset: 0x28EFD30 VA: 0x1828F1330
	public void .ctor(int v) { }

	// RVA: 0x28F1380 Offset: 0x28EFD80 VA: 0x1828F1380
	public void .ctor(int4x3 v) { }

	// RVA: 0x2889040 Offset: 0x2887A40 VA: 0x182889040
	public void .ctor(float v) { }

	// RVA: 0x2888DE0 Offset: 0x28877E0 VA: 0x182888DE0
	public void .ctor(float4x3 v) { }

	// RVA: 0x2888F40 Offset: 0x2887940 VA: 0x182888F40
	public void .ctor(double v) { }

	// RVA: 0x2889140 Offset: 0x2887B40 VA: 0x182889140
	public void .ctor(double4x3 v) { }

	// RVA: 0x28A96E0 Offset: 0x28A80E0 VA: 0x1828A96E0
	public static uint4x3 op_Implicit(uint v) { }

	// RVA: 0x28F2730 Offset: 0x28F1130 VA: 0x1828F2730
	public static uint4x3 op_Explicit(bool v) { }

	// RVA: 0x28A9810 Offset: 0x28A8210 VA: 0x1828A9810
	public static uint4x3 op_Explicit(bool4x3 v) { }

	// RVA: 0x28A96E0 Offset: 0x28A80E0 VA: 0x1828A96E0
	public static uint4x3 op_Explicit(int v) { }

	// RVA: 0x28A99B0 Offset: 0x28A83B0 VA: 0x1828A99B0
	public static uint4x3 op_Explicit(int4x3 v) { }

	// RVA: 0x28F2700 Offset: 0x28F1100 VA: 0x1828F2700
	public static uint4x3 op_Explicit(float v) { }

	// RVA: 0x28D4270 Offset: 0x28D2C70 VA: 0x1828D4270
	public static uint4x3 op_Explicit(float4x3 v) { }

	// RVA: 0x28F2760 Offset: 0x28F1160 VA: 0x1828F2760
	public static uint4x3 op_Explicit(double v) { }

	// RVA: 0x28D42C0 Offset: 0x28D2CC0 VA: 0x1828D42C0
	public static uint4x3 op_Explicit(double4x3 v) { }

	// RVA: 0x28F3AA0 Offset: 0x28F24A0 VA: 0x1828F3AA0
	public static uint4x3 op_Multiply(uint4x3 lhs, uint4x3 rhs) { }

	// RVA: 0x28F38E0 Offset: 0x28F22E0 VA: 0x1828F38E0
	public static uint4x3 op_Multiply(uint4x3 lhs, uint rhs) { }

	// RVA: 0x28F39C0 Offset: 0x28F23C0 VA: 0x1828F39C0
	public static uint4x3 op_Multiply(uint lhs, uint4x3 rhs) { }

	// RVA: 0x28F15E0 Offset: 0x28EFFE0 VA: 0x1828F15E0
	public static uint4x3 op_Addition(uint4x3 lhs, uint4x3 rhs) { }

	// RVA: 0x28F1430 Offset: 0x28EFE30 VA: 0x1828F1430
	public static uint4x3 op_Addition(uint4x3 lhs, uint rhs) { }

	// RVA: 0x28F1510 Offset: 0x28EFF10 VA: 0x1828F1510
	public static uint4x3 op_Addition(uint lhs, uint4x3 rhs) { }

	// RVA: 0x28F3EA0 Offset: 0x28F28A0 VA: 0x1828F3EA0
	public static uint4x3 op_Subtraction(uint4x3 lhs, uint4x3 rhs) { }

	// RVA: 0x28F4000 Offset: 0x28F2A00 VA: 0x1828F4000
	public static uint4x3 op_Subtraction(uint4x3 lhs, uint rhs) { }

	// RVA: 0x28F3DB0 Offset: 0x28F27B0 VA: 0x1828F3DB0
	public static uint4x3 op_Subtraction(uint lhs, uint4x3 rhs) { }

	// RVA: 0x28F1E20 Offset: 0x28F0820 VA: 0x1828F1E20
	public static uint4x3 op_Division(uint4x3 lhs, uint4x3 rhs) { }

	// RVA: 0x28F20A0 Offset: 0x28F0AA0 VA: 0x1828F20A0
	public static uint4x3 op_Division(uint4x3 lhs, uint rhs) { }

	// RVA: 0x28F1FA0 Offset: 0x28F09A0 VA: 0x1828F1FA0
	public static uint4x3 op_Division(uint lhs, uint4x3 rhs) { }

	// RVA: 0x28F3760 Offset: 0x28F2160 VA: 0x1828F3760
	public static uint4x3 op_Modulus(uint4x3 lhs, uint4x3 rhs) { }

	// RVA: 0x28F3670 Offset: 0x28F2070 VA: 0x1828F3670
	public static uint4x3 op_Modulus(uint4x3 lhs, uint rhs) { }

	// RVA: 0x28F3570 Offset: 0x28F1F70 VA: 0x1828F3570
	public static uint4x3 op_Modulus(uint lhs, uint4x3 rhs) { }

	// RVA: 0x28F2C70 Offset: 0x28F1670 VA: 0x1828F2C70
	public static uint4x3 op_Increment(uint4x3 val) { }

	// RVA: 0x28F1D40 Offset: 0x28F0740 VA: 0x1828F1D40
	public static uint4x3 op_Decrement(uint4x3 val) { }

	// RVA: 0x28F3300 Offset: 0x28F1D00 VA: 0x1828F3300
	public static bool4x3 op_LessThan(uint4x3 lhs, uint4x3 rhs) { }

	// RVA: 0x28F34C0 Offset: 0x28F1EC0 VA: 0x1828F34C0
	public static bool4x3 op_LessThan(uint4x3 lhs, uint rhs) { }

	// RVA: 0x28F3410 Offset: 0x28F1E10 VA: 0x1828F3410
	public static bool4x3 op_LessThan(uint lhs, uint4x3 rhs) { }

	// RVA: 0x28F31F0 Offset: 0x28F1BF0 VA: 0x1828F31F0
	public static bool4x3 op_LessThanOrEqual(uint4x3 lhs, uint4x3 rhs) { }

	// RVA: 0x28F3140 Offset: 0x28F1B40 VA: 0x1828F3140
	public static bool4x3 op_LessThanOrEqual(uint4x3 lhs, uint rhs) { }

	// RVA: 0x28F3090 Offset: 0x28F1A90 VA: 0x1828F3090
	public static bool4x3 op_LessThanOrEqual(uint lhs, uint4x3 rhs) { }

	// RVA: 0x28F2AB0 Offset: 0x28F14B0 VA: 0x1828F2AB0
	public static bool4x3 op_GreaterThan(uint4x3 lhs, uint4x3 rhs) { }

	// RVA: 0x28F2BC0 Offset: 0x28F15C0 VA: 0x1828F2BC0
	public static bool4x3 op_GreaterThan(uint4x3 lhs, uint rhs) { }

	// RVA: 0x28F2A00 Offset: 0x28F1400 VA: 0x1828F2A00
	public static bool4x3 op_GreaterThan(uint lhs, uint4x3 rhs) { }

	// RVA: 0x28F2790 Offset: 0x28F1190 VA: 0x1828F2790
	public static bool4x3 op_GreaterThanOrEqual(uint4x3 lhs, uint4x3 rhs) { }

	// RVA: 0x28F2950 Offset: 0x28F1350 VA: 0x1828F2950
	public static bool4x3 op_GreaterThanOrEqual(uint4x3 lhs, uint rhs) { }

	// RVA: 0x28F28A0 Offset: 0x28F12A0 VA: 0x1828F28A0
	public static bool4x3 op_GreaterThanOrEqual(uint lhs, uint4x3 rhs) { }

	// RVA: 0x28F40D0 Offset: 0x28F2AD0 VA: 0x1828F40D0
	public static uint4x3 op_UnaryNegation(uint4x3 val) { }

	// RVA: 0x28F4190 Offset: 0x28F2B90 VA: 0x1828F4190
	public static uint4x3 op_UnaryPlus(uint4x3 val) { }

	// RVA: 0x28F2FC0 Offset: 0x28F19C0 VA: 0x1828F2FC0
	public static uint4x3 op_LeftShift(uint4x3 x, int n) { }

	// RVA: 0x28F3CD0 Offset: 0x28F26D0 VA: 0x1828F3CD0
	public static uint4x3 op_RightShift(uint4x3 x, int n) { }

	// RVA: 0x28F2240 Offset: 0x28F0C40 VA: 0x1828F2240
	public static bool4x3 op_Equality(uint4x3 lhs, uint4x3 rhs) { }

	// RVA: 0x28F2350 Offset: 0x28F0D50 VA: 0x1828F2350
	public static bool4x3 op_Equality(uint4x3 lhs, uint rhs) { }

	// RVA: 0x28F2190 Offset: 0x28F0B90 VA: 0x1828F2190
	public static bool4x3 op_Equality(uint lhs, uint4x3 rhs) { }

	// RVA: 0x28F2E00 Offset: 0x28F1800 VA: 0x1828F2E00
	public static bool4x3 op_Inequality(uint4x3 lhs, uint4x3 rhs) { }

	// RVA: 0x28F2D50 Offset: 0x28F1750 VA: 0x1828F2D50
	public static bool4x3 op_Inequality(uint4x3 lhs, uint rhs) { }

	// RVA: 0x28F2F10 Offset: 0x28F1910 VA: 0x1828F2F10
	public static bool4x3 op_Inequality(uint lhs, uint4x3 rhs) { }

	// RVA: 0x28F3C10 Offset: 0x28F2610 VA: 0x1828F3C10
	public static uint4x3 op_OnesComplement(uint4x3 val) { }

	// RVA: 0x28F1810 Offset: 0x28F0210 VA: 0x1828F1810
	public static uint4x3 op_BitwiseAnd(uint4x3 lhs, uint4x3 rhs) { }

	// RVA: 0x28F1740 Offset: 0x28F0140 VA: 0x1828F1740
	public static uint4x3 op_BitwiseAnd(uint4x3 lhs, uint rhs) { }

	// RVA: 0x28F1970 Offset: 0x28F0370 VA: 0x1828F1970
	public static uint4x3 op_BitwiseAnd(uint lhs, uint4x3 rhs) { }

	// RVA: 0x28F1B10 Offset: 0x28F0510 VA: 0x1828F1B10
	public static uint4x3 op_BitwiseOr(uint4x3 lhs, uint4x3 rhs) { }

	// RVA: 0x28F1A40 Offset: 0x28F0440 VA: 0x1828F1A40
	public static uint4x3 op_BitwiseOr(uint4x3 lhs, uint rhs) { }

	// RVA: 0x28F1C70 Offset: 0x28F0670 VA: 0x1828F1C70
	public static uint4x3 op_BitwiseOr(uint lhs, uint4x3 rhs) { }

	// RVA: 0x28F24D0 Offset: 0x28F0ED0 VA: 0x1828F24D0
	public static uint4x3 op_ExclusiveOr(uint4x3 lhs, uint4x3 rhs) { }

	// RVA: 0x28F2400 Offset: 0x28F0E00 VA: 0x1828F2400
	public static uint4x3 op_ExclusiveOr(uint4x3 lhs, uint rhs) { }

	// RVA: 0x28F2630 Offset: 0x28F1030 VA: 0x1828F2630
	public static uint4x3 op_ExclusiveOr(uint lhs, uint4x3 rhs) { }

	// RVA: 0xF6D000 Offset: 0xF6BA00 VA: 0x180F6D000
	public ref uint4 get_Item(int index) { }

	// RVA: 0x28F06C0 Offset: 0x28EF0C0 VA: 0x1828F06C0 Slot: 4
	public bool Equals(uint4x3 rhs) { }

	// RVA: 0x28F0760 Offset: 0x28EF160 VA: 0x1828F0760 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x28F0880 Offset: 0x28EF280 VA: 0x1828F0880 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x28F08B0 Offset: 0x28EF2B0 VA: 0x1828F08B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x28F0DC0 Offset: 0x28EF7C0 VA: 0x1828F0DC0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
