public struct float2x3 : IEquatable<float2x3>, IFormattable // TypeDefIndex: 10902
{
	// Fields
	public float2 c0; // 0x0
	public float2 c1; // 0x8
	public float2 c2; // 0x10
	public static readonly float2x3 zero; // 0x0

	// Properties
	public float2 Item { get; }

	// Methods

	// RVA: 0x1BA9540 Offset: 0x1BA7F40 VA: 0x181BA9540
	public void .ctor(float2 c0, float2 c1, float2 c2) { }

	// RVA: 0x292B4D0 Offset: 0x2929ED0 VA: 0x18292B4D0
	public void .ctor(float m00, float m01, float m02, float m10, float m11, float m12) { }

	// RVA: 0x292B550 Offset: 0x2929F50 VA: 0x18292B550
	public void .ctor(float v) { }

	// RVA: 0x292B570 Offset: 0x2929F70 VA: 0x18292B570
	public void .ctor(bool v) { }

	// RVA: 0x292B5C0 Offset: 0x2929FC0 VA: 0x18292B5C0
	public void .ctor(bool2x3 v) { }

	// RVA: 0x292B6C0 Offset: 0x292A0C0 VA: 0x18292B6C0
	public void .ctor(int v) { }

	// RVA: 0x292B470 Offset: 0x2929E70 VA: 0x18292B470
	public void .ctor(int2x3 v) { }

	// RVA: 0x292B640 Offset: 0x292A040 VA: 0x18292B640
	public void .ctor(uint v) { }

	// RVA: 0x292B3E0 Offset: 0x2929DE0 VA: 0x18292B3E0
	public void .ctor(uint2x3 v) { }

	// RVA: 0x292B500 Offset: 0x2929F00 VA: 0x18292B500
	public void .ctor(double v) { }

	// RVA: 0x292B380 Offset: 0x2929D80 VA: 0x18292B380
	public void .ctor(double2x3 v) { }

	// RVA: 0x2899600 Offset: 0x2898000 VA: 0x182899600
	public static float2x3 op_Implicit(float v) { }

	// RVA: 0x28996F0 Offset: 0x28980F0 VA: 0x1828996F0
	public static float2x3 op_Explicit(bool v) { }

	// RVA: 0x2899800 Offset: 0x2898200 VA: 0x182899800
	public static float2x3 op_Explicit(bool2x3 v) { }

	// RVA: 0x2899990 Offset: 0x2898390 VA: 0x182899990
	public static float2x3 op_Implicit(int v) { }

	// RVA: 0x28999E0 Offset: 0x28983E0 VA: 0x1828999E0
	public static float2x3 op_Implicit(int2x3 v) { }

	// RVA: 0x2899670 Offset: 0x2898070 VA: 0x182899670
	public static float2x3 op_Implicit(uint v) { }

	// RVA: 0x28998C0 Offset: 0x28982C0 VA: 0x1828998C0
	public static float2x3 op_Implicit(uint2x3 v) { }

	// RVA: 0x2899620 Offset: 0x2898020 VA: 0x182899620
	public static float2x3 op_Explicit(double v) { }

	// RVA: 0x2899750 Offset: 0x2898150 VA: 0x182899750
	public static float2x3 op_Explicit(double2x3 v) { }

	// RVA: 0x292C720 Offset: 0x292B120 VA: 0x18292C720
	public static float2x3 op_Multiply(float2x3 lhs, float2x3 rhs) { }

	// RVA: 0x292C6F0 Offset: 0x292B0F0 VA: 0x18292C6F0
	public static float2x3 op_Multiply(float2x3 lhs, float rhs) { }

	// RVA: 0x292C790 Offset: 0x292B190 VA: 0x18292C790
	public static float2x3 op_Multiply(float lhs, float2x3 rhs) { }

	// RVA: 0x292B770 Offset: 0x292A170 VA: 0x18292B770
	public static float2x3 op_Addition(float2x3 lhs, float2x3 rhs) { }

	// RVA: 0x292B7E0 Offset: 0x292A1E0 VA: 0x18292B7E0
	public static float2x3 op_Addition(float2x3 lhs, float rhs) { }

	// RVA: 0x292B710 Offset: 0x292A110 VA: 0x18292B710
	public static float2x3 op_Addition(float lhs, float2x3 rhs) { }

	// RVA: 0x292C7F0 Offset: 0x292B1F0 VA: 0x18292C7F0
	public static float2x3 op_Subtraction(float2x3 lhs, float2x3 rhs) { }

	// RVA: 0x292C860 Offset: 0x292B260 VA: 0x18292C860
	public static float2x3 op_Subtraction(float2x3 lhs, float rhs) { }

	// RVA: 0x292C890 Offset: 0x292B290 VA: 0x18292C890
	public static float2x3 op_Subtraction(float lhs, float2x3 rhs) { }

	// RVA: 0x292B930 Offset: 0x292A330 VA: 0x18292B930
	public static float2x3 op_Division(float2x3 lhs, float2x3 rhs) { }

	// RVA: 0x292B8A0 Offset: 0x292A2A0 VA: 0x18292B8A0
	public static float2x3 op_Division(float2x3 lhs, float rhs) { }

	// RVA: 0x292B8D0 Offset: 0x292A2D0 VA: 0x18292B8D0
	public static float2x3 op_Division(float lhs, float2x3 rhs) { }

	// RVA: 0x292C4D0 Offset: 0x292AED0 VA: 0x18292C4D0
	public static float2x3 op_Modulus(float2x3 lhs, float2x3 rhs) { }

	// RVA: 0x292C640 Offset: 0x292B040 VA: 0x18292C640
	public static float2x3 op_Modulus(float2x3 lhs, float rhs) { }

	// RVA: 0x292C590 Offset: 0x292AF90 VA: 0x18292C590
	public static float2x3 op_Modulus(float lhs, float2x3 rhs) { }

	// RVA: 0x292BEF0 Offset: 0x292A8F0 VA: 0x18292BEF0
	public static float2x3 op_Increment(float2x3 val) { }

	// RVA: 0x292B810 Offset: 0x292A210 VA: 0x18292B810
	public static float2x3 op_Decrement(float2x3 val) { }

	// RVA: 0x292C3C0 Offset: 0x292ADC0 VA: 0x18292C3C0
	public static bool2x3 op_LessThan(float2x3 lhs, float2x3 rhs) { }

	// RVA: 0x292C350 Offset: 0x292AD50 VA: 0x18292C350
	public static bool2x3 op_LessThan(float2x3 lhs, float rhs) { }

	// RVA: 0x292C450 Offset: 0x292AE50 VA: 0x18292C450
	public static bool2x3 op_LessThan(float lhs, float2x3 rhs) { }

	// RVA: 0x292C240 Offset: 0x292AC40 VA: 0x18292C240
	public static bool2x3 op_LessThanOrEqual(float2x3 lhs, float2x3 rhs) { }

	// RVA: 0x292C1D0 Offset: 0x292ABD0 VA: 0x18292C1D0
	public static bool2x3 op_LessThanOrEqual(float2x3 lhs, float rhs) { }

	// RVA: 0x292C2D0 Offset: 0x292ACD0 VA: 0x18292C2D0
	public static bool2x3 op_LessThanOrEqual(float lhs, float2x3 rhs) { }

	// RVA: 0x292BDE0 Offset: 0x292A7E0 VA: 0x18292BDE0
	public static bool2x3 op_GreaterThan(float2x3 lhs, float2x3 rhs) { }

	// RVA: 0x292BE70 Offset: 0x292A870 VA: 0x18292BE70
	public static bool2x3 op_GreaterThan(float2x3 lhs, float rhs) { }

	// RVA: 0x292BD70 Offset: 0x292A770 VA: 0x18292BD70
	public static bool2x3 op_GreaterThan(float lhs, float2x3 rhs) { }

	// RVA: 0x292BCE0 Offset: 0x292A6E0 VA: 0x18292BCE0
	public static bool2x3 op_GreaterThanOrEqual(float2x3 lhs, float2x3 rhs) { }

	// RVA: 0x292BBF0 Offset: 0x292A5F0 VA: 0x18292BBF0
	public static bool2x3 op_GreaterThanOrEqual(float2x3 lhs, float rhs) { }

	// RVA: 0x292BC70 Offset: 0x292A670 VA: 0x18292BC70
	public static bool2x3 op_GreaterThanOrEqual(float lhs, float2x3 rhs) { }

	// RVA: 0x292C8F0 Offset: 0x292B2F0 VA: 0x18292C8F0
	public static float2x3 op_UnaryNegation(float2x3 val) { }

	// RVA: 0x292C920 Offset: 0x292B320 VA: 0x18292C920
	public static float2x3 op_UnaryPlus(float2x3 val) { }

	// RVA: 0x292BB10 Offset: 0x292A510 VA: 0x18292BB10
	public static bool2x3 op_Equality(float2x3 lhs, float2x3 rhs) { }

	// RVA: 0x292B9A0 Offset: 0x292A3A0 VA: 0x18292B9A0
	public static bool2x3 op_Equality(float2x3 lhs, float rhs) { }

	// RVA: 0x292BA60 Offset: 0x292A460 VA: 0x18292BA60
	public static bool2x3 op_Equality(float lhs, float2x3 rhs) { }

	// RVA: 0x292C040 Offset: 0x292AA40 VA: 0x18292C040
	public static bool2x3 op_Inequality(float2x3 lhs, float2x3 rhs) { }

	// RVA: 0x292BF80 Offset: 0x292A980 VA: 0x18292BF80
	public static bool2x3 op_Inequality(float2x3 lhs, float rhs) { }

	// RVA: 0x292C120 Offset: 0x292AB20 VA: 0x18292C120
	public static bool2x3 op_Inequality(float lhs, float2x3 rhs) { }

	// RVA: 0xF6CFF0 Offset: 0xF6B9F0 VA: 0x180F6CFF0
	public ref float2 get_Item(int index) { }

	// RVA: 0x292AD00 Offset: 0x2929700 VA: 0x18292AD00 Slot: 4
	public bool Equals(float2x3 rhs) { }

	// RVA: 0x292ABF0 Offset: 0x29295F0 VA: 0x18292ABF0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x292AD90 Offset: 0x2929790 VA: 0x18292AD90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x292ADC0 Offset: 0x29297C0 VA: 0x18292ADC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x292B0B0 Offset: 0x2929AB0 VA: 0x18292B0B0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
