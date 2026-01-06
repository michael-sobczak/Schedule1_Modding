public struct double4x3 : IEquatable<double4x3>, IFormattable // TypeDefIndex: 10897
{
	// Fields
	public double4 c0; // 0x0
	public double4 c1; // 0x20
	public double4 c2; // 0x40
	public static readonly double4x3 zero; // 0x0

	// Properties
	public double4 Item { get; }

	// Methods

	// RVA: 0x291D600 Offset: 0x291C000 VA: 0x18291D600
	public void .ctor(double4 c0, double4 c1, double4 c2) { }

	// RVA: 0x291D500 Offset: 0x291BF00 VA: 0x18291D500
	public void .ctor(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22, double m30, double m31, double m32) { }

	// RVA: 0x291D1E0 Offset: 0x291BBE0 VA: 0x18291D1E0
	public void .ctor(double v) { }

	// RVA: 0x291D640 Offset: 0x291C040 VA: 0x18291D640
	public void .ctor(bool v) { }

	// RVA: 0x2881C40 Offset: 0x2880640 VA: 0x182881C40
	public void .ctor(bool4x3 v) { }

	// RVA: 0x291D590 Offset: 0x291BF90 VA: 0x18291D590
	public void .ctor(int v) { }

	// RVA: 0x291D2F0 Offset: 0x291BCF0 VA: 0x18291D2F0
	public void .ctor(int4x3 v) { }

	// RVA: 0x2881B90 Offset: 0x2880590 VA: 0x182881B90
	public void .ctor(uint v) { }

	// RVA: 0x291D3C0 Offset: 0x291BDC0 VA: 0x18291D3C0
	public void .ctor(uint4x3 v) { }

	// RVA: 0x291D4A0 Offset: 0x291BEA0 VA: 0x18291D4A0
	public void .ctor(float v) { }

	// RVA: 0x291D230 Offset: 0x291BC30 VA: 0x18291D230
	public void .ctor(float4x3 v) { }

	// RVA: 0x2894870 Offset: 0x2893270 VA: 0x182894870
	public static double4x3 op_Implicit(double v) { }

	// RVA: 0x2894CD0 Offset: 0x28936D0 VA: 0x182894CD0
	public static double4x3 op_Explicit(bool v) { }

	// RVA: 0x291E380 Offset: 0x291CD80 VA: 0x18291E380
	public static double4x3 op_Explicit(bool4x3 v) { }

	// RVA: 0x2894AA0 Offset: 0x28934A0 VA: 0x182894AA0
	public static double4x3 op_Implicit(int v) { }

	// RVA: 0x2894C00 Offset: 0x2893600 VA: 0x182894C00
	public static double4x3 op_Implicit(int4x3 v) { }

	// RVA: 0x2894B50 Offset: 0x2893550 VA: 0x182894B50
	public static double4x3 op_Implicit(uint v) { }

	// RVA: 0x2894790 Offset: 0x2893190 VA: 0x182894790
	public static double4x3 op_Implicit(uint4x3 v) { }

	// RVA: 0x2894D30 Offset: 0x2893730 VA: 0x182894D30
	public static double4x3 op_Implicit(float v) { }

	// RVA: 0x2894D90 Offset: 0x2893790 VA: 0x182894D90
	public static double4x3 op_Implicit(float4x3 v) { }

	// RVA: 0x291F940 Offset: 0x291E340 VA: 0x18291F940
	public static double4x3 op_Multiply(double4x3 lhs, double4x3 rhs) { }

	// RVA: 0x291FAA0 Offset: 0x291E4A0 VA: 0x18291FAA0
	public static double4x3 op_Multiply(double4x3 lhs, double rhs) { }

	// RVA: 0x291FBB0 Offset: 0x291E5B0 VA: 0x18291FBB0
	public static double4x3 op_Multiply(double lhs, double4x3 rhs) { }

	// RVA: 0x291D7B0 Offset: 0x291C1B0 VA: 0x18291D7B0
	public static double4x3 op_Addition(double4x3 lhs, double4x3 rhs) { }

	// RVA: 0x291D6A0 Offset: 0x291C0A0 VA: 0x18291D6A0
	public static double4x3 op_Addition(double4x3 lhs, double rhs) { }

	// RVA: 0x291D910 Offset: 0x291C310 VA: 0x18291D910
	public static double4x3 op_Addition(double lhs, double4x3 rhs) { }

	// RVA: 0x291FF30 Offset: 0x291E930 VA: 0x18291FF30
	public static double4x3 op_Subtraction(double4x3 lhs, double4x3 rhs) { }

	// RVA: 0x291FE20 Offset: 0x291E820 VA: 0x18291FE20
	public static double4x3 op_Subtraction(double4x3 lhs, double rhs) { }

	// RVA: 0x291FCD0 Offset: 0x291E6D0 VA: 0x18291FCD0
	public static double4x3 op_Subtraction(double lhs, double4x3 rhs) { }

	// RVA: 0x291DB70 Offset: 0x291C570 VA: 0x18291DB70
	public static double4x3 op_Division(double4x3 lhs, double4x3 rhs) { }

	// RVA: 0x291DCE0 Offset: 0x291C6E0 VA: 0x18291DCE0
	public static double4x3 op_Division(double4x3 lhs, double rhs) { }

	// RVA: 0x291DDF0 Offset: 0x291C7F0 VA: 0x18291DDF0
	public static double4x3 op_Division(double lhs, double4x3 rhs) { }

	// RVA: 0x291F310 Offset: 0x291DD10 VA: 0x18291F310
	public static double4x3 op_Modulus(double4x3 lhs, double4x3 rhs) { }

	// RVA: 0x291F540 Offset: 0x291DF40 VA: 0x18291F540
	public static double4x3 op_Modulus(double4x3 lhs, double rhs) { }

	// RVA: 0x291F740 Offset: 0x291E140 VA: 0x18291F740
	public static double4x3 op_Modulus(double lhs, double4x3 rhs) { }

	// RVA: 0x291E8B0 Offset: 0x291D2B0 VA: 0x18291E8B0
	public static double4x3 op_Increment(double4x3 val) { }

	// RVA: 0x291DA30 Offset: 0x291C430 VA: 0x18291DA30
	public static double4x3 op_Decrement(double4x3 val) { }

	// RVA: 0x291F0A0 Offset: 0x291DAA0 VA: 0x18291F0A0
	public static bool4x3 op_LessThan(double4x3 lhs, double4x3 rhs) { }

	// RVA: 0x291F190 Offset: 0x291DB90 VA: 0x18291F190
	public static bool4x3 op_LessThan(double4x3 lhs, double rhs) { }

	// RVA: 0x291F250 Offset: 0x291DC50 VA: 0x18291F250
	public static bool4x3 op_LessThan(double lhs, double4x3 rhs) { }

	// RVA: 0x291EE30 Offset: 0x291D830 VA: 0x18291EE30
	public static bool4x3 op_LessThanOrEqual(double4x3 lhs, double4x3 rhs) { }

	// RVA: 0x291EF20 Offset: 0x291D920 VA: 0x18291EF20
	public static bool4x3 op_LessThanOrEqual(double4x3 lhs, double rhs) { }

	// RVA: 0x291EFE0 Offset: 0x291D9E0 VA: 0x18291EFE0
	public static bool4x3 op_LessThanOrEqual(double lhs, double4x3 rhs) { }

	// RVA: 0x291E700 Offset: 0x291D100 VA: 0x18291E700
	public static bool4x3 op_GreaterThan(double4x3 lhs, double4x3 rhs) { }

	// RVA: 0x291E640 Offset: 0x291D040 VA: 0x18291E640
	public static bool4x3 op_GreaterThan(double4x3 lhs, double rhs) { }

	// RVA: 0x291E7F0 Offset: 0x291D1F0 VA: 0x18291E7F0
	public static bool4x3 op_GreaterThan(double lhs, double4x3 rhs) { }

	// RVA: 0x291E3D0 Offset: 0x291CDD0 VA: 0x18291E3D0
	public static bool4x3 op_GreaterThanOrEqual(double4x3 lhs, double4x3 rhs) { }

	// RVA: 0x291E4C0 Offset: 0x291CEC0 VA: 0x18291E4C0
	public static bool4x3 op_GreaterThanOrEqual(double4x3 lhs, double rhs) { }

	// RVA: 0x291E580 Offset: 0x291CF80 VA: 0x18291E580
	public static bool4x3 op_GreaterThanOrEqual(double lhs, double4x3 rhs) { }

	// RVA: 0x29200A0 Offset: 0x291EAA0 VA: 0x1829200A0
	public static double4x3 op_UnaryNegation(double4x3 val) { }

	// RVA: 0x29201B0 Offset: 0x291EBB0 VA: 0x1829201B0
	public static double4x3 op_UnaryPlus(double4x3 val) { }

	// RVA: 0x291DF40 Offset: 0x291C940 VA: 0x18291DF40
	public static bool4x3 op_Equality(double4x3 lhs, double4x3 rhs) { }

	// RVA: 0x291E0E0 Offset: 0x291CAE0 VA: 0x18291E0E0
	public static bool4x3 op_Equality(double4x3 lhs, double rhs) { }

	// RVA: 0x291E230 Offset: 0x291CC30 VA: 0x18291E230
	public static bool4x3 op_Equality(double lhs, double4x3 rhs) { }

	// RVA: 0x291E9F0 Offset: 0x291D3F0 VA: 0x18291E9F0
	public static bool4x3 op_Inequality(double4x3 lhs, double4x3 rhs) { }

	// RVA: 0x291EB90 Offset: 0x291D590 VA: 0x18291EB90
	public static bool4x3 op_Inequality(double4x3 lhs, double rhs) { }

	// RVA: 0x291ECE0 Offset: 0x291D6E0 VA: 0x18291ECE0
	public static bool4x3 op_Inequality(double lhs, double4x3 rhs) { }

	// RVA: 0xF6D010 Offset: 0xF6BA10 VA: 0x180F6D010
	public ref double4 get_Item(int index) { }

	// RVA: 0x29107F0 Offset: 0x290F1F0 VA: 0x1829107F0 Slot: 4
	public bool Equals(double4x3 rhs) { }

	// RVA: 0x291C680 Offset: 0x291B080 VA: 0x18291C680 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x291C760 Offset: 0x291B160 VA: 0x18291C760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x291CCA0 Offset: 0x291B6A0 VA: 0x18291CCA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x291C7B0 Offset: 0x291B1B0 VA: 0x18291C7B0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
