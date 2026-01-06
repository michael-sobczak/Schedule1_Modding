public struct double3 : IEquatable<double3>, IFormattable // TypeDefIndex: 10890
{
	// Fields
	public double x; // 0x0
	public double y; // 0x8
	public double z; // 0x10
	public static readonly double3 zero; // 0x0

	// Properties
	[EditorBrowsable(1)]
	public double4 xxxx { get; }
	[EditorBrowsable(1)]
	public double4 xxxy { get; }
	[EditorBrowsable(1)]
	public double4 xxxz { get; }
	[EditorBrowsable(1)]
	public double4 xxyx { get; }
	[EditorBrowsable(1)]
	public double4 xxyy { get; }
	[EditorBrowsable(1)]
	public double4 xxyz { get; }
	[EditorBrowsable(1)]
	public double4 xxzx { get; }
	[EditorBrowsable(1)]
	public double4 xxzy { get; }
	[EditorBrowsable(1)]
	public double4 xxzz { get; }
	[EditorBrowsable(1)]
	public double4 xyxx { get; }
	[EditorBrowsable(1)]
	public double4 xyxy { get; }
	[EditorBrowsable(1)]
	public double4 xyxz { get; }
	[EditorBrowsable(1)]
	public double4 xyyx { get; }
	[EditorBrowsable(1)]
	public double4 xyyy { get; }
	[EditorBrowsable(1)]
	public double4 xyyz { get; }
	[EditorBrowsable(1)]
	public double4 xyzx { get; }
	[EditorBrowsable(1)]
	public double4 xyzy { get; }
	[EditorBrowsable(1)]
	public double4 xyzz { get; }
	[EditorBrowsable(1)]
	public double4 xzxx { get; }
	[EditorBrowsable(1)]
	public double4 xzxy { get; }
	[EditorBrowsable(1)]
	public double4 xzxz { get; }
	[EditorBrowsable(1)]
	public double4 xzyx { get; }
	[EditorBrowsable(1)]
	public double4 xzyy { get; }
	[EditorBrowsable(1)]
	public double4 xzyz { get; }
	[EditorBrowsable(1)]
	public double4 xzzx { get; }
	[EditorBrowsable(1)]
	public double4 xzzy { get; }
	[EditorBrowsable(1)]
	public double4 xzzz { get; }
	[EditorBrowsable(1)]
	public double4 yxxx { get; }
	[EditorBrowsable(1)]
	public double4 yxxy { get; }
	[EditorBrowsable(1)]
	public double4 yxxz { get; }
	[EditorBrowsable(1)]
	public double4 yxyx { get; }
	[EditorBrowsable(1)]
	public double4 yxyy { get; }
	[EditorBrowsable(1)]
	public double4 yxyz { get; }
	[EditorBrowsable(1)]
	public double4 yxzx { get; }
	[EditorBrowsable(1)]
	public double4 yxzy { get; }
	[EditorBrowsable(1)]
	public double4 yxzz { get; }
	[EditorBrowsable(1)]
	public double4 yyxx { get; }
	[EditorBrowsable(1)]
	public double4 yyxy { get; }
	[EditorBrowsable(1)]
	public double4 yyxz { get; }
	[EditorBrowsable(1)]
	public double4 yyyx { get; }
	[EditorBrowsable(1)]
	public double4 yyyy { get; }
	[EditorBrowsable(1)]
	public double4 yyyz { get; }
	[EditorBrowsable(1)]
	public double4 yyzx { get; }
	[EditorBrowsable(1)]
	public double4 yyzy { get; }
	[EditorBrowsable(1)]
	public double4 yyzz { get; }
	[EditorBrowsable(1)]
	public double4 yzxx { get; }
	[EditorBrowsable(1)]
	public double4 yzxy { get; }
	[EditorBrowsable(1)]
	public double4 yzxz { get; }
	[EditorBrowsable(1)]
	public double4 yzyx { get; }
	[EditorBrowsable(1)]
	public double4 yzyy { get; }
	[EditorBrowsable(1)]
	public double4 yzyz { get; }
	[EditorBrowsable(1)]
	public double4 yzzx { get; }
	[EditorBrowsable(1)]
	public double4 yzzy { get; }
	[EditorBrowsable(1)]
	public double4 yzzz { get; }
	[EditorBrowsable(1)]
	public double4 zxxx { get; }
	[EditorBrowsable(1)]
	public double4 zxxy { get; }
	[EditorBrowsable(1)]
	public double4 zxxz { get; }
	[EditorBrowsable(1)]
	public double4 zxyx { get; }
	[EditorBrowsable(1)]
	public double4 zxyy { get; }
	[EditorBrowsable(1)]
	public double4 zxyz { get; }
	[EditorBrowsable(1)]
	public double4 zxzx { get; }
	[EditorBrowsable(1)]
	public double4 zxzy { get; }
	[EditorBrowsable(1)]
	public double4 zxzz { get; }
	[EditorBrowsable(1)]
	public double4 zyxx { get; }
	[EditorBrowsable(1)]
	public double4 zyxy { get; }
	[EditorBrowsable(1)]
	public double4 zyxz { get; }
	[EditorBrowsable(1)]
	public double4 zyyx { get; }
	[EditorBrowsable(1)]
	public double4 zyyy { get; }
	[EditorBrowsable(1)]
	public double4 zyyz { get; }
	[EditorBrowsable(1)]
	public double4 zyzx { get; }
	[EditorBrowsable(1)]
	public double4 zyzy { get; }
	[EditorBrowsable(1)]
	public double4 zyzz { get; }
	[EditorBrowsable(1)]
	public double4 zzxx { get; }
	[EditorBrowsable(1)]
	public double4 zzxy { get; }
	[EditorBrowsable(1)]
	public double4 zzxz { get; }
	[EditorBrowsable(1)]
	public double4 zzyx { get; }
	[EditorBrowsable(1)]
	public double4 zzyy { get; }
	[EditorBrowsable(1)]
	public double4 zzyz { get; }
	[EditorBrowsable(1)]
	public double4 zzzx { get; }
	[EditorBrowsable(1)]
	public double4 zzzy { get; }
	[EditorBrowsable(1)]
	public double4 zzzz { get; }
	[EditorBrowsable(1)]
	public double3 xxx { get; }
	[EditorBrowsable(1)]
	public double3 xxy { get; }
	[EditorBrowsable(1)]
	public double3 xxz { get; }
	[EditorBrowsable(1)]
	public double3 xyx { get; }
	[EditorBrowsable(1)]
	public double3 xyy { get; }
	[EditorBrowsable(1)]
	public double3 xyz { get; set; }
	[EditorBrowsable(1)]
	public double3 xzx { get; }
	[EditorBrowsable(1)]
	public double3 xzy { get; set; }
	[EditorBrowsable(1)]
	public double3 xzz { get; }
	[EditorBrowsable(1)]
	public double3 yxx { get; }
	[EditorBrowsable(1)]
	public double3 yxy { get; }
	[EditorBrowsable(1)]
	public double3 yxz { get; set; }
	[EditorBrowsable(1)]
	public double3 yyx { get; }
	[EditorBrowsable(1)]
	public double3 yyy { get; }
	[EditorBrowsable(1)]
	public double3 yyz { get; }
	[EditorBrowsable(1)]
	public double3 yzx { get; set; }
	[EditorBrowsable(1)]
	public double3 yzy { get; }
	[EditorBrowsable(1)]
	public double3 yzz { get; }
	[EditorBrowsable(1)]
	public double3 zxx { get; }
	[EditorBrowsable(1)]
	public double3 zxy { get; set; }
	[EditorBrowsable(1)]
	public double3 zxz { get; }
	[EditorBrowsable(1)]
	public double3 zyx { get; set; }
	[EditorBrowsable(1)]
	public double3 zyy { get; }
	[EditorBrowsable(1)]
	public double3 zyz { get; }
	[EditorBrowsable(1)]
	public double3 zzx { get; }
	[EditorBrowsable(1)]
	public double3 zzy { get; }
	[EditorBrowsable(1)]
	public double3 zzz { get; }
	[EditorBrowsable(1)]
	public double2 xx { get; }
	[EditorBrowsable(1)]
	public double2 xy { get; set; }
	[EditorBrowsable(1)]
	public double2 xz { get; set; }
	[EditorBrowsable(1)]
	public double2 yx { get; set; }
	[EditorBrowsable(1)]
	public double2 yy { get; }
	[EditorBrowsable(1)]
	public double2 yz { get; set; }
	[EditorBrowsable(1)]
	public double2 zx { get; set; }
	[EditorBrowsable(1)]
	public double2 zy { get; set; }
	[EditorBrowsable(1)]
	public double2 zz { get; }
	public double Item { get; set; }

	// Methods

	// RVA: 0x1A4D9B0 Offset: 0x1A4C3B0 VA: 0x181A4D9B0
	public void .ctor(double x, double y, double z) { }

	// RVA: 0x2908820 Offset: 0x2907220 VA: 0x182908820
	public void .ctor(double x, double2 yz) { }

	// RVA: 0x29087E0 Offset: 0x29071E0 VA: 0x1829087E0
	public void .ctor(double2 xy, double z) { }

	// RVA: 0x2908860 Offset: 0x2907260 VA: 0x182908860
	public void .ctor(double3 xyz) { }

	// RVA: 0x29088D0 Offset: 0x29072D0 VA: 0x1829088D0
	public void .ctor(double v) { }

	// RVA: 0x29088E0 Offset: 0x29072E0 VA: 0x1829088E0
	public void .ctor(bool v) { }

	// RVA: 0x2908880 Offset: 0x2907280 VA: 0x182908880
	public void .ctor(bool3 v) { }

	// RVA: 0x2908840 Offset: 0x2907240 VA: 0x182908840
	public void .ctor(int v) { }

	// RVA: 0x2908800 Offset: 0x2907200 VA: 0x182908800
	public void .ctor(int3 v) { }

	// RVA: 0x2908900 Offset: 0x2907300 VA: 0x182908900
	public void .ctor(uint v) { }

	// RVA: 0x2908930 Offset: 0x2907330 VA: 0x182908930
	public void .ctor(uint3 v) { }

	// RVA: 0x2880FA0 Offset: 0x287F9A0 VA: 0x182880FA0
	public void .ctor(half v) { }

	// RVA: 0x28810D0 Offset: 0x287FAD0 VA: 0x1828810D0
	public void .ctor(half3 v) { }

	// RVA: 0x29087C0 Offset: 0x29071C0 VA: 0x1829087C0
	public void .ctor(float v) { }

	// RVA: 0x29087A0 Offset: 0x29071A0 VA: 0x1829087A0
	public void .ctor(float3 v) { }

	// RVA: 0x28928A0 Offset: 0x28912A0 VA: 0x1828928A0
	public static double3 op_Implicit(double v) { }

	// RVA: 0x2892A00 Offset: 0x2891400 VA: 0x182892A00
	public static double3 op_Explicit(bool v) { }

	// RVA: 0x28928B0 Offset: 0x28912B0 VA: 0x1828928B0
	public static double3 op_Explicit(bool3 v) { }

	// RVA: 0x28929B0 Offset: 0x28913B0 VA: 0x1828929B0
	public static double3 op_Implicit(int v) { }

	// RVA: 0x28926B0 Offset: 0x28910B0 VA: 0x1828926B0
	public static double3 op_Implicit(int3 v) { }

	// RVA: 0x2892850 Offset: 0x2891250 VA: 0x182892850
	public static double3 op_Implicit(uint v) { }

	// RVA: 0x2892920 Offset: 0x2891320 VA: 0x182892920
	public static double3 op_Implicit(uint3 v) { }

	// RVA: 0x2909940 Offset: 0x2908340 VA: 0x182909940
	public static double3 op_Implicit(half v) { }

	// RVA: 0x2909970 Offset: 0x2908370 VA: 0x182909970
	public static double3 op_Implicit(half3 v) { }

	// RVA: 0x2892680 Offset: 0x2891080 VA: 0x182892680
	public static double3 op_Implicit(float v) { }

	// RVA: 0x2892B70 Offset: 0x2891570 VA: 0x182892B70
	public static double3 op_Implicit(float3 v) { }

	// RVA: 0x2909D50 Offset: 0x2908750 VA: 0x182909D50
	public static double3 op_Multiply(double3 lhs, double3 rhs) { }

	// RVA: 0x2909D30 Offset: 0x2908730 VA: 0x182909D30
	public static double3 op_Multiply(double3 lhs, double rhs) { }

	// RVA: 0x2909D10 Offset: 0x2908710 VA: 0x182909D10
	public static double3 op_Multiply(double lhs, double3 rhs) { }

	// RVA: 0x29095F0 Offset: 0x2907FF0 VA: 0x1829095F0
	public static double3 op_Addition(double3 lhs, double3 rhs) { }

	// RVA: 0x29095D0 Offset: 0x2907FD0 VA: 0x1829095D0
	public static double3 op_Addition(double3 lhs, double rhs) { }

	// RVA: 0x29095B0 Offset: 0x2907FB0 VA: 0x1829095B0
	public static double3 op_Addition(double lhs, double3 rhs) { }

	// RVA: 0x2909DB0 Offset: 0x29087B0 VA: 0x182909DB0
	public static double3 op_Subtraction(double3 lhs, double3 rhs) { }

	// RVA: 0x2909D90 Offset: 0x2908790 VA: 0x182909D90
	public static double3 op_Subtraction(double3 lhs, double rhs) { }

	// RVA: 0x2909DF0 Offset: 0x29087F0 VA: 0x182909DF0
	public static double3 op_Subtraction(double lhs, double3 rhs) { }

	// RVA: 0x2909660 Offset: 0x2908060 VA: 0x182909660
	public static double3 op_Division(double3 lhs, double3 rhs) { }

	// RVA: 0x29096A0 Offset: 0x29080A0 VA: 0x1829096A0
	public static double3 op_Division(double3 lhs, double rhs) { }

	// RVA: 0x29096C0 Offset: 0x29080C0 VA: 0x1829096C0
	public static double3 op_Division(double lhs, double3 rhs) { }

	// RVA: 0x289DA20 Offset: 0x289C420 VA: 0x18289DA20
	public static double3 op_Modulus(double3 lhs, double3 rhs) { }

	// RVA: 0x2909C50 Offset: 0x2908650 VA: 0x182909C50
	public static double3 op_Modulus(double3 lhs, double rhs) { }

	// RVA: 0x2909CB0 Offset: 0x29086B0 VA: 0x182909CB0
	public static double3 op_Modulus(double lhs, double3 rhs) { }

	// RVA: 0x29099B0 Offset: 0x29083B0 VA: 0x1829099B0
	public static double3 op_Increment(double3 val) { }

	// RVA: 0x2909630 Offset: 0x2908030 VA: 0x182909630
	public static double3 op_Decrement(double3 val) { }

	// RVA: 0x2909BA0 Offset: 0x29085A0 VA: 0x182909BA0
	public static bool3 op_LessThan(double3 lhs, double3 rhs) { }

	// RVA: 0x2909BE0 Offset: 0x29085E0 VA: 0x182909BE0
	public static bool3 op_LessThan(double3 lhs, double rhs) { }

	// RVA: 0x2909C10 Offset: 0x2908610 VA: 0x182909C10
	public static bool3 op_LessThan(double lhs, double3 rhs) { }

	// RVA: 0x2909AF0 Offset: 0x29084F0 VA: 0x182909AF0
	public static bool3 op_LessThanOrEqual(double3 lhs, double3 rhs) { }

	// RVA: 0x2909B70 Offset: 0x2908570 VA: 0x182909B70
	public static bool3 op_LessThanOrEqual(double3 lhs, double rhs) { }

	// RVA: 0x2909B30 Offset: 0x2908530 VA: 0x182909B30
	public static bool3 op_LessThanOrEqual(double lhs, double3 rhs) { }

	// RVA: 0x29098D0 Offset: 0x29082D0 VA: 0x1829098D0
	public static bool3 op_GreaterThan(double3 lhs, double3 rhs) { }

	// RVA: 0x29098A0 Offset: 0x29082A0 VA: 0x1829098A0
	public static bool3 op_GreaterThan(double3 lhs, double rhs) { }

	// RVA: 0x2909910 Offset: 0x2908310 VA: 0x182909910
	public static bool3 op_GreaterThan(double lhs, double3 rhs) { }

	// RVA: 0x2909830 Offset: 0x2908230 VA: 0x182909830
	public static bool3 op_GreaterThanOrEqual(double3 lhs, double3 rhs) { }

	// RVA: 0x2909870 Offset: 0x2908270 VA: 0x182909870
	public static bool3 op_GreaterThanOrEqual(double3 lhs, double rhs) { }

	// RVA: 0x2909800 Offset: 0x2908200 VA: 0x182909800
	public static bool3 op_GreaterThanOrEqual(double lhs, double3 rhs) { }

	// RVA: 0x2909E20 Offset: 0x2908820 VA: 0x182909E20
	public static double3 op_UnaryNegation(double3 val) { }

	// RVA: 0x2908A50 Offset: 0x2907450 VA: 0x182908A50
	public static double3 op_UnaryPlus(double3 val) { }

	// RVA: 0x29096F0 Offset: 0x29080F0 VA: 0x1829096F0
	public static bool3 op_Equality(double3 lhs, double3 rhs) { }

	// RVA: 0x2909750 Offset: 0x2908150 VA: 0x182909750
	public static bool3 op_Equality(double3 lhs, double rhs) { }

	// RVA: 0x29097B0 Offset: 0x29081B0 VA: 0x1829097B0
	public static bool3 op_Equality(double lhs, double3 rhs) { }

	// RVA: 0x2909A40 Offset: 0x2908440 VA: 0x182909A40
	public static bool3 op_Inequality(double3 lhs, double3 rhs) { }

	// RVA: 0x29099E0 Offset: 0x29083E0 VA: 0x1829099E0
	public static bool3 op_Inequality(double3 lhs, double rhs) { }

	// RVA: 0x2909AA0 Offset: 0x29084A0 VA: 0x182909AA0
	public static bool3 op_Inequality(double lhs, double3 rhs) { }

	// RVA: 0x2902040 Offset: 0x2900A40 VA: 0x182902040
	public double4 get_xxxx() { }

	// RVA: 0x2902060 Offset: 0x2900A60 VA: 0x182902060
	public double4 get_xxxy() { }

	// RVA: 0x2908960 Offset: 0x2907360 VA: 0x182908960
	public double4 get_xxxz() { }

	// RVA: 0x29020A0 Offset: 0x2900AA0 VA: 0x1829020A0
	public double4 get_xxyx() { }

	// RVA: 0x29020C0 Offset: 0x2900AC0 VA: 0x1829020C0
	public double4 get_xxyy() { }

	// RVA: 0x2908980 Offset: 0x2907380 VA: 0x182908980
	public double4 get_xxyz() { }

	// RVA: 0x29089C0 Offset: 0x29073C0 VA: 0x1829089C0
	public double4 get_xxzx() { }

	// RVA: 0x29089E0 Offset: 0x29073E0 VA: 0x1829089E0
	public double4 get_xxzy() { }

	// RVA: 0x270B860 Offset: 0x270A260 VA: 0x18270B860
	public double4 get_xxzz() { }

	// RVA: 0x2902120 Offset: 0x2900B20 VA: 0x182902120
	public double4 get_xyxx() { }

	// RVA: 0x2902140 Offset: 0x2900B40 VA: 0x182902140
	public double4 get_xyxy() { }

	// RVA: 0x2908A00 Offset: 0x2907400 VA: 0x182908A00
	public double4 get_xyxz() { }

	// RVA: 0x2902190 Offset: 0x2900B90 VA: 0x182902190
	public double4 get_xyyx() { }

	// RVA: 0x29021B0 Offset: 0x2900BB0 VA: 0x1829021B0
	public double4 get_xyyy() { }

	// RVA: 0x2908A30 Offset: 0x2907430 VA: 0x182908A30
	public double4 get_xyyz() { }

	// RVA: 0x2908A70 Offset: 0x2907470 VA: 0x182908A70
	public double4 get_xyzx() { }

	// RVA: 0x2908AA0 Offset: 0x29074A0 VA: 0x182908AA0
	public double4 get_xyzy() { }

	// RVA: 0x2908AD0 Offset: 0x29074D0 VA: 0x182908AD0
	public double4 get_xyzz() { }

	// RVA: 0x2908B30 Offset: 0x2907530 VA: 0x182908B30
	public double4 get_xzxx() { }

	// RVA: 0x2908B50 Offset: 0x2907550 VA: 0x182908B50
	public double4 get_xzxy() { }

	// RVA: 0x2908B80 Offset: 0x2907580 VA: 0x182908B80
	public double4 get_xzxz() { }

	// RVA: 0x2908BD0 Offset: 0x29075D0 VA: 0x182908BD0
	public double4 get_xzyx() { }

	// RVA: 0x2908C00 Offset: 0x2907600 VA: 0x182908C00
	public double4 get_xzyy() { }

	// RVA: 0x2908C20 Offset: 0x2907620 VA: 0x182908C20
	public double4 get_xzyz() { }

	// RVA: 0x2908C70 Offset: 0x2907670 VA: 0x182908C70
	public double4 get_xzzx() { }

	// RVA: 0x2908C90 Offset: 0x2907690 VA: 0x182908C90
	public double4 get_xzzy() { }

	// RVA: 0x2908CB0 Offset: 0x29076B0 VA: 0x182908CB0
	public double4 get_xzzz() { }

	// RVA: 0x2902210 Offset: 0x2900C10 VA: 0x182902210
	public double4 get_yxxx() { }

	// RVA: 0x2902230 Offset: 0x2900C30 VA: 0x182902230
	public double4 get_yxxy() { }

	// RVA: 0x2908CD0 Offset: 0x29076D0 VA: 0x182908CD0
	public double4 get_yxxz() { }

	// RVA: 0x2902270 Offset: 0x2900C70 VA: 0x182902270
	public double4 get_yxyx() { }

	// RVA: 0x29022A0 Offset: 0x2900CA0 VA: 0x1829022A0
	public double4 get_yxyy() { }

	// RVA: 0x2908CF0 Offset: 0x29076F0 VA: 0x182908CF0
	public double4 get_yxyz() { }

	// RVA: 0x2908D40 Offset: 0x2907740 VA: 0x182908D40
	public double4 get_yxzx() { }

	// RVA: 0x2908D70 Offset: 0x2907770 VA: 0x182908D70
	public double4 get_yxzy() { }

	// RVA: 0x2908DA0 Offset: 0x29077A0 VA: 0x182908DA0
	public double4 get_yxzz() { }

	// RVA: 0x29022F0 Offset: 0x2900CF0 VA: 0x1829022F0
	public double4 get_yyxx() { }

	// RVA: 0x2902310 Offset: 0x2900D10 VA: 0x182902310
	public double4 get_yyxy() { }

	// RVA: 0x2908DC0 Offset: 0x29077C0 VA: 0x182908DC0
	public double4 get_yyxz() { }

	// RVA: 0x2902350 Offset: 0x2900D50 VA: 0x182902350
	public double4 get_yyyx() { }

	// RVA: 0x2902370 Offset: 0x2900D70 VA: 0x182902370
	public double4 get_yyyy() { }

	// RVA: 0x2908DE0 Offset: 0x29077E0 VA: 0x182908DE0
	public double4 get_yyyz() { }

	// RVA: 0x2908E20 Offset: 0x2907820 VA: 0x182908E20
	public double4 get_yyzx() { }

	// RVA: 0x2908E40 Offset: 0x2907840 VA: 0x182908E40
	public double4 get_yyzy() { }

	// RVA: 0x2908E60 Offset: 0x2907860 VA: 0x182908E60
	public double4 get_yyzz() { }

	// RVA: 0x2908EC0 Offset: 0x29078C0 VA: 0x182908EC0
	public double4 get_yzxx() { }

	// RVA: 0x2908EE0 Offset: 0x29078E0 VA: 0x182908EE0
	public double4 get_yzxy() { }

	// RVA: 0x2908F10 Offset: 0x2907910 VA: 0x182908F10
	public double4 get_yzxz() { }

	// RVA: 0x2908F60 Offset: 0x2907960 VA: 0x182908F60
	public double4 get_yzyx() { }

	// RVA: 0x2908F90 Offset: 0x2907990 VA: 0x182908F90
	public double4 get_yzyy() { }

	// RVA: 0x2908FB0 Offset: 0x29079B0 VA: 0x182908FB0
	public double4 get_yzyz() { }

	// RVA: 0x2909000 Offset: 0x2907A00 VA: 0x182909000
	public double4 get_yzzx() { }

	// RVA: 0x2909020 Offset: 0x2907A20 VA: 0x182909020
	public double4 get_yzzy() { }

	// RVA: 0x2909040 Offset: 0x2907A40 VA: 0x182909040
	public double4 get_yzzz() { }

	// RVA: 0x29090A0 Offset: 0x2907AA0 VA: 0x1829090A0
	public double4 get_zxxx() { }

	// RVA: 0x29090C0 Offset: 0x2907AC0 VA: 0x1829090C0
	public double4 get_zxxy() { }

	// RVA: 0x29090E0 Offset: 0x2907AE0 VA: 0x1829090E0
	public double4 get_zxxz() { }

	// RVA: 0x2909120 Offset: 0x2907B20 VA: 0x182909120
	public double4 get_zxyx() { }

	// RVA: 0x2909150 Offset: 0x2907B50 VA: 0x182909150
	public double4 get_zxyy() { }

	// RVA: 0x2909170 Offset: 0x2907B70 VA: 0x182909170
	public double4 get_zxyz() { }

	// RVA: 0x29091C0 Offset: 0x2907BC0 VA: 0x1829091C0
	public double4 get_zxzx() { }

	// RVA: 0x29091F0 Offset: 0x2907BF0 VA: 0x1829091F0
	public double4 get_zxzy() { }

	// RVA: 0x2909220 Offset: 0x2907C20 VA: 0x182909220
	public double4 get_zxzz() { }

	// RVA: 0x2909280 Offset: 0x2907C80 VA: 0x182909280
	public double4 get_zyxx() { }

	// RVA: 0x29092A0 Offset: 0x2907CA0 VA: 0x1829092A0
	public double4 get_zyxy() { }

	// RVA: 0x29092D0 Offset: 0x2907CD0 VA: 0x1829092D0
	public double4 get_zyxz() { }

	// RVA: 0x2909320 Offset: 0x2907D20 VA: 0x182909320
	public double4 get_zyyx() { }

	// RVA: 0x2909340 Offset: 0x2907D40 VA: 0x182909340
	public double4 get_zyyy() { }

	// RVA: 0x2909360 Offset: 0x2907D60 VA: 0x182909360
	public double4 get_zyyz() { }

	// RVA: 0x29093A0 Offset: 0x2907DA0 VA: 0x1829093A0
	public double4 get_zyzx() { }

	// RVA: 0x29093D0 Offset: 0x2907DD0 VA: 0x1829093D0
	public double4 get_zyzy() { }

	// RVA: 0x2909400 Offset: 0x2907E00 VA: 0x182909400
	public double4 get_zyzz() { }

	// RVA: 0x2909450 Offset: 0x2907E50 VA: 0x182909450
	public double4 get_zzxx() { }

	// RVA: 0x2909470 Offset: 0x2907E70 VA: 0x182909470
	public double4 get_zzxy() { }

	// RVA: 0x2909490 Offset: 0x2907E90 VA: 0x182909490
	public double4 get_zzxz() { }

	// RVA: 0x29094D0 Offset: 0x2907ED0 VA: 0x1829094D0
	public double4 get_zzyx() { }

	// RVA: 0x29094F0 Offset: 0x2907EF0 VA: 0x1829094F0
	public double4 get_zzyy() { }

	// RVA: 0x2909510 Offset: 0x2907F10 VA: 0x182909510
	public double4 get_zzyz() { }

	// RVA: 0x2909550 Offset: 0x2907F50 VA: 0x182909550
	public double4 get_zzzx() { }

	// RVA: 0x2909570 Offset: 0x2907F70 VA: 0x182909570
	public double4 get_zzzy() { }

	// RVA: 0x2909590 Offset: 0x2907F90 VA: 0x182909590
	public double4 get_zzzz() { }

	// RVA: 0x2902020 Offset: 0x2900A20 VA: 0x182902020
	public double3 get_xxx() { }

	// RVA: 0x2902080 Offset: 0x2900A80 VA: 0x182902080
	public double3 get_xxy() { }

	// RVA: 0x29089A0 Offset: 0x29073A0 VA: 0x1829089A0
	public double3 get_xxz() { }

	// RVA: 0x2902100 Offset: 0x2900B00 VA: 0x182902100
	public double3 get_xyx() { }

	// RVA: 0x2902170 Offset: 0x2900B70 VA: 0x182902170
	public double3 get_xyy() { }

	// RVA: 0x2908A50 Offset: 0x2907450 VA: 0x182908A50
	public double3 get_xyz() { }

	// RVA: 0x2908860 Offset: 0x2907260 VA: 0x182908860
	public void set_xyz(double3 value) { }

	// RVA: 0x2908B10 Offset: 0x2907510 VA: 0x182908B10
	public double3 get_xzx() { }

	// RVA: 0x2908BB0 Offset: 0x29075B0 VA: 0x182908BB0
	public double3 get_xzy() { }

	// RVA: 0x2909E60 Offset: 0x2908860 VA: 0x182909E60
	public void set_xzy(double3 value) { }

	// RVA: 0x2908C50 Offset: 0x2907650 VA: 0x182908C50
	public double3 get_xzz() { }

	// RVA: 0x29021F0 Offset: 0x2900BF0 VA: 0x1829021F0
	public double3 get_yxx() { }

	// RVA: 0x2902250 Offset: 0x2900C50 VA: 0x182902250
	public double3 get_yxy() { }

	// RVA: 0x2908D20 Offset: 0x2907720 VA: 0x182908D20
	public double3 get_yxz() { }

	// RVA: 0x2909E80 Offset: 0x2908880 VA: 0x182909E80
	public void set_yxz(double3 value) { }

	// RVA: 0x29022D0 Offset: 0x2900CD0 VA: 0x1829022D0
	public double3 get_yyx() { }

	// RVA: 0x2902330 Offset: 0x2900D30 VA: 0x182902330
	public double3 get_yyy() { }

	// RVA: 0x2908E00 Offset: 0x2907800 VA: 0x182908E00
	public double3 get_yyz() { }

	// RVA: 0x2908EA0 Offset: 0x29078A0 VA: 0x182908EA0
	public double3 get_yzx() { }

	// RVA: 0x2909EB0 Offset: 0x29088B0 VA: 0x182909EB0
	public void set_yzx(double3 value) { }

	// RVA: 0x2908F40 Offset: 0x2907940 VA: 0x182908F40
	public double3 get_yzy() { }

	// RVA: 0x2908FE0 Offset: 0x29079E0 VA: 0x182908FE0
	public double3 get_yzz() { }

	// RVA: 0x2909080 Offset: 0x2907A80 VA: 0x182909080
	public double3 get_zxx() { }

	// RVA: 0x2909100 Offset: 0x2907B00 VA: 0x182909100
	public double3 get_zxy() { }

	// RVA: 0x2909EE0 Offset: 0x29088E0 VA: 0x182909EE0
	public void set_zxy(double3 value) { }

	// RVA: 0x29091A0 Offset: 0x2907BA0 VA: 0x1829091A0
	public double3 get_zxz() { }

	// RVA: 0x2909260 Offset: 0x2907C60 VA: 0x182909260
	public double3 get_zyx() { }

	// RVA: 0x2909F10 Offset: 0x2908910 VA: 0x182909F10
	public void set_zyx(double3 value) { }

	// RVA: 0x2909300 Offset: 0x2907D00 VA: 0x182909300
	public double3 get_zyy() { }

	// RVA: 0x2909380 Offset: 0x2907D80 VA: 0x182909380
	public double3 get_zyz() { }

	// RVA: 0x2909430 Offset: 0x2907E30 VA: 0x182909430
	public double3 get_zzx() { }

	// RVA: 0x29094B0 Offset: 0x2907EB0 VA: 0x1829094B0
	public double3 get_zzy() { }

	// RVA: 0x2909530 Offset: 0x2907F30 VA: 0x182909530
	public double3 get_zzz() { }

	// RVA: 0x27169F0 Offset: 0x27153F0 VA: 0x1827169F0
	public double2 get_xx() { }

	// RVA: 0x29020E0 Offset: 0x2900AE0 VA: 0x1829020E0
	public double2 get_xy() { }

	// RVA: 0xC3F6C0 Offset: 0xC3E0C0 VA: 0x180C3F6C0
	public void set_xy(double2 value) { }

	// RVA: 0x2908AF0 Offset: 0x29074F0 VA: 0x182908AF0
	public double2 get_xz() { }

	// RVA: 0x2909E50 Offset: 0x2908850 VA: 0x182909E50
	public void set_xz(double2 value) { }

	// RVA: 0x29021D0 Offset: 0x2900BD0 VA: 0x1829021D0
	public double2 get_yx() { }

	// RVA: 0x2902950 Offset: 0x2901350 VA: 0x182902950
	public void set_yx(double2 value) { }

	// RVA: 0x29022C0 Offset: 0x2900CC0 VA: 0x1829022C0
	public double2 get_yy() { }

	// RVA: 0x2908E80 Offset: 0x2907880 VA: 0x182908E80
	public double2 get_yz() { }

	// RVA: 0x2909EA0 Offset: 0x29088A0 VA: 0x182909EA0
	public void set_yz(double2 value) { }

	// RVA: 0x2909060 Offset: 0x2907A60 VA: 0x182909060
	public double2 get_zx() { }

	// RVA: 0x2909ED0 Offset: 0x29088D0 VA: 0x182909ED0
	public void set_zx(double2 value) { }

	// RVA: 0x2909240 Offset: 0x2907C40 VA: 0x182909240
	public double2 get_zy() { }

	// RVA: 0x2909F00 Offset: 0x2908900 VA: 0x182909F00
	public void set_zy(double2 value) { }

	// RVA: 0x2909420 Offset: 0x2907E20 VA: 0x182909420
	public double2 get_zz() { }

	// RVA: 0xF6CD00 Offset: 0xF6B700 VA: 0x180F6CD00
	public double get_Item(int index) { }

	// RVA: 0xF72FD0 Offset: 0xF719D0 VA: 0x180F72FD0
	public void set_Item(int index, double value) { }

	// RVA: 0x29085E0 Offset: 0x2906FE0 VA: 0x1829085E0 Slot: 4
	public bool Equals(double3 rhs) { }

	// RVA: 0x2908520 Offset: 0x2906F20 VA: 0x182908520 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x28A1450 Offset: 0x289FE50 VA: 0x1828A1450 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x29086E0 Offset: 0x29070E0 VA: 0x1829086E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2908620 Offset: 0x2907020 VA: 0x182908620 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
