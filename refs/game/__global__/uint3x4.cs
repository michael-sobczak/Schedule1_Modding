public struct uint3x4 : IEquatable<uint3x4>, IFormattable // TypeDefIndex: 10951
{
	// Fields
	public uint3 c0; // 0x0
	public uint3 c1; // 0xC
	public uint3 c2; // 0x18
	public uint3 c3; // 0x24
	public static readonly uint3x4 zero; // 0x0

	// Properties
	public uint3 Item { get; }

	// Methods

	// RVA: 0x28E5460 Offset: 0x28E3E60 VA: 0x1828E5460
	public void .ctor(uint3 c0, uint3 c1, uint3 c2, uint3 c3) { }

	// RVA: 0x28E52F0 Offset: 0x28E3CF0 VA: 0x1828E52F0
	public void .ctor(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23) { }

	// RVA: 0x28E5290 Offset: 0x28E3C90 VA: 0x1828E5290
	public void .ctor(uint v) { }

	// RVA: 0x2884730 Offset: 0x2883130 VA: 0x182884730
	public void .ctor(bool v) { }

	// RVA: 0x28847F0 Offset: 0x28831F0 VA: 0x1828847F0
	public void .ctor(bool3x4 v) { }

	// RVA: 0x28E5290 Offset: 0x28E3C90 VA: 0x1828E5290
	public void .ctor(int v) { }

	// RVA: 0x28E5380 Offset: 0x28E3D80 VA: 0x1828E5380
	public void .ctor(int3x4 v) { }

	// RVA: 0x2888630 Offset: 0x2887030 VA: 0x182888630
	public void .ctor(float v) { }

	// RVA: 0x2888850 Offset: 0x2887250 VA: 0x182888850
	public void .ctor(float3x4 v) { }

	// RVA: 0x2888740 Offset: 0x2887140 VA: 0x182888740
	public void .ctor(double v) { }

	// RVA: 0x2888490 Offset: 0x2886E90 VA: 0x182888490
	public void .ctor(double3x4 v) { }

	// RVA: 0x28A8D10 Offset: 0x28A7710 VA: 0x1828A8D10
	public static uint3x4 op_Implicit(uint v) { }

	// RVA: 0x28E6FF0 Offset: 0x28E59F0 VA: 0x1828E6FF0
	public static uint3x4 op_Explicit(bool v) { }

	// RVA: 0x28E6FB0 Offset: 0x28E59B0 VA: 0x1828E6FB0
	public static uint3x4 op_Explicit(bool3x4 v) { }

	// RVA: 0x28A8D10 Offset: 0x28A7710 VA: 0x1828A8D10
	public static uint3x4 op_Explicit(int v) { }

	// RVA: 0x28A8FF0 Offset: 0x28A79F0 VA: 0x1828A8FF0
	public static uint3x4 op_Explicit(int3x4 v) { }

	// RVA: 0x28E7020 Offset: 0x28E5A20 VA: 0x1828E7020
	public static uint3x4 op_Explicit(float v) { }

	// RVA: 0x28D3B90 Offset: 0x28D2590 VA: 0x1828D3B90
	public static uint3x4 op_Explicit(float3x4 v) { }

	// RVA: 0x28E6F80 Offset: 0x28E5980 VA: 0x1828E6F80
	public static uint3x4 op_Explicit(double v) { }

	// RVA: 0x28D3B20 Offset: 0x28D2520 VA: 0x1828D3B20
	public static uint3x4 op_Explicit(double3x4 v) { }

	// RVA: 0x28E8DE0 Offset: 0x28E77E0 VA: 0x1828E8DE0
	public static uint3x4 op_Multiply(uint3x4 lhs, uint3x4 rhs) { }

	// RVA: 0x28E8FE0 Offset: 0x28E79E0 VA: 0x1828E8FE0
	public static uint3x4 op_Multiply(uint3x4 lhs, uint rhs) { }

	// RVA: 0x28E8CA0 Offset: 0x28E76A0 VA: 0x1828E8CA0
	public static uint3x4 op_Multiply(uint lhs, uint3x4 rhs) { }

	// RVA: 0x28E54B0 Offset: 0x28E3EB0 VA: 0x1828E54B0
	public static uint3x4 op_Addition(uint3x4 lhs, uint3x4 rhs) { }

	// RVA: 0x28E56B0 Offset: 0x28E40B0 VA: 0x1828E56B0
	public static uint3x4 op_Addition(uint3x4 lhs, uint rhs) { }

	// RVA: 0x28E57D0 Offset: 0x28E41D0 VA: 0x1828E57D0
	public static uint3x4 op_Addition(uint lhs, uint3x4 rhs) { }

	// RVA: 0x28E95A0 Offset: 0x28E7FA0 VA: 0x1828E95A0
	public static uint3x4 op_Subtraction(uint3x4 lhs, uint3x4 rhs) { }

	// RVA: 0x28E9350 Offset: 0x28E7D50 VA: 0x1828E9350
	public static uint3x4 op_Subtraction(uint3x4 lhs, uint rhs) { }

	// RVA: 0x28E9470 Offset: 0x28E7E70 VA: 0x1828E9470
	public static uint3x4 op_Subtraction(uint lhs, uint3x4 rhs) { }

	// RVA: 0x28E6510 Offset: 0x28E4F10 VA: 0x1828E6510
	public static uint3x4 op_Division(uint3x4 lhs, uint3x4 rhs) { }

	// RVA: 0x28E63C0 Offset: 0x28E4DC0 VA: 0x1828E63C0
	public static uint3x4 op_Division(uint3x4 lhs, uint rhs) { }

	// RVA: 0x28E6270 Offset: 0x28E4C70 VA: 0x1828E6270
	public static uint3x4 op_Division(uint lhs, uint3x4 rhs) { }

	// RVA: 0x28E87F0 Offset: 0x28E71F0 VA: 0x1828E87F0
	public static uint3x4 op_Modulus(uint3x4 lhs, uint3x4 rhs) { }

	// RVA: 0x28E8A00 Offset: 0x28E7400 VA: 0x1828E8A00
	public static uint3x4 op_Modulus(uint3x4 lhs, uint rhs) { }

	// RVA: 0x28E8B50 Offset: 0x28E7550 VA: 0x1828E8B50
	public static uint3x4 op_Modulus(uint lhs, uint3x4 rhs) { }

	// RVA: 0x28E78D0 Offset: 0x28E62D0 VA: 0x1828E78D0
	public static uint3x4 op_Increment(uint3x4 val) { }

	// RVA: 0x28E6130 Offset: 0x28E4B30 VA: 0x1828E6130
	public static uint3x4 op_Decrement(uint3x4 val) { }

	// RVA: 0x28E85F0 Offset: 0x28E6FF0 VA: 0x1828E85F0
	public static bool3x4 op_LessThan(uint3x4 lhs, uint3x4 rhs) { }

	// RVA: 0x28E83B0 Offset: 0x28E6DB0 VA: 0x1828E83B0
	public static bool3x4 op_LessThan(uint3x4 lhs, uint rhs) { }

	// RVA: 0x28E84D0 Offset: 0x28E6ED0 VA: 0x1828E84D0
	public static bool3x4 op_LessThan(uint lhs, uint3x4 rhs) { }

	// RVA: 0x28E7F70 Offset: 0x28E6970 VA: 0x1828E7F70
	public static bool3x4 op_LessThanOrEqual(uint3x4 lhs, uint3x4 rhs) { }

	// RVA: 0x28E8170 Offset: 0x28E6B70 VA: 0x1828E8170
	public static bool3x4 op_LessThanOrEqual(uint3x4 lhs, uint rhs) { }

	// RVA: 0x28E8290 Offset: 0x28E6C90 VA: 0x1828E8290
	public static bool3x4 op_LessThanOrEqual(uint lhs, uint3x4 rhs) { }

	// RVA: 0x28E7490 Offset: 0x28E5E90 VA: 0x1828E7490
	public static bool3x4 op_GreaterThan(uint3x4 lhs, uint3x4 rhs) { }

	// RVA: 0x28E7690 Offset: 0x28E6090 VA: 0x1828E7690
	public static bool3x4 op_GreaterThan(uint3x4 lhs, uint rhs) { }

	// RVA: 0x28E77B0 Offset: 0x28E61B0 VA: 0x1828E77B0
	public static bool3x4 op_GreaterThan(uint lhs, uint3x4 rhs) { }

	// RVA: 0x28E7170 Offset: 0x28E5B70 VA: 0x1828E7170
	public static bool3x4 op_GreaterThanOrEqual(uint3x4 lhs, uint3x4 rhs) { }

	// RVA: 0x28E7050 Offset: 0x28E5A50 VA: 0x1828E7050
	public static bool3x4 op_GreaterThanOrEqual(uint3x4 lhs, uint rhs) { }

	// RVA: 0x28E7370 Offset: 0x28E5D70 VA: 0x1828E7370
	public static bool3x4 op_GreaterThanOrEqual(uint lhs, uint3x4 rhs) { }

	// RVA: 0x28E9780 Offset: 0x28E8180 VA: 0x1828E9780
	public static uint3x4 op_UnaryNegation(uint3x4 val) { }

	// RVA: 0x28E98A0 Offset: 0x28E82A0 VA: 0x1828E98A0
	public static uint3x4 op_UnaryPlus(uint3x4 val) { }

	// RVA: 0x28E7E50 Offset: 0x28E6850 VA: 0x1828E7E50
	public static uint3x4 op_LeftShift(uint3x4 x, int n) { }

	// RVA: 0x28E9220 Offset: 0x28E7C20 VA: 0x1828E9220
	public static uint3x4 op_RightShift(uint3x4 x, int n) { }

	// RVA: 0x28E6840 Offset: 0x28E5240 VA: 0x1828E6840
	public static bool3x4 op_Equality(uint3x4 lhs, uint3x4 rhs) { }

	// RVA: 0x28E6720 Offset: 0x28E5120 VA: 0x1828E6720
	public static bool3x4 op_Equality(uint3x4 lhs, uint rhs) { }

	// RVA: 0x28E6A40 Offset: 0x28E5440 VA: 0x1828E6A40
	public static bool3x4 op_Equality(uint lhs, uint3x4 rhs) { }

	// RVA: 0x28E7A10 Offset: 0x28E6410 VA: 0x1828E7A10
	public static bool3x4 op_Inequality(uint3x4 lhs, uint3x4 rhs) { }

	// RVA: 0x28E7D30 Offset: 0x28E6730 VA: 0x1828E7D30
	public static bool3x4 op_Inequality(uint3x4 lhs, uint rhs) { }

	// RVA: 0x28E7C10 Offset: 0x28E6610 VA: 0x1828E7C10
	public static bool3x4 op_Inequality(uint lhs, uint3x4 rhs) { }

	// RVA: 0x28E9110 Offset: 0x28E7B10 VA: 0x1828E9110
	public static uint3x4 op_OnesComplement(uint3x4 val) { }

	// RVA: 0x28E5B30 Offset: 0x28E4530 VA: 0x1828E5B30
	public static uint3x4 op_BitwiseAnd(uint3x4 lhs, uint3x4 rhs) { }

	// RVA: 0x28E58F0 Offset: 0x28E42F0 VA: 0x1828E58F0
	public static uint3x4 op_BitwiseAnd(uint3x4 lhs, uint rhs) { }

	// RVA: 0x28E5A10 Offset: 0x28E4410 VA: 0x1828E5A10
	public static uint3x4 op_BitwiseAnd(uint lhs, uint3x4 rhs) { }

	// RVA: 0x28E5F50 Offset: 0x28E4950 VA: 0x1828E5F50
	public static uint3x4 op_BitwiseOr(uint3x4 lhs, uint3x4 rhs) { }

	// RVA: 0x28E5D10 Offset: 0x28E4710 VA: 0x1828E5D10
	public static uint3x4 op_BitwiseOr(uint3x4 lhs, uint rhs) { }

	// RVA: 0x28E5E30 Offset: 0x28E4830 VA: 0x1828E5E30
	public static uint3x4 op_BitwiseOr(uint lhs, uint3x4 rhs) { }

	// RVA: 0x28E6DA0 Offset: 0x28E57A0 VA: 0x1828E6DA0
	public static uint3x4 op_ExclusiveOr(uint3x4 lhs, uint3x4 rhs) { }

	// RVA: 0x28E6B60 Offset: 0x28E5560 VA: 0x1828E6B60
	public static uint3x4 op_ExclusiveOr(uint3x4 lhs, uint rhs) { }

	// RVA: 0x28E6C80 Offset: 0x28E5680 VA: 0x1828E6C80
	public static uint3x4 op_ExclusiveOr(uint lhs, uint3x4 rhs) { }

	// RVA: 0xF6D040 Offset: 0xF6BA40 VA: 0x180F6D040
	public ref uint3 get_Item(int index) { }

	// RVA: 0x28E1950 Offset: 0x28E0350 VA: 0x1828E1950 Slot: 4
	public bool Equals(uint3x4 rhs) { }

	// RVA: 0x28E47B0 Offset: 0x28E31B0 VA: 0x1828E47B0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x28E4860 Offset: 0x28E3260 VA: 0x1828E4860 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x28E4D80 Offset: 0x28E3780 VA: 0x1828E4D80 Slot: 3
	public override string ToString() { }

	// RVA: 0x28E4890 Offset: 0x28E3290 VA: 0x1828E4890 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
