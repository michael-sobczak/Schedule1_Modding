public struct float4x2 : IEquatable<float4x2>, IFormattable // TypeDefIndex: 10911
{
	// Fields
	public float4 c0; // 0x0
	public float4 c1; // 0x10
	public static readonly float4x2 zero; // 0x0

	// Properties
	public float4 Item { get; }

	// Methods

	// RVA: 0x1330B70 Offset: 0x132F570 VA: 0x181330B70
	public void .ctor(float4 c0, float4 c1) { }

	// RVA: 0x293F4D0 Offset: 0x293DED0 VA: 0x18293F4D0
	public void .ctor(float m00, float m01, float m10, float m11, float m20, float m21, float m30, float m31) { }

	// RVA: 0x293F410 Offset: 0x293DE10 VA: 0x18293F410
	public void .ctor(float v) { }

	// RVA: 0x293F540 Offset: 0x293DF40 VA: 0x18293F540
	public void .ctor(bool v) { }

	// RVA: 0x2883240 Offset: 0x2881C40 VA: 0x182883240
	public void .ctor(bool4x2 v) { }

	// RVA: 0x293F2B0 Offset: 0x293DCB0 VA: 0x18293F2B0
	public void .ctor(int v) { }

	// RVA: 0x293F360 Offset: 0x293DD60 VA: 0x18293F360
	public void .ctor(int4x2 v) { }

	// RVA: 0x2883310 Offset: 0x2881D10 VA: 0x182883310
	public void .ctor(uint v) { }

	// RVA: 0x293F1D0 Offset: 0x293DBD0 VA: 0x18293F1D0
	public void .ctor(uint4x2 v) { }

	// RVA: 0x293F2D0 Offset: 0x293DCD0 VA: 0x18293F2D0
	public void .ctor(double v) { }

	// RVA: 0x293F430 Offset: 0x293DE30 VA: 0x18293F430
	public void .ctor(double4x2 v) { }

	// RVA: 0x289BE70 Offset: 0x289A870 VA: 0x18289BE70
	public static float4x2 op_Implicit(float v) { }

	// RVA: 0x289C160 Offset: 0x289AB60 VA: 0x18289C160
	public static float4x2 op_Explicit(bool v) { }

	// RVA: 0x293FF50 Offset: 0x293E950 VA: 0x18293FF50
	public static float4x2 op_Explicit(bool4x2 v) { }

	// RVA: 0x289C070 Offset: 0x289AA70 VA: 0x18289C070
	public static float4x2 op_Implicit(int v) { }

	// RVA: 0x289BF50 Offset: 0x289A950 VA: 0x18289BF50
	public static float4x2 op_Implicit(int4x2 v) { }

	// RVA: 0x29404A0 Offset: 0x293EEA0 VA: 0x1829404A0
	public static float4x2 op_Implicit(uint v) { }

	// RVA: 0x289BD90 Offset: 0x289A790 VA: 0x18289BD90
	public static float4x2 op_Implicit(uint4x2 v) { }

	// RVA: 0x289BD00 Offset: 0x289A700 VA: 0x18289BD00
	public static float4x2 op_Explicit(double v) { }

	// RVA: 0x289BEA0 Offset: 0x289A8A0 VA: 0x18289BEA0
	public static float4x2 op_Explicit(double4x2 v) { }

	// RVA: 0x29412C0 Offset: 0x293FCC0 VA: 0x1829412C0
	public static float4x2 op_Multiply(float4x2 lhs, float4x2 rhs) { }

	// RVA: 0x29414A0 Offset: 0x293FEA0 VA: 0x1829414A0
	public static float4x2 op_Multiply(float4x2 lhs, float rhs) { }

	// RVA: 0x29413D0 Offset: 0x293FDD0 VA: 0x1829413D0
	public static float4x2 op_Multiply(float lhs, float4x2 rhs) { }

	// RVA: 0x293F710 Offset: 0x293E110 VA: 0x18293F710
	public static float4x2 op_Addition(float4x2 lhs, float4x2 rhs) { }

	// RVA: 0x293F570 Offset: 0x293DF70 VA: 0x18293F570
	public static float4x2 op_Addition(float4x2 lhs, float rhs) { }

	// RVA: 0x293F640 Offset: 0x293E040 VA: 0x18293F640
	public static float4x2 op_Addition(float lhs, float4x2 rhs) { }

	// RVA: 0x2941570 Offset: 0x293FF70 VA: 0x182941570
	public static float4x2 op_Subtraction(float4x2 lhs, float4x2 rhs) { }

	// RVA: 0x2941790 Offset: 0x2940190 VA: 0x182941790
	public static float4x2 op_Subtraction(float4x2 lhs, float rhs) { }

	// RVA: 0x2941680 Offset: 0x2940080 VA: 0x182941680
	public static float4x2 op_Subtraction(float lhs, float4x2 rhs) { }

	// RVA: 0x293F9E0 Offset: 0x293E3E0 VA: 0x18293F9E0
	public static float4x2 op_Division(float4x2 lhs, float4x2 rhs) { }

	// RVA: 0x293FAF0 Offset: 0x293E4F0 VA: 0x18293FAF0
	public static float4x2 op_Division(float4x2 lhs, float rhs) { }

	// RVA: 0x293F8D0 Offset: 0x293E2D0 VA: 0x18293F8D0
	public static float4x2 op_Division(float lhs, float4x2 rhs) { }

	// RVA: 0x2940FA0 Offset: 0x293F9A0 VA: 0x182940FA0
	public static float4x2 op_Modulus(float4x2 lhs, float4x2 rhs) { }

	// RVA: 0x2940E30 Offset: 0x293F830 VA: 0x182940E30
	public static float4x2 op_Modulus(float4x2 lhs, float rhs) { }

	// RVA: 0x2941140 Offset: 0x293FB40 VA: 0x182941140
	public static float4x2 op_Modulus(float lhs, float4x2 rhs) { }

	// RVA: 0x29404D0 Offset: 0x293EED0 VA: 0x1829404D0
	public static float4x2 op_Increment(float4x2 val) { }

	// RVA: 0x293F820 Offset: 0x293E220 VA: 0x18293F820
	public static float4x2 op_Decrement(float4x2 val) { }

	// RVA: 0x2940BA0 Offset: 0x293F5A0 VA: 0x182940BA0
	public static bool4x2 op_LessThan(float4x2 lhs, float4x2 rhs) { }

	// RVA: 0x2940C90 Offset: 0x293F690 VA: 0x182940C90
	public static bool4x2 op_LessThan(float4x2 lhs, float rhs) { }

	// RVA: 0x2940D60 Offset: 0x293F760 VA: 0x182940D60
	public static bool4x2 op_LessThan(float lhs, float4x2 rhs) { }

	// RVA: 0x29409E0 Offset: 0x293F3E0 VA: 0x1829409E0
	public static bool4x2 op_LessThanOrEqual(float4x2 lhs, float4x2 rhs) { }

	// RVA: 0x2940AD0 Offset: 0x293F4D0 VA: 0x182940AD0
	public static bool4x2 op_LessThanOrEqual(float4x2 lhs, float rhs) { }

	// RVA: 0x2940910 Offset: 0x293F310 VA: 0x182940910
	public static bool4x2 op_LessThanOrEqual(float lhs, float4x2 rhs) { }

	// RVA: 0x29402E0 Offset: 0x293ECE0 VA: 0x1829402E0
	public static bool4x2 op_GreaterThan(float4x2 lhs, float4x2 rhs) { }

	// RVA: 0x29403D0 Offset: 0x293EDD0 VA: 0x1829403D0
	public static bool4x2 op_GreaterThan(float4x2 lhs, float rhs) { }

	// RVA: 0x2940210 Offset: 0x293EC10 VA: 0x182940210
	public static bool4x2 op_GreaterThan(float lhs, float4x2 rhs) { }

	// RVA: 0x2940120 Offset: 0x293EB20 VA: 0x182940120
	public static bool4x2 op_GreaterThanOrEqual(float4x2 lhs, float4x2 rhs) { }

	// RVA: 0x2940050 Offset: 0x293EA50 VA: 0x182940050
	public static bool4x2 op_GreaterThanOrEqual(float4x2 lhs, float rhs) { }

	// RVA: 0x293FF80 Offset: 0x293E980 VA: 0x18293FF80
	public static bool4x2 op_GreaterThanOrEqual(float lhs, float4x2 rhs) { }

	// RVA: 0x2941860 Offset: 0x2940260 VA: 0x182941860
	public static float4x2 op_UnaryNegation(float4x2 val) { }

	// RVA: 0x2941930 Offset: 0x2940330 VA: 0x182941930
	public static float4x2 op_UnaryPlus(float4x2 val) { }

	// RVA: 0x293FE00 Offset: 0x293E800 VA: 0x18293FE00
	public static bool4x2 op_Equality(float4x2 lhs, float4x2 rhs) { }

	// RVA: 0x293FCE0 Offset: 0x293E6E0 VA: 0x18293FCE0
	public static bool4x2 op_Equality(float4x2 lhs, float rhs) { }

	// RVA: 0x293FBC0 Offset: 0x293E5C0 VA: 0x18293FBC0
	public static bool4x2 op_Equality(float lhs, float4x2 rhs) { }

	// RVA: 0x29407C0 Offset: 0x293F1C0 VA: 0x1829407C0
	public static bool4x2 op_Inequality(float4x2 lhs, float4x2 rhs) { }

	// RVA: 0x2940580 Offset: 0x293EF80 VA: 0x182940580
	public static bool4x2 op_Inequality(float4x2 lhs, float rhs) { }

	// RVA: 0x29406A0 Offset: 0x293F0A0 VA: 0x1829406A0
	public static bool4x2 op_Inequality(float lhs, float4x2 rhs) { }

	// RVA: 0xF6D000 Offset: 0xF6BA00 VA: 0x180F6D000
	public ref float4 get_Item(int index) { }

	// RVA: 0x293E800 Offset: 0x293D200 VA: 0x18293E800 Slot: 4
	public bool Equals(float4x2 rhs) { }

	// RVA: 0x293E8B0 Offset: 0x293D2B0 VA: 0x18293E8B0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x293E9D0 Offset: 0x293D3D0 VA: 0x18293E9D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x293EE10 Offset: 0x293D810 VA: 0x18293EE10 Slot: 3
	public override string ToString() { }

	// RVA: 0x293EA90 Offset: 0x293D490 VA: 0x18293EA90 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
