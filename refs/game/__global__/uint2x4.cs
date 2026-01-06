public struct uint2x4 : IEquatable<uint2x4>, IFormattable // TypeDefIndex: 10946
{
	// Fields
	public uint2 c0; // 0x0
	public uint2 c1; // 0x8
	public uint2 c2; // 0x10
	public uint2 c3; // 0x18
	public static readonly uint2x4 zero; // 0x0

	// Properties
	public uint2 Item { get; }

	// Methods

	// RVA: 0xC411A0 Offset: 0xC3FBA0 VA: 0x180C411A0
	public void .ctor(uint2 c0, uint2 c1, uint2 c2, uint2 c3) { }

	// RVA: 0x295A4B0 Offset: 0x2958EB0 VA: 0x18295A4B0
	public void .ctor(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13) { }

	// RVA: 0x295A590 Offset: 0x2958F90 VA: 0x18295A590
	public void .ctor(uint v) { }

	// RVA: 0x2884580 Offset: 0x2882F80 VA: 0x182884580
	public void .ctor(bool v) { }

	// RVA: 0x2884440 Offset: 0x2882E40 VA: 0x182884440
	public void .ctor(bool2x4 v) { }

	// RVA: 0x295A590 Offset: 0x2958F90 VA: 0x18295A590
	public void .ctor(int v) { }

	// RVA: 0x295A440 Offset: 0x2958E40 VA: 0x18295A440
	public void .ctor(int2x4 v) { }

	// RVA: 0x2887BC0 Offset: 0x28865C0 VA: 0x182887BC0
	public void .ctor(float v) { }

	// RVA: 0x2887C80 Offset: 0x2886680 VA: 0x182887C80
	public void .ctor(float2x4 v) { }

	// RVA: 0x2887B00 Offset: 0x2886500 VA: 0x182887B00
	public void .ctor(double v) { }

	// RVA: 0x2887A00 Offset: 0x2886400 VA: 0x182887A00
	public void .ctor(double2x4 v) { }

	// RVA: 0x28A7C30 Offset: 0x28A6630 VA: 0x1828A7C30
	public static uint2x4 op_Implicit(uint v) { }

	// RVA: 0x295B3F0 Offset: 0x2959DF0 VA: 0x18295B3F0
	public static uint2x4 op_Explicit(bool v) { }

	// RVA: 0x28A7C00 Offset: 0x28A6600 VA: 0x1828A7C00
	public static uint2x4 op_Explicit(bool2x4 v) { }

	// RVA: 0x28A7C30 Offset: 0x28A6630 VA: 0x1828A7C30
	public static uint2x4 op_Explicit(int v) { }

	// RVA: 0x28A7C80 Offset: 0x28A6680 VA: 0x1828A7C80
	public static uint2x4 op_Explicit(int2x4 v) { }

	// RVA: 0x298F110 Offset: 0x298DB10 VA: 0x18298F110
	public static uint2x4 op_Explicit(float v) { }

	// RVA: 0x298F170 Offset: 0x298DB70 VA: 0x18298F170
	public static uint2x4 op_Explicit(float2x4 v) { }

	// RVA: 0x298F140 Offset: 0x298DB40 VA: 0x18298F140
	public static uint2x4 op_Explicit(double v) { }

	// RVA: 0x298F0C0 Offset: 0x298DAC0 VA: 0x18298F0C0
	public static uint2x4 op_Explicit(double2x4 v) { }

	// RVA: 0x295C5F0 Offset: 0x295AFF0 VA: 0x18295C5F0
	public static uint2x4 op_Multiply(uint2x4 lhs, uint2x4 rhs) { }

	// RVA: 0x295C6B0 Offset: 0x295B0B0 VA: 0x18295C6B0
	public static uint2x4 op_Multiply(uint2x4 lhs, uint rhs) { }

	// RVA: 0x295C550 Offset: 0x295AF50 VA: 0x18295C550
	public static uint2x4 op_Multiply(uint lhs, uint2x4 rhs) { }

	// RVA: 0x295A7E0 Offset: 0x29591E0 VA: 0x18295A7E0
	public static uint2x4 op_Addition(uint2x4 lhs, uint2x4 rhs) { }

	// RVA: 0x295A750 Offset: 0x2959150 VA: 0x18295A750
	public static uint2x4 op_Addition(uint2x4 lhs, uint rhs) { }

	// RVA: 0x295A6C0 Offset: 0x29590C0 VA: 0x18295A6C0
	public static uint2x4 op_Addition(uint lhs, uint2x4 rhs) { }

	// RVA: 0x295C880 Offset: 0x295B280 VA: 0x18295C880
	public static uint2x4 op_Subtraction(uint2x4 lhs, uint2x4 rhs) { }

	// RVA: 0x295C9E0 Offset: 0x295B3E0 VA: 0x18295C9E0
	public static uint2x4 op_Subtraction(uint2x4 lhs, uint rhs) { }

	// RVA: 0x295C940 Offset: 0x295B340 VA: 0x18295C940
	public static uint2x4 op_Subtraction(uint lhs, uint2x4 rhs) { }

	// RVA: 0x298EE60 Offset: 0x298D860 VA: 0x18298EE60
	public static uint2x4 op_Division(uint2x4 lhs, uint2x4 rhs) { }

	// RVA: 0x298F000 Offset: 0x298DA00 VA: 0x18298F000
	public static uint2x4 op_Division(uint2x4 lhs, uint rhs) { }

	// RVA: 0x298EF40 Offset: 0x298D940 VA: 0x18298EF40
	public static uint2x4 op_Division(uint lhs, uint2x4 rhs) { }

	// RVA: 0x298FE30 Offset: 0x298E830 VA: 0x18298FE30
	public static uint2x4 op_Modulus(uint2x4 lhs, uint2x4 rhs) { }

	// RVA: 0x298FCB0 Offset: 0x298E6B0 VA: 0x18298FCB0
	public static uint2x4 op_Modulus(uint2x4 lhs, uint rhs) { }

	// RVA: 0x298FD70 Offset: 0x298E770 VA: 0x18298FD70
	public static uint2x4 op_Modulus(uint lhs, uint2x4 rhs) { }

	// RVA: 0x295B9A0 Offset: 0x295A3A0 VA: 0x18295B9A0
	public static uint2x4 op_Increment(uint2x4 val) { }

	// RVA: 0x295AC70 Offset: 0x2959670 VA: 0x18295AC70
	public static uint2x4 op_Decrement(uint2x4 val) { }

	// RVA: 0x298FBB0 Offset: 0x298E5B0 VA: 0x18298FBB0
	public static bool2x4 op_LessThan(uint2x4 lhs, uint2x4 rhs) { }

	// RVA: 0x298F9F0 Offset: 0x298E3F0 VA: 0x18298F9F0
	public static bool2x4 op_LessThan(uint2x4 lhs, uint rhs) { }

	// RVA: 0x298FAD0 Offset: 0x298E4D0 VA: 0x18298FAD0
	public static bool2x4 op_LessThan(uint lhs, uint2x4 rhs) { }

	// RVA: 0x298F810 Offset: 0x298E210 VA: 0x18298F810
	public static bool2x4 op_LessThanOrEqual(uint2x4 lhs, uint2x4 rhs) { }

	// RVA: 0x298F730 Offset: 0x298E130 VA: 0x18298F730
	public static bool2x4 op_LessThanOrEqual(uint2x4 lhs, uint rhs) { }

	// RVA: 0x298F910 Offset: 0x298E310 VA: 0x18298F910
	public static bool2x4 op_LessThanOrEqual(uint lhs, uint2x4 rhs) { }

	// RVA: 0x298F470 Offset: 0x298DE70 VA: 0x18298F470
	public static bool2x4 op_GreaterThan(uint2x4 lhs, uint2x4 rhs) { }

	// RVA: 0x298F570 Offset: 0x298DF70 VA: 0x18298F570
	public static bool2x4 op_GreaterThan(uint2x4 lhs, uint rhs) { }

	// RVA: 0x298F650 Offset: 0x298E050 VA: 0x18298F650
	public static bool2x4 op_GreaterThan(uint lhs, uint2x4 rhs) { }

	// RVA: 0x298F290 Offset: 0x298DC90 VA: 0x18298F290
	public static bool2x4 op_GreaterThanOrEqual(uint2x4 lhs, uint2x4 rhs) { }

	// RVA: 0x298F1B0 Offset: 0x298DBB0 VA: 0x18298F1B0
	public static bool2x4 op_GreaterThanOrEqual(uint2x4 lhs, uint rhs) { }

	// RVA: 0x298F390 Offset: 0x298DD90 VA: 0x18298F390
	public static bool2x4 op_GreaterThanOrEqual(uint lhs, uint2x4 rhs) { }

	// RVA: 0x295CA80 Offset: 0x295B480 VA: 0x18295CA80
	public static uint2x4 op_UnaryNegation(uint2x4 val) { }

	// RVA: 0x295CB10 Offset: 0x295B510 VA: 0x18295CB10
	public static uint2x4 op_UnaryPlus(uint2x4 val) { }

	// RVA: 0x295BCF0 Offset: 0x295A6F0 VA: 0x18295BCF0
	public static uint2x4 op_LeftShift(uint2x4 x, int n) { }

	// RVA: 0x298FF10 Offset: 0x298E910 VA: 0x18298FF10
	public static uint2x4 op_RightShift(uint2x4 x, int n) { }

	// RVA: 0x295AF40 Offset: 0x2959940 VA: 0x18295AF40
	public static bool2x4 op_Equality(uint2x4 lhs, uint2x4 rhs) { }

	// RVA: 0x295B040 Offset: 0x2959A40 VA: 0x18295B040
	public static bool2x4 op_Equality(uint2x4 lhs, uint rhs) { }

	// RVA: 0x295B120 Offset: 0x2959B20 VA: 0x18295B120
	public static bool2x4 op_Equality(uint lhs, uint2x4 rhs) { }

	// RVA: 0x295BBF0 Offset: 0x295A5F0 VA: 0x18295BBF0
	public static bool2x4 op_Inequality(uint2x4 lhs, uint2x4 rhs) { }

	// RVA: 0x295BB10 Offset: 0x295A510 VA: 0x18295BB10
	public static bool2x4 op_Inequality(uint2x4 lhs, uint rhs) { }

	// RVA: 0x295BA30 Offset: 0x295A430 VA: 0x18295BA30
	public static bool2x4 op_Inequality(uint lhs, uint2x4 rhs) { }

	// RVA: 0x295C750 Offset: 0x295B150 VA: 0x18295C750
	public static uint2x4 op_OnesComplement(uint2x4 val) { }

	// RVA: 0x295A9C0 Offset: 0x29593C0 VA: 0x18295A9C0
	public static uint2x4 op_BitwiseAnd(uint2x4 lhs, uint2x4 rhs) { }

	// RVA: 0x295A890 Offset: 0x2959290 VA: 0x18295A890
	public static uint2x4 op_BitwiseAnd(uint2x4 lhs, uint rhs) { }

	// RVA: 0x295A930 Offset: 0x2959330 VA: 0x18295A930
	public static uint2x4 op_BitwiseAnd(uint lhs, uint2x4 rhs) { }

	// RVA: 0x295ABB0 Offset: 0x29595B0 VA: 0x18295ABB0
	public static uint2x4 op_BitwiseOr(uint2x4 lhs, uint2x4 rhs) { }

	// RVA: 0x295AA80 Offset: 0x2959480 VA: 0x18295AA80
	public static uint2x4 op_BitwiseOr(uint2x4 lhs, uint rhs) { }

	// RVA: 0x295AB20 Offset: 0x2959520 VA: 0x18295AB20
	public static uint2x4 op_BitwiseOr(uint lhs, uint2x4 rhs) { }

	// RVA: 0x295B2A0 Offset: 0x2959CA0 VA: 0x18295B2A0
	public static uint2x4 op_ExclusiveOr(uint2x4 lhs, uint2x4 rhs) { }

	// RVA: 0x295B200 Offset: 0x2959C00 VA: 0x18295B200
	public static uint2x4 op_ExclusiveOr(uint2x4 lhs, uint rhs) { }

	// RVA: 0x295B360 Offset: 0x2959D60 VA: 0x18295B360
	public static uint2x4 op_ExclusiveOr(uint lhs, uint2x4 rhs) { }

	// RVA: 0xF6CFF0 Offset: 0xF6B9F0 VA: 0x180F6CFF0
	public ref uint2 get_Item(int index) { }

	// RVA: 0x2959BF0 Offset: 0x29585F0 VA: 0x182959BF0 Slot: 4
	public bool Equals(uint2x4 rhs) { }

	// RVA: 0x298E610 Offset: 0x298D010 VA: 0x18298E610 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x298E710 Offset: 0x298D110 VA: 0x18298E710 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x298E740 Offset: 0x298D140 VA: 0x18298E740 Slot: 3
	public override string ToString() { }

	// RVA: 0x298EAE0 Offset: 0x298D4E0 VA: 0x18298EAE0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
