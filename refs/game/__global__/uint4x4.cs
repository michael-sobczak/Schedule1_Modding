public struct uint4x4 : IEquatable<uint4x4>, IFormattable // TypeDefIndex: 10956
{
	// Fields
	public uint4 c0; // 0x0
	public uint4 c1; // 0x10
	public uint4 c2; // 0x20
	public uint4 c3; // 0x30
	public static readonly uint4x4 identity; // 0x0
	public static readonly uint4x4 zero; // 0x40

	// Properties
	public uint4 Item { get; }

	// Methods

	// RVA: 0x28F5170 Offset: 0x28F3B70 VA: 0x1828F5170
	public void .ctor(uint4 c0, uint4 c1, uint4 c2, uint4 c3) { }

	// RVA: 0x28F5280 Offset: 0x28F3C80 VA: 0x1828F5280
	public void .ctor(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23, uint m30, uint m31, uint m32, uint m33) { }

	// RVA: 0x28F5110 Offset: 0x28F3B10 VA: 0x1828F5110
	public void .ctor(uint v) { }

	// RVA: 0x2889370 Offset: 0x2887D70 VA: 0x182889370
	public void .ctor(bool v) { }

	// RVA: 0x28849F0 Offset: 0x28833F0 VA: 0x1828849F0
	public void .ctor(bool4x4 v) { }

	// RVA: 0x28F5110 Offset: 0x28F3B10 VA: 0x1828F5110
	public void .ctor(int v) { }

	// RVA: 0x28F51A0 Offset: 0x28F3BA0 VA: 0x1828F51A0
	public void .ctor(int4x4 v) { }

	// RVA: 0x28895D0 Offset: 0x2887FD0 VA: 0x1828895D0
	public void .ctor(float v) { }

	// RVA: 0x28898F0 Offset: 0x28882F0 VA: 0x1828898F0
	public void .ctor(float4x4 v) { }

	// RVA: 0x2889480 Offset: 0x2887E80 VA: 0x182889480
	public void .ctor(double v) { }

	// RVA: 0x2889720 Offset: 0x2888120 VA: 0x182889720
	public void .ctor(double4x4 v) { }

	// RVA: 0x28A9C90 Offset: 0x28A8690 VA: 0x1828A9C90
	public static uint4x4 op_Implicit(uint v) { }

	// RVA: 0x28F6D10 Offset: 0x28F5710 VA: 0x1828F6D10
	public static uint4x4 op_Explicit(bool v) { }

	// RVA: 0x28F6D40 Offset: 0x28F5740 VA: 0x1828F6D40
	public static uint4x4 op_Explicit(bool4x4 v) { }

	// RVA: 0x28A9C90 Offset: 0x28A8690 VA: 0x1828A9C90
	public static uint4x4 op_Explicit(int v) { }

	// RVA: 0x28A9E90 Offset: 0x28A8890 VA: 0x1828A9E90
	public static uint4x4 op_Explicit(int4x4 v) { }

	// RVA: 0x28D4810 Offset: 0x28D3210 VA: 0x1828D4810
	public static uint4x4 op_Explicit(float v) { }

	// RVA: 0x28D4730 Offset: 0x28D3130 VA: 0x1828D4730
	public static uint4x4 op_Explicit(float4x4 v) { }

	// RVA: 0x28D4840 Offset: 0x28D3240 VA: 0x1828D4840
	public static uint4x4 op_Explicit(double v) { }

	// RVA: 0x28D4790 Offset: 0x28D3190 VA: 0x1828D4790
	public static uint4x4 op_Explicit(double4x4 v) { }

	// RVA: 0x28F8660 Offset: 0x28F7060 VA: 0x1828F8660
	public static uint4x4 op_Multiply(uint4x4 lhs, uint4x4 rhs) { }

	// RVA: 0x28F8510 Offset: 0x28F6F10 VA: 0x1828F8510
	public static uint4x4 op_Multiply(uint4x4 lhs, uint rhs) { }

	// RVA: 0x28F8820 Offset: 0x28F7220 VA: 0x1828F8820
	public static uint4x4 op_Multiply(uint lhs, uint4x4 rhs) { }

	// RVA: 0x28F55B0 Offset: 0x28F3FB0 VA: 0x1828F55B0
	public static uint4x4 op_Addition(uint4x4 lhs, uint4x4 rhs) { }

	// RVA: 0x28F5470 Offset: 0x28F3E70 VA: 0x1828F5470
	public static uint4x4 op_Addition(uint4x4 lhs, uint rhs) { }

	// RVA: 0x28F5330 Offset: 0x28F3D30 VA: 0x1828F5330
	public static uint4x4 op_Addition(uint lhs, uint4x4 rhs) { }

	// RVA: 0x28F8D10 Offset: 0x28F7710 VA: 0x1828F8D10
	public static uint4x4 op_Subtraction(uint4x4 lhs, uint4x4 rhs) { }

	// RVA: 0x28F8BD0 Offset: 0x28F75D0 VA: 0x1828F8BD0
	public static uint4x4 op_Subtraction(uint4x4 lhs, uint rhs) { }

	// RVA: 0x28F8EC0 Offset: 0x28F78C0 VA: 0x1828F8EC0
	public static uint4x4 op_Subtraction(uint lhs, uint4x4 rhs) { }

	// RVA: 0x28F60E0 Offset: 0x28F4AE0 VA: 0x1828F60E0
	public static uint4x4 op_Division(uint4x4 lhs, uint4x4 rhs) { }

	// RVA: 0x28F62C0 Offset: 0x28F4CC0 VA: 0x1828F62C0
	public static uint4x4 op_Division(uint4x4 lhs, uint rhs) { }

	// RVA: 0x28F6430 Offset: 0x28F4E30 VA: 0x1828F6430
	public static uint4x4 op_Division(uint lhs, uint4x4 rhs) { }

	// RVA: 0x28F8040 Offset: 0x28F6A40 VA: 0x1828F8040
	public static uint4x4 op_Modulus(uint4x4 lhs, uint4x4 rhs) { }

	// RVA: 0x28F83A0 Offset: 0x28F6DA0 VA: 0x1828F83A0
	public static uint4x4 op_Modulus(uint4x4 lhs, uint rhs) { }

	// RVA: 0x28F8220 Offset: 0x28F6C20 VA: 0x1828F8220
	public static uint4x4 op_Modulus(uint lhs, uint4x4 rhs) { }

	// RVA: 0x28F7400 Offset: 0x28F5E00 VA: 0x1828F7400
	public static uint4x4 op_Increment(uint4x4 val) { }

	// RVA: 0x28F5FA0 Offset: 0x28F49A0 VA: 0x1828F5FA0
	public static uint4x4 op_Decrement(uint4x4 val) { }

	// RVA: 0x28F7DF0 Offset: 0x28F67F0 VA: 0x1828F7DF0
	public static bool4x4 op_LessThan(uint4x4 lhs, uint4x4 rhs) { }

	// RVA: 0x28F7F50 Offset: 0x28F6950 VA: 0x1828F7F50
	public static bool4x4 op_LessThan(uint4x4 lhs, uint rhs) { }

	// RVA: 0x28F7D00 Offset: 0x28F6700 VA: 0x1828F7D00
	public static bool4x4 op_LessThan(uint lhs, uint4x4 rhs) { }

	// RVA: 0x28F7AB0 Offset: 0x28F64B0 VA: 0x1828F7AB0
	public static bool4x4 op_LessThanOrEqual(uint4x4 lhs, uint4x4 rhs) { }

	// RVA: 0x28F7C10 Offset: 0x28F6610 VA: 0x1828F7C10
	public static bool4x4 op_LessThanOrEqual(uint4x4 lhs, uint rhs) { }

	// RVA: 0x28F79C0 Offset: 0x28F63C0 VA: 0x1828F79C0
	public static bool4x4 op_LessThanOrEqual(uint lhs, uint4x4 rhs) { }

	// RVA: 0x28F72A0 Offset: 0x28F5CA0 VA: 0x1828F72A0
	public static bool4x4 op_GreaterThan(uint4x4 lhs, uint4x4 rhs) { }

	// RVA: 0x28F71B0 Offset: 0x28F5BB0 VA: 0x1828F71B0
	public static bool4x4 op_GreaterThan(uint4x4 lhs, uint rhs) { }

	// RVA: 0x28F70C0 Offset: 0x28F5AC0 VA: 0x1828F70C0
	public static bool4x4 op_GreaterThan(uint lhs, uint4x4 rhs) { }

	// RVA: 0x28F6E70 Offset: 0x28F5870 VA: 0x1828F6E70
	public static bool4x4 op_GreaterThanOrEqual(uint4x4 lhs, uint4x4 rhs) { }

	// RVA: 0x28F6D80 Offset: 0x28F5780 VA: 0x1828F6D80
	public static bool4x4 op_GreaterThanOrEqual(uint4x4 lhs, uint rhs) { }

	// RVA: 0x28F6FD0 Offset: 0x28F59D0 VA: 0x1828F6FD0
	public static bool4x4 op_GreaterThanOrEqual(uint lhs, uint4x4 rhs) { }

	// RVA: 0x28F9020 Offset: 0x28F7A20 VA: 0x1828F9020
	public static uint4x4 op_UnaryNegation(uint4x4 val) { }

	// RVA: 0x28F9150 Offset: 0x28F7B50 VA: 0x1828F9150
	public static uint4x4 op_UnaryPlus(uint4x4 val) { }

	// RVA: 0x28F7880 Offset: 0x28F6280 VA: 0x1828F7880
	public static uint4x4 op_LeftShift(uint4x4 x, int n) { }

	// RVA: 0x28F8A90 Offset: 0x28F7490 VA: 0x1828F8A90
	public static uint4x4 op_RightShift(uint4x4 x, int n) { }

	// RVA: 0x28F65B0 Offset: 0x28F4FB0 VA: 0x1828F65B0
	public static bool4x4 op_Equality(uint4x4 lhs, uint4x4 rhs) { }

	// RVA: 0x28F6800 Offset: 0x28F5200 VA: 0x1828F6800
	public static bool4x4 op_Equality(uint4x4 lhs, uint rhs) { }

	// RVA: 0x28F6710 Offset: 0x28F5110 VA: 0x1828F6710
	public static bool4x4 op_Equality(uint lhs, uint4x4 rhs) { }

	// RVA: 0x28F7720 Offset: 0x28F6120 VA: 0x1828F7720
	public static bool4x4 op_Inequality(uint4x4 lhs, uint4x4 rhs) { }

	// RVA: 0x28F7630 Offset: 0x28F6030 VA: 0x1828F7630
	public static bool4x4 op_Inequality(uint4x4 lhs, uint rhs) { }

	// RVA: 0x28F7540 Offset: 0x28F5F40 VA: 0x1828F7540
	public static bool4x4 op_Inequality(uint lhs, uint4x4 rhs) { }

	// RVA: 0x28F8960 Offset: 0x28F7360 VA: 0x1828F8960
	public static uint4x4 op_OnesComplement(uint4x4 val) { }

	// RVA: 0x28F5760 Offset: 0x28F4160 VA: 0x1828F5760
	public static uint4x4 op_BitwiseAnd(uint4x4 lhs, uint4x4 rhs) { }

	// RVA: 0x28F5A40 Offset: 0x28F4440 VA: 0x1828F5A40
	public static uint4x4 op_BitwiseAnd(uint4x4 lhs, uint rhs) { }

	// RVA: 0x28F5910 Offset: 0x28F4310 VA: 0x1828F5910
	public static uint4x4 op_BitwiseAnd(uint lhs, uint4x4 rhs) { }

	// RVA: 0x28F5B80 Offset: 0x28F4580 VA: 0x1828F5B80
	public static uint4x4 op_BitwiseOr(uint4x4 lhs, uint4x4 rhs) { }

	// RVA: 0x28F5D30 Offset: 0x28F4730 VA: 0x1828F5D30
	public static uint4x4 op_BitwiseOr(uint4x4 lhs, uint rhs) { }

	// RVA: 0x28F5E70 Offset: 0x28F4870 VA: 0x1828F5E70
	public static uint4x4 op_BitwiseOr(uint lhs, uint4x4 rhs) { }

	// RVA: 0x28F6B60 Offset: 0x28F5560 VA: 0x1828F6B60
	public static uint4x4 op_ExclusiveOr(uint4x4 lhs, uint4x4 rhs) { }

	// RVA: 0x28F68F0 Offset: 0x28F52F0 VA: 0x1828F68F0
	public static uint4x4 op_ExclusiveOr(uint4x4 lhs, uint rhs) { }

	// RVA: 0x28F6A30 Offset: 0x28F5430 VA: 0x1828F6A30
	public static uint4x4 op_ExclusiveOr(uint lhs, uint4x4 rhs) { }

	// RVA: 0xF6D000 Offset: 0xF6BA00 VA: 0x180F6D000
	public ref uint4 get_Item(int index) { }

	// RVA: 0x28E3960 Offset: 0x28E2360 VA: 0x1828E3960 Slot: 4
	public bool Equals(uint4x4 rhs) { }

	// RVA: 0x28F4250 Offset: 0x28F2C50 VA: 0x1828F4250 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x28F4300 Offset: 0x28F2D00 VA: 0x1828F4300 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x28F4340 Offset: 0x28F2D40 VA: 0x1828F4340 Slot: 3
	public override string ToString() { }

	// RVA: 0x28F49F0 Offset: 0x28F33F0 VA: 0x1828F49F0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x28F5070 Offset: 0x28F3A70 VA: 0x1828F5070
	private static void .cctor() { }
}
