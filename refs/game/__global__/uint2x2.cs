public struct uint2x2 : IEquatable<uint2x2>, IFormattable // TypeDefIndex: 10944
{
	// Fields
	public uint2 c0; // 0x0
	public uint2 c1; // 0x8
	public static readonly uint2x2 identity; // 0x0
	public static readonly uint2x2 zero; // 0x10

	// Properties
	public uint2 Item { get; }

	// Methods

	// RVA: 0xC41170 Offset: 0xC3FB70 VA: 0x180C41170
	public void .ctor(uint2 c0, uint2 c1) { }

	// RVA: 0x2954360 Offset: 0x2952D60 VA: 0x182954360
	public void .ctor(uint m00, uint m01, uint m10, uint m11) { }

	// RVA: 0x2954240 Offset: 0x2952C40 VA: 0x182954240
	public void .ctor(uint v) { }

	// RVA: 0x2954300 Offset: 0x2952D00 VA: 0x182954300
	public void .ctor(bool v) { }

	// RVA: 0x2884230 Offset: 0x2882C30 VA: 0x182884230
	public void .ctor(bool2x2 v) { }

	// RVA: 0x2954240 Offset: 0x2952C40 VA: 0x182954240
	public void .ctor(int v) { }

	// RVA: 0x2954390 Offset: 0x2952D90 VA: 0x182954390
	public void .ctor(int2x2 v) { }

	// RVA: 0x2887640 Offset: 0x2886040 VA: 0x182887640
	public void .ctor(float v) { }

	// RVA: 0x298CB70 Offset: 0x298B570 VA: 0x18298CB70
	public void .ctor(float2x2 v) { }

	// RVA: 0x28876B0 Offset: 0x28860B0 VA: 0x1828876B0
	public void .ctor(double v) { }

	// RVA: 0x298CC00 Offset: 0x298B600 VA: 0x18298CC00
	public void .ctor(double2x2 v) { }

	// RVA: 0x28A75C0 Offset: 0x28A5FC0 VA: 0x1828A75C0
	public static uint2x2 op_Implicit(uint v) { }

	// RVA: 0x28A7740 Offset: 0x28A6140 VA: 0x1828A7740
	public static uint2x2 op_Explicit(bool v) { }

	// RVA: 0x2954AB0 Offset: 0x29534B0 VA: 0x182954AB0
	public static uint2x2 op_Explicit(bool2x2 v) { }

	// RVA: 0x28A75C0 Offset: 0x28A5FC0 VA: 0x1828A75C0
	public static uint2x2 op_Explicit(int v) { }

	// RVA: 0x28A76B0 Offset: 0x28A60B0 VA: 0x1828A76B0
	public static uint2x2 op_Explicit(int2x2 v) { }

	// RVA: 0x28D2930 Offset: 0x28D1330 VA: 0x1828D2930
	public static uint2x2 op_Explicit(float v) { }

	// RVA: 0x28D2AB0 Offset: 0x28D14B0 VA: 0x1828D2AB0
	public static uint2x2 op_Explicit(float2x2 v) { }

	// RVA: 0x28D29A0 Offset: 0x28D13A0 VA: 0x1828D29A0
	public static uint2x2 op_Explicit(double v) { }

	// RVA: 0x28D2A10 Offset: 0x28D1410 VA: 0x1828D2A10
	public static uint2x2 op_Explicit(double2x2 v) { }

	// RVA: 0x2955380 Offset: 0x2953D80 VA: 0x182955380
	public static uint2x2 op_Multiply(uint2x2 lhs, uint2x2 rhs) { }

	// RVA: 0x2955430 Offset: 0x2953E30 VA: 0x182955430
	public static uint2x2 op_Multiply(uint2x2 lhs, uint rhs) { }

	// RVA: 0x29553E0 Offset: 0x2953DE0 VA: 0x1829553E0
	public static uint2x2 op_Multiply(uint lhs, uint2x2 rhs) { }

	// RVA: 0x2954420 Offset: 0x2952E20 VA: 0x182954420
	public static uint2x2 op_Addition(uint2x2 lhs, uint2x2 rhs) { }

	// RVA: 0x2954480 Offset: 0x2952E80 VA: 0x182954480
	public static uint2x2 op_Addition(uint2x2 lhs, uint rhs) { }

	// RVA: 0x29543D0 Offset: 0x2952DD0 VA: 0x1829543D0
	public static uint2x2 op_Addition(uint lhs, uint2x2 rhs) { }

	// RVA: 0x2955570 Offset: 0x2953F70 VA: 0x182955570
	public static uint2x2 op_Subtraction(uint2x2 lhs, uint2x2 rhs) { }

	// RVA: 0x29555D0 Offset: 0x2953FD0 VA: 0x1829555D0
	public static uint2x2 op_Subtraction(uint2x2 lhs, uint rhs) { }

	// RVA: 0x2955520 Offset: 0x2953F20 VA: 0x182955520
	public static uint2x2 op_Subtraction(uint lhs, uint2x2 rhs) { }

	// RVA: 0x298CC90 Offset: 0x298B690 VA: 0x18298CC90
	public static uint2x2 op_Division(uint2x2 lhs, uint2x2 rhs) { }

	// RVA: 0x298CD10 Offset: 0x298B710 VA: 0x18298CD10
	public static uint2x2 op_Division(uint2x2 lhs, uint rhs) { }

	// RVA: 0x298CD70 Offset: 0x298B770 VA: 0x18298CD70
	public static uint2x2 op_Division(uint lhs, uint2x2 rhs) { }

	// RVA: 0x298D3B0 Offset: 0x298BDB0 VA: 0x18298D3B0
	public static uint2x2 op_Modulus(uint2x2 lhs, uint2x2 rhs) { }

	// RVA: 0x298D350 Offset: 0x298BD50 VA: 0x18298D350
	public static uint2x2 op_Modulus(uint2x2 lhs, uint rhs) { }

	// RVA: 0x298D430 Offset: 0x298BE30 VA: 0x18298D430
	public static uint2x2 op_Modulus(uint lhs, uint2x2 rhs) { }

	// RVA: 0x2954D90 Offset: 0x2953790 VA: 0x182954D90
	public static uint2x2 op_Increment(uint2x2 val) { }

	// RVA: 0x29546D0 Offset: 0x29530D0 VA: 0x1829546D0
	public static uint2x2 op_Decrement(uint2x2 val) { }

	// RVA: 0x298D260 Offset: 0x298BC60 VA: 0x18298D260
	public static bool2x2 op_LessThan(uint2x2 lhs, uint2x2 rhs) { }

	// RVA: 0x298D2E0 Offset: 0x298BCE0 VA: 0x18298D2E0
	public static bool2x2 op_LessThan(uint2x2 lhs, uint rhs) { }

	// RVA: 0x298D1F0 Offset: 0x298BBF0 VA: 0x18298D1F0
	public static bool2x2 op_LessThan(uint lhs, uint2x2 rhs) { }

	// RVA: 0x298D170 Offset: 0x298BB70 VA: 0x18298D170
	public static bool2x2 op_LessThanOrEqual(uint2x2 lhs, uint2x2 rhs) { }

	// RVA: 0x298D100 Offset: 0x298BB00 VA: 0x18298D100
	public static bool2x2 op_LessThanOrEqual(uint2x2 lhs, uint rhs) { }

	// RVA: 0x298D090 Offset: 0x298BA90 VA: 0x18298D090
	public static bool2x2 op_LessThanOrEqual(uint lhs, uint2x2 rhs) { }

	// RVA: 0x298D010 Offset: 0x298BA10 VA: 0x18298D010
	public static bool2x2 op_GreaterThan(uint2x2 lhs, uint2x2 rhs) { }

	// RVA: 0x298CFA0 Offset: 0x298B9A0 VA: 0x18298CFA0
	public static bool2x2 op_GreaterThan(uint2x2 lhs, uint rhs) { }

	// RVA: 0x298CF30 Offset: 0x298B930 VA: 0x18298CF30
	public static bool2x2 op_GreaterThan(uint lhs, uint2x2 rhs) { }

	// RVA: 0x298CDD0 Offset: 0x298B7D0 VA: 0x18298CDD0
	public static bool2x2 op_GreaterThanOrEqual(uint2x2 lhs, uint2x2 rhs) { }

	// RVA: 0x298CE50 Offset: 0x298B850 VA: 0x18298CE50
	public static bool2x2 op_GreaterThanOrEqual(uint2x2 lhs, uint rhs) { }

	// RVA: 0x298CEC0 Offset: 0x298B8C0 VA: 0x18298CEC0
	public static bool2x2 op_GreaterThanOrEqual(uint lhs, uint2x2 rhs) { }

	// RVA: 0x2955620 Offset: 0x2954020 VA: 0x182955620
	public static uint2x2 op_UnaryNegation(uint2x2 val) { }

	// RVA: 0x2955670 Offset: 0x2954070 VA: 0x182955670
	public static uint2x2 op_UnaryPlus(uint2x2 val) { }

	// RVA: 0x2954F40 Offset: 0x2953940 VA: 0x182954F40
	public static uint2x2 op_LeftShift(uint2x2 x, int n) { }

	// RVA: 0x298D490 Offset: 0x298BE90 VA: 0x18298D490
	public static uint2x2 op_RightShift(uint2x2 x, int n) { }

	// RVA: 0x29548C0 Offset: 0x29532C0 VA: 0x1829548C0
	public static bool2x2 op_Equality(uint2x2 lhs, uint2x2 rhs) { }

	// RVA: 0x2954940 Offset: 0x2953340 VA: 0x182954940
	public static bool2x2 op_Equality(uint2x2 lhs, uint rhs) { }

	// RVA: 0x2954850 Offset: 0x2953250 VA: 0x182954850
	public static bool2x2 op_Equality(uint lhs, uint2x2 rhs) { }

	// RVA: 0x2954DE0 Offset: 0x29537E0 VA: 0x182954DE0
	public static bool2x2 op_Inequality(uint2x2 lhs, uint2x2 rhs) { }

	// RVA: 0x2954ED0 Offset: 0x29538D0 VA: 0x182954ED0
	public static bool2x2 op_Inequality(uint2x2 lhs, uint rhs) { }

	// RVA: 0x2954E60 Offset: 0x2953860 VA: 0x182954E60
	public static bool2x2 op_Inequality(uint lhs, uint2x2 rhs) { }

	// RVA: 0x2955480 Offset: 0x2953E80 VA: 0x182955480
	public static uint2x2 op_OnesComplement(uint2x2 val) { }

	// RVA: 0x2954570 Offset: 0x2952F70 VA: 0x182954570
	public static uint2x2 op_BitwiseAnd(uint2x2 lhs, uint2x2 rhs) { }

	// RVA: 0x2954520 Offset: 0x2952F20 VA: 0x182954520
	public static uint2x2 op_BitwiseAnd(uint2x2 lhs, uint rhs) { }

	// RVA: 0x29544D0 Offset: 0x2952ED0 VA: 0x1829544D0
	public static uint2x2 op_BitwiseAnd(uint lhs, uint2x2 rhs) { }

	// RVA: 0x29545D0 Offset: 0x2952FD0 VA: 0x1829545D0
	public static uint2x2 op_BitwiseOr(uint2x2 lhs, uint2x2 rhs) { }

	// RVA: 0x2954680 Offset: 0x2953080 VA: 0x182954680
	public static uint2x2 op_BitwiseOr(uint2x2 lhs, uint rhs) { }

	// RVA: 0x2954630 Offset: 0x2953030 VA: 0x182954630
	public static uint2x2 op_BitwiseOr(uint lhs, uint2x2 rhs) { }

	// RVA: 0x2954A00 Offset: 0x2953400 VA: 0x182954A00
	public static uint2x2 op_ExclusiveOr(uint2x2 lhs, uint2x2 rhs) { }

	// RVA: 0x29549B0 Offset: 0x29533B0 VA: 0x1829549B0
	public static uint2x2 op_ExclusiveOr(uint2x2 lhs, uint rhs) { }

	// RVA: 0x2954A60 Offset: 0x2953460 VA: 0x182954A60
	public static uint2x2 op_ExclusiveOr(uint lhs, uint2x2 rhs) { }

	// RVA: 0xF6CFF0 Offset: 0xF6B9F0 VA: 0x180F6CFF0
	public ref uint2 get_Item(int index) { }

	// RVA: 0x2953B50 Offset: 0x2952550 VA: 0x182953B50 Slot: 4
	public bool Equals(uint2x2 rhs) { }

	// RVA: 0x298C560 Offset: 0x298AF60 VA: 0x18298C560 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x298C610 Offset: 0x298B010 VA: 0x18298C610 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x298C8F0 Offset: 0x298B2F0 VA: 0x18298C8F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x298C6E0 Offset: 0x298B0E0 VA: 0x18298C6E0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x298CB00 Offset: 0x298B500 VA: 0x18298CB00
	private static void .cctor() { }
}
