public struct uint2 : IEquatable<uint2>, IFormattable // TypeDefIndex: 10943
{
	// Fields
	public uint x; // 0x0
	public uint y; // 0x4
	public static readonly uint2 zero; // 0x0

	// Properties
	[EditorBrowsable(1)]
	public uint4 xxxx { get; }
	[EditorBrowsable(1)]
	public uint4 xxxy { get; }
	[EditorBrowsable(1)]
	public uint4 xxyx { get; }
	[EditorBrowsable(1)]
	public uint4 xxyy { get; }
	[EditorBrowsable(1)]
	public uint4 xyxx { get; }
	[EditorBrowsable(1)]
	public uint4 xyxy { get; }
	[EditorBrowsable(1)]
	public uint4 xyyx { get; }
	[EditorBrowsable(1)]
	public uint4 xyyy { get; }
	[EditorBrowsable(1)]
	public uint4 yxxx { get; }
	[EditorBrowsable(1)]
	public uint4 yxxy { get; }
	[EditorBrowsable(1)]
	public uint4 yxyx { get; }
	[EditorBrowsable(1)]
	public uint4 yxyy { get; }
	[EditorBrowsable(1)]
	public uint4 yyxx { get; }
	[EditorBrowsable(1)]
	public uint4 yyxy { get; }
	[EditorBrowsable(1)]
	public uint4 yyyx { get; }
	[EditorBrowsable(1)]
	public uint4 yyyy { get; }
	[EditorBrowsable(1)]
	public uint3 xxx { get; }
	[EditorBrowsable(1)]
	public uint3 xxy { get; }
	[EditorBrowsable(1)]
	public uint3 xyx { get; }
	[EditorBrowsable(1)]
	public uint3 xyy { get; }
	[EditorBrowsable(1)]
	public uint3 yxx { get; }
	[EditorBrowsable(1)]
	public uint3 yxy { get; }
	[EditorBrowsable(1)]
	public uint3 yyx { get; }
	[EditorBrowsable(1)]
	public uint3 yyy { get; }
	[EditorBrowsable(1)]
	public uint2 xx { get; }
	[EditorBrowsable(1)]
	public uint2 xy { get; set; }
	[EditorBrowsable(1)]
	public uint2 yx { get; set; }
	[EditorBrowsable(1)]
	public uint2 yy { get; }
	public uint Item { get; set; }

	// Methods

	// RVA: 0x541AB0 Offset: 0x5404B0 VA: 0x180541AB0
	public void .ctor(uint x, uint y) { }

	// RVA: 0x214D550 Offset: 0x214BF50 VA: 0x18214D550
	public void .ctor(uint2 xy) { }

	// RVA: 0x2953480 Offset: 0x2951E80 VA: 0x182953480
	public void .ctor(uint v) { }

	// RVA: 0x29534A0 Offset: 0x2951EA0 VA: 0x1829534A0
	public void .ctor(bool v) { }

	// RVA: 0x29534E0 Offset: 0x2951EE0 VA: 0x1829534E0
	public void .ctor(bool2 v) { }

	// RVA: 0x2953480 Offset: 0x2951E80 VA: 0x182953480
	public void .ctor(int v) { }

	// RVA: 0x214D550 Offset: 0x214BF50 VA: 0x18214D550
	public void .ctor(int2 v) { }

	// RVA: 0x298C1E0 Offset: 0x298ABE0 VA: 0x18298C1E0
	public void .ctor(float v) { }

	// RVA: 0x298C210 Offset: 0x298AC10 VA: 0x18298C210
	public void .ctor(float2 v) { }

	// RVA: 0x298C1B0 Offset: 0x298ABB0 VA: 0x18298C1B0
	public void .ctor(double v) { }

	// RVA: 0x298C250 Offset: 0x298AC50 VA: 0x18298C250
	public void .ctor(double2 v) { }

	// RVA: 0x28A74A0 Offset: 0x28A5EA0 VA: 0x1828A74A0
	public static uint2 op_Implicit(uint v) { }

	// RVA: 0x28A7440 Offset: 0x28A5E40 VA: 0x1828A7440
	public static uint2 op_Explicit(bool v) { }

	// RVA: 0x28A7480 Offset: 0x28A5E80 VA: 0x1828A7480
	public static uint2 op_Explicit(bool2 v) { }

	// RVA: 0x28A74A0 Offset: 0x28A5EA0 VA: 0x1828A74A0
	public static uint2 op_Explicit(int v) { }

	// RVA: 0x2746F10 Offset: 0x2745910 VA: 0x182746F10
	public static uint2 op_Explicit(int2 v) { }

	// RVA: 0x28D28A0 Offset: 0x28D12A0 VA: 0x1828D28A0
	public static uint2 op_Explicit(float v) { }

	// RVA: 0x28D28E0 Offset: 0x28D12E0 VA: 0x1828D28E0
	public static uint2 op_Explicit(float2 v) { }

	// RVA: 0x28D2860 Offset: 0x28D1260 VA: 0x1828D2860
	public static uint2 op_Explicit(double v) { }

	// RVA: 0x28D2810 Offset: 0x28D1210 VA: 0x1828D2810
	public static uint2 op_Explicit(double2 v) { }

	// RVA: 0x2953A80 Offset: 0x2952480 VA: 0x182953A80
	public static uint2 op_Multiply(uint2 lhs, uint2 rhs) { }

	// RVA: 0x2953A60 Offset: 0x2952460 VA: 0x182953A60
	public static uint2 op_Multiply(uint2 lhs, uint rhs) { }

	// RVA: 0x2953A40 Offset: 0x2952440 VA: 0x182953A40
	public static uint2 op_Multiply(uint lhs, uint2 rhs) { }

	// RVA: 0xB1B7F0 Offset: 0xB1A1F0 VA: 0x180B1B7F0
	public static uint2 op_Addition(uint2 lhs, uint2 rhs) { }

	// RVA: 0x2953530 Offset: 0x2951F30 VA: 0x182953530
	public static uint2 op_Addition(uint2 lhs, uint rhs) { }

	// RVA: 0x2953510 Offset: 0x2951F10 VA: 0x182953510
	public static uint2 op_Addition(uint lhs, uint2 rhs) { }

	// RVA: 0xB1B810 Offset: 0xB1A210 VA: 0x180B1B810
	public static uint2 op_Subtraction(uint2 lhs, uint2 rhs) { }

	// RVA: 0x2953B10 Offset: 0x2952510 VA: 0x182953B10
	public static uint2 op_Subtraction(uint2 lhs, uint rhs) { }

	// RVA: 0x2953AF0 Offset: 0x29524F0 VA: 0x182953AF0
	public static uint2 op_Subtraction(uint lhs, uint2 rhs) { }

	// RVA: 0x298C2C0 Offset: 0x298ACC0 VA: 0x18298C2C0
	public static uint2 op_Division(uint2 lhs, uint2 rhs) { }

	// RVA: 0x298C2F0 Offset: 0x298ACF0 VA: 0x18298C2F0
	public static uint2 op_Division(uint2 lhs, uint rhs) { }

	// RVA: 0x298C290 Offset: 0x298AC90 VA: 0x18298C290
	public static uint2 op_Division(uint lhs, uint2 rhs) { }

	// RVA: 0x298C500 Offset: 0x298AF00 VA: 0x18298C500
	public static uint2 op_Modulus(uint2 lhs, uint2 rhs) { }

	// RVA: 0x298C4D0 Offset: 0x298AED0 VA: 0x18298C4D0
	public static uint2 op_Modulus(uint2 lhs, uint rhs) { }

	// RVA: 0x298C4A0 Offset: 0x298AEA0 VA: 0x18298C4A0
	public static uint2 op_Modulus(uint lhs, uint2 rhs) { }

	// RVA: 0x2953840 Offset: 0x2952240 VA: 0x182953840
	public static uint2 op_Increment(uint2 val) { }

	// RVA: 0x2953610 Offset: 0x2952010 VA: 0x182953610
	public static uint2 op_Decrement(uint2 val) { }

	// RVA: 0x298C440 Offset: 0x298AE40 VA: 0x18298C440
	public static bool2 op_LessThan(uint2 lhs, uint2 rhs) { }

	// RVA: 0x298C480 Offset: 0x298AE80 VA: 0x18298C480
	public static bool2 op_LessThan(uint2 lhs, uint rhs) { }

	// RVA: 0x298C460 Offset: 0x298AE60 VA: 0x18298C460
	public static bool2 op_LessThan(uint lhs, uint2 rhs) { }

	// RVA: 0x298C400 Offset: 0x298AE00 VA: 0x18298C400
	public static bool2 op_LessThanOrEqual(uint2 lhs, uint2 rhs) { }

	// RVA: 0x298C420 Offset: 0x298AE20 VA: 0x18298C420
	public static bool2 op_LessThanOrEqual(uint2 lhs, uint rhs) { }

	// RVA: 0x298C3E0 Offset: 0x298ADE0 VA: 0x18298C3E0
	public static bool2 op_LessThanOrEqual(uint lhs, uint2 rhs) { }

	// RVA: 0x298C3A0 Offset: 0x298ADA0 VA: 0x18298C3A0
	public static bool2 op_GreaterThan(uint2 lhs, uint2 rhs) { }

	// RVA: 0x298C3C0 Offset: 0x298ADC0 VA: 0x18298C3C0
	public static bool2 op_GreaterThan(uint2 lhs, uint rhs) { }

	// RVA: 0x298C380 Offset: 0x298AD80 VA: 0x18298C380
	public static bool2 op_GreaterThan(uint lhs, uint2 rhs) { }

	// RVA: 0x298C320 Offset: 0x298AD20 VA: 0x18298C320
	public static bool2 op_GreaterThanOrEqual(uint2 lhs, uint2 rhs) { }

	// RVA: 0x298C340 Offset: 0x298AD40 VA: 0x18298C340
	public static bool2 op_GreaterThanOrEqual(uint2 lhs, uint rhs) { }

	// RVA: 0x298C360 Offset: 0x298AD60 VA: 0x18298C360
	public static bool2 op_GreaterThanOrEqual(uint lhs, uint2 rhs) { }

	// RVA: 0x2953B30 Offset: 0x2952530 VA: 0x182953B30
	public static uint2 op_UnaryNegation(uint2 val) { }

	// RVA: 0x2746F10 Offset: 0x2745910 VA: 0x182746F10
	public static uint2 op_UnaryPlus(uint2 val) { }

	// RVA: 0x29538C0 Offset: 0x29522C0 VA: 0x1829538C0
	public static uint2 op_LeftShift(uint2 x, int n) { }

	// RVA: 0x298C530 Offset: 0x298AF30 VA: 0x18298C530
	public static uint2 op_RightShift(uint2 x, int n) { }

	// RVA: 0x29536E0 Offset: 0x29520E0 VA: 0x1829536E0
	public static bool2 op_Equality(uint2 lhs, uint2 rhs) { }

	// RVA: 0x2953700 Offset: 0x2952100 VA: 0x182953700
	public static bool2 op_Equality(uint2 lhs, uint rhs) { }

	// RVA: 0x29536C0 Offset: 0x29520C0 VA: 0x1829536C0
	public static bool2 op_Equality(uint lhs, uint2 rhs) { }

	// RVA: 0x2953860 Offset: 0x2952260 VA: 0x182953860
	public static bool2 op_Inequality(uint2 lhs, uint2 rhs) { }

	// RVA: 0x2953880 Offset: 0x2952280 VA: 0x182953880
	public static bool2 op_Inequality(uint2 lhs, uint rhs) { }

	// RVA: 0x29538A0 Offset: 0x29522A0 VA: 0x1829538A0
	public static bool2 op_Inequality(uint lhs, uint2 rhs) { }

	// RVA: 0x2953AA0 Offset: 0x29524A0 VA: 0x182953AA0
	public static uint2 op_OnesComplement(uint2 val) { }

	// RVA: 0x2953590 Offset: 0x2951F90 VA: 0x182953590
	public static uint2 op_BitwiseAnd(uint2 lhs, uint2 rhs) { }

	// RVA: 0x2953550 Offset: 0x2951F50 VA: 0x182953550
	public static uint2 op_BitwiseAnd(uint2 lhs, uint rhs) { }

	// RVA: 0x2953570 Offset: 0x2951F70 VA: 0x182953570
	public static uint2 op_BitwiseAnd(uint lhs, uint2 rhs) { }

	// RVA: 0x29535B0 Offset: 0x2951FB0 VA: 0x1829535B0
	public static uint2 op_BitwiseOr(uint2 lhs, uint2 rhs) { }

	// RVA: 0x29535F0 Offset: 0x2951FF0 VA: 0x1829535F0
	public static uint2 op_BitwiseOr(uint2 lhs, uint rhs) { }

	// RVA: 0x29535D0 Offset: 0x2951FD0 VA: 0x1829535D0
	public static uint2 op_BitwiseOr(uint lhs, uint2 rhs) { }

	// RVA: 0x2953760 Offset: 0x2952160 VA: 0x182953760
	public static uint2 op_ExclusiveOr(uint2 lhs, uint2 rhs) { }

	// RVA: 0x2953740 Offset: 0x2952140 VA: 0x182953740
	public static uint2 op_ExclusiveOr(uint2 lhs, uint rhs) { }

	// RVA: 0x2953720 Offset: 0x2952120 VA: 0x182953720
	public static uint2 op_ExclusiveOr(uint lhs, uint2 rhs) { }

	// RVA: 0x28EAF00 Offset: 0x28E9900 VA: 0x1828EAF00
	public uint4 get_xxxx() { }

	// RVA: 0x28EAF20 Offset: 0x28E9920 VA: 0x1828EAF20
	public uint4 get_xxxy() { }

	// RVA: 0x28EAFA0 Offset: 0x28E99A0 VA: 0x1828EAFA0
	public uint4 get_xxyx() { }

	// RVA: 0x28EAFC0 Offset: 0x28E99C0 VA: 0x1828EAFC0
	public uint4 get_xxyy() { }

	// RVA: 0x28EB160 Offset: 0x28E9B60 VA: 0x1828EB160
	public uint4 get_xyxx() { }

	// RVA: 0x28EB180 Offset: 0x28E9B80 VA: 0x1828EB180
	public uint4 get_xyxy() { }

	// RVA: 0x28EB200 Offset: 0x28E9C00 VA: 0x1828EB200
	public uint4 get_xyyx() { }

	// RVA: 0x28EB220 Offset: 0x28E9C20 VA: 0x1828EB220
	public uint4 get_xyyy() { }

	// RVA: 0x28EB8E0 Offset: 0x28EA2E0 VA: 0x1828EB8E0
	public uint4 get_yxxx() { }

	// RVA: 0x28EB900 Offset: 0x28EA300 VA: 0x1828EB900
	public uint4 get_yxxy() { }

	// RVA: 0x28EB980 Offset: 0x28EA380 VA: 0x1828EB980
	public uint4 get_yxyx() { }

	// RVA: 0x28EB9A0 Offset: 0x28EA3A0 VA: 0x1828EB9A0
	public uint4 get_yxyy() { }

	// RVA: 0x28EBB60 Offset: 0x28EA560 VA: 0x1828EBB60
	public uint4 get_yyxx() { }

	// RVA: 0x28EBB80 Offset: 0x28EA580 VA: 0x1828EBB80
	public uint4 get_yyxy() { }

	// RVA: 0x28EBBF0 Offset: 0x28EA5F0 VA: 0x1828EBBF0
	public uint4 get_yyyx() { }

	// RVA: 0x28EBC10 Offset: 0x28EA610 VA: 0x1828EBC10
	public uint4 get_yyyy() { }

	// RVA: 0x28EAED0 Offset: 0x28E98D0 VA: 0x1828EAED0
	public uint3 get_xxx() { }

	// RVA: 0x28EAF60 Offset: 0x28E9960 VA: 0x1828EAF60
	public uint3 get_xxy() { }

	// RVA: 0x28EB120 Offset: 0x28E9B20 VA: 0x1828EB120
	public uint3 get_xyx() { }

	// RVA: 0x28EB1C0 Offset: 0x28E9BC0 VA: 0x1828EB1C0
	public uint3 get_xyy() { }

	// RVA: 0x28EB8A0 Offset: 0x28EA2A0 VA: 0x1828EB8A0
	public uint3 get_yxx() { }

	// RVA: 0x28EB940 Offset: 0x28EA340 VA: 0x1828EB940
	public uint3 get_yxy() { }

	// RVA: 0x28EBB20 Offset: 0x28EA520 VA: 0x1828EBB20
	public uint3 get_yyx() { }

	// RVA: 0x28EBBC0 Offset: 0x28EA5C0 VA: 0x1828EBBC0
	public uint3 get_yyy() { }

	// RVA: 0x28EAE20 Offset: 0x28E9820 VA: 0x1828EAE20
	public uint2 get_xx() { }

	// RVA: 0xA97F50 Offset: 0xA96950 VA: 0x180A97F50
	public uint2 get_xy() { }

	// RVA: 0x214D550 Offset: 0x214BF50 VA: 0x18214D550
	public void set_xy(uint2 value) { }

	// RVA: 0x28EB7E0 Offset: 0x28EA1E0 VA: 0x1828EB7E0
	public uint2 get_yx() { }

	// RVA: 0x28ED680 Offset: 0x28EC080 VA: 0x1828ED680
	public void set_yx(uint2 value) { }

	// RVA: 0x28EBA80 Offset: 0x28EA480 VA: 0x1828EBA80
	public uint2 get_yy() { }

	// RVA: 0xF6CBB0 Offset: 0xF6B5B0 VA: 0x180F6CBB0
	public uint get_Item(int index) { }

	// RVA: 0xF72E80 Offset: 0xF71880 VA: 0x180F72E80
	public void set_Item(int index, uint value) { }

	// RVA: 0x50DAD0 Offset: 0x50C4D0 VA: 0x18050DAD0 Slot: 4
	public bool Equals(uint2 rhs) { }

	// RVA: 0x298BFB0 Offset: 0x298A9B0 VA: 0x18298BFB0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x298C040 Offset: 0x298AA40 VA: 0x18298C040 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x298C120 Offset: 0x298AB20 VA: 0x18298C120 Slot: 3
	public override string ToString() { }

	// RVA: 0x298C090 Offset: 0x298AA90 VA: 0x18298C090 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
