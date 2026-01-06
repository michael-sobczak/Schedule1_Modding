public struct int2x4 : IEquatable<int2x4>, IFormattable // TypeDefIndex: 10925
{
	// Fields
	public int2 c0; // 0x0
	public int2 c1; // 0x8
	public int2 c2; // 0x10
	public int2 c3; // 0x18
	public static readonly int2x4 zero; // 0x0

	// Properties
	public int2 Item { get; }

	// Methods

	// RVA: 0xC411A0 Offset: 0xC3FBA0 VA: 0x180C411A0
	public void .ctor(int2 c0, int2 c1, int2 c2, int2 c3) { }

	// RVA: 0x295A4B0 Offset: 0x2958EB0 VA: 0x18295A4B0
	public void .ctor(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13) { }

	// RVA: 0x295A590 Offset: 0x2958F90 VA: 0x18295A590
	public void .ctor(int v) { }

	// RVA: 0x2884580 Offset: 0x2882F80 VA: 0x182884580
	public void .ctor(bool v) { }

	// RVA: 0x2884440 Offset: 0x2882E40 VA: 0x182884440
	public void .ctor(bool2x4 v) { }

	// RVA: 0x295A590 Offset: 0x2958F90 VA: 0x18295A590
	public void .ctor(uint v) { }

	// RVA: 0x295A440 Offset: 0x2958E40 VA: 0x18295A440
	public void .ctor(uint2x4 v) { }

	// RVA: 0x295A5E0 Offset: 0x2958FE0 VA: 0x18295A5E0
	public void .ctor(float v) { }

	// RVA: 0x295A3C0 Offset: 0x2958DC0 VA: 0x18295A3C0
	public void .ctor(float2x4 v) { }

	// RVA: 0x295A650 Offset: 0x2959050 VA: 0x18295A650
	public void .ctor(double v) { }

	// RVA: 0x295A510 Offset: 0x2958F10 VA: 0x18295A510
	public void .ctor(double2x4 v) { }

	// RVA: 0x28A7C30 Offset: 0x28A6630 VA: 0x1828A7C30
	public static int2x4 op_Implicit(int v) { }

	// RVA: 0x295B3F0 Offset: 0x2959DF0 VA: 0x18295B3F0
	public static int2x4 op_Explicit(bool v) { }

	// RVA: 0x28A7C00 Offset: 0x28A6600 VA: 0x1828A7C00
	public static int2x4 op_Explicit(bool2x4 v) { }

	// RVA: 0x28A7C30 Offset: 0x28A6630 VA: 0x1828A7C30
	public static int2x4 op_Explicit(uint v) { }

	// RVA: 0x28A7C80 Offset: 0x28A6680 VA: 0x1828A7C80
	public static int2x4 op_Explicit(uint2x4 v) { }

	// RVA: 0x28A7F30 Offset: 0x28A6930 VA: 0x1828A7F30
	public static int2x4 op_Explicit(float v) { }

	// RVA: 0x28A7E90 Offset: 0x28A6890 VA: 0x1828A7E90
	public static int2x4 op_Explicit(float2x4 v) { }

	// RVA: 0x28A7E20 Offset: 0x28A6820 VA: 0x1828A7E20
	public static int2x4 op_Explicit(double v) { }

	// RVA: 0x28A7FA0 Offset: 0x28A69A0 VA: 0x1828A7FA0
	public static int2x4 op_Explicit(double2x4 v) { }

	// RVA: 0x295C5F0 Offset: 0x295AFF0 VA: 0x18295C5F0
	public static int2x4 op_Multiply(int2x4 lhs, int2x4 rhs) { }

	// RVA: 0x295C6B0 Offset: 0x295B0B0 VA: 0x18295C6B0
	public static int2x4 op_Multiply(int2x4 lhs, int rhs) { }

	// RVA: 0x295C550 Offset: 0x295AF50 VA: 0x18295C550
	public static int2x4 op_Multiply(int lhs, int2x4 rhs) { }

	// RVA: 0x295A7E0 Offset: 0x29591E0 VA: 0x18295A7E0
	public static int2x4 op_Addition(int2x4 lhs, int2x4 rhs) { }

	// RVA: 0x295A750 Offset: 0x2959150 VA: 0x18295A750
	public static int2x4 op_Addition(int2x4 lhs, int rhs) { }

	// RVA: 0x295A6C0 Offset: 0x29590C0 VA: 0x18295A6C0
	public static int2x4 op_Addition(int lhs, int2x4 rhs) { }

	// RVA: 0x295C880 Offset: 0x295B280 VA: 0x18295C880
	public static int2x4 op_Subtraction(int2x4 lhs, int2x4 rhs) { }

	// RVA: 0x295C9E0 Offset: 0x295B3E0 VA: 0x18295C9E0
	public static int2x4 op_Subtraction(int2x4 lhs, int rhs) { }

	// RVA: 0x295C940 Offset: 0x295B340 VA: 0x18295C940
	public static int2x4 op_Subtraction(int lhs, int2x4 rhs) { }

	// RVA: 0x295AE60 Offset: 0x2959860 VA: 0x18295AE60
	public static int2x4 op_Division(int2x4 lhs, int2x4 rhs) { }

	// RVA: 0x295AD00 Offset: 0x2959700 VA: 0x18295AD00
	public static int2x4 op_Division(int2x4 lhs, int rhs) { }

	// RVA: 0x295ADB0 Offset: 0x29597B0 VA: 0x18295ADB0
	public static int2x4 op_Division(int lhs, int2x4 rhs) { }

	// RVA: 0x295C3C0 Offset: 0x295ADC0 VA: 0x18295C3C0
	public static int2x4 op_Modulus(int2x4 lhs, int2x4 rhs) { }

	// RVA: 0x295C4A0 Offset: 0x295AEA0 VA: 0x18295C4A0
	public static int2x4 op_Modulus(int2x4 lhs, int rhs) { }

	// RVA: 0x295C310 Offset: 0x295AD10 VA: 0x18295C310
	public static int2x4 op_Modulus(int lhs, int2x4 rhs) { }

	// RVA: 0x295B9A0 Offset: 0x295A3A0 VA: 0x18295B9A0
	public static int2x4 op_Increment(int2x4 val) { }

	// RVA: 0x295AC70 Offset: 0x2959670 VA: 0x18295AC70
	public static int2x4 op_Decrement(int2x4 val) { }

	// RVA: 0x295C130 Offset: 0x295AB30 VA: 0x18295C130
	public static bool2x4 op_LessThan(int2x4 lhs, int2x4 rhs) { }

	// RVA: 0x295C050 Offset: 0x295AA50 VA: 0x18295C050
	public static bool2x4 op_LessThan(int2x4 lhs, int rhs) { }

	// RVA: 0x295C230 Offset: 0x295AC30 VA: 0x18295C230
	public static bool2x4 op_LessThan(int lhs, int2x4 rhs) { }

	// RVA: 0x295BF50 Offset: 0x295A950 VA: 0x18295BF50
	public static bool2x4 op_LessThanOrEqual(int2x4 lhs, int2x4 rhs) { }

	// RVA: 0x295BD90 Offset: 0x295A790 VA: 0x18295BD90
	public static bool2x4 op_LessThanOrEqual(int2x4 lhs, int rhs) { }

	// RVA: 0x295BE70 Offset: 0x295A870 VA: 0x18295BE70
	public static bool2x4 op_LessThanOrEqual(int lhs, int2x4 rhs) { }

	// RVA: 0x295B6E0 Offset: 0x295A0E0 VA: 0x18295B6E0
	public static bool2x4 op_GreaterThan(int2x4 lhs, int2x4 rhs) { }

	// RVA: 0x295B7E0 Offset: 0x295A1E0 VA: 0x18295B7E0
	public static bool2x4 op_GreaterThan(int2x4 lhs, int rhs) { }

	// RVA: 0x295B8C0 Offset: 0x295A2C0 VA: 0x18295B8C0
	public static bool2x4 op_GreaterThan(int lhs, int2x4 rhs) { }

	// RVA: 0x295B420 Offset: 0x2959E20 VA: 0x18295B420
	public static bool2x4 op_GreaterThanOrEqual(int2x4 lhs, int2x4 rhs) { }

	// RVA: 0x295B520 Offset: 0x2959F20 VA: 0x18295B520
	public static bool2x4 op_GreaterThanOrEqual(int2x4 lhs, int rhs) { }

	// RVA: 0x295B600 Offset: 0x295A000 VA: 0x18295B600
	public static bool2x4 op_GreaterThanOrEqual(int lhs, int2x4 rhs) { }

	// RVA: 0x295CA80 Offset: 0x295B480 VA: 0x18295CA80
	public static int2x4 op_UnaryNegation(int2x4 val) { }

	// RVA: 0x295CB10 Offset: 0x295B510 VA: 0x18295CB10
	public static int2x4 op_UnaryPlus(int2x4 val) { }

	// RVA: 0x295BCF0 Offset: 0x295A6F0 VA: 0x18295BCF0
	public static int2x4 op_LeftShift(int2x4 x, int n) { }

	// RVA: 0x295C7E0 Offset: 0x295B1E0 VA: 0x18295C7E0
	public static int2x4 op_RightShift(int2x4 x, int n) { }

	// RVA: 0x295AF40 Offset: 0x2959940 VA: 0x18295AF40
	public static bool2x4 op_Equality(int2x4 lhs, int2x4 rhs) { }

	// RVA: 0x295B040 Offset: 0x2959A40 VA: 0x18295B040
	public static bool2x4 op_Equality(int2x4 lhs, int rhs) { }

	// RVA: 0x295B120 Offset: 0x2959B20 VA: 0x18295B120
	public static bool2x4 op_Equality(int lhs, int2x4 rhs) { }

	// RVA: 0x295BBF0 Offset: 0x295A5F0 VA: 0x18295BBF0
	public static bool2x4 op_Inequality(int2x4 lhs, int2x4 rhs) { }

	// RVA: 0x295BB10 Offset: 0x295A510 VA: 0x18295BB10
	public static bool2x4 op_Inequality(int2x4 lhs, int rhs) { }

	// RVA: 0x295BA30 Offset: 0x295A430 VA: 0x18295BA30
	public static bool2x4 op_Inequality(int lhs, int2x4 rhs) { }

	// RVA: 0x295C750 Offset: 0x295B150 VA: 0x18295C750
	public static int2x4 op_OnesComplement(int2x4 val) { }

	// RVA: 0x295A9C0 Offset: 0x29593C0 VA: 0x18295A9C0
	public static int2x4 op_BitwiseAnd(int2x4 lhs, int2x4 rhs) { }

	// RVA: 0x295A890 Offset: 0x2959290 VA: 0x18295A890
	public static int2x4 op_BitwiseAnd(int2x4 lhs, int rhs) { }

	// RVA: 0x295A930 Offset: 0x2959330 VA: 0x18295A930
	public static int2x4 op_BitwiseAnd(int lhs, int2x4 rhs) { }

	// RVA: 0x295ABB0 Offset: 0x29595B0 VA: 0x18295ABB0
	public static int2x4 op_BitwiseOr(int2x4 lhs, int2x4 rhs) { }

	// RVA: 0x295AA80 Offset: 0x2959480 VA: 0x18295AA80
	public static int2x4 op_BitwiseOr(int2x4 lhs, int rhs) { }

	// RVA: 0x295AB20 Offset: 0x2959520 VA: 0x18295AB20
	public static int2x4 op_BitwiseOr(int lhs, int2x4 rhs) { }

	// RVA: 0x295B2A0 Offset: 0x2959CA0 VA: 0x18295B2A0
	public static int2x4 op_ExclusiveOr(int2x4 lhs, int2x4 rhs) { }

	// RVA: 0x295B200 Offset: 0x2959C00 VA: 0x18295B200
	public static int2x4 op_ExclusiveOr(int2x4 lhs, int rhs) { }

	// RVA: 0x295B360 Offset: 0x2959D60 VA: 0x18295B360
	public static int2x4 op_ExclusiveOr(int lhs, int2x4 rhs) { }

	// RVA: 0xF6CFF0 Offset: 0xF6B9F0 VA: 0x180F6CFF0
	public ref int2 get_Item(int index) { }

	// RVA: 0x2959BF0 Offset: 0x29585F0 VA: 0x182959BF0 Slot: 4
	public bool Equals(int2x4 rhs) { }

	// RVA: 0x2959AF0 Offset: 0x29584F0 VA: 0x182959AF0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2959C70 Offset: 0x2958670 VA: 0x182959C70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x295A020 Offset: 0x2958A20 VA: 0x18295A020 Slot: 3
	public override string ToString() { }

	// RVA: 0x2959CA0 Offset: 0x29586A0 VA: 0x182959CA0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
