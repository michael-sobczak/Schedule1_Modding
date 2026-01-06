public struct double2x3 : IEquatable<double2x3>, IFormattable // TypeDefIndex: 10887
{
	// Fields
	public double2 c0; // 0x0
	public double2 c1; // 0x10
	public double2 c2; // 0x20
	public static readonly double2x3 zero; // 0x0

	// Properties
	public double2 Item { get; }

	// Methods

	// RVA: 0x133AD50 Offset: 0x1339750 VA: 0x18133AD50
	public void .ctor(double2 c0, double2 c1, double2 c2) { }

	// RVA: 0x2904980 Offset: 0x2903380 VA: 0x182904980
	public void .ctor(double m00, double m01, double m02, double m10, double m11, double m12) { }

	// RVA: 0x2904880 Offset: 0x2903280 VA: 0x182904880
	public void .ctor(double v) { }

	// RVA: 0x2904890 Offset: 0x2903290 VA: 0x182904890
	public void .ctor(bool v) { }

	// RVA: 0x29048C0 Offset: 0x29032C0 VA: 0x1829048C0
	public void .ctor(bool2x3 v) { }

	// RVA: 0x2904A70 Offset: 0x2903470 VA: 0x182904A70
	public void .ctor(int v) { }

	// RVA: 0x2904790 Offset: 0x2903190 VA: 0x182904790
	public void .ctor(int2x3 v) { }

	// RVA: 0x2904A10 Offset: 0x2903410 VA: 0x182904A10
	public void .ctor(uint v) { }

	// RVA: 0x2904800 Offset: 0x2903200 VA: 0x182904800
	public void .ctor(uint2x3 v) { }

	// RVA: 0x2904940 Offset: 0x2903340 VA: 0x182904940
	public void .ctor(float v) { }

	// RVA: 0x29049B0 Offset: 0x29033B0 VA: 0x1829049B0
	public void .ctor(float2x3 v) { }

	// RVA: 0x2891D40 Offset: 0x2890740 VA: 0x182891D40
	public static double2x3 op_Implicit(double v) { }

	// RVA: 0x2891DE0 Offset: 0x28907E0 VA: 0x182891DE0
	public static double2x3 op_Explicit(bool v) { }

	// RVA: 0x2891F30 Offset: 0x2890930 VA: 0x182891F30
	public static double2x3 op_Explicit(bool2x3 v) { }

	// RVA: 0x2891E10 Offset: 0x2890810 VA: 0x182891E10
	public static double2x3 op_Implicit(int v) { }

	// RVA: 0x2891FF0 Offset: 0x28909F0 VA: 0x182891FF0
	public static double2x3 op_Implicit(int2x3 v) { }

	// RVA: 0x2891C90 Offset: 0x2890690 VA: 0x182891C90
	public static double2x3 op_Implicit(uint v) { }

	// RVA: 0x2891E70 Offset: 0x2890870 VA: 0x182891E70
	public static double2x3 op_Implicit(uint2x3 v) { }

	// RVA: 0x2891CF0 Offset: 0x28906F0 VA: 0x182891CF0
	public static double2x3 op_Implicit(float v) { }

	// RVA: 0x2891D60 Offset: 0x2890760 VA: 0x182891D60
	public static double2x3 op_Implicit(float2x3 v) { }

	// RVA: 0x29059E0 Offset: 0x29043E0 VA: 0x1829059E0
	public static double2x3 op_Multiply(double2x3 lhs, double2x3 rhs) { }

	// RVA: 0x2905A50 Offset: 0x2904450 VA: 0x182905A50
	public static double2x3 op_Multiply(double2x3 lhs, double rhs) { }

	// RVA: 0x2905990 Offset: 0x2904390 VA: 0x182905990
	public static double2x3 op_Multiply(double lhs, double2x3 rhs) { }

	// RVA: 0x2904B50 Offset: 0x2903550 VA: 0x182904B50
	public static double2x3 op_Addition(double2x3 lhs, double2x3 rhs) { }

	// RVA: 0x2904B10 Offset: 0x2903510 VA: 0x182904B10
	public static double2x3 op_Addition(double2x3 lhs, double rhs) { }

	// RVA: 0x2904AC0 Offset: 0x29034C0 VA: 0x182904AC0
	public static double2x3 op_Addition(double lhs, double2x3 rhs) { }

	// RVA: 0x2905B30 Offset: 0x2904530 VA: 0x182905B30
	public static double2x3 op_Subtraction(double2x3 lhs, double2x3 rhs) { }

	// RVA: 0x2905A90 Offset: 0x2904490 VA: 0x182905A90
	public static double2x3 op_Subtraction(double2x3 lhs, double rhs) { }

	// RVA: 0x2905AD0 Offset: 0x29044D0 VA: 0x182905AD0
	public static double2x3 op_Subtraction(double lhs, double2x3 rhs) { }

	// RVA: 0x2904CD0 Offset: 0x29036D0 VA: 0x182904CD0
	public static double2x3 op_Division(double2x3 lhs, double2x3 rhs) { }

	// RVA: 0x2904C30 Offset: 0x2903630 VA: 0x182904C30
	public static double2x3 op_Division(double2x3 lhs, double rhs) { }

	// RVA: 0x2904C70 Offset: 0x2903670 VA: 0x182904C70
	public static double2x3 op_Division(double lhs, double2x3 rhs) { }

	// RVA: 0x2905820 Offset: 0x2904220 VA: 0x182905820
	public static double2x3 op_Modulus(double2x3 lhs, double2x3 rhs) { }

	// RVA: 0x29058E0 Offset: 0x29042E0 VA: 0x1829058E0
	public static double2x3 op_Modulus(double2x3 lhs, double rhs) { }

	// RVA: 0x2905770 Offset: 0x2904170 VA: 0x182905770
	public static double2x3 op_Modulus(double lhs, double2x3 rhs) { }

	// RVA: 0x2905220 Offset: 0x2903C20 VA: 0x182905220
	public static double2x3 op_Increment(double2x3 val) { }

	// RVA: 0x2904BC0 Offset: 0x29035C0 VA: 0x182904BC0
	public static double2x3 op_Decrement(double2x3 val) { }

	// RVA: 0x2905690 Offset: 0x2904090 VA: 0x182905690
	public static bool2x3 op_LessThan(double2x3 lhs, double2x3 rhs) { }

	// RVA: 0x2905710 Offset: 0x2904110 VA: 0x182905710
	public static bool2x3 op_LessThan(double2x3 lhs, double rhs) { }

	// RVA: 0x2905610 Offset: 0x2904010 VA: 0x182905610
	public static bool2x3 op_LessThan(double lhs, double2x3 rhs) { }

	// RVA: 0x2905590 Offset: 0x2903F90 VA: 0x182905590
	public static bool2x3 op_LessThanOrEqual(double2x3 lhs, double2x3 rhs) { }

	// RVA: 0x29054B0 Offset: 0x2903EB0 VA: 0x1829054B0
	public static bool2x3 op_LessThanOrEqual(double2x3 lhs, double rhs) { }

	// RVA: 0x2905510 Offset: 0x2903F10 VA: 0x182905510
	public static bool2x3 op_LessThanOrEqual(double lhs, double2x3 rhs) { }

	// RVA: 0x29051A0 Offset: 0x2903BA0 VA: 0x1829051A0
	public static bool2x3 op_GreaterThan(double2x3 lhs, double2x3 rhs) { }

	// RVA: 0x2905130 Offset: 0x2903B30 VA: 0x182905130
	public static bool2x3 op_GreaterThan(double2x3 lhs, double rhs) { }

	// RVA: 0x29050C0 Offset: 0x2903AC0 VA: 0x1829050C0
	public static bool2x3 op_GreaterThan(double lhs, double2x3 rhs) { }

	// RVA: 0x2904F60 Offset: 0x2903960 VA: 0x182904F60
	public static bool2x3 op_GreaterThanOrEqual(double2x3 lhs, double2x3 rhs) { }

	// RVA: 0x2905050 Offset: 0x2903A50 VA: 0x182905050
	public static bool2x3 op_GreaterThanOrEqual(double2x3 lhs, double rhs) { }

	// RVA: 0x2904FE0 Offset: 0x29039E0 VA: 0x182904FE0
	public static bool2x3 op_GreaterThanOrEqual(double lhs, double2x3 rhs) { }

	// RVA: 0x2905BA0 Offset: 0x29045A0 VA: 0x182905BA0
	public static double2x3 op_UnaryNegation(double2x3 val) { }

	// RVA: 0x2905BE0 Offset: 0x29045E0 VA: 0x182905BE0
	public static double2x3 op_UnaryPlus(double2x3 val) { }

	// RVA: 0x2904E90 Offset: 0x2903890 VA: 0x182904E90
	public static bool2x3 op_Equality(double2x3 lhs, double2x3 rhs) { }

	// RVA: 0x2904D40 Offset: 0x2903740 VA: 0x182904D40
	public static bool2x3 op_Equality(double2x3 lhs, double rhs) { }

	// RVA: 0x2904DF0 Offset: 0x29037F0 VA: 0x182904DF0
	public static bool2x3 op_Equality(double lhs, double2x3 rhs) { }

	// RVA: 0x2905340 Offset: 0x2903D40 VA: 0x182905340
	public static bool2x3 op_Inequality(double2x3 lhs, double2x3 rhs) { }

	// RVA: 0x2905290 Offset: 0x2903C90 VA: 0x182905290
	public static bool2x3 op_Inequality(double2x3 lhs, double rhs) { }

	// RVA: 0x2905410 Offset: 0x2903E10 VA: 0x182905410
	public static bool2x3 op_Inequality(double lhs, double2x3 rhs) { }

	// RVA: 0xF6D000 Offset: 0xF6BA00 VA: 0x180F6D000
	public ref double2 get_Item(int index) { }

	// RVA: 0x2904030 Offset: 0x2902A30 VA: 0x182904030 Slot: 4
	public bool Equals(double2x3 rhs) { }

	// RVA: 0x29040B0 Offset: 0x2902AB0 VA: 0x1829040B0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x29041A0 Offset: 0x2902BA0 VA: 0x1829041A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x29044A0 Offset: 0x2902EA0 VA: 0x1829044A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x29041D0 Offset: 0x2902BD0 VA: 0x1829041D0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
