public struct int2x2 : IEquatable<int2x2>, IFormattable // TypeDefIndex: 10923
{
	// Fields
	public int2 c0; // 0x0
	public int2 c1; // 0x8
	public static readonly int2x2 identity; // 0x0
	public static readonly int2x2 zero; // 0x10

	// Properties
	public int2 Item { get; }

	// Methods

	// RVA: 0xC41170 Offset: 0xC3FB70 VA: 0x180C41170
	public void .ctor(int2 c0, int2 c1) { }

	// RVA: 0x2954360 Offset: 0x2952D60 VA: 0x182954360
	public void .ctor(int m00, int m01, int m10, int m11) { }

	// RVA: 0x2954240 Offset: 0x2952C40 VA: 0x182954240
	public void .ctor(int v) { }

	// RVA: 0x2954300 Offset: 0x2952D00 VA: 0x182954300
	public void .ctor(bool v) { }

	// RVA: 0x2884230 Offset: 0x2882C30 VA: 0x182884230
	public void .ctor(bool2x2 v) { }

	// RVA: 0x2954240 Offset: 0x2952C40 VA: 0x182954240
	public void .ctor(uint v) { }

	// RVA: 0x2954390 Offset: 0x2952D90 VA: 0x182954390
	public void .ctor(uint2x2 v) { }

	// RVA: 0x29541C0 Offset: 0x2952BC0 VA: 0x1829541C0
	public void .ctor(float v) { }

	// RVA: 0x29542B0 Offset: 0x2952CB0 VA: 0x1829542B0
	public void .ctor(float2x2 v) { }

	// RVA: 0x2954270 Offset: 0x2952C70 VA: 0x182954270
	public void .ctor(double v) { }

	// RVA: 0x2954200 Offset: 0x2952C00 VA: 0x182954200
	public void .ctor(double2x2 v) { }

	// RVA: 0x28A75C0 Offset: 0x28A5FC0 VA: 0x1828A75C0
	public static int2x2 op_Implicit(int v) { }

	// RVA: 0x28A7740 Offset: 0x28A6140 VA: 0x1828A7740
	public static int2x2 op_Explicit(bool v) { }

	// RVA: 0x2954AB0 Offset: 0x29534B0 VA: 0x182954AB0
	public static int2x2 op_Explicit(bool2x2 v) { }

	// RVA: 0x28A75C0 Offset: 0x28A5FC0 VA: 0x1828A75C0
	public static int2x2 op_Explicit(uint v) { }

	// RVA: 0x28A76B0 Offset: 0x28A60B0 VA: 0x1828A76B0
	public static int2x2 op_Explicit(uint2x2 v) { }

	// RVA: 0x28A7670 Offset: 0x28A6070 VA: 0x1828A7670
	public static int2x2 op_Explicit(float v) { }

	// RVA: 0x28A7570 Offset: 0x28A5F70 VA: 0x1828A7570
	public static int2x2 op_Explicit(float2x2 v) { }

	// RVA: 0x28A7700 Offset: 0x28A6100 VA: 0x1828A7700
	public static int2x2 op_Explicit(double v) { }

	// RVA: 0x28A7620 Offset: 0x28A6020 VA: 0x1828A7620
	public static int2x2 op_Explicit(double2x2 v) { }

	// RVA: 0x2955380 Offset: 0x2953D80 VA: 0x182955380
	public static int2x2 op_Multiply(int2x2 lhs, int2x2 rhs) { }

	// RVA: 0x2955430 Offset: 0x2953E30 VA: 0x182955430
	public static int2x2 op_Multiply(int2x2 lhs, int rhs) { }

	// RVA: 0x29553E0 Offset: 0x2953DE0 VA: 0x1829553E0
	public static int2x2 op_Multiply(int lhs, int2x2 rhs) { }

	// RVA: 0x2954420 Offset: 0x2952E20 VA: 0x182954420
	public static int2x2 op_Addition(int2x2 lhs, int2x2 rhs) { }

	// RVA: 0x2954480 Offset: 0x2952E80 VA: 0x182954480
	public static int2x2 op_Addition(int2x2 lhs, int rhs) { }

	// RVA: 0x29543D0 Offset: 0x2952DD0 VA: 0x1829543D0
	public static int2x2 op_Addition(int lhs, int2x2 rhs) { }

	// RVA: 0x2955570 Offset: 0x2953F70 VA: 0x182955570
	public static int2x2 op_Subtraction(int2x2 lhs, int2x2 rhs) { }

	// RVA: 0x29555D0 Offset: 0x2953FD0 VA: 0x1829555D0
	public static int2x2 op_Subtraction(int2x2 lhs, int rhs) { }

	// RVA: 0x2955520 Offset: 0x2953F20 VA: 0x182955520
	public static int2x2 op_Subtraction(int lhs, int2x2 rhs) { }

	// RVA: 0x29547E0 Offset: 0x29531E0 VA: 0x1829547E0
	public static int2x2 op_Division(int2x2 lhs, int2x2 rhs) { }

	// RVA: 0x2954780 Offset: 0x2953180 VA: 0x182954780
	public static int2x2 op_Division(int2x2 lhs, int rhs) { }

	// RVA: 0x2954720 Offset: 0x2953120 VA: 0x182954720
	public static int2x2 op_Division(int lhs, int2x2 rhs) { }

	// RVA: 0x2955310 Offset: 0x2953D10 VA: 0x182955310
	public static int2x2 op_Modulus(int2x2 lhs, int2x2 rhs) { }

	// RVA: 0x2955250 Offset: 0x2953C50 VA: 0x182955250
	public static int2x2 op_Modulus(int2x2 lhs, int rhs) { }

	// RVA: 0x29552B0 Offset: 0x2953CB0 VA: 0x1829552B0
	public static int2x2 op_Modulus(int lhs, int2x2 rhs) { }

	// RVA: 0x2954D90 Offset: 0x2953790 VA: 0x182954D90
	public static int2x2 op_Increment(int2x2 val) { }

	// RVA: 0x29546D0 Offset: 0x29530D0 VA: 0x1829546D0
	public static int2x2 op_Decrement(int2x2 val) { }

	// RVA: 0x2955160 Offset: 0x2953B60 VA: 0x182955160
	public static bool2x2 op_LessThan(int2x2 lhs, int2x2 rhs) { }

	// RVA: 0x29551E0 Offset: 0x2953BE0 VA: 0x1829551E0
	public static bool2x2 op_LessThan(int2x2 lhs, int rhs) { }

	// RVA: 0x29550F0 Offset: 0x2953AF0 VA: 0x1829550F0
	public static bool2x2 op_LessThan(int lhs, int2x2 rhs) { }

	// RVA: 0x2954F90 Offset: 0x2953990 VA: 0x182954F90
	public static bool2x2 op_LessThanOrEqual(int2x2 lhs, int2x2 rhs) { }

	// RVA: 0x2955080 Offset: 0x2953A80 VA: 0x182955080
	public static bool2x2 op_LessThanOrEqual(int2x2 lhs, int rhs) { }

	// RVA: 0x2955010 Offset: 0x2953A10 VA: 0x182955010
	public static bool2x2 op_LessThanOrEqual(int lhs, int2x2 rhs) { }

	// RVA: 0x2954C30 Offset: 0x2953630 VA: 0x182954C30
	public static bool2x2 op_GreaterThan(int2x2 lhs, int2x2 rhs) { }

	// RVA: 0x2954CB0 Offset: 0x29536B0 VA: 0x182954CB0
	public static bool2x2 op_GreaterThan(int2x2 lhs, int rhs) { }

	// RVA: 0x2954D20 Offset: 0x2953720 VA: 0x182954D20
	public static bool2x2 op_GreaterThan(int lhs, int2x2 rhs) { }

	// RVA: 0x2954BB0 Offset: 0x29535B0 VA: 0x182954BB0
	public static bool2x2 op_GreaterThanOrEqual(int2x2 lhs, int2x2 rhs) { }

	// RVA: 0x2954AD0 Offset: 0x29534D0 VA: 0x182954AD0
	public static bool2x2 op_GreaterThanOrEqual(int2x2 lhs, int rhs) { }

	// RVA: 0x2954B40 Offset: 0x2953540 VA: 0x182954B40
	public static bool2x2 op_GreaterThanOrEqual(int lhs, int2x2 rhs) { }

	// RVA: 0x2955620 Offset: 0x2954020 VA: 0x182955620
	public static int2x2 op_UnaryNegation(int2x2 val) { }

	// RVA: 0x2955670 Offset: 0x2954070 VA: 0x182955670
	public static int2x2 op_UnaryPlus(int2x2 val) { }

	// RVA: 0x2954F40 Offset: 0x2953940 VA: 0x182954F40
	public static int2x2 op_LeftShift(int2x2 x, int n) { }

	// RVA: 0x29554D0 Offset: 0x2953ED0 VA: 0x1829554D0
	public static int2x2 op_RightShift(int2x2 x, int n) { }

	// RVA: 0x29548C0 Offset: 0x29532C0 VA: 0x1829548C0
	public static bool2x2 op_Equality(int2x2 lhs, int2x2 rhs) { }

	// RVA: 0x2954940 Offset: 0x2953340 VA: 0x182954940
	public static bool2x2 op_Equality(int2x2 lhs, int rhs) { }

	// RVA: 0x2954850 Offset: 0x2953250 VA: 0x182954850
	public static bool2x2 op_Equality(int lhs, int2x2 rhs) { }

	// RVA: 0x2954DE0 Offset: 0x29537E0 VA: 0x182954DE0
	public static bool2x2 op_Inequality(int2x2 lhs, int2x2 rhs) { }

	// RVA: 0x2954ED0 Offset: 0x29538D0 VA: 0x182954ED0
	public static bool2x2 op_Inequality(int2x2 lhs, int rhs) { }

	// RVA: 0x2954E60 Offset: 0x2953860 VA: 0x182954E60
	public static bool2x2 op_Inequality(int lhs, int2x2 rhs) { }

	// RVA: 0x2955480 Offset: 0x2953E80 VA: 0x182955480
	public static int2x2 op_OnesComplement(int2x2 val) { }

	// RVA: 0x2954570 Offset: 0x2952F70 VA: 0x182954570
	public static int2x2 op_BitwiseAnd(int2x2 lhs, int2x2 rhs) { }

	// RVA: 0x2954520 Offset: 0x2952F20 VA: 0x182954520
	public static int2x2 op_BitwiseAnd(int2x2 lhs, int rhs) { }

	// RVA: 0x29544D0 Offset: 0x2952ED0 VA: 0x1829544D0
	public static int2x2 op_BitwiseAnd(int lhs, int2x2 rhs) { }

	// RVA: 0x29545D0 Offset: 0x2952FD0 VA: 0x1829545D0
	public static int2x2 op_BitwiseOr(int2x2 lhs, int2x2 rhs) { }

	// RVA: 0x2954680 Offset: 0x2953080 VA: 0x182954680
	public static int2x2 op_BitwiseOr(int2x2 lhs, int rhs) { }

	// RVA: 0x2954630 Offset: 0x2953030 VA: 0x182954630
	public static int2x2 op_BitwiseOr(int lhs, int2x2 rhs) { }

	// RVA: 0x2954A00 Offset: 0x2953400 VA: 0x182954A00
	public static int2x2 op_ExclusiveOr(int2x2 lhs, int2x2 rhs) { }

	// RVA: 0x29549B0 Offset: 0x29533B0 VA: 0x1829549B0
	public static int2x2 op_ExclusiveOr(int2x2 lhs, int rhs) { }

	// RVA: 0x2954A60 Offset: 0x2953460 VA: 0x182954A60
	public static int2x2 op_ExclusiveOr(int lhs, int2x2 rhs) { }

	// RVA: 0xF6CFF0 Offset: 0xF6B9F0 VA: 0x180F6CFF0
	public ref int2 get_Item(int index) { }

	// RVA: 0x2953B50 Offset: 0x2952550 VA: 0x182953B50 Slot: 4
	public bool Equals(int2x2 rhs) { }

	// RVA: 0x2953B80 Offset: 0x2952580 VA: 0x182953B80 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2953C30 Offset: 0x2952630 VA: 0x182953C30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2953D30 Offset: 0x2952730 VA: 0x182953D30 Slot: 3
	public override string ToString() { }

	// RVA: 0x2953F40 Offset: 0x2952940 VA: 0x182953F40 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2954150 Offset: 0x2952B50 VA: 0x182954150
	private static void .cctor() { }
}
