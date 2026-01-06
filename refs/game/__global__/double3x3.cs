public struct double3x3 : IEquatable<double3x3>, IFormattable // TypeDefIndex: 10892
{
	// Fields
	public double3 c0; // 0x0
	public double3 c1; // 0x18
	public double3 c2; // 0x30
	public static readonly double3x3 identity; // 0x0
	public static readonly double3x3 zero; // 0x48

	// Properties
	public double3 Item { get; }

	// Methods

	// RVA: 0x290CA20 Offset: 0x290B420 VA: 0x18290CA20
	public void .ctor(double3 c0, double3 c1, double3 c2) { }

	// RVA: 0x290CE80 Offset: 0x290B880 VA: 0x18290CE80
	public void .ctor(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22) { }

	// RVA: 0x290CA60 Offset: 0x290B460 VA: 0x18290CA60
	public void .ctor(double v) { }

	// RVA: 0x290CE00 Offset: 0x290B800 VA: 0x18290CE00
	public void .ctor(bool v) { }

	// RVA: 0x2881290 Offset: 0x287FC90 VA: 0x182881290
	public void .ctor(bool3x3 v) { }

	// RVA: 0x290CCB0 Offset: 0x290B6B0 VA: 0x18290CCB0
	public void .ctor(int v) { }

	// RVA: 0x290CD20 Offset: 0x290B720 VA: 0x18290CD20
	public void .ctor(int3x3 v) { }

	// RVA: 0x290CAA0 Offset: 0x290B4A0 VA: 0x18290CAA0
	public void .ctor(uint v) { }

	// RVA: 0x290CBD0 Offset: 0x290B5D0 VA: 0x18290CBD0
	public void .ctor(uint3x3 v) { }

	// RVA: 0x290C9C0 Offset: 0x290B3C0 VA: 0x18290C9C0
	public void .ctor(float v) { }

	// RVA: 0x290CB30 Offset: 0x290B530 VA: 0x18290CB30
	public void .ctor(float3x3 v) { }

	// RVA: 0x2893600 Offset: 0x2892000 VA: 0x182893600
	public static double3x3 op_Implicit(double v) { }

	// RVA: 0x2893450 Offset: 0x2891E50 VA: 0x182893450
	public static double3x3 op_Explicit(bool v) { }

	// RVA: 0x290D840 Offset: 0x290C240 VA: 0x18290D840
	public static double3x3 op_Explicit(bool3x3 v) { }

	// RVA: 0x28933E0 Offset: 0x2891DE0 VA: 0x1828933E0
	public static double3x3 op_Implicit(int v) { }

	// RVA: 0x2893310 Offset: 0x2891D10 VA: 0x182893310
	public static double3x3 op_Implicit(int3x3 v) { }

	// RVA: 0x2893280 Offset: 0x2891C80 VA: 0x182893280
	public static double3x3 op_Implicit(uint v) { }

	// RVA: 0x2893520 Offset: 0x2891F20 VA: 0x182893520
	public static double3x3 op_Implicit(uint3x3 v) { }

	// RVA: 0x2893040 Offset: 0x2891A40 VA: 0x182893040
	public static double3x3 op_Implicit(float v) { }

	// RVA: 0x2893180 Offset: 0x2891B80 VA: 0x182893180
	public static double3x3 op_Implicit(float3x3 v) { }

	// RVA: 0x290EB90 Offset: 0x290D590 VA: 0x18290EB90
	public static double3x3 op_Multiply(double3x3 lhs, double3x3 rhs) { }

	// RVA: 0x290EC90 Offset: 0x290D690 VA: 0x18290EC90
	public static double3x3 op_Multiply(double3x3 lhs, double rhs) { }

	// RVA: 0x290EAD0 Offset: 0x290D4D0 VA: 0x18290EAD0
	public static double3x3 op_Multiply(double lhs, double3x3 rhs) { }

	// RVA: 0x290CEE0 Offset: 0x290B8E0 VA: 0x18290CEE0
	public static double3x3 op_Addition(double3x3 lhs, double3x3 rhs) { }

	// RVA: 0x290D0A0 Offset: 0x290BAA0 VA: 0x18290D0A0
	public static double3x3 op_Addition(double3x3 lhs, double rhs) { }

	// RVA: 0x290CFE0 Offset: 0x290B9E0 VA: 0x18290CFE0
	public static double3x3 op_Addition(double lhs, double3x3 rhs) { }

	// RVA: 0x290EE30 Offset: 0x290D830 VA: 0x18290EE30
	public static double3x3 op_Subtraction(double3x3 lhs, double3x3 rhs) { }

	// RVA: 0x290EF30 Offset: 0x290D930 VA: 0x18290EF30
	public static double3x3 op_Subtraction(double3x3 lhs, double rhs) { }

	// RVA: 0x290ED50 Offset: 0x290D750 VA: 0x18290ED50
	public static double3x3 op_Subtraction(double lhs, double3x3 rhs) { }

	// RVA: 0x290D240 Offset: 0x290BC40 VA: 0x18290D240
	public static double3x3 op_Division(double3x3 lhs, double3x3 rhs) { }

	// RVA: 0x290D340 Offset: 0x290BD40 VA: 0x18290D340
	public static double3x3 op_Division(double3x3 lhs, double rhs) { }

	// RVA: 0x290D400 Offset: 0x290BE00 VA: 0x18290D400
	public static double3x3 op_Division(double lhs, double3x3 rhs) { }

	// RVA: 0x290E780 Offset: 0x290D180 VA: 0x18290E780
	public static double3x3 op_Modulus(double3x3 lhs, double3x3 rhs) { }

	// RVA: 0x290E5F0 Offset: 0x290CFF0 VA: 0x18290E5F0
	public static double3x3 op_Modulus(double3x3 lhs, double rhs) { }

	// RVA: 0x290E940 Offset: 0x290D340 VA: 0x18290E940
	public static double3x3 op_Modulus(double lhs, double3x3 rhs) { }

	// RVA: 0x290DD10 Offset: 0x290C710 VA: 0x18290DD10
	public static double3x3 op_Increment(double3x3 val) { }

	// RVA: 0x290D160 Offset: 0x290BB60 VA: 0x18290D160
	public static double3x3 op_Decrement(double3x3 val) { }

	// RVA: 0x290E450 Offset: 0x290CE50 VA: 0x18290E450
	public static bool3x3 op_LessThan(double3x3 lhs, double3x3 rhs) { }

	// RVA: 0x290E3A0 Offset: 0x290CDA0 VA: 0x18290E3A0
	public static bool3x3 op_LessThan(double3x3 lhs, double rhs) { }

	// RVA: 0x290E530 Offset: 0x290CF30 VA: 0x18290E530
	public static bool3x3 op_LessThan(double lhs, double3x3 rhs) { }

	// RVA: 0x290E210 Offset: 0x290CC10 VA: 0x18290E210
	public static bool3x3 op_LessThanOrEqual(double3x3 lhs, double3x3 rhs) { }

	// RVA: 0x290E2F0 Offset: 0x290CCF0 VA: 0x18290E2F0
	public static bool3x3 op_LessThanOrEqual(double3x3 lhs, double rhs) { }

	// RVA: 0x290E150 Offset: 0x290CB50 VA: 0x18290E150
	public static bool3x3 op_LessThanOrEqual(double lhs, double3x3 rhs) { }

	// RVA: 0x290DC30 Offset: 0x290C630 VA: 0x18290DC30
	public static bool3x3 op_GreaterThan(double3x3 lhs, double3x3 rhs) { }

	// RVA: 0x290DAD0 Offset: 0x290C4D0 VA: 0x18290DAD0
	public static bool3x3 op_GreaterThan(double3x3 lhs, double rhs) { }

	// RVA: 0x290DB80 Offset: 0x290C580 VA: 0x18290DB80
	public static bool3x3 op_GreaterThan(double lhs, double3x3 rhs) { }

	// RVA: 0x290D940 Offset: 0x290C340 VA: 0x18290D940
	public static bool3x3 op_GreaterThanOrEqual(double3x3 lhs, double3x3 rhs) { }

	// RVA: 0x290DA20 Offset: 0x290C420 VA: 0x18290DA20
	public static bool3x3 op_GreaterThanOrEqual(double3x3 lhs, double rhs) { }

	// RVA: 0x290D890 Offset: 0x290C290 VA: 0x18290D890
	public static bool3x3 op_GreaterThanOrEqual(double lhs, double3x3 rhs) { }

	// RVA: 0x290EFF0 Offset: 0x290D9F0 VA: 0x18290EFF0
	public static double3x3 op_UnaryNegation(double3x3 val) { }

	// RVA: 0x290F0B0 Offset: 0x290DAB0 VA: 0x18290F0B0
	public static double3x3 op_UnaryPlus(double3x3 val) { }

	// RVA: 0x290D5F0 Offset: 0x290BFF0 VA: 0x18290D5F0
	public static bool3x3 op_Equality(double3x3 lhs, double3x3 rhs) { }

	// RVA: 0x290D4E0 Offset: 0x290BEE0 VA: 0x18290D4E0
	public static bool3x3 op_Equality(double3x3 lhs, double rhs) { }

	// RVA: 0x290D730 Offset: 0x290C130 VA: 0x18290D730
	public static bool3x3 op_Equality(double lhs, double3x3 rhs) { }

	// RVA: 0x290DDF0 Offset: 0x290C7F0 VA: 0x18290DDF0
	public static bool3x3 op_Inequality(double3x3 lhs, double3x3 rhs) { }

	// RVA: 0x290DF30 Offset: 0x290C930 VA: 0x18290DF30
	public static bool3x3 op_Inequality(double3x3 lhs, double rhs) { }

	// RVA: 0x290E040 Offset: 0x290CA40 VA: 0x18290E040
	public static bool3x3 op_Inequality(double lhs, double3x3 rhs) { }

	// RVA: 0xF6D020 Offset: 0xF6BA20 VA: 0x180F6D020
	public ref double3 get_Item(int index) { }

	// RVA: 0x28FD260 Offset: 0x28FBC60 VA: 0x1828FD260 Slot: 4
	public bool Equals(double3x3 rhs) { }

	// RVA: 0x290C040 Offset: 0x290AA40 VA: 0x18290C040 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x290C100 Offset: 0x290AB00 VA: 0x18290C100 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x290C150 Offset: 0x290AB50 VA: 0x18290C150 Slot: 3
	public override string ToString() { }

	// RVA: 0x290C580 Offset: 0x290AF80 VA: 0x18290C580 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x290C960 Offset: 0x290B360 VA: 0x18290C960
	private static void .cctor() { }
}
