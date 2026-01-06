public struct float2x4 : IEquatable<float2x4>, IFormattable // TypeDefIndex: 10903
{
	// Fields
	public float2 c0; // 0x0
	public float2 c1; // 0x8
	public float2 c2; // 0x10
	public float2 c3; // 0x18
	public static readonly float2x4 zero; // 0x0

	// Properties
	public float2 Item { get; }

	// Methods

	// RVA: 0x292D230 Offset: 0x292BC30 VA: 0x18292D230
	public void .ctor(float2 c0, float2 c1, float2 c2, float2 c3) { }

	// RVA: 0x292D160 Offset: 0x292BB60 VA: 0x18292D160
	public void .ctor(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13) { }

	// RVA: 0x292D250 Offset: 0x292BC50 VA: 0x18292D250
	public void .ctor(float v) { }

	// RVA: 0x292D410 Offset: 0x292BE10 VA: 0x18292D410
	public void .ctor(bool v) { }

	// RVA: 0x2882450 Offset: 0x2880E50 VA: 0x182882450
	public void .ctor(bool2x4 v) { }

	// RVA: 0x292D500 Offset: 0x292BF00 VA: 0x18292D500
	public void .ctor(int v) { }

	// RVA: 0x292D260 Offset: 0x292BC60 VA: 0x18292D260
	public void .ctor(int2x4 v) { }

	// RVA: 0x292D460 Offset: 0x292BE60 VA: 0x18292D460
	public void .ctor(uint v) { }

	// RVA: 0x292D2E0 Offset: 0x292BCE0 VA: 0x18292D2E0
	public void .ctor(uint2x4 v) { }

	// RVA: 0x292D3A0 Offset: 0x292BDA0 VA: 0x18292D3A0
	public void .ctor(double v) { }

	// RVA: 0x292D1B0 Offset: 0x292BBB0 VA: 0x18292D1B0
	public void .ctor(double2x4 v) { }

	// RVA: 0x2899DA0 Offset: 0x28987A0 VA: 0x182899DA0
	public static float2x4 op_Implicit(float v) { }

	// RVA: 0x2899AA0 Offset: 0x28984A0 VA: 0x182899AA0
	public static float2x4 op_Explicit(bool v) { }

	// RVA: 0x292DC50 Offset: 0x292C650 VA: 0x18292DC50
	public static float2x4 op_Explicit(bool2x4 v) { }

	// RVA: 0x2899D30 Offset: 0x2898730 VA: 0x182899D30
	public static float2x4 op_Implicit(int v) { }

	// RVA: 0x2899F20 Offset: 0x2898920 VA: 0x182899F20
	public static float2x4 op_Implicit(int2x4 v) { }

	// RVA: 0x2899C40 Offset: 0x2898640 VA: 0x182899C40
	public static float2x4 op_Implicit(uint v) { }

	// RVA: 0x2899E20 Offset: 0x2898820 VA: 0x182899E20
	public static float2x4 op_Implicit(uint2x4 v) { }

	// RVA: 0x2899DB0 Offset: 0x28987B0 VA: 0x182899DB0
	public static float2x4 op_Explicit(double v) { }

	// RVA: 0x2899AF0 Offset: 0x28984F0 VA: 0x182899AF0
	public static float2x4 op_Explicit(double2x4 v) { }

	// RVA: 0x292EF00 Offset: 0x292D900 VA: 0x18292EF00
	public static float2x4 op_Multiply(float2x4 lhs, float2x4 rhs) { }

	// RVA: 0x292EF90 Offset: 0x292D990 VA: 0x18292EF90
	public static float2x4 op_Multiply(float2x4 lhs, float rhs) { }

	// RVA: 0x292EEB0 Offset: 0x292D8B0 VA: 0x18292EEB0
	public static float2x4 op_Multiply(float lhs, float2x4 rhs) { }

	// RVA: 0x292D560 Offset: 0x292BF60 VA: 0x18292D560
	public static float2x4 op_Addition(float2x4 lhs, float2x4 rhs) { }

	// RVA: 0x292D5F0 Offset: 0x292BFF0 VA: 0x18292D5F0
	public static float2x4 op_Addition(float2x4 lhs, float rhs) { }

	// RVA: 0x292D640 Offset: 0x292C040 VA: 0x18292D640
	public static float2x4 op_Addition(float lhs, float2x4 rhs) { }

	// RVA: 0x292F030 Offset: 0x292DA30 VA: 0x18292F030
	public static float2x4 op_Subtraction(float2x4 lhs, float2x4 rhs) { }

	// RVA: 0x292EFE0 Offset: 0x292D9E0 VA: 0x18292EFE0
	public static float2x4 op_Subtraction(float2x4 lhs, float rhs) { }

	// RVA: 0x292F0C0 Offset: 0x292DAC0 VA: 0x18292F0C0
	public static float2x4 op_Subtraction(float lhs, float2x4 rhs) { }

	// RVA: 0x292D7E0 Offset: 0x292C1E0 VA: 0x18292D7E0
	public static float2x4 op_Division(float2x4 lhs, float2x4 rhs) { }

	// RVA: 0x292D870 Offset: 0x292C270 VA: 0x18292D870
	public static float2x4 op_Division(float2x4 lhs, float rhs) { }

	// RVA: 0x292D760 Offset: 0x292C160 VA: 0x18292D760
	public static float2x4 op_Division(float lhs, float2x4 rhs) { }

	// RVA: 0x292ECF0 Offset: 0x292D6F0 VA: 0x18292ECF0
	public static float2x4 op_Modulus(float2x4 lhs, float2x4 rhs) { }

	// RVA: 0x292EDE0 Offset: 0x292D7E0 VA: 0x18292EDE0
	public static float2x4 op_Modulus(float2x4 lhs, float rhs) { }

	// RVA: 0x292EC20 Offset: 0x292D620 VA: 0x18292EC20
	public static float2x4 op_Modulus(float lhs, float2x4 rhs) { }

	// RVA: 0x292E220 Offset: 0x292CC20 VA: 0x18292E220
	public static float2x4 op_Increment(float2x4 val) { }

	// RVA: 0x292D690 Offset: 0x292C090 VA: 0x18292D690
	public static float2x4 op_Decrement(float2x4 val) { }

	// RVA: 0x292EB10 Offset: 0x292D510 VA: 0x18292EB10
	public static bool2x4 op_LessThan(float2x4 lhs, float2x4 rhs) { }

	// RVA: 0x292EA40 Offset: 0x292D440 VA: 0x18292EA40
	public static bool2x4 op_LessThan(float2x4 lhs, float rhs) { }

	// RVA: 0x292E950 Offset: 0x292D350 VA: 0x18292E950
	public static bool2x4 op_LessThan(float lhs, float2x4 rhs) { }

	// RVA: 0x292E840 Offset: 0x292D240 VA: 0x18292E840
	public static bool2x4 op_LessThanOrEqual(float2x4 lhs, float2x4 rhs) { }

	// RVA: 0x292E680 Offset: 0x292D080 VA: 0x18292E680
	public static bool2x4 op_LessThanOrEqual(float2x4 lhs, float rhs) { }

	// RVA: 0x292E750 Offset: 0x292D150 VA: 0x18292E750
	public static bool2x4 op_LessThanOrEqual(float lhs, float2x4 rhs) { }

	// RVA: 0x292DF50 Offset: 0x292C950 VA: 0x18292DF50
	public static bool2x4 op_GreaterThan(float2x4 lhs, float2x4 rhs) { }

	// RVA: 0x292E130 Offset: 0x292CB30 VA: 0x18292E130
	public static bool2x4 op_GreaterThan(float2x4 lhs, float rhs) { }

	// RVA: 0x292E060 Offset: 0x292CA60 VA: 0x18292E060
	public static bool2x4 op_GreaterThan(float lhs, float2x4 rhs) { }

	// RVA: 0x292DE40 Offset: 0x292C840 VA: 0x18292DE40
	public static bool2x4 op_GreaterThanOrEqual(float2x4 lhs, float2x4 rhs) { }

	// RVA: 0x292DC80 Offset: 0x292C680 VA: 0x18292DC80
	public static bool2x4 op_GreaterThanOrEqual(float2x4 lhs, float rhs) { }

	// RVA: 0x292DD70 Offset: 0x292C770 VA: 0x18292DD70
	public static bool2x4 op_GreaterThanOrEqual(float lhs, float2x4 rhs) { }

	// RVA: 0x292F140 Offset: 0x292DB40 VA: 0x18292F140
	public static float2x4 op_UnaryNegation(float2x4 val) { }

	// RVA: 0x292F190 Offset: 0x292DB90 VA: 0x18292F190
	public static float2x4 op_UnaryPlus(float2x4 val) { }

	// RVA: 0x292D8C0 Offset: 0x292C2C0 VA: 0x18292D8C0
	public static bool2x4 op_Equality(float2x4 lhs, float2x4 rhs) { }

	// RVA: 0x292DA10 Offset: 0x292C410 VA: 0x18292DA10
	public static bool2x4 op_Equality(float2x4 lhs, float rhs) { }

	// RVA: 0x292DB40 Offset: 0x292C540 VA: 0x18292DB40
	public static bool2x4 op_Equality(float lhs, float2x4 rhs) { }

	// RVA: 0x292E420 Offset: 0x292CE20 VA: 0x18292E420
	public static bool2x4 op_Inequality(float2x4 lhs, float2x4 rhs) { }

	// RVA: 0x292E2F0 Offset: 0x292CCF0 VA: 0x18292E2F0
	public static bool2x4 op_Inequality(float2x4 lhs, float rhs) { }

	// RVA: 0x292E570 Offset: 0x292CF70 VA: 0x18292E570
	public static bool2x4 op_Inequality(float lhs, float2x4 rhs) { }

	// RVA: 0xF6CFF0 Offset: 0xF6B9F0 VA: 0x180F6CFF0
	public ref float2 get_Item(int index) { }

	// RVA: 0x2925B20 Offset: 0x2924520 VA: 0x182925B20 Slot: 4
	public bool Equals(float2x4 rhs) { }

	// RVA: 0x292C950 Offset: 0x292B350 VA: 0x18292C950 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x292C9F0 Offset: 0x292B3F0 VA: 0x18292C9F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x292CDA0 Offset: 0x292B7A0 VA: 0x18292CDA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x292CA20 Offset: 0x292B420 VA: 0x18292CA20 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
