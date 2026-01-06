public struct double4x4 : IEquatable<double4x4>, IFormattable // TypeDefIndex: 10898
{
	// Fields
	public double4 c0; // 0x0
	public double4 c1; // 0x20
	public double4 c2; // 0x40
	public double4 c3; // 0x60
	public static readonly double4x4 identity; // 0x0
	public static readonly double4x4 zero; // 0x80

	// Properties
	public double4 Item { get; }

	// Methods

	// RVA: 0x2921310 Offset: 0x291FD10 VA: 0x182921310
	public void .ctor(double4 c0, double4 c1, double4 c2, double4 c3) { }

	// RVA: 0x29213F0 Offset: 0x291FDF0 VA: 0x1829213F0
	public void .ctor(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33) { }

	// RVA: 0x2921240 Offset: 0x291FC40 VA: 0x182921240
	public void .ctor(double v) { }

	// RVA: 0x29212A0 Offset: 0x291FCA0 VA: 0x1829212A0
	public void .ctor(bool v) { }

	// RVA: 0x2882050 Offset: 0x2880A50 VA: 0x182882050
	public void .ctor(bool4x4 v) { }

	// RVA: 0x2921360 Offset: 0x291FD60 VA: 0x182921360
	public void .ctor(int v) { }

	// RVA: 0x28821A0 Offset: 0x2880BA0 VA: 0x1828821A0
	public void .ctor(int4x4 v) { }

	// RVA: 0x2881F70 Offset: 0x2880970 VA: 0x182881F70
	public void .ctor(uint v) { }

	// RVA: 0x2881E40 Offset: 0x2880840 VA: 0x182881E40
	public void .ctor(uint4x4 v) { }

	// RVA: 0x29211D0 Offset: 0x291FBD0 VA: 0x1829211D0
	public void .ctor(float v) { }

	// RVA: 0x2881D40 Offset: 0x2880740 VA: 0x182881D40
	public void .ctor(float4x4 v) { }

	// RVA: 0x2894F50 Offset: 0x2893950 VA: 0x182894F50
	public static double4x4 op_Implicit(double v) { }

	// RVA: 0x2894FB0 Offset: 0x28939B0 VA: 0x182894FB0
	public static double4x4 op_Explicit(bool v) { }

	// RVA: 0x2895450 Offset: 0x2893E50 VA: 0x182895450
	public static double4x4 op_Explicit(bool4x4 v) { }

	// RVA: 0x28954A0 Offset: 0x2893EA0 VA: 0x1828954A0
	public static double4x4 op_Implicit(int v) { }

	// RVA: 0x2922CE0 Offset: 0x29216E0 VA: 0x182922CE0
	public static double4x4 op_Implicit(int4x4 v) { }

	// RVA: 0x2922DC0 Offset: 0x29217C0 VA: 0x182922DC0
	public static double4x4 op_Implicit(uint v) { }

	// RVA: 0x2922D50 Offset: 0x2921750 VA: 0x182922D50
	public static double4x4 op_Implicit(uint4x4 v) { }

	// RVA: 0x28953D0 Offset: 0x2893DD0 VA: 0x1828953D0
	public static double4x4 op_Implicit(float v) { }

	// RVA: 0x2922E00 Offset: 0x2921800 VA: 0x182922E00
	public static double4x4 op_Implicit(float4x4 v) { }

	// RVA: 0x2924750 Offset: 0x2923150 VA: 0x182924750
	public static double4x4 op_Multiply(double4x4 lhs, double4x4 rhs) { }

	// RVA: 0x2924430 Offset: 0x2922E30 VA: 0x182924430
	public static double4x4 op_Multiply(double4x4 lhs, double rhs) { }

	// RVA: 0x29245C0 Offset: 0x2922FC0 VA: 0x1829245C0
	public static double4x4 op_Multiply(double lhs, double4x4 rhs) { }

	// RVA: 0x29217E0 Offset: 0x29201E0 VA: 0x1829217E0
	public static double4x4 op_Addition(double4x4 lhs, double4x4 rhs) { }

	// RVA: 0x2921650 Offset: 0x2920050 VA: 0x182921650
	public static double4x4 op_Addition(double4x4 lhs, double rhs) { }

	// RVA: 0x29214C0 Offset: 0x291FEC0 VA: 0x1829214C0
	public static double4x4 op_Addition(double lhs, double4x4 rhs) { }

	// RVA: 0x2924930 Offset: 0x2923330 VA: 0x182924930
	public static double4x4 op_Subtraction(double4x4 lhs, double4x4 rhs) { }

	// RVA: 0x2924CD0 Offset: 0x29236D0 VA: 0x182924CD0
	public static double4x4 op_Subtraction(double4x4 lhs, double rhs) { }

	// RVA: 0x2924B10 Offset: 0x2923510 VA: 0x182924B10
	public static double4x4 op_Subtraction(double lhs, double4x4 rhs) { }

	// RVA: 0x2921EE0 Offset: 0x29208E0 VA: 0x182921EE0
	public static double4x4 op_Division(double4x4 lhs, double4x4 rhs) { }

	// RVA: 0x2921D50 Offset: 0x2920750 VA: 0x182921D50
	public static double4x4 op_Division(double4x4 lhs, double rhs) { }

	// RVA: 0x2921B90 Offset: 0x2920590 VA: 0x182921B90
	public static double4x4 op_Division(double lhs, double4x4 rhs) { }

	// RVA: 0x2924160 Offset: 0x2922B60 VA: 0x182924160
	public static double4x4 op_Modulus(double4x4 lhs, double4x4 rhs) { }

	// RVA: 0x2923EE0 Offset: 0x29228E0 VA: 0x182923EE0
	public static double4x4 op_Modulus(double4x4 lhs, double rhs) { }

	// RVA: 0x2923C60 Offset: 0x2922660 VA: 0x182923C60
	public static double4x4 op_Modulus(double lhs, double4x4 rhs) { }

	// RVA: 0x2922E70 Offset: 0x2921870 VA: 0x182922E70
	public static double4x4 op_Increment(double4x4 val) { }

	// RVA: 0x29219C0 Offset: 0x29203C0 VA: 0x1829219C0
	public static double4x4 op_Decrement(double4x4 val) { }

	// RVA: 0x2923B20 Offset: 0x2922520 VA: 0x182923B20
	public static bool4x4 op_LessThan(double4x4 lhs, double4x4 rhs) { }

	// RVA: 0x2923A20 Offset: 0x2922420 VA: 0x182923A20
	public static bool4x4 op_LessThan(double4x4 lhs, double rhs) { }

	// RVA: 0x2923920 Offset: 0x2922320 VA: 0x182923920
	public static bool4x4 op_LessThan(double lhs, double4x4 rhs) { }

	// RVA: 0x29235E0 Offset: 0x2921FE0 VA: 0x1829235E0
	public static bool4x4 op_LessThanOrEqual(double4x4 lhs, double4x4 rhs) { }

	// RVA: 0x2923820 Offset: 0x2922220 VA: 0x182923820
	public static bool4x4 op_LessThanOrEqual(double4x4 lhs, double rhs) { }

	// RVA: 0x2923720 Offset: 0x2922120 VA: 0x182923720
	public static bool4x4 op_LessThanOrEqual(double lhs, double4x4 rhs) { }

	// RVA: 0x2922AA0 Offset: 0x29214A0 VA: 0x182922AA0
	public static bool4x4 op_GreaterThan(double4x4 lhs, double4x4 rhs) { }

	// RVA: 0x29229A0 Offset: 0x29213A0 VA: 0x1829229A0
	public static bool4x4 op_GreaterThan(double4x4 lhs, double rhs) { }

	// RVA: 0x2922BE0 Offset: 0x29215E0 VA: 0x182922BE0
	public static bool4x4 op_GreaterThan(double lhs, double4x4 rhs) { }

	// RVA: 0x2922860 Offset: 0x2921260 VA: 0x182922860
	public static bool4x4 op_GreaterThanOrEqual(double4x4 lhs, double4x4 rhs) { }

	// RVA: 0x2922760 Offset: 0x2921160 VA: 0x182922760
	public static bool4x4 op_GreaterThanOrEqual(double4x4 lhs, double rhs) { }

	// RVA: 0x2922660 Offset: 0x2921060 VA: 0x182922660
	public static bool4x4 op_GreaterThanOrEqual(double lhs, double4x4 rhs) { }

	// RVA: 0x2924E60 Offset: 0x2923860 VA: 0x182924E60
	public static double4x4 op_UnaryNegation(double4x4 val) { }

	// RVA: 0x2924FE0 Offset: 0x29239E0 VA: 0x182924FE0
	public static double4x4 op_UnaryPlus(double4x4 val) { }

	// RVA: 0x2922440 Offset: 0x2920E40 VA: 0x182922440
	public static bool4x4 op_Equality(double4x4 lhs, double4x4 rhs) { }

	// RVA: 0x2922280 Offset: 0x2920C80 VA: 0x182922280
	public static bool4x4 op_Equality(double4x4 lhs, double rhs) { }

	// RVA: 0x29220C0 Offset: 0x2920AC0 VA: 0x1829220C0
	public static bool4x4 op_Equality(double lhs, double4x4 rhs) { }

	// RVA: 0x29233C0 Offset: 0x2921DC0 VA: 0x1829233C0
	public static bool4x4 op_Inequality(double4x4 lhs, double4x4 rhs) { }

	// RVA: 0x2923040 Offset: 0x2921A40 VA: 0x182923040
	public static bool4x4 op_Inequality(double4x4 lhs, double rhs) { }

	// RVA: 0x2923200 Offset: 0x2921C00 VA: 0x182923200
	public static bool4x4 op_Inequality(double lhs, double4x4 rhs) { }

	// RVA: 0xF6D010 Offset: 0xF6BA10 VA: 0x180F6D010
	public ref double4 get_Item(int index) { }

	// RVA: 0x2911320 Offset: 0x290FD20 VA: 0x182911320 Slot: 4
	public bool Equals(double4x4 rhs) { }

	// RVA: 0x2920290 Offset: 0x291EC90 VA: 0x182920290 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2920390 Offset: 0x291ED90 VA: 0x182920390 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2920A70 Offset: 0x291F470 VA: 0x182920A70 Slot: 3
	public override string ToString() { }

	// RVA: 0x29203F0 Offset: 0x291EDF0 VA: 0x1829203F0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2921160 Offset: 0x291FB60 VA: 0x182921160
	private static void .cctor() { }
}
