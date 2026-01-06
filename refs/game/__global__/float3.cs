public struct float3 : IEquatable<float3>, IFormattable // TypeDefIndex: 10905
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public static readonly float3 zero; // 0x0

	// Properties
	[EditorBrowsable(1)]
	public float4 xxxx { get; }
	[EditorBrowsable(1)]
	public float4 xxxy { get; }
	[EditorBrowsable(1)]
	public float4 xxxz { get; }
	[EditorBrowsable(1)]
	public float4 xxyx { get; }
	[EditorBrowsable(1)]
	public float4 xxyy { get; }
	[EditorBrowsable(1)]
	public float4 xxyz { get; }
	[EditorBrowsable(1)]
	public float4 xxzx { get; }
	[EditorBrowsable(1)]
	public float4 xxzy { get; }
	[EditorBrowsable(1)]
	public float4 xxzz { get; }
	[EditorBrowsable(1)]
	public float4 xyxx { get; }
	[EditorBrowsable(1)]
	public float4 xyxy { get; }
	[EditorBrowsable(1)]
	public float4 xyxz { get; }
	[EditorBrowsable(1)]
	public float4 xyyx { get; }
	[EditorBrowsable(1)]
	public float4 xyyy { get; }
	[EditorBrowsable(1)]
	public float4 xyyz { get; }
	[EditorBrowsable(1)]
	public float4 xyzx { get; }
	[EditorBrowsable(1)]
	public float4 xyzy { get; }
	[EditorBrowsable(1)]
	public float4 xyzz { get; }
	[EditorBrowsable(1)]
	public float4 xzxx { get; }
	[EditorBrowsable(1)]
	public float4 xzxy { get; }
	[EditorBrowsable(1)]
	public float4 xzxz { get; }
	[EditorBrowsable(1)]
	public float4 xzyx { get; }
	[EditorBrowsable(1)]
	public float4 xzyy { get; }
	[EditorBrowsable(1)]
	public float4 xzyz { get; }
	[EditorBrowsable(1)]
	public float4 xzzx { get; }
	[EditorBrowsable(1)]
	public float4 xzzy { get; }
	[EditorBrowsable(1)]
	public float4 xzzz { get; }
	[EditorBrowsable(1)]
	public float4 yxxx { get; }
	[EditorBrowsable(1)]
	public float4 yxxy { get; }
	[EditorBrowsable(1)]
	public float4 yxxz { get; }
	[EditorBrowsable(1)]
	public float4 yxyx { get; }
	[EditorBrowsable(1)]
	public float4 yxyy { get; }
	[EditorBrowsable(1)]
	public float4 yxyz { get; }
	[EditorBrowsable(1)]
	public float4 yxzx { get; }
	[EditorBrowsable(1)]
	public float4 yxzy { get; }
	[EditorBrowsable(1)]
	public float4 yxzz { get; }
	[EditorBrowsable(1)]
	public float4 yyxx { get; }
	[EditorBrowsable(1)]
	public float4 yyxy { get; }
	[EditorBrowsable(1)]
	public float4 yyxz { get; }
	[EditorBrowsable(1)]
	public float4 yyyx { get; }
	[EditorBrowsable(1)]
	public float4 yyyy { get; }
	[EditorBrowsable(1)]
	public float4 yyyz { get; }
	[EditorBrowsable(1)]
	public float4 yyzx { get; }
	[EditorBrowsable(1)]
	public float4 yyzy { get; }
	[EditorBrowsable(1)]
	public float4 yyzz { get; }
	[EditorBrowsable(1)]
	public float4 yzxx { get; }
	[EditorBrowsable(1)]
	public float4 yzxy { get; }
	[EditorBrowsable(1)]
	public float4 yzxz { get; }
	[EditorBrowsable(1)]
	public float4 yzyx { get; }
	[EditorBrowsable(1)]
	public float4 yzyy { get; }
	[EditorBrowsable(1)]
	public float4 yzyz { get; }
	[EditorBrowsable(1)]
	public float4 yzzx { get; }
	[EditorBrowsable(1)]
	public float4 yzzy { get; }
	[EditorBrowsable(1)]
	public float4 yzzz { get; }
	[EditorBrowsable(1)]
	public float4 zxxx { get; }
	[EditorBrowsable(1)]
	public float4 zxxy { get; }
	[EditorBrowsable(1)]
	public float4 zxxz { get; }
	[EditorBrowsable(1)]
	public float4 zxyx { get; }
	[EditorBrowsable(1)]
	public float4 zxyy { get; }
	[EditorBrowsable(1)]
	public float4 zxyz { get; }
	[EditorBrowsable(1)]
	public float4 zxzx { get; }
	[EditorBrowsable(1)]
	public float4 zxzy { get; }
	[EditorBrowsable(1)]
	public float4 zxzz { get; }
	[EditorBrowsable(1)]
	public float4 zyxx { get; }
	[EditorBrowsable(1)]
	public float4 zyxy { get; }
	[EditorBrowsable(1)]
	public float4 zyxz { get; }
	[EditorBrowsable(1)]
	public float4 zyyx { get; }
	[EditorBrowsable(1)]
	public float4 zyyy { get; }
	[EditorBrowsable(1)]
	public float4 zyyz { get; }
	[EditorBrowsable(1)]
	public float4 zyzx { get; }
	[EditorBrowsable(1)]
	public float4 zyzy { get; }
	[EditorBrowsable(1)]
	public float4 zyzz { get; }
	[EditorBrowsable(1)]
	public float4 zzxx { get; }
	[EditorBrowsable(1)]
	public float4 zzxy { get; }
	[EditorBrowsable(1)]
	public float4 zzxz { get; }
	[EditorBrowsable(1)]
	public float4 zzyx { get; }
	[EditorBrowsable(1)]
	public float4 zzyy { get; }
	[EditorBrowsable(1)]
	public float4 zzyz { get; }
	[EditorBrowsable(1)]
	public float4 zzzx { get; }
	[EditorBrowsable(1)]
	public float4 zzzy { get; }
	[EditorBrowsable(1)]
	public float4 zzzz { get; }
	[EditorBrowsable(1)]
	public float3 xxx { get; }
	[EditorBrowsable(1)]
	public float3 xxy { get; }
	[EditorBrowsable(1)]
	public float3 xxz { get; }
	[EditorBrowsable(1)]
	public float3 xyx { get; }
	[EditorBrowsable(1)]
	public float3 xyy { get; }
	[EditorBrowsable(1)]
	public float3 xyz { get; set; }
	[EditorBrowsable(1)]
	public float3 xzx { get; }
	[EditorBrowsable(1)]
	public float3 xzy { get; set; }
	[EditorBrowsable(1)]
	public float3 xzz { get; }
	[EditorBrowsable(1)]
	public float3 yxx { get; }
	[EditorBrowsable(1)]
	public float3 yxy { get; }
	[EditorBrowsable(1)]
	public float3 yxz { get; set; }
	[EditorBrowsable(1)]
	public float3 yyx { get; }
	[EditorBrowsable(1)]
	public float3 yyy { get; }
	[EditorBrowsable(1)]
	public float3 yyz { get; }
	[EditorBrowsable(1)]
	public float3 yzx { get; set; }
	[EditorBrowsable(1)]
	public float3 yzy { get; }
	[EditorBrowsable(1)]
	public float3 yzz { get; }
	[EditorBrowsable(1)]
	public float3 zxx { get; }
	[EditorBrowsable(1)]
	public float3 zxy { get; set; }
	[EditorBrowsable(1)]
	public float3 zxz { get; }
	[EditorBrowsable(1)]
	public float3 zyx { get; set; }
	[EditorBrowsable(1)]
	public float3 zyy { get; }
	[EditorBrowsable(1)]
	public float3 zyz { get; }
	[EditorBrowsable(1)]
	public float3 zzx { get; }
	[EditorBrowsable(1)]
	public float3 zzy { get; }
	[EditorBrowsable(1)]
	public float3 zzz { get; }
	[EditorBrowsable(1)]
	public float2 xx { get; }
	[EditorBrowsable(1)]
	public float2 xy { get; set; }
	[EditorBrowsable(1)]
	public float2 xz { get; set; }
	[EditorBrowsable(1)]
	public float2 yx { get; set; }
	[EditorBrowsable(1)]
	public float2 yy { get; }
	[EditorBrowsable(1)]
	public float2 yz { get; set; }
	[EditorBrowsable(1)]
	public float2 zx { get; set; }
	[EditorBrowsable(1)]
	public float2 zy { get; set; }
	[EditorBrowsable(1)]
	public float2 zz { get; }
	public float Item { get; set; }

	// Methods

	// RVA: 0x8272A0 Offset: 0x825CA0 VA: 0x1808272A0
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x292F5E0 Offset: 0x292DFE0 VA: 0x18292F5E0
	public void .ctor(float x, float2 yz) { }

	// RVA: 0x292F4A0 Offset: 0x292DEA0 VA: 0x18292F4A0
	public void .ctor(float2 xy, float z) { }

	// RVA: 0x28ED540 Offset: 0x28EBF40 VA: 0x1828ED540
	public void .ctor(float3 xyz) { }

	// RVA: 0xD2D750 Offset: 0xD2C150 VA: 0x180D2D750
	public void .ctor(float v) { }

	// RVA: 0x292F4C0 Offset: 0x292DEC0 VA: 0x18292F4C0
	public void .ctor(bool v) { }

	// RVA: 0x292F530 Offset: 0x292DF30 VA: 0x18292F530
	public void .ctor(bool3 v) { }

	// RVA: 0x292F430 Offset: 0x292DE30 VA: 0x18292F430
	public void .ctor(int v) { }

	// RVA: 0x292F5B0 Offset: 0x292DFB0 VA: 0x18292F5B0
	public void .ctor(int3 v) { }

	// RVA: 0x292F4F0 Offset: 0x292DEF0 VA: 0x18292F4F0
	public void .ctor(uint v) { }

	// RVA: 0x292F460 Offset: 0x292DE60 VA: 0x18292F460
	public void .ctor(uint3 v) { }

	// RVA: 0x2882630 Offset: 0x2881030 VA: 0x182882630
	public void .ctor(half v) { }

	// RVA: 0x2882500 Offset: 0x2880F00 VA: 0x182882500
	public void .ctor(half3 v) { }

	// RVA: 0x292F580 Offset: 0x292DF80 VA: 0x18292F580
	public void .ctor(double v) { }

	// RVA: 0x292F600 Offset: 0x292E000 VA: 0x18292F600
	public void .ctor(double3 v) { }

	// RVA: 0x289A500 Offset: 0x2898F00 VA: 0x18289A500
	public static float3 op_Implicit(float v) { }

	// RVA: 0x2899FE0 Offset: 0x28989E0 VA: 0x182899FE0
	public static float3 op_Explicit(bool v) { }

	// RVA: 0x289A4B0 Offset: 0x2898EB0 VA: 0x18289A4B0
	public static float3 op_Explicit(bool3 v) { }

	// RVA: 0x289A050 Offset: 0x2898A50 VA: 0x18289A050
	public static float3 op_Implicit(int v) { }

	// RVA: 0x289A460 Offset: 0x2898E60 VA: 0x18289A460
	public static float3 op_Implicit(int3 v) { }

	// RVA: 0x289A420 Offset: 0x2898E20 VA: 0x18289A420
	public static float3 op_Implicit(uint v) { }

	// RVA: 0x289A390 Offset: 0x2898D90 VA: 0x18289A390
	public static float3 op_Implicit(uint3 v) { }

	// RVA: 0x292F9D0 Offset: 0x292E3D0 VA: 0x18292F9D0
	public static float3 op_Implicit(half v) { }

	// RVA: 0x292FA00 Offset: 0x292E400 VA: 0x18292FA00
	public static float3 op_Implicit(half3 v) { }

	// RVA: 0x289A1A0 Offset: 0x2898BA0 VA: 0x18289A1A0
	public static float3 op_Explicit(double v) { }

	// RVA: 0x289A010 Offset: 0x2898A10 VA: 0x18289A010
	public static float3 op_Explicit(double3 v) { }

	// RVA: 0xDAC620 Offset: 0xDAB020 VA: 0x180DAC620
	public static float3 op_Multiply(float3 lhs, float3 rhs) { }

	// RVA: 0x292FD90 Offset: 0x292E790 VA: 0x18292FD90
	public static float3 op_Multiply(float3 lhs, float rhs) { }

	// RVA: 0x292FD60 Offset: 0x292E760 VA: 0x18292FD60
	public static float3 op_Multiply(float lhs, float3 rhs) { }

	// RVA: 0x292F6B0 Offset: 0x292E0B0 VA: 0x18292F6B0
	public static float3 op_Addition(float3 lhs, float3 rhs) { }

	// RVA: 0x292F650 Offset: 0x292E050 VA: 0x18292F650
	public static float3 op_Addition(float3 lhs, float rhs) { }

	// RVA: 0x292F680 Offset: 0x292E080 VA: 0x18292F680
	public static float3 op_Addition(float lhs, float3 rhs) { }

	// RVA: 0x292FDF0 Offset: 0x292E7F0 VA: 0x18292FDF0
	public static float3 op_Subtraction(float3 lhs, float3 rhs) { }

	// RVA: 0x292FDC0 Offset: 0x292E7C0 VA: 0x18292FDC0
	public static float3 op_Subtraction(float3 lhs, float rhs) { }

	// RVA: 0x292FE30 Offset: 0x292E830 VA: 0x18292FE30
	public static float3 op_Subtraction(float lhs, float3 rhs) { }

	// RVA: 0x1EACB50 Offset: 0x1EAB550 VA: 0x181EACB50
	public static float3 op_Division(float3 lhs, float3 rhs) { }

	// RVA: 0x292F760 Offset: 0x292E160 VA: 0x18292F760
	public static float3 op_Division(float3 lhs, float rhs) { }

	// RVA: 0x292F730 Offset: 0x292E130 VA: 0x18292F730
	public static float3 op_Division(float lhs, float3 rhs) { }

	// RVA: 0x289D9B0 Offset: 0x289C3B0 VA: 0x18289D9B0
	public static float3 op_Modulus(float3 lhs, float3 rhs) { }

	// RVA: 0x292FD00 Offset: 0x292E700 VA: 0x18292FD00
	public static float3 op_Modulus(float3 lhs, float rhs) { }

	// RVA: 0x292FCA0 Offset: 0x292E6A0 VA: 0x18292FCA0
	public static float3 op_Modulus(float lhs, float3 rhs) { }

	// RVA: 0x292FA40 Offset: 0x292E440 VA: 0x18292FA40
	public static float3 op_Increment(float3 val) { }

	// RVA: 0x292F6F0 Offset: 0x292E0F0 VA: 0x18292F6F0
	public static float3 op_Decrement(float3 val) { }

	// RVA: 0x292FC40 Offset: 0x292E640 VA: 0x18292FC40
	public static bool3 op_LessThan(float3 lhs, float3 rhs) { }

	// RVA: 0x292FC80 Offset: 0x292E680 VA: 0x18292FC80
	public static bool3 op_LessThan(float3 lhs, float rhs) { }

	// RVA: 0x292FC10 Offset: 0x292E610 VA: 0x18292FC10
	public static bool3 op_LessThan(float lhs, float3 rhs) { }

	// RVA: 0x292FB80 Offset: 0x292E580 VA: 0x18292FB80
	public static bool3 op_LessThanOrEqual(float3 lhs, float3 rhs) { }

	// RVA: 0x292FBF0 Offset: 0x292E5F0 VA: 0x18292FBF0
	public static bool3 op_LessThanOrEqual(float3 lhs, float rhs) { }

	// RVA: 0x292FBC0 Offset: 0x292E5C0 VA: 0x18292FBC0
	public static bool3 op_LessThanOrEqual(float lhs, float3 rhs) { }

	// RVA: 0x292F930 Offset: 0x292E330 VA: 0x18292F930
	public static bool3 op_GreaterThan(float3 lhs, float3 rhs) { }

	// RVA: 0x292F9A0 Offset: 0x292E3A0 VA: 0x18292F9A0
	public static bool3 op_GreaterThan(float3 lhs, float rhs) { }

	// RVA: 0x292F970 Offset: 0x292E370 VA: 0x18292F970
	public static bool3 op_GreaterThan(float lhs, float3 rhs) { }

	// RVA: 0x292F890 Offset: 0x292E290 VA: 0x18292F890
	public static bool3 op_GreaterThanOrEqual(float3 lhs, float3 rhs) { }

	// RVA: 0x292F8D0 Offset: 0x292E2D0 VA: 0x18292F8D0
	public static bool3 op_GreaterThanOrEqual(float3 lhs, float rhs) { }

	// RVA: 0x292F900 Offset: 0x292E300 VA: 0x18292F900
	public static bool3 op_GreaterThanOrEqual(float lhs, float3 rhs) { }

	// RVA: 0x4D1A70 Offset: 0x4D0470 VA: 0x1804D1A70
	public static float3 op_UnaryNegation(float3 val) { }

	// RVA: 0x541660 Offset: 0x540060 VA: 0x180541660
	public static float3 op_UnaryPlus(float3 val) { }

	// RVA: 0x292F790 Offset: 0x292E190 VA: 0x18292F790
	public static bool3 op_Equality(float3 lhs, float3 rhs) { }

	// RVA: 0x292F7F0 Offset: 0x292E1F0 VA: 0x18292F7F0
	public static bool3 op_Equality(float3 lhs, float rhs) { }

	// RVA: 0x292F840 Offset: 0x292E240 VA: 0x18292F840
	public static bool3 op_Equality(float lhs, float3 rhs) { }

	// RVA: 0x292FAD0 Offset: 0x292E4D0 VA: 0x18292FAD0
	public static bool3 op_Inequality(float3 lhs, float3 rhs) { }

	// RVA: 0x292FB30 Offset: 0x292E530 VA: 0x18292FB30
	public static bool3 op_Inequality(float3 lhs, float rhs) { }

	// RVA: 0x292FA80 Offset: 0x292E480 VA: 0x18292FA80
	public static bool3 op_Inequality(float lhs, float3 rhs) { }

	// RVA: 0x28EAF00 Offset: 0x28E9900 VA: 0x1828EAF00
	public float4 get_xxxx() { }

	// RVA: 0x28EAF20 Offset: 0x28E9920 VA: 0x1828EAF20
	public float4 get_xxxy() { }

	// RVA: 0x28EAF40 Offset: 0x28E9940 VA: 0x1828EAF40
	public float4 get_xxxz() { }

	// RVA: 0x28EAFA0 Offset: 0x28E99A0 VA: 0x1828EAFA0
	public float4 get_xxyx() { }

	// RVA: 0x28EAFC0 Offset: 0x28E99C0 VA: 0x1828EAFC0
	public float4 get_xxyy() { }

	// RVA: 0x28EAFE0 Offset: 0x28E99E0 VA: 0x1828EAFE0
	public float4 get_xxyz() { }

	// RVA: 0x28EB040 Offset: 0x28E9A40 VA: 0x1828EB040
	public float4 get_xxzx() { }

	// RVA: 0x28EB060 Offset: 0x28E9A60 VA: 0x1828EB060
	public float4 get_xxzy() { }

	// RVA: 0x2716A20 Offset: 0x2715420 VA: 0x182716A20
	public float4 get_xxzz() { }

	// RVA: 0x28EB160 Offset: 0x28E9B60 VA: 0x1828EB160
	public float4 get_xyxx() { }

	// RVA: 0x28EB180 Offset: 0x28E9B80 VA: 0x1828EB180
	public float4 get_xyxy() { }

	// RVA: 0x28EB1A0 Offset: 0x28E9BA0 VA: 0x1828EB1A0
	public float4 get_xyxz() { }

	// RVA: 0x28EB200 Offset: 0x28E9C00 VA: 0x1828EB200
	public float4 get_xyyx() { }

	// RVA: 0x28EB220 Offset: 0x28E9C20 VA: 0x1828EB220
	public float4 get_xyyy() { }

	// RVA: 0x28EB240 Offset: 0x28E9C40 VA: 0x1828EB240
	public float4 get_xyyz() { }

	// RVA: 0x28EB260 Offset: 0x28E9C60 VA: 0x1828EB260
	public float4 get_xyzx() { }

	// RVA: 0x28EB280 Offset: 0x28E9C80 VA: 0x1828EB280
	public float4 get_xyzy() { }

	// RVA: 0x28EB2A0 Offset: 0x28E9CA0 VA: 0x1828EB2A0
	public float4 get_xyzz() { }

	// RVA: 0x28EB3A0 Offset: 0x28E9DA0 VA: 0x1828EB3A0
	public float4 get_xzxx() { }

	// RVA: 0x28EB3C0 Offset: 0x28E9DC0 VA: 0x1828EB3C0
	public float4 get_xzxy() { }

	// RVA: 0x28EB3E0 Offset: 0x28E9DE0 VA: 0x1828EB3E0
	public float4 get_xzxz() { }

	// RVA: 0x28EB440 Offset: 0x28E9E40 VA: 0x1828EB440
	public float4 get_xzyx() { }

	// RVA: 0x28EB460 Offset: 0x28E9E60 VA: 0x1828EB460
	public float4 get_xzyy() { }

	// RVA: 0x28EB480 Offset: 0x28E9E80 VA: 0x1828EB480
	public float4 get_xzyz() { }

	// RVA: 0x28EB4E0 Offset: 0x28E9EE0 VA: 0x1828EB4E0
	public float4 get_xzzx() { }

	// RVA: 0x28EB500 Offset: 0x28E9F00 VA: 0x1828EB500
	public float4 get_xzzy() { }

	// RVA: 0x28EB520 Offset: 0x28E9F20 VA: 0x1828EB520
	public float4 get_xzzz() { }

	// RVA: 0x28EB8E0 Offset: 0x28EA2E0 VA: 0x1828EB8E0
	public float4 get_yxxx() { }

	// RVA: 0x28EB900 Offset: 0x28EA300 VA: 0x1828EB900
	public float4 get_yxxy() { }

	// RVA: 0x28EB920 Offset: 0x28EA320 VA: 0x1828EB920
	public float4 get_yxxz() { }

	// RVA: 0x28EB980 Offset: 0x28EA380 VA: 0x1828EB980
	public float4 get_yxyx() { }

	// RVA: 0x28EB9A0 Offset: 0x28EA3A0 VA: 0x1828EB9A0
	public float4 get_yxyy() { }

	// RVA: 0x28EB9C0 Offset: 0x28EA3C0 VA: 0x1828EB9C0
	public float4 get_yxyz() { }

	// RVA: 0x28EBA20 Offset: 0x28EA420 VA: 0x1828EBA20
	public float4 get_yxzx() { }

	// RVA: 0x28EBA40 Offset: 0x28EA440 VA: 0x1828EBA40
	public float4 get_yxzy() { }

	// RVA: 0x28EBA60 Offset: 0x28EA460 VA: 0x1828EBA60
	public float4 get_yxzz() { }

	// RVA: 0x28EBB60 Offset: 0x28EA560 VA: 0x1828EBB60
	public float4 get_yyxx() { }

	// RVA: 0x28EBB80 Offset: 0x28EA580 VA: 0x1828EBB80
	public float4 get_yyxy() { }

	// RVA: 0x28EBBA0 Offset: 0x28EA5A0 VA: 0x1828EBBA0
	public float4 get_yyxz() { }

	// RVA: 0x28EBBF0 Offset: 0x28EA5F0 VA: 0x1828EBBF0
	public float4 get_yyyx() { }

	// RVA: 0x28EBC10 Offset: 0x28EA610 VA: 0x1828EBC10
	public float4 get_yyyy() { }

	// RVA: 0x28EBC30 Offset: 0x28EA630 VA: 0x1828EBC30
	public float4 get_yyyz() { }

	// RVA: 0x28EBC90 Offset: 0x28EA690 VA: 0x1828EBC90
	public float4 get_yyzx() { }

	// RVA: 0x28EBCB0 Offset: 0x28EA6B0 VA: 0x1828EBCB0
	public float4 get_yyzy() { }

	// RVA: 0x28EBCD0 Offset: 0x28EA6D0 VA: 0x1828EBCD0
	public float4 get_yyzz() { }

	// RVA: 0x28EBDF0 Offset: 0x28EA7F0 VA: 0x1828EBDF0
	public float4 get_yzxx() { }

	// RVA: 0x28EBE10 Offset: 0x28EA810 VA: 0x1828EBE10
	public float4 get_yzxy() { }

	// RVA: 0x28EBE30 Offset: 0x28EA830 VA: 0x1828EBE30
	public float4 get_yzxz() { }

	// RVA: 0x28EBE90 Offset: 0x28EA890 VA: 0x1828EBE90
	public float4 get_yzyx() { }

	// RVA: 0x28EBEB0 Offset: 0x28EA8B0 VA: 0x1828EBEB0
	public float4 get_yzyy() { }

	// RVA: 0x28EBED0 Offset: 0x28EA8D0 VA: 0x1828EBED0
	public float4 get_yzyz() { }

	// RVA: 0x28EBF30 Offset: 0x28EA930 VA: 0x1828EBF30
	public float4 get_yzzx() { }

	// RVA: 0x28EBF50 Offset: 0x28EA950 VA: 0x1828EBF50
	public float4 get_yzzy() { }

	// RVA: 0x28EBF70 Offset: 0x28EA970 VA: 0x1828EBF70
	public float4 get_yzzz() { }

	// RVA: 0x28EC310 Offset: 0x28EAD10 VA: 0x1828EC310
	public float4 get_zxxx() { }

	// RVA: 0x28EC330 Offset: 0x28EAD30 VA: 0x1828EC330
	public float4 get_zxxy() { }

	// RVA: 0x28EC350 Offset: 0x28EAD50 VA: 0x1828EC350
	public float4 get_zxxz() { }

	// RVA: 0x28EC3B0 Offset: 0x28EADB0 VA: 0x1828EC3B0
	public float4 get_zxyx() { }

	// RVA: 0x28EC3D0 Offset: 0x28EADD0 VA: 0x1828EC3D0
	public float4 get_zxyy() { }

	// RVA: 0x28EC3F0 Offset: 0x28EADF0 VA: 0x1828EC3F0
	public float4 get_zxyz() { }

	// RVA: 0x28EC450 Offset: 0x28EAE50 VA: 0x1828EC450
	public float4 get_zxzx() { }

	// RVA: 0x28EC470 Offset: 0x28EAE70 VA: 0x1828EC470
	public float4 get_zxzy() { }

	// RVA: 0x28EC490 Offset: 0x28EAE90 VA: 0x1828EC490
	public float4 get_zxzz() { }

	// RVA: 0x28EC5B0 Offset: 0x28EAFB0 VA: 0x1828EC5B0
	public float4 get_zyxx() { }

	// RVA: 0x28EC5D0 Offset: 0x28EAFD0 VA: 0x1828EC5D0
	public float4 get_zyxy() { }

	// RVA: 0x28EC5F0 Offset: 0x28EAFF0 VA: 0x1828EC5F0
	public float4 get_zyxz() { }

	// RVA: 0x28EC650 Offset: 0x28EB050 VA: 0x1828EC650
	public float4 get_zyyx() { }

	// RVA: 0x28EC670 Offset: 0x28EB070 VA: 0x1828EC670
	public float4 get_zyyy() { }

	// RVA: 0x28EC690 Offset: 0x28EB090 VA: 0x1828EC690
	public float4 get_zyyz() { }

	// RVA: 0x28EC6F0 Offset: 0x28EB0F0 VA: 0x1828EC6F0
	public float4 get_zyzx() { }

	// RVA: 0x28EC710 Offset: 0x28EB110 VA: 0x1828EC710
	public float4 get_zyzy() { }

	// RVA: 0x28EC730 Offset: 0x28EB130 VA: 0x1828EC730
	public float4 get_zyzz() { }

	// RVA: 0x28EC850 Offset: 0x28EB250 VA: 0x1828EC850
	public float4 get_zzxx() { }

	// RVA: 0x28EC870 Offset: 0x28EB270 VA: 0x1828EC870
	public float4 get_zzxy() { }

	// RVA: 0x28EC890 Offset: 0x28EB290 VA: 0x1828EC890
	public float4 get_zzxz() { }

	// RVA: 0x28EC8F0 Offset: 0x28EB2F0 VA: 0x1828EC8F0
	public float4 get_zzyx() { }

	// RVA: 0x28EC910 Offset: 0x28EB310 VA: 0x1828EC910
	public float4 get_zzyy() { }

	// RVA: 0x28EC930 Offset: 0x28EB330 VA: 0x1828EC930
	public float4 get_zzyz() { }

	// RVA: 0x28EC980 Offset: 0x28EB380 VA: 0x1828EC980
	public float4 get_zzzx() { }

	// RVA: 0x28EC9A0 Offset: 0x28EB3A0 VA: 0x1828EC9A0
	public float4 get_zzzy() { }

	// RVA: 0x28EC9C0 Offset: 0x28EB3C0 VA: 0x1828EC9C0
	public float4 get_zzzz() { }

	// RVA: 0x28EAED0 Offset: 0x28E98D0 VA: 0x1828EAED0
	public float3 get_xxx() { }

	// RVA: 0x28EAF60 Offset: 0x28E9960 VA: 0x1828EAF60
	public float3 get_xxy() { }

	// RVA: 0x28EB000 Offset: 0x28E9A00 VA: 0x1828EB000
	public float3 get_xxz() { }

	// RVA: 0x28EB120 Offset: 0x28E9B20 VA: 0x1828EB120
	public float3 get_xyx() { }

	// RVA: 0x28EB1C0 Offset: 0x28E9BC0 VA: 0x1828EB1C0
	public float3 get_xyy() { }

	// RVA: 0x541660 Offset: 0x540060 VA: 0x180541660
	public float3 get_xyz() { }

	// RVA: 0x28ED540 Offset: 0x28EBF40 VA: 0x1828ED540
	public void set_xyz(float3 value) { }

	// RVA: 0x28EB360 Offset: 0x28E9D60 VA: 0x1828EB360
	public float3 get_xzx() { }

	// RVA: 0x28EB400 Offset: 0x28E9E00 VA: 0x1828EB400
	public float3 get_xzy() { }

	// RVA: 0x28ED5B0 Offset: 0x28EBFB0 VA: 0x1828ED5B0
	public void set_xzy(float3 value) { }

	// RVA: 0x28EB4A0 Offset: 0x28E9EA0 VA: 0x1828EB4A0
	public float3 get_xzz() { }

	// RVA: 0x28EB8A0 Offset: 0x28EA2A0 VA: 0x1828EB8A0
	public float3 get_yxx() { }

	// RVA: 0x28EB940 Offset: 0x28EA340 VA: 0x1828EB940
	public float3 get_yxy() { }

	// RVA: 0x28EB9E0 Offset: 0x28EA3E0 VA: 0x1828EB9E0
	public float3 get_yxz() { }

	// RVA: 0x28ED6D0 Offset: 0x28EC0D0 VA: 0x1828ED6D0
	public void set_yxz(float3 value) { }

	// RVA: 0x28EBB20 Offset: 0x28EA520 VA: 0x1828EBB20
	public float3 get_yyx() { }

	// RVA: 0x28EBBC0 Offset: 0x28EA5C0 VA: 0x1828EBBC0
	public float3 get_yyy() { }

	// RVA: 0x28EBC50 Offset: 0x28EA650 VA: 0x1828EBC50
	public float3 get_yyz() { }

	// RVA: 0x28EBDB0 Offset: 0x28EA7B0 VA: 0x1828EBDB0
	public float3 get_yzx() { }

	// RVA: 0x28ED760 Offset: 0x28EC160 VA: 0x1828ED760
	public void set_yzx(float3 value) { }

	// RVA: 0x28EBE50 Offset: 0x28EA850 VA: 0x1828EBE50
	public float3 get_yzy() { }

	// RVA: 0x28EBEF0 Offset: 0x28EA8F0 VA: 0x1828EBEF0
	public float3 get_yzz() { }

	// RVA: 0x28EC2D0 Offset: 0x28EACD0 VA: 0x1828EC2D0
	public float3 get_zxx() { }

	// RVA: 0x28EC370 Offset: 0x28EAD70 VA: 0x1828EC370
	public float3 get_zxy() { }

	// RVA: 0x28ED870 Offset: 0x28EC270 VA: 0x1828ED870
	public void set_zxy(float3 value) { }

	// RVA: 0x28EC410 Offset: 0x28EAE10 VA: 0x1828EC410
	public float3 get_zxz() { }

	// RVA: 0x28EC570 Offset: 0x28EAF70 VA: 0x1828EC570
	public float3 get_zyx() { }

	// RVA: 0x28ED900 Offset: 0x28EC300 VA: 0x1828ED900
	public void set_zyx(float3 value) { }

	// RVA: 0x28EC610 Offset: 0x28EB010 VA: 0x1828EC610
	public float3 get_zyy() { }

	// RVA: 0x28EC6B0 Offset: 0x28EB0B0 VA: 0x1828EC6B0
	public float3 get_zyz() { }

	// RVA: 0x28EC810 Offset: 0x28EB210 VA: 0x1828EC810
	public float3 get_zzx() { }

	// RVA: 0x28EC8B0 Offset: 0x28EB2B0 VA: 0x1828EC8B0
	public float3 get_zzy() { }

	// RVA: 0x28EC950 Offset: 0x28EB350 VA: 0x1828EC950
	public float3 get_zzz() { }

	// RVA: 0x2928AE0 Offset: 0x29274E0 VA: 0x182928AE0
	public float2 get_xx() { }

	// RVA: 0x4A0C40 Offset: 0x49F640 VA: 0x1804A0C40
	public float2 get_xy() { }

	// RVA: 0x214CC40 Offset: 0x214B640 VA: 0x18214CC40
	public void set_xy(float2 value) { }

	// RVA: 0x7BCB30 Offset: 0x7BB530 VA: 0x1807BCB30
	public float2 get_xz() { }

	// RVA: 0x292FE60 Offset: 0x292E860 VA: 0x18292FE60
	public void set_xz(float2 value) { }

	// RVA: 0x7BCB50 Offset: 0x7BB550 VA: 0x1807BCB50
	public float2 get_yx() { }

	// RVA: 0x2929280 Offset: 0x2927C80 VA: 0x182929280
	public void set_yx(float2 value) { }

	// RVA: 0x2928AF0 Offset: 0x29274F0 VA: 0x182928AF0
	public float2 get_yy() { }

	// RVA: 0x7BCB70 Offset: 0x7BB570 VA: 0x1807BCB70
	public float2 get_yz() { }

	// RVA: 0x292FE80 Offset: 0x292E880 VA: 0x18292FE80
	public void set_yz(float2 value) { }

	// RVA: 0x7BCB90 Offset: 0x7BB590 VA: 0x1807BCB90
	public float2 get_zx() { }

	// RVA: 0x292FEA0 Offset: 0x292E8A0 VA: 0x18292FEA0
	public void set_zx(float2 value) { }

	// RVA: 0x7BCBB0 Offset: 0x7BB5B0 VA: 0x1807BCBB0
	public float2 get_zy() { }

	// RVA: 0x292FEC0 Offset: 0x292E8C0 VA: 0x18292FEC0
	public void set_zy(float2 value) { }

	// RVA: 0x292F630 Offset: 0x292E030 VA: 0x18292F630
	public float2 get_zz() { }

	// RVA: 0xF6CE40 Offset: 0xF6B840 VA: 0x180F6CE40
	public float get_Item(int index) { }

	// RVA: 0xF73260 Offset: 0xF71C60 VA: 0x180F73260
	public void set_Item(int index, float value) { }

	// RVA: 0x292F1D0 Offset: 0x292DBD0 VA: 0x18292F1D0 Slot: 4
	public bool Equals(float3 rhs) { }

	// RVA: 0x292F200 Offset: 0x292DC00 VA: 0x18292F200 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x28A1970 Offset: 0x28A0370 VA: 0x1828A1970 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x292F2B0 Offset: 0x292DCB0 VA: 0x18292F2B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x292F370 Offset: 0x292DD70 VA: 0x18292F370 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x541660 Offset: 0x540060 VA: 0x180541660
	public static Vector3 op_Implicit(float3 v) { }

	// RVA: 0x541660 Offset: 0x540060 VA: 0x180541660
	public static float3 op_Implicit(Vector3 v) { }
}
