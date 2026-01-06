public struct half2 : IEquatable<half2>, IFormattable // TypeDefIndex: 10916
{
	// Fields
	public half x; // 0x0
	public half y; // 0x2
	public static readonly half2 zero; // 0x0

	// Properties
	[EditorBrowsable(1)]
	public half4 xxxx { get; }
	[EditorBrowsable(1)]
	public half4 xxxy { get; }
	[EditorBrowsable(1)]
	public half4 xxyx { get; }
	[EditorBrowsable(1)]
	public half4 xxyy { get; }
	[EditorBrowsable(1)]
	public half4 xyxx { get; }
	[EditorBrowsable(1)]
	public half4 xyxy { get; }
	[EditorBrowsable(1)]
	public half4 xyyx { get; }
	[EditorBrowsable(1)]
	public half4 xyyy { get; }
	[EditorBrowsable(1)]
	public half4 yxxx { get; }
	[EditorBrowsable(1)]
	public half4 yxxy { get; }
	[EditorBrowsable(1)]
	public half4 yxyx { get; }
	[EditorBrowsable(1)]
	public half4 yxyy { get; }
	[EditorBrowsable(1)]
	public half4 yyxx { get; }
	[EditorBrowsable(1)]
	public half4 yyxy { get; }
	[EditorBrowsable(1)]
	public half4 yyyx { get; }
	[EditorBrowsable(1)]
	public half4 yyyy { get; }
	[EditorBrowsable(1)]
	public half3 xxx { get; }
	[EditorBrowsable(1)]
	public half3 xxy { get; }
	[EditorBrowsable(1)]
	public half3 xyx { get; }
	[EditorBrowsable(1)]
	public half3 xyy { get; }
	[EditorBrowsable(1)]
	public half3 yxx { get; }
	[EditorBrowsable(1)]
	public half3 yxy { get; }
	[EditorBrowsable(1)]
	public half3 yyx { get; }
	[EditorBrowsable(1)]
	public half3 yyy { get; }
	[EditorBrowsable(1)]
	public half2 xx { get; }
	[EditorBrowsable(1)]
	public half2 xy { get; set; }
	[EditorBrowsable(1)]
	public half2 yx { get; set; }
	[EditorBrowsable(1)]
	public half2 yy { get; }
	public half Item { get; set; }

	// Methods

	// RVA: 0x691550 Offset: 0x68FF50 VA: 0x180691550
	public void .ctor(half x, half y) { }

	// RVA: 0x294DE40 Offset: 0x294C840 VA: 0x18294DE40
	public void .ctor(half2 xy) { }

	// RVA: 0x294DDF0 Offset: 0x294C7F0 VA: 0x18294DDF0
	public void .ctor(half v) { }

	// RVA: 0x294DDB0 Offset: 0x294C7B0 VA: 0x18294DDB0
	public void .ctor(float v) { }

	// RVA: 0x294DE00 Offset: 0x294C800 VA: 0x18294DE00
	public void .ctor(float2 v) { }

	// RVA: 0x294DD70 Offset: 0x294C770 VA: 0x18294DD70
	public void .ctor(double v) { }

	// RVA: 0x294DE50 Offset: 0x294C850 VA: 0x18294DE50
	public void .ctor(double2 v) { }

	// RVA: 0x289E890 Offset: 0x289D290 VA: 0x18289E890
	public static half2 op_Implicit(half v) { }

	// RVA: 0x289E8A0 Offset: 0x289D2A0 VA: 0x18289E8A0
	public static half2 op_Explicit(float v) { }

	// RVA: 0x289E8E0 Offset: 0x289D2E0 VA: 0x18289E8E0
	public static half2 op_Explicit(float2 v) { }

	// RVA: 0x289E800 Offset: 0x289D200 VA: 0x18289E800
	public static half2 op_Explicit(double v) { }

	// RVA: 0x289E840 Offset: 0x289D240 VA: 0x18289E840
	public static half2 op_Explicit(double2 v) { }

	// RVA: 0x294E320 Offset: 0x294CD20 VA: 0x18294E320
	public static bool2 op_Equality(half2 lhs, half2 rhs) { }

	// RVA: 0x294E340 Offset: 0x294CD40 VA: 0x18294E340
	public static bool2 op_Equality(half2 lhs, half rhs) { }

	// RVA: 0x294E300 Offset: 0x294CD00 VA: 0x18294E300
	public static bool2 op_Equality(half lhs, half2 rhs) { }

	// RVA: 0x294E3A0 Offset: 0x294CDA0 VA: 0x18294E3A0
	public static bool2 op_Inequality(half2 lhs, half2 rhs) { }

	// RVA: 0x294E360 Offset: 0x294CD60 VA: 0x18294E360
	public static bool2 op_Inequality(half2 lhs, half rhs) { }

	// RVA: 0x294E380 Offset: 0x294CD80 VA: 0x18294E380
	public static bool2 op_Inequality(half lhs, half2 rhs) { }

	// RVA: 0x294DEE0 Offset: 0x294C8E0 VA: 0x18294DEE0
	public half4 get_xxxx() { }

	// RVA: 0x294DF00 Offset: 0x294C900 VA: 0x18294DF00
	public half4 get_xxxy() { }

	// RVA: 0x294DF50 Offset: 0x294C950 VA: 0x18294DF50
	public half4 get_xxyx() { }

	// RVA: 0x294DF80 Offset: 0x294C980 VA: 0x18294DF80
	public half4 get_xxyy() { }

	// RVA: 0x294DFF0 Offset: 0x294C9F0 VA: 0x18294DFF0
	public half4 get_xyxx() { }

	// RVA: 0x294E020 Offset: 0x294CA20 VA: 0x18294E020
	public half4 get_xyxy() { }

	// RVA: 0x294E070 Offset: 0x294CA70 VA: 0x18294E070
	public half4 get_xyyx() { }

	// RVA: 0x294E0A0 Offset: 0x294CAA0 VA: 0x18294E0A0
	public half4 get_xyyy() { }

	// RVA: 0x294E110 Offset: 0x294CB10 VA: 0x18294E110
	public half4 get_yxxx() { }

	// RVA: 0x294E140 Offset: 0x294CB40 VA: 0x18294E140
	public half4 get_yxxy() { }

	// RVA: 0x294E190 Offset: 0x294CB90 VA: 0x18294E190
	public half4 get_yxyx() { }

	// RVA: 0x294E1C0 Offset: 0x294CBC0 VA: 0x18294E1C0
	public half4 get_yxyy() { }

	// RVA: 0x294E230 Offset: 0x294CC30 VA: 0x18294E230
	public half4 get_yyxx() { }

	// RVA: 0x294E260 Offset: 0x294CC60 VA: 0x18294E260
	public half4 get_yyxy() { }

	// RVA: 0x294E2B0 Offset: 0x294CCB0 VA: 0x18294E2B0
	public half4 get_yyyx() { }

	// RVA: 0x294E2E0 Offset: 0x294CCE0 VA: 0x18294E2E0
	public half4 get_yyyy() { }

	// RVA: 0x294DEC0 Offset: 0x294C8C0 VA: 0x18294DEC0
	public half3 get_xxx() { }

	// RVA: 0x294DF30 Offset: 0x294C930 VA: 0x18294DF30
	public half3 get_xxy() { }

	// RVA: 0x294DFD0 Offset: 0x294C9D0 VA: 0x18294DFD0
	public half3 get_xyx() { }

	// RVA: 0x294E050 Offset: 0x294CA50 VA: 0x18294E050
	public half3 get_xyy() { }

	// RVA: 0x294E0F0 Offset: 0x294CAF0 VA: 0x18294E0F0
	public half3 get_yxx() { }

	// RVA: 0x294E170 Offset: 0x294CB70 VA: 0x18294E170
	public half3 get_yxy() { }

	// RVA: 0x294E210 Offset: 0x294CC10 VA: 0x18294E210
	public half3 get_yyx() { }

	// RVA: 0x294E290 Offset: 0x294CC90 VA: 0x18294E290
	public half3 get_yyy() { }

	// RVA: 0x294DEA0 Offset: 0x294C8A0 VA: 0x18294DEA0
	public half2 get_xx() { }

	// RVA: 0x294DFB0 Offset: 0x294C9B0 VA: 0x18294DFB0
	public half2 get_xy() { }

	// RVA: 0x294DE40 Offset: 0x294C840 VA: 0x18294DE40
	public void set_xy(half2 value) { }

	// RVA: 0x294E0D0 Offset: 0x294CAD0 VA: 0x18294E0D0
	public half2 get_yx() { }

	// RVA: 0x294E3C0 Offset: 0x294CDC0 VA: 0x18294E3C0
	public void set_yx(half2 value) { }

	// RVA: 0x294E1F0 Offset: 0x294CBF0 VA: 0x18294E1F0
	public half2 get_yy() { }

	// RVA: 0xF6CD10 Offset: 0xF6B710 VA: 0x180F6CD10
	public half get_Item(int index) { }

	// RVA: 0xF730D0 Offset: 0xF71AD0 VA: 0x180F730D0
	public void set_Item(int index, half value) { }

	// RVA: 0x294DBC0 Offset: 0x294C5C0 VA: 0x18294DBC0 Slot: 4
	public bool Equals(half2 rhs) { }

	// RVA: 0x294DB30 Offset: 0x294C530 VA: 0x18294DB30 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x294DBE0 Offset: 0x294C5E0 VA: 0x18294DBE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x294DCE0 Offset: 0x294C6E0 VA: 0x18294DCE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x294DC50 Offset: 0x294C650 VA: 0x18294DC50 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
