public struct double2x4 : IEquatable<double2x4>, IFormattable // TypeDefIndex: 10888
{
	// Fields
	public double2 c0; // 0x0
	public double2 c1; // 0x10
	public double2 c2; // 0x20
	public double2 c3; // 0x30
	public static readonly double2x4 zero; // 0x0

	// Properties
	public double2 Item { get; }

	// Methods

	// RVA: 0x28F5170 Offset: 0x28F3B70 VA: 0x1828F5170
	public void .ctor(double2 c0, double2 c1, double2 c2, double2 c3) { }

	// RVA: 0x2906780 Offset: 0x2905180 VA: 0x182906780
	public void .ctor(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13) { }

	// RVA: 0x29067D0 Offset: 0x29051D0 VA: 0x1829067D0
	public void .ctor(double v) { }

	// RVA: 0x2906740 Offset: 0x2905140 VA: 0x182906740
	public void .ctor(bool v) { }

	// RVA: 0x2880EF0 Offset: 0x287F8F0 VA: 0x182880EF0
	public void .ctor(bool2x4 v) { }

	// RVA: 0x2906660 Offset: 0x2905060 VA: 0x182906660
	public void .ctor(int v) { }

	// RVA: 0x2906870 Offset: 0x2905270 VA: 0x182906870
	public void .ctor(int2x4 v) { }

	// RVA: 0x29067F0 Offset: 0x29051F0 VA: 0x1829067F0
	public void .ctor(uint v) { }

	// RVA: 0x29065C0 Offset: 0x2904FC0 VA: 0x1829065C0
	public void .ctor(uint2x4 v) { }

	// RVA: 0x2906560 Offset: 0x2904F60 VA: 0x182906560
	public void .ctor(float v) { }

	// RVA: 0x29066C0 Offset: 0x29050C0 VA: 0x1829066C0
	public void .ctor(float2x4 v) { }

	// RVA: 0x2892410 Offset: 0x2890E10 VA: 0x182892410
	public static double2x4 op_Implicit(double v) { }

	// RVA: 0x2892160 Offset: 0x2890B60 VA: 0x182892160
	public static double2x4 op_Explicit(bool v) { }

	// RVA: 0x2906FE0 Offset: 0x29059E0 VA: 0x182906FE0
	public static double2x4 op_Explicit(bool2x4 v) { }

	// RVA: 0x28925C0 Offset: 0x2890FC0 VA: 0x1828925C0
	public static double2x4 op_Implicit(int v) { }

	// RVA: 0x2892340 Offset: 0x2890D40 VA: 0x182892340
	public static double2x4 op_Implicit(int2x4 v) { }

	// RVA: 0x28924A0 Offset: 0x2890EA0 VA: 0x1828924A0
	public static double2x4 op_Implicit(uint v) { }

	// RVA: 0x28921A0 Offset: 0x2890BA0 VA: 0x1828921A0
	public static double2x4 op_Implicit(uint2x4 v) { }

	// RVA: 0x2892430 Offset: 0x2890E30 VA: 0x182892430
	public static double2x4 op_Implicit(float v) { }

	// RVA: 0x2892520 Offset: 0x2890F20 VA: 0x182892520
	public static double2x4 op_Implicit(float2x4 v) { }

	// RVA: 0x2908290 Offset: 0x2906C90 VA: 0x182908290
	public static double2x4 op_Multiply(double2x4 lhs, double2x4 rhs) { }

	// RVA: 0x29081E0 Offset: 0x2906BE0 VA: 0x1829081E0
	public static double2x4 op_Multiply(double2x4 lhs, double rhs) { }

	// RVA: 0x2908230 Offset: 0x2906C30 VA: 0x182908230
	public static double2x4 op_Multiply(double lhs, double2x4 rhs) { }

	// RVA: 0x29069B0 Offset: 0x29053B0 VA: 0x1829069B0
	public static double2x4 op_Addition(double2x4 lhs, double2x4 rhs) { }

	// RVA: 0x2906960 Offset: 0x2905360 VA: 0x182906960
	public static double2x4 op_Addition(double2x4 lhs, double rhs) { }

	// RVA: 0x2906900 Offset: 0x2905300 VA: 0x182906900
	public static double2x4 op_Addition(double lhs, double2x4 rhs) { }

	// RVA: 0x29083A0 Offset: 0x2906DA0 VA: 0x1829083A0
	public static double2x4 op_Subtraction(double2x4 lhs, double2x4 rhs) { }

	// RVA: 0x2908430 Offset: 0x2906E30 VA: 0x182908430
	public static double2x4 op_Subtraction(double2x4 lhs, double rhs) { }

	// RVA: 0x2908320 Offset: 0x2906D20 VA: 0x182908320
	public static double2x4 op_Subtraction(double lhs, double2x4 rhs) { }

	// RVA: 0x2906B40 Offset: 0x2905540 VA: 0x182906B40
	public static double2x4 op_Division(double2x4 lhs, double2x4 rhs) { }

	// RVA: 0x2906AF0 Offset: 0x29054F0 VA: 0x182906AF0
	public static double2x4 op_Division(double2x4 lhs, double rhs) { }

	// RVA: 0x2906BD0 Offset: 0x29055D0 VA: 0x182906BD0
	public static double2x4 op_Division(double lhs, double2x4 rhs) { }

	// RVA: 0x2908020 Offset: 0x2906A20 VA: 0x182908020
	public static double2x4 op_Modulus(double2x4 lhs, double2x4 rhs) { }

	// RVA: 0x2908110 Offset: 0x2906B10 VA: 0x182908110
	public static double2x4 op_Modulus(double2x4 lhs, double rhs) { }

	// RVA: 0x2907F50 Offset: 0x2906950 VA: 0x182907F50
	public static double2x4 op_Modulus(double lhs, double2x4 rhs) { }

	// RVA: 0x2907590 Offset: 0x2905F90 VA: 0x182907590
	public static double2x4 op_Increment(double2x4 val) { }

	// RVA: 0x2906A40 Offset: 0x2905440 VA: 0x182906A40
	public static double2x4 op_Decrement(double2x4 val) { }

	// RVA: 0x2907D60 Offset: 0x2906760 VA: 0x182907D60
	public static bool2x4 op_LessThan(double2x4 lhs, double2x4 rhs) { }

	// RVA: 0x2907C90 Offset: 0x2906690 VA: 0x182907C90
	public static bool2x4 op_LessThan(double2x4 lhs, double rhs) { }

	// RVA: 0x2907E60 Offset: 0x2906860 VA: 0x182907E60
	public static bool2x4 op_LessThan(double lhs, double2x4 rhs) { }

	// RVA: 0x2907B90 Offset: 0x2906590 VA: 0x182907B90
	public static bool2x4 op_LessThanOrEqual(double2x4 lhs, double2x4 rhs) { }

	// RVA: 0x2907AC0 Offset: 0x29064C0 VA: 0x182907AC0
	public static bool2x4 op_LessThanOrEqual(double2x4 lhs, double rhs) { }

	// RVA: 0x29079D0 Offset: 0x29063D0 VA: 0x1829079D0
	public static bool2x4 op_LessThanOrEqual(double lhs, double2x4 rhs) { }

	// RVA: 0x29073A0 Offset: 0x2905DA0 VA: 0x1829073A0
	public static bool2x4 op_GreaterThan(double2x4 lhs, double2x4 rhs) { }

	// RVA: 0x29074A0 Offset: 0x2905EA0 VA: 0x1829074A0
	public static bool2x4 op_GreaterThan(double2x4 lhs, double rhs) { }

	// RVA: 0x29072D0 Offset: 0x2905CD0 VA: 0x1829072D0
	public static bool2x4 op_GreaterThan(double lhs, double2x4 rhs) { }

	// RVA: 0x29071D0 Offset: 0x2905BD0 VA: 0x1829071D0
	public static bool2x4 op_GreaterThanOrEqual(double2x4 lhs, double2x4 rhs) { }

	// RVA: 0x29070E0 Offset: 0x2905AE0 VA: 0x1829070E0
	public static bool2x4 op_GreaterThanOrEqual(double2x4 lhs, double rhs) { }

	// RVA: 0x2907010 Offset: 0x2905A10 VA: 0x182907010
	public static bool2x4 op_GreaterThanOrEqual(double lhs, double2x4 rhs) { }

	// RVA: 0x2908480 Offset: 0x2906E80 VA: 0x182908480
	public static double2x4 op_UnaryNegation(double2x4 val) { }

	// RVA: 0x29084D0 Offset: 0x2906ED0 VA: 0x1829084D0
	public static double2x4 op_UnaryPlus(double2x4 val) { }

	// RVA: 0x2906D60 Offset: 0x2905760 VA: 0x182906D60
	public static bool2x4 op_Equality(double2x4 lhs, double2x4 rhs) { }

	// RVA: 0x2906EB0 Offset: 0x29058B0 VA: 0x182906EB0
	public static bool2x4 op_Equality(double2x4 lhs, double rhs) { }

	// RVA: 0x2906C50 Offset: 0x2905650 VA: 0x182906C50
	public static bool2x4 op_Equality(double lhs, double2x4 rhs) { }

	// RVA: 0x2907880 Offset: 0x2906280 VA: 0x182907880
	public static bool2x4 op_Inequality(double2x4 lhs, double2x4 rhs) { }

	// RVA: 0x2907750 Offset: 0x2906150 VA: 0x182907750
	public static bool2x4 op_Inequality(double2x4 lhs, double rhs) { }

	// RVA: 0x2907640 Offset: 0x2906040 VA: 0x182907640
	public static bool2x4 op_Inequality(double lhs, double2x4 rhs) { }

	// RVA: 0xF6D000 Offset: 0xF6BA00 VA: 0x180F6D000
	public ref double2 get_Item(int index) { }

	// RVA: 0x2905C20 Offset: 0x2904620 VA: 0x182905C20 Slot: 4
	public bool Equals(double2x4 rhs) { }

	// RVA: 0x2905CC0 Offset: 0x29046C0 VA: 0x182905CC0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2905DE0 Offset: 0x29047E0 VA: 0x182905DE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x29061A0 Offset: 0x2904BA0 VA: 0x1829061A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2905E20 Offset: 0x2904820 VA: 0x182905E20 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
