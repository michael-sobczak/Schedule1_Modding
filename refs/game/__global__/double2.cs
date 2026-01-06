public struct double2 : IEquatable<double2>, IFormattable // TypeDefIndex: 10885
{
	// Fields
	public double x; // 0x0
	public double y; // 0x8
	public static readonly double2 zero; // 0x0

	// Properties
	[EditorBrowsable(1)]
	public double4 xxxx { get; }
	[EditorBrowsable(1)]
	public double4 xxxy { get; }
	[EditorBrowsable(1)]
	public double4 xxyx { get; }
	[EditorBrowsable(1)]
	public double4 xxyy { get; }
	[EditorBrowsable(1)]
	public double4 xyxx { get; }
	[EditorBrowsable(1)]
	public double4 xyxy { get; }
	[EditorBrowsable(1)]
	public double4 xyyx { get; }
	[EditorBrowsable(1)]
	public double4 xyyy { get; }
	[EditorBrowsable(1)]
	public double4 yxxx { get; }
	[EditorBrowsable(1)]
	public double4 yxxy { get; }
	[EditorBrowsable(1)]
	public double4 yxyx { get; }
	[EditorBrowsable(1)]
	public double4 yxyy { get; }
	[EditorBrowsable(1)]
	public double4 yyxx { get; }
	[EditorBrowsable(1)]
	public double4 yyxy { get; }
	[EditorBrowsable(1)]
	public double4 yyyx { get; }
	[EditorBrowsable(1)]
	public double4 yyyy { get; }
	[EditorBrowsable(1)]
	public double3 xxx { get; }
	[EditorBrowsable(1)]
	public double3 xxy { get; }
	[EditorBrowsable(1)]
	public double3 xyx { get; }
	[EditorBrowsable(1)]
	public double3 xyy { get; }
	[EditorBrowsable(1)]
	public double3 yxx { get; }
	[EditorBrowsable(1)]
	public double3 yxy { get; }
	[EditorBrowsable(1)]
	public double3 yyx { get; }
	[EditorBrowsable(1)]
	public double3 yyy { get; }
	[EditorBrowsable(1)]
	public double2 xx { get; }
	[EditorBrowsable(1)]
	public double2 xy { get; set; }
	[EditorBrowsable(1)]
	public double2 yx { get; set; }
	[EditorBrowsable(1)]
	public double2 yy { get; }
	public double Item { get; set; }

	// Methods

	// RVA: 0xC3F6D0 Offset: 0xC3E0D0 VA: 0x180C3F6D0
	public void .ctor(double x, double y) { }

	// RVA: 0xC3F6C0 Offset: 0xC3E0C0 VA: 0x180C3F6C0
	public void .ctor(double2 xy) { }

	// RVA: 0x2712610 Offset: 0x2711010 VA: 0x182712610
	public void .ctor(double v) { }

	// RVA: 0x2901F90 Offset: 0x2900990 VA: 0x182901F90
	public void .ctor(bool v) { }

	// RVA: 0x2901F10 Offset: 0x2900910 VA: 0x182901F10
	public void .ctor(bool2 v) { }

	// RVA: 0x2901FD0 Offset: 0x29009D0 VA: 0x182901FD0
	public void .ctor(int v) { }

	// RVA: 0x2901F70 Offset: 0x2900970 VA: 0x182901F70
	public void .ctor(int2 v) { }

	// RVA: 0x2901FB0 Offset: 0x29009B0 VA: 0x182901FB0
	public void .ctor(uint v) { }

	// RVA: 0x2901FF0 Offset: 0x29009F0 VA: 0x182901FF0
	public void .ctor(uint2 v) { }

	// RVA: 0x2880E10 Offset: 0x287F810 VA: 0x182880E10
	public void .ctor(half v) { }

	// RVA: 0x2880D30 Offset: 0x287F730 VA: 0x182880D30
	public void .ctor(half2 v) { }

	// RVA: 0x2902010 Offset: 0x2900A10 VA: 0x182902010
	public void .ctor(float v) { }

	// RVA: 0x2901F40 Offset: 0x2900940 VA: 0x182901F40
	public void .ctor(float2 v) { }

	// RVA: 0x2714F90 Offset: 0x2713990 VA: 0x182714F90
	public static double2 op_Implicit(double v) { }

	// RVA: 0x28919B0 Offset: 0x28903B0 VA: 0x1828919B0
	public static double2 op_Explicit(bool v) { }

	// RVA: 0x28917C0 Offset: 0x28901C0 VA: 0x1828917C0
	public static double2 op_Explicit(bool2 v) { }

	// RVA: 0x2891860 Offset: 0x2890260 VA: 0x182891860
	public static double2 op_Implicit(int v) { }

	// RVA: 0x2891800 Offset: 0x2890200 VA: 0x182891800
	public static double2 op_Implicit(int2 v) { }

	// RVA: 0x2891760 Offset: 0x2890160 VA: 0x182891760
	public static double2 op_Implicit(uint v) { }

	// RVA: 0x2891830 Offset: 0x2890230 VA: 0x182891830
	public static double2 op_Implicit(uint2 v) { }

	// RVA: 0x2902610 Offset: 0x2901010 VA: 0x182902610
	public static double2 op_Implicit(half v) { }

	// RVA: 0x29025F0 Offset: 0x2900FF0 VA: 0x1829025F0
	public static double2 op_Implicit(half2 v) { }

	// RVA: 0x2891880 Offset: 0x2890280 VA: 0x182891880
	public static double2 op_Implicit(float v) { }

	// RVA: 0x2891790 Offset: 0x2890190 VA: 0x182891790
	public static double2 op_Implicit(float2 v) { }

	// RVA: 0x27149C0 Offset: 0x27133C0 VA: 0x1827149C0
	public static double2 op_Multiply(double2 lhs, double2 rhs) { }

	// RVA: 0x29028D0 Offset: 0x29012D0 VA: 0x1829028D0
	public static double2 op_Multiply(double2 lhs, double rhs) { }

	// RVA: 0x29028B0 Offset: 0x29012B0 VA: 0x1829028B0
	public static double2 op_Multiply(double lhs, double2 rhs) { }

	// RVA: 0x2712C60 Offset: 0x2711660 VA: 0x182712C60
	public static double2 op_Addition(double2 lhs, double2 rhs) { }

	// RVA: 0x29023B0 Offset: 0x2900DB0 VA: 0x1829023B0
	public static double2 op_Addition(double2 lhs, double rhs) { }

	// RVA: 0x2902390 Offset: 0x2900D90 VA: 0x182902390
	public static double2 op_Addition(double lhs, double2 rhs) { }

	// RVA: 0x2716400 Offset: 0x2714E00 VA: 0x182716400
	public static double2 op_Subtraction(double2 lhs, double2 rhs) { }

	// RVA: 0x29028F0 Offset: 0x29012F0 VA: 0x1829028F0
	public static double2 op_Subtraction(double2 lhs, double rhs) { }

	// RVA: 0x2902910 Offset: 0x2901310 VA: 0x182902910
	public static double2 op_Subtraction(double lhs, double2 rhs) { }

	// RVA: 0x2714280 Offset: 0x2712C80 VA: 0x182714280
	public static double2 op_Division(double2 lhs, double2 rhs) { }

	// RVA: 0x2902410 Offset: 0x2900E10 VA: 0x182902410
	public static double2 op_Division(double2 lhs, double rhs) { }

	// RVA: 0x29023F0 Offset: 0x2900DF0 VA: 0x1829023F0
	public static double2 op_Division(double lhs, double2 rhs) { }

	// RVA: 0x289DBF0 Offset: 0x289C5F0 VA: 0x18289DBF0
	public static double2 op_Modulus(double2 lhs, double2 rhs) { }

	// RVA: 0x2902810 Offset: 0x2901210 VA: 0x182902810
	public static double2 op_Modulus(double2 lhs, double rhs) { }

	// RVA: 0x2902860 Offset: 0x2901260 VA: 0x182902860
	public static double2 op_Modulus(double lhs, double2 rhs) { }

	// RVA: 0x2902630 Offset: 0x2901030 VA: 0x182902630
	public static double2 op_Increment(double2 val) { }

	// RVA: 0x29023D0 Offset: 0x2900DD0 VA: 0x1829023D0
	public static double2 op_Decrement(double2 val) { }

	// RVA: 0x29027E0 Offset: 0x29011E0 VA: 0x1829027E0
	public static bool2 op_LessThan(double2 lhs, double2 rhs) { }

	// RVA: 0x29027C0 Offset: 0x29011C0 VA: 0x1829027C0
	public static bool2 op_LessThan(double2 lhs, double rhs) { }

	// RVA: 0x2902790 Offset: 0x2901190 VA: 0x182902790
	public static bool2 op_LessThan(double lhs, double2 rhs) { }

	// RVA: 0x2902710 Offset: 0x2901110 VA: 0x182902710
	public static bool2 op_LessThanOrEqual(double2 lhs, double2 rhs) { }

	// RVA: 0x2902770 Offset: 0x2901170 VA: 0x182902770
	public static bool2 op_LessThanOrEqual(double2 lhs, double rhs) { }

	// RVA: 0x2902740 Offset: 0x2901140 VA: 0x182902740
	public static bool2 op_LessThanOrEqual(double lhs, double2 rhs) { }

	// RVA: 0x2902570 Offset: 0x2900F70 VA: 0x182902570
	public static bool2 op_GreaterThan(double2 lhs, double2 rhs) { }

	// RVA: 0x29025C0 Offset: 0x2900FC0 VA: 0x1829025C0
	public static bool2 op_GreaterThan(double2 lhs, double rhs) { }

	// RVA: 0x29025A0 Offset: 0x2900FA0 VA: 0x1829025A0
	public static bool2 op_GreaterThan(double lhs, double2 rhs) { }

	// RVA: 0x2902510 Offset: 0x2900F10 VA: 0x182902510
	public static bool2 op_GreaterThanOrEqual(double2 lhs, double2 rhs) { }

	// RVA: 0x2902540 Offset: 0x2900F40 VA: 0x182902540
	public static bool2 op_GreaterThanOrEqual(double2 lhs, double rhs) { }

	// RVA: 0x29024F0 Offset: 0x2900EF0 VA: 0x1829024F0
	public static bool2 op_GreaterThanOrEqual(double lhs, double2 rhs) { }

	// RVA: 0x2902930 Offset: 0x2901330 VA: 0x182902930
	public static double2 op_UnaryNegation(double2 val) { }

	// RVA: 0x29020E0 Offset: 0x2900AE0 VA: 0x1829020E0
	public static double2 op_UnaryPlus(double2 val) { }

	// RVA: 0x2902430 Offset: 0x2900E30 VA: 0x182902430
	public static bool2 op_Equality(double2 lhs, double2 rhs) { }

	// RVA: 0x2902470 Offset: 0x2900E70 VA: 0x182902470
	public static bool2 op_Equality(double2 lhs, double rhs) { }

	// RVA: 0x29024B0 Offset: 0x2900EB0 VA: 0x1829024B0
	public static bool2 op_Equality(double lhs, double2 rhs) { }

	// RVA: 0x29026D0 Offset: 0x29010D0 VA: 0x1829026D0
	public static bool2 op_Inequality(double2 lhs, double2 rhs) { }

	// RVA: 0x2902690 Offset: 0x2901090 VA: 0x182902690
	public static bool2 op_Inequality(double2 lhs, double rhs) { }

	// RVA: 0x2902650 Offset: 0x2901050 VA: 0x182902650
	public static bool2 op_Inequality(double lhs, double2 rhs) { }

	// RVA: 0x2902040 Offset: 0x2900A40 VA: 0x182902040
	public double4 get_xxxx() { }

	// RVA: 0x2902060 Offset: 0x2900A60 VA: 0x182902060
	public double4 get_xxxy() { }

	// RVA: 0x29020A0 Offset: 0x2900AA0 VA: 0x1829020A0
	public double4 get_xxyx() { }

	// RVA: 0x29020C0 Offset: 0x2900AC0 VA: 0x1829020C0
	public double4 get_xxyy() { }

	// RVA: 0x2902120 Offset: 0x2900B20 VA: 0x182902120
	public double4 get_xyxx() { }

	// RVA: 0x2902140 Offset: 0x2900B40 VA: 0x182902140
	public double4 get_xyxy() { }

	// RVA: 0x2902190 Offset: 0x2900B90 VA: 0x182902190
	public double4 get_xyyx() { }

	// RVA: 0x29021B0 Offset: 0x2900BB0 VA: 0x1829021B0
	public double4 get_xyyy() { }

	// RVA: 0x2902210 Offset: 0x2900C10 VA: 0x182902210
	public double4 get_yxxx() { }

	// RVA: 0x2902230 Offset: 0x2900C30 VA: 0x182902230
	public double4 get_yxxy() { }

	// RVA: 0x2902270 Offset: 0x2900C70 VA: 0x182902270
	public double4 get_yxyx() { }

	// RVA: 0x29022A0 Offset: 0x2900CA0 VA: 0x1829022A0
	public double4 get_yxyy() { }

	// RVA: 0x29022F0 Offset: 0x2900CF0 VA: 0x1829022F0
	public double4 get_yyxx() { }

	// RVA: 0x2902310 Offset: 0x2900D10 VA: 0x182902310
	public double4 get_yyxy() { }

	// RVA: 0x2902350 Offset: 0x2900D50 VA: 0x182902350
	public double4 get_yyyx() { }

	// RVA: 0x2902370 Offset: 0x2900D70 VA: 0x182902370
	public double4 get_yyyy() { }

	// RVA: 0x2902020 Offset: 0x2900A20 VA: 0x182902020
	public double3 get_xxx() { }

	// RVA: 0x2902080 Offset: 0x2900A80 VA: 0x182902080
	public double3 get_xxy() { }

	// RVA: 0x2902100 Offset: 0x2900B00 VA: 0x182902100
	public double3 get_xyx() { }

	// RVA: 0x2902170 Offset: 0x2900B70 VA: 0x182902170
	public double3 get_xyy() { }

	// RVA: 0x29021F0 Offset: 0x2900BF0 VA: 0x1829021F0
	public double3 get_yxx() { }

	// RVA: 0x2902250 Offset: 0x2900C50 VA: 0x182902250
	public double3 get_yxy() { }

	// RVA: 0x29022D0 Offset: 0x2900CD0 VA: 0x1829022D0
	public double3 get_yyx() { }

	// RVA: 0x2902330 Offset: 0x2900D30 VA: 0x182902330
	public double3 get_yyy() { }

	// RVA: 0x27169F0 Offset: 0x27153F0 VA: 0x1827169F0
	public double2 get_xx() { }

	// RVA: 0x29020E0 Offset: 0x2900AE0 VA: 0x1829020E0
	public double2 get_xy() { }

	// RVA: 0xC3F6C0 Offset: 0xC3E0C0 VA: 0x180C3F6C0
	public void set_xy(double2 value) { }

	// RVA: 0x29021D0 Offset: 0x2900BD0 VA: 0x1829021D0
	public double2 get_yx() { }

	// RVA: 0x2902950 Offset: 0x2901350 VA: 0x182902950
	public void set_yx(double2 value) { }

	// RVA: 0x29022C0 Offset: 0x2900CC0 VA: 0x1829022C0
	public double2 get_yy() { }

	// RVA: 0xF6CD00 Offset: 0xF6B700 VA: 0x180F6CD00
	public double get_Item(int index) { }

	// RVA: 0xF72FD0 Offset: 0xF719D0 VA: 0x180F72FD0
	public void set_Item(int index, double value) { }

	// RVA: 0x2901D30 Offset: 0x2900730 VA: 0x182901D30 Slot: 4
	public bool Equals(double2 rhs) { }

	// RVA: 0x2901D50 Offset: 0x2900750 VA: 0x182901D50 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x28A0B40 Offset: 0x289F540 VA: 0x1828A0B40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2901E80 Offset: 0x2900880 VA: 0x182901E80 Slot: 3
	public override string ToString() { }

	// RVA: 0x2901DF0 Offset: 0x29007F0 VA: 0x182901DF0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
