public struct float2 : IEquatable<float2>, IFormattable // TypeDefIndex: 10900
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public static readonly float2 zero; // 0x0

	// Properties
	[EditorBrowsable(1)]
	public float4 xxxx { get; }
	[EditorBrowsable(1)]
	public float4 xxxy { get; }
	[EditorBrowsable(1)]
	public float4 xxyx { get; }
	[EditorBrowsable(1)]
	public float4 xxyy { get; }
	[EditorBrowsable(1)]
	public float4 xyxx { get; }
	[EditorBrowsable(1)]
	public float4 xyxy { get; }
	[EditorBrowsable(1)]
	public float4 xyyx { get; }
	[EditorBrowsable(1)]
	public float4 xyyy { get; }
	[EditorBrowsable(1)]
	public float4 yxxx { get; }
	[EditorBrowsable(1)]
	public float4 yxxy { get; }
	[EditorBrowsable(1)]
	public float4 yxyx { get; }
	[EditorBrowsable(1)]
	public float4 yxyy { get; }
	[EditorBrowsable(1)]
	public float4 yyxx { get; }
	[EditorBrowsable(1)]
	public float4 yyxy { get; }
	[EditorBrowsable(1)]
	public float4 yyyx { get; }
	[EditorBrowsable(1)]
	public float4 yyyy { get; }
	[EditorBrowsable(1)]
	public float3 xxx { get; }
	[EditorBrowsable(1)]
	public float3 xxy { get; }
	[EditorBrowsable(1)]
	public float3 xyx { get; }
	[EditorBrowsable(1)]
	public float3 xyy { get; }
	[EditorBrowsable(1)]
	public float3 yxx { get; }
	[EditorBrowsable(1)]
	public float3 yxy { get; }
	[EditorBrowsable(1)]
	public float3 yyx { get; }
	[EditorBrowsable(1)]
	public float3 yyy { get; }
	[EditorBrowsable(1)]
	public float2 xx { get; }
	[EditorBrowsable(1)]
	public float2 xy { get; set; }
	[EditorBrowsable(1)]
	public float2 yx { get; set; }
	[EditorBrowsable(1)]
	public float2 yy { get; }
	public float Item { get; set; }

	// Methods

	// RVA: 0x7B38F0 Offset: 0x7B22F0 VA: 0x1807B38F0
	public void .ctor(float x, float y) { }

	// RVA: 0x214CC40 Offset: 0x214B640 VA: 0x18214CC40
	public void .ctor(float2 xy) { }

	// RVA: 0x29289C0 Offset: 0x29273C0 VA: 0x1829289C0
	public void .ctor(float v) { }

	// RVA: 0x2928A90 Offset: 0x2927490 VA: 0x182928A90
	public void .ctor(bool v) { }

	// RVA: 0x2928990 Offset: 0x2927390 VA: 0x182928990
	public void .ctor(bool2 v) { }

	// RVA: 0x2928A50 Offset: 0x2927450 VA: 0x182928A50
	public void .ctor(int v) { }

	// RVA: 0x2928A30 Offset: 0x2927430 VA: 0x182928A30
	public void .ctor(int2 v) { }

	// RVA: 0x2928A00 Offset: 0x2927400 VA: 0x182928A00
	public void .ctor(uint v) { }

	// RVA: 0x29289D0 Offset: 0x29273D0 VA: 0x1829289D0
	public void .ctor(uint2 v) { }

	// RVA: 0x28822B0 Offset: 0x2880CB0 VA: 0x1828822B0
	public void .ctor(half v) { }

	// RVA: 0x2882380 Offset: 0x2880D80 VA: 0x182882380
	public void .ctor(half2 v) { }

	// RVA: 0x2928A70 Offset: 0x2927470 VA: 0x182928A70
	public void .ctor(double v) { }

	// RVA: 0x2928AC0 Offset: 0x29274C0 VA: 0x182928AC0
	public void .ctor(double2 v) { }

	// RVA: 0x2899320 Offset: 0x2897D20 VA: 0x182899320
	public static float2 op_Implicit(float v) { }

	// RVA: 0x2899030 Offset: 0x2897A30 VA: 0x182899030
	public static float2 op_Explicit(bool v) { }

	// RVA: 0x2899080 Offset: 0x2897A80 VA: 0x182899080
	public static float2 op_Explicit(bool2 v) { }

	// RVA: 0x28990D0 Offset: 0x2897AD0 VA: 0x1828990D0
	public static float2 op_Implicit(int v) { }

	// RVA: 0x214C690 Offset: 0x214B090 VA: 0x18214C690
	public static float2 op_Implicit(int2 v) { }

	// RVA: 0x28991F0 Offset: 0x2897BF0 VA: 0x1828991F0
	public static float2 op_Implicit(uint v) { }

	// RVA: 0x28990F0 Offset: 0x2897AF0 VA: 0x1828990F0
	public static float2 op_Implicit(uint2 v) { }

	// RVA: 0x2899240 Offset: 0x2897C40 VA: 0x182899240
	public static float2 op_Implicit(half v) { }

	// RVA: 0x2899120 Offset: 0x2897B20 VA: 0x182899120
	public static float2 op_Implicit(half2 v) { }

	// RVA: 0x2899300 Offset: 0x2897D00 VA: 0x182899300
	public static float2 op_Explicit(double v) { }

	// RVA: 0x2899060 Offset: 0x2897A60 VA: 0x182899060
	public static float2 op_Explicit(double2 v) { }

	// RVA: 0xDAC660 Offset: 0xDAB060 VA: 0x180DAC660
	public static float2 op_Multiply(float2 lhs, float2 rhs) { }

	// RVA: 0x2929160 Offset: 0x2927B60 VA: 0x182929160
	public static float2 op_Multiply(float2 lhs, float rhs) { }

	// RVA: 0x2929190 Offset: 0x2927B90 VA: 0x182929190
	public static float2 op_Multiply(float lhs, float2 rhs) { }

	// RVA: 0x2928B40 Offset: 0x2927540 VA: 0x182928B40
	public static float2 op_Addition(float2 lhs, float2 rhs) { }

	// RVA: 0x2928B10 Offset: 0x2927510 VA: 0x182928B10
	public static float2 op_Addition(float2 lhs, float rhs) { }

	// RVA: 0x2928B80 Offset: 0x2927580 VA: 0x182928B80
	public static float2 op_Addition(float lhs, float2 rhs) { }

	// RVA: 0x29291C0 Offset: 0x2927BC0 VA: 0x1829291C0
	public static float2 op_Subtraction(float2 lhs, float2 rhs) { }

	// RVA: 0x2929220 Offset: 0x2927C20 VA: 0x182929220
	public static float2 op_Subtraction(float2 lhs, float rhs) { }

	// RVA: 0x2929200 Offset: 0x2927C00 VA: 0x182929200
	public static float2 op_Subtraction(float lhs, float2 rhs) { }

	// RVA: 0x2928C10 Offset: 0x2927610 VA: 0x182928C10
	public static float2 op_Division(float2 lhs, float2 rhs) { }

	// RVA: 0x2928BE0 Offset: 0x29275E0 VA: 0x182928BE0
	public static float2 op_Division(float2 lhs, float rhs) { }

	// RVA: 0x2928C50 Offset: 0x2927650 VA: 0x182928C50
	public static float2 op_Division(float lhs, float2 rhs) { }

	// RVA: 0x289DA90 Offset: 0x289C490 VA: 0x18289DA90
	public static float2 op_Modulus(float2 lhs, float2 rhs) { }

	// RVA: 0x2929110 Offset: 0x2927B10 VA: 0x182929110
	public static float2 op_Modulus(float2 lhs, float rhs) { }

	// RVA: 0x29290C0 Offset: 0x2927AC0 VA: 0x1829290C0
	public static float2 op_Modulus(float lhs, float2 rhs) { }

	// RVA: 0x2928E80 Offset: 0x2927880 VA: 0x182928E80
	public static float2 op_Increment(float2 val) { }

	// RVA: 0x2928BB0 Offset: 0x29275B0 VA: 0x182928BB0
	public static float2 op_Decrement(float2 val) { }

	// RVA: 0x2929060 Offset: 0x2927A60 VA: 0x182929060
	public static bool2 op_LessThan(float2 lhs, float2 rhs) { }

	// RVA: 0x29290A0 Offset: 0x2927AA0 VA: 0x1829290A0
	public static bool2 op_LessThan(float2 lhs, float rhs) { }

	// RVA: 0x2929030 Offset: 0x2927A30 VA: 0x182929030
	public static bool2 op_LessThan(float lhs, float2 rhs) { }

	// RVA: 0x2928FD0 Offset: 0x29279D0 VA: 0x182928FD0
	public static bool2 op_LessThanOrEqual(float2 lhs, float2 rhs) { }

	// RVA: 0x2929010 Offset: 0x2927A10 VA: 0x182929010
	public static bool2 op_LessThanOrEqual(float2 lhs, float rhs) { }

	// RVA: 0x2928FA0 Offset: 0x29279A0 VA: 0x182928FA0
	public static bool2 op_LessThanOrEqual(float lhs, float2 rhs) { }

	// RVA: 0x2928E20 Offset: 0x2927820 VA: 0x182928E20
	public static bool2 op_GreaterThan(float2 lhs, float2 rhs) { }

	// RVA: 0x2928DF0 Offset: 0x29277F0 VA: 0x182928DF0
	public static bool2 op_GreaterThan(float2 lhs, float rhs) { }

	// RVA: 0x2928E60 Offset: 0x2927860 VA: 0x182928E60
	public static bool2 op_GreaterThan(float lhs, float2 rhs) { }

	// RVA: 0x2928D60 Offset: 0x2927760 VA: 0x182928D60
	public static bool2 op_GreaterThanOrEqual(float2 lhs, float2 rhs) { }

	// RVA: 0x2928DC0 Offset: 0x29277C0 VA: 0x182928DC0
	public static bool2 op_GreaterThanOrEqual(float2 lhs, float rhs) { }

	// RVA: 0x2928DA0 Offset: 0x29277A0 VA: 0x182928DA0
	public static bool2 op_GreaterThanOrEqual(float lhs, float2 rhs) { }

	// RVA: 0x2929250 Offset: 0x2927C50 VA: 0x182929250
	public static float2 op_UnaryNegation(float2 val) { }

	// RVA: 0x2899220 Offset: 0x2897C20 VA: 0x182899220
	public static float2 op_UnaryPlus(float2 val) { }

	// RVA: 0x2928C70 Offset: 0x2927670 VA: 0x182928C70
	public static bool2 op_Equality(float2 lhs, float2 rhs) { }

	// RVA: 0x2928CD0 Offset: 0x29276D0 VA: 0x182928CD0
	public static bool2 op_Equality(float2 lhs, float rhs) { }

	// RVA: 0x2928D20 Offset: 0x2927720 VA: 0x182928D20
	public static bool2 op_Equality(float lhs, float2 rhs) { }

	// RVA: 0x2928F40 Offset: 0x2927940 VA: 0x182928F40
	public static bool2 op_Inequality(float2 lhs, float2 rhs) { }

	// RVA: 0x2928EB0 Offset: 0x29278B0 VA: 0x182928EB0
	public static bool2 op_Inequality(float2 lhs, float rhs) { }

	// RVA: 0x2928F00 Offset: 0x2927900 VA: 0x182928F00
	public static bool2 op_Inequality(float lhs, float2 rhs) { }

	// RVA: 0x28EAF00 Offset: 0x28E9900 VA: 0x1828EAF00
	public float4 get_xxxx() { }

	// RVA: 0x28EAF20 Offset: 0x28E9920 VA: 0x1828EAF20
	public float4 get_xxxy() { }

	// RVA: 0x28EAFA0 Offset: 0x28E99A0 VA: 0x1828EAFA0
	public float4 get_xxyx() { }

	// RVA: 0x28EAFC0 Offset: 0x28E99C0 VA: 0x1828EAFC0
	public float4 get_xxyy() { }

	// RVA: 0x28EB160 Offset: 0x28E9B60 VA: 0x1828EB160
	public float4 get_xyxx() { }

	// RVA: 0x28EB180 Offset: 0x28E9B80 VA: 0x1828EB180
	public float4 get_xyxy() { }

	// RVA: 0x28EB200 Offset: 0x28E9C00 VA: 0x1828EB200
	public float4 get_xyyx() { }

	// RVA: 0x28EB220 Offset: 0x28E9C20 VA: 0x1828EB220
	public float4 get_xyyy() { }

	// RVA: 0x28EB8E0 Offset: 0x28EA2E0 VA: 0x1828EB8E0
	public float4 get_yxxx() { }

	// RVA: 0x28EB900 Offset: 0x28EA300 VA: 0x1828EB900
	public float4 get_yxxy() { }

	// RVA: 0x28EB980 Offset: 0x28EA380 VA: 0x1828EB980
	public float4 get_yxyx() { }

	// RVA: 0x28EB9A0 Offset: 0x28EA3A0 VA: 0x1828EB9A0
	public float4 get_yxyy() { }

	// RVA: 0x28EBB60 Offset: 0x28EA560 VA: 0x1828EBB60
	public float4 get_yyxx() { }

	// RVA: 0x28EBB80 Offset: 0x28EA580 VA: 0x1828EBB80
	public float4 get_yyxy() { }

	// RVA: 0x28EBBF0 Offset: 0x28EA5F0 VA: 0x1828EBBF0
	public float4 get_yyyx() { }

	// RVA: 0x28EBC10 Offset: 0x28EA610 VA: 0x1828EBC10
	public float4 get_yyyy() { }

	// RVA: 0x28EAED0 Offset: 0x28E98D0 VA: 0x1828EAED0
	public float3 get_xxx() { }

	// RVA: 0x28EAF60 Offset: 0x28E9960 VA: 0x1828EAF60
	public float3 get_xxy() { }

	// RVA: 0x28EB120 Offset: 0x28E9B20 VA: 0x1828EB120
	public float3 get_xyx() { }

	// RVA: 0x28EB1C0 Offset: 0x28E9BC0 VA: 0x1828EB1C0
	public float3 get_xyy() { }

	// RVA: 0x28EB8A0 Offset: 0x28EA2A0 VA: 0x1828EB8A0
	public float3 get_yxx() { }

	// RVA: 0x28EB940 Offset: 0x28EA340 VA: 0x1828EB940
	public float3 get_yxy() { }

	// RVA: 0x28EBB20 Offset: 0x28EA520 VA: 0x1828EBB20
	public float3 get_yyx() { }

	// RVA: 0x28EBBC0 Offset: 0x28EA5C0 VA: 0x1828EBBC0
	public float3 get_yyy() { }

	// RVA: 0x2928AE0 Offset: 0x29274E0 VA: 0x182928AE0
	public float2 get_xx() { }

	// RVA: 0x4A0C40 Offset: 0x49F640 VA: 0x1804A0C40
	public float2 get_xy() { }

	// RVA: 0x214CC40 Offset: 0x214B640 VA: 0x18214CC40
	public void set_xy(float2 value) { }

	// RVA: 0x7BCB50 Offset: 0x7BB550 VA: 0x1807BCB50
	public float2 get_yx() { }

	// RVA: 0x2929280 Offset: 0x2927C80 VA: 0x182929280
	public void set_yx(float2 value) { }

	// RVA: 0x2928AF0 Offset: 0x29274F0 VA: 0x182928AF0
	public float2 get_yy() { }

	// RVA: 0xF6CE40 Offset: 0xF6B840 VA: 0x180F6CE40
	public float get_Item(int index) { }

	// RVA: 0xF73260 Offset: 0xF71C60 VA: 0x180F73260
	public void set_Item(int index, float value) { }

	// RVA: 0x7B3800 Offset: 0x7B2200 VA: 0x1807B3800 Slot: 4
	public bool Equals(float2 rhs) { }

	// RVA: 0x2928750 Offset: 0x2927150 VA: 0x182928750 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x29287F0 Offset: 0x29271F0 VA: 0x1829287F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2928900 Offset: 0x2927300 VA: 0x182928900 Slot: 3
	public override string ToString() { }

	// RVA: 0x2928870 Offset: 0x2927270 VA: 0x182928870 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2899220 Offset: 0x2897C20 VA: 0x182899220
	public static Vector2 op_Implicit(float2 v) { }

	// RVA: 0x2899220 Offset: 0x2897C20 VA: 0x182899220
	public static float2 op_Implicit(Vector2 v) { }
}
