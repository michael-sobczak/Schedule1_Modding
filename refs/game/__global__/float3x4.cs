public struct float3x4 : IEquatable<float3x4>, IFormattable // TypeDefIndex: 10908
{
	// Fields
	public float3 c0; // 0x0
	public float3 c1; // 0xC
	public float3 c2; // 0x18
	public float3 c3; // 0x24
	public static readonly float3x4 zero; // 0x0

	// Properties
	public float3 Item { get; }

	// Methods

	// RVA: 0x28E5460 Offset: 0x28E3E60 VA: 0x1828E5460
	public void .ctor(float3 c0, float3 c1, float3 c2, float3 c3) { }

	// RVA: 0x2937290 Offset: 0x2935C90 VA: 0x182937290
	public void .ctor(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23) { }

	// RVA: 0x2937070 Offset: 0x2935A70 VA: 0x182937070
	public void .ctor(float v) { }

	// RVA: 0x2882AC0 Offset: 0x28814C0 VA: 0x182882AC0
	public void .ctor(bool v) { }

	// RVA: 0x2882DB0 Offset: 0x28817B0 VA: 0x182882DB0
	public void .ctor(bool3x4 v) { }

	// RVA: 0x2937200 Offset: 0x2935C00 VA: 0x182937200
	public void .ctor(int v) { }

	// RVA: 0x28829B0 Offset: 0x28813B0 VA: 0x1828829B0
	public void .ctor(int3x4 v) { }

	// RVA: 0x2882CD0 Offset: 0x28816D0 VA: 0x182882CD0
	public void .ctor(uint v) { }

	// RVA: 0x2882B60 Offset: 0x2881560 VA: 0x182882B60
	public void .ctor(uint3x4 v) { }

	// RVA: 0x2937170 Offset: 0x2935B70 VA: 0x182937170
	public void .ctor(double v) { }

	// RVA: 0x29370B0 Offset: 0x2935AB0 VA: 0x1829370B0
	public void .ctor(double3x4 v) { }

	// RVA: 0x289B440 Offset: 0x2899E40 VA: 0x18289B440
	public static float3x4 op_Implicit(float v) { }

	// RVA: 0x2938110 Offset: 0x2936B10 VA: 0x182938110
	public static float3x4 op_Explicit(bool v) { }

	// RVA: 0x29380D0 Offset: 0x2936AD0 VA: 0x1829380D0
	public static float3x4 op_Explicit(bool3x4 v) { }

	// RVA: 0x289B2B0 Offset: 0x2899CB0 VA: 0x18289B2B0
	public static float3x4 op_Implicit(int v) { }

	// RVA: 0x29387C0 Offset: 0x29371C0 VA: 0x1829387C0
	public static float3x4 op_Implicit(int3x4 v) { }

	// RVA: 0x2938790 Offset: 0x2937190 VA: 0x182938790
	public static float3x4 op_Implicit(uint v) { }

	// RVA: 0x2938740 Offset: 0x2937140 VA: 0x182938740
	public static float3x4 op_Implicit(uint3x4 v) { }

	// RVA: 0x289B060 Offset: 0x2899A60 VA: 0x18289B060
	public static float3x4 op_Explicit(double v) { }

	// RVA: 0x289B490 Offset: 0x2899E90 VA: 0x18289B490
	public static float3x4 op_Explicit(double3x4 v) { }

	// RVA: 0x2939AD0 Offset: 0x29384D0 VA: 0x182939AD0
	public static float3x4 op_Multiply(float3x4 lhs, float3x4 rhs) { }

	// RVA: 0x29399A0 Offset: 0x29383A0 VA: 0x1829399A0
	public static float3x4 op_Multiply(float3x4 lhs, float rhs) { }

	// RVA: 0x2939C40 Offset: 0x2938640 VA: 0x182939C40
	public static float3x4 op_Multiply(float lhs, float3x4 rhs) { }

	// RVA: 0x2937310 Offset: 0x2935D10 VA: 0x182937310
	public static float3x4 op_Addition(float3x4 lhs, float3x4 rhs) { }

	// RVA: 0x2937480 Offset: 0x2935E80 VA: 0x182937480
	public static float3x4 op_Addition(float3x4 lhs, float rhs) { }

	// RVA: 0x29375B0 Offset: 0x2935FB0 VA: 0x1829375B0
	public static float3x4 op_Addition(float lhs, float3x4 rhs) { }

	// RVA: 0x2939FF0 Offset: 0x29389F0 VA: 0x182939FF0
	public static float3x4 op_Subtraction(float3x4 lhs, float3x4 rhs) { }

	// RVA: 0x2939EC0 Offset: 0x29388C0 VA: 0x182939EC0
	public static float3x4 op_Subtraction(float3x4 lhs, float rhs) { }

	// RVA: 0x2939D70 Offset: 0x2938770 VA: 0x182939D70
	public static float3x4 op_Subtraction(float lhs, float3x4 rhs) { }

	// RVA: 0x2937980 Offset: 0x2936380 VA: 0x182937980
	public static float3x4 op_Division(float3x4 lhs, float3x4 rhs) { }

	// RVA: 0x2937AF0 Offset: 0x29364F0 VA: 0x182937AF0
	public static float3x4 op_Division(float3x4 lhs, float rhs) { }

	// RVA: 0x2937830 Offset: 0x2936230 VA: 0x182937830
	public static float3x4 op_Division(float lhs, float3x4 rhs) { }

	// RVA: 0x2939410 Offset: 0x2937E10 VA: 0x182939410
	public static float3x4 op_Modulus(float3x4 lhs, float3x4 rhs) { }

	// RVA: 0x29395F0 Offset: 0x2937FF0 VA: 0x1829395F0
	public static float3x4 op_Modulus(float3x4 lhs, float rhs) { }

	// RVA: 0x29397C0 Offset: 0x29381C0 VA: 0x1829397C0
	public static float3x4 op_Modulus(float lhs, float3x4 rhs) { }

	// RVA: 0x2938810 Offset: 0x2937210 VA: 0x182938810
	public static float3x4 op_Increment(float3x4 val) { }

	// RVA: 0x29376E0 Offset: 0x29360E0 VA: 0x1829376E0
	public static float3x4 op_Decrement(float3x4 val) { }

	// RVA: 0x29392E0 Offset: 0x2937CE0 VA: 0x1829392E0
	public static bool3x4 op_LessThan(float3x4 lhs, float3x4 rhs) { }

	// RVA: 0x2939110 Offset: 0x2937B10 VA: 0x182939110
	public static bool3x4 op_LessThan(float3x4 lhs, float rhs) { }

	// RVA: 0x29391F0 Offset: 0x2937BF0 VA: 0x1829391F0
	public static bool3x4 op_LessThan(float lhs, float3x4 rhs) { }

	// RVA: 0x2938EF0 Offset: 0x29378F0 VA: 0x182938EF0
	public static bool3x4 op_LessThanOrEqual(float3x4 lhs, float3x4 rhs) { }

	// RVA: 0x2938E10 Offset: 0x2937810 VA: 0x182938E10
	public static bool3x4 op_LessThanOrEqual(float3x4 lhs, float rhs) { }

	// RVA: 0x2939020 Offset: 0x2937A20 VA: 0x182939020
	public static bool3x4 op_LessThanOrEqual(float lhs, float3x4 rhs) { }

	// RVA: 0x2938440 Offset: 0x2936E40 VA: 0x182938440
	public static bool3x4 op_GreaterThan(float3x4 lhs, float3x4 rhs) { }

	// RVA: 0x2938570 Offset: 0x2936F70 VA: 0x182938570
	public static bool3x4 op_GreaterThan(float3x4 lhs, float rhs) { }

	// RVA: 0x2938660 Offset: 0x2937060 VA: 0x182938660
	public static bool3x4 op_GreaterThan(float lhs, float3x4 rhs) { }

	// RVA: 0x2938310 Offset: 0x2936D10 VA: 0x182938310
	public static bool3x4 op_GreaterThanOrEqual(float3x4 lhs, float3x4 rhs) { }

	// RVA: 0x2938140 Offset: 0x2936B40 VA: 0x182938140
	public static bool3x4 op_GreaterThanOrEqual(float3x4 lhs, float rhs) { }

	// RVA: 0x2938230 Offset: 0x2936C30 VA: 0x182938230
	public static bool3x4 op_GreaterThanOrEqual(float lhs, float3x4 rhs) { }

	// RVA: 0x293A160 Offset: 0x2938B60 VA: 0x18293A160
	public static float3x4 op_UnaryNegation(float3x4 val) { }

	// RVA: 0x293A290 Offset: 0x2938C90 VA: 0x18293A290
	public static float3x4 op_UnaryPlus(float3x4 val) { }

	// RVA: 0x2937C20 Offset: 0x2936620 VA: 0x182937C20
	public static bool3x4 op_Equality(float3x4 lhs, float3x4 rhs) { }

	// RVA: 0x2937F40 Offset: 0x2936940 VA: 0x182937F40
	public static bool3x4 op_Equality(float3x4 lhs, float rhs) { }

	// RVA: 0x2937DE0 Offset: 0x29367E0 VA: 0x182937DE0
	public static bool3x4 op_Equality(float lhs, float3x4 rhs) { }

	// RVA: 0x2938C50 Offset: 0x2937650 VA: 0x182938C50
	public static bool3x4 op_Inequality(float3x4 lhs, float3x4 rhs) { }

	// RVA: 0x2938960 Offset: 0x2937360 VA: 0x182938960
	public static bool3x4 op_Inequality(float3x4 lhs, float rhs) { }

	// RVA: 0x2938AF0 Offset: 0x29374F0 VA: 0x182938AF0
	public static bool3x4 op_Inequality(float lhs, float3x4 rhs) { }

	// RVA: 0xF6D040 Offset: 0xF6BA40 VA: 0x180F6D040
	public ref float3 get_Item(int index) { }

	// RVA: 0x2927B90 Offset: 0x2926590 VA: 0x182927B90 Slot: 4
	public bool Equals(float3x4 rhs) { }

	// RVA: 0x2936560 Offset: 0x2934F60 VA: 0x182936560 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2936610 Offset: 0x2935010 VA: 0x182936610 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2936B30 Offset: 0x2935530 VA: 0x182936B30 Slot: 3
	public override string ToString() { }

	// RVA: 0x2936640 Offset: 0x2935040 VA: 0x182936640 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
