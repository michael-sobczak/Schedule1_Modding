public struct float4x3 : IEquatable<float4x3>, IFormattable // TypeDefIndex: 10912
{
	// Fields
	public float4 c0; // 0x0
	public float4 c1; // 0x10
	public float4 c2; // 0x20
	public static readonly float4x3 zero; // 0x0

	// Properties
	public float4 Item { get; }

	// Methods

	// RVA: 0x133AD50 Offset: 0x1339750 VA: 0x18133AD50
	public void .ctor(float4 c0, float4 c1, float4 c2) { }

	// RVA: 0x2942570 Offset: 0x2940F70 VA: 0x182942570
	public void .ctor(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22, float m30, float m31, float m32) { }

	// RVA: 0x29424D0 Offset: 0x2940ED0 VA: 0x1829424D0
	public void .ctor(float v) { }

	// RVA: 0x2942500 Offset: 0x2940F00 VA: 0x182942500
	public void .ctor(bool v) { }

	// RVA: 0x2883490 Offset: 0x2881E90 VA: 0x182883490
	public void .ctor(bool4x3 v) { }

	// RVA: 0x2942540 Offset: 0x2940F40 VA: 0x182942540
	public void .ctor(int v) { }

	// RVA: 0x28835C0 Offset: 0x2881FC0 VA: 0x1828835C0
	public void .ctor(int4x3 v) { }

	// RVA: 0x28838E0 Offset: 0x28822E0 VA: 0x1828838E0
	public void .ctor(uint v) { }

	// RVA: 0x28836B0 Offset: 0x28820B0 VA: 0x1828836B0
	public void .ctor(uint4x3 v) { }

	// RVA: 0x28833D0 Offset: 0x2881DD0 VA: 0x1828833D0
	public void .ctor(double v) { }

	// RVA: 0x28837F0 Offset: 0x28821F0 VA: 0x1828837F0
	public void .ctor(double4x3 v) { }

	// RVA: 0x289C8C0 Offset: 0x289B2C0 VA: 0x18289C8C0
	public static float4x3 op_Implicit(float v) { }

	// RVA: 0x289C8F0 Offset: 0x289B2F0 VA: 0x18289C8F0
	public static float4x3 op_Explicit(bool v) { }

	// RVA: 0x2943520 Offset: 0x2941F20 VA: 0x182943520
	public static float4x3 op_Explicit(bool4x3 v) { }

	// RVA: 0x289C930 Offset: 0x289B330 VA: 0x18289C930
	public static float4x3 op_Implicit(int v) { }

	// RVA: 0x2943A90 Offset: 0x2942490 VA: 0x182943A90
	public static float4x3 op_Implicit(int4x3 v) { }

	// RVA: 0x2943A60 Offset: 0x2942460 VA: 0x182943A60
	public static float4x3 op_Implicit(uint v) { }

	// RVA: 0x2943AE0 Offset: 0x29424E0 VA: 0x182943AE0
	public static float4x3 op_Implicit(uint4x3 v) { }

	// RVA: 0x29434F0 Offset: 0x2941EF0 VA: 0x1829434F0
	public static float4x3 op_Explicit(double v) { }

	// RVA: 0x289C260 Offset: 0x289AC60 VA: 0x18289C260
	public static float4x3 op_Explicit(double4x3 v) { }

	// RVA: 0x2944DA0 Offset: 0x29437A0 VA: 0x182944DA0
	public static float4x3 op_Multiply(float4x3 lhs, float4x3 rhs) { }

	// RVA: 0x2944F50 Offset: 0x2943950 VA: 0x182944F50
	public static float4x3 op_Multiply(float4x3 lhs, float rhs) { }

	// RVA: 0x2944C40 Offset: 0x2943640 VA: 0x182944C40
	public static float4x3 op_Multiply(float lhs, float4x3 rhs) { }

	// RVA: 0x2942790 Offset: 0x2941190 VA: 0x182942790
	public static float4x3 op_Addition(float4x3 lhs, float4x3 rhs) { }

	// RVA: 0x2942940 Offset: 0x2941340 VA: 0x182942940
	public static float4x3 op_Addition(float4x3 lhs, float rhs) { }

	// RVA: 0x2942630 Offset: 0x2941030 VA: 0x182942630
	public static float4x3 op_Addition(float lhs, float4x3 rhs) { }

	// RVA: 0x29450B0 Offset: 0x2943AB0 VA: 0x1829450B0
	public static float4x3 op_Subtraction(float4x3 lhs, float4x3 rhs) { }

	// RVA: 0x2945260 Offset: 0x2943C60 VA: 0x182945260
	public static float4x3 op_Subtraction(float4x3 lhs, float rhs) { }

	// RVA: 0x29453C0 Offset: 0x2943DC0 VA: 0x1829453C0
	public static float4x3 op_Subtraction(float lhs, float4x3 rhs) { }

	// RVA: 0x2942C10 Offset: 0x2941610 VA: 0x182942C10
	public static float4x3 op_Division(float4x3 lhs, float4x3 rhs) { }

	// RVA: 0x2942DC0 Offset: 0x29417C0 VA: 0x182942DC0
	public static float4x3 op_Division(float4x3 lhs, float rhs) { }

	// RVA: 0x2942F20 Offset: 0x2941920 VA: 0x182942F20
	public static float4x3 op_Division(float lhs, float4x3 rhs) { }

	// RVA: 0x2944A00 Offset: 0x2943400 VA: 0x182944A00
	public static float4x3 op_Modulus(float4x3 lhs, float4x3 rhs) { }

	// RVA: 0x29447F0 Offset: 0x29431F0 VA: 0x1829447F0
	public static float4x3 op_Modulus(float4x3 lhs, float rhs) { }

	// RVA: 0x29445E0 Offset: 0x2942FE0 VA: 0x1829445E0
	public static float4x3 op_Modulus(float lhs, float4x3 rhs) { }

	// RVA: 0x2943B30 Offset: 0x2942530 VA: 0x182943B30
	public static float4x3 op_Increment(float4x3 val) { }

	// RVA: 0x2942AA0 Offset: 0x29414A0 VA: 0x182942AA0
	public static float4x3 op_Decrement(float4x3 val) { }

	// RVA: 0x2944360 Offset: 0x2942D60 VA: 0x182944360
	public static bool4x3 op_LessThan(float4x3 lhs, float4x3 rhs) { }

	// RVA: 0x2944520 Offset: 0x2942F20 VA: 0x182944520
	public static bool4x3 op_LessThan(float4x3 lhs, float rhs) { }

	// RVA: 0x2944460 Offset: 0x2942E60 VA: 0x182944460
	public static bool4x3 op_LessThan(float lhs, float4x3 rhs) { }

	// RVA: 0x29440E0 Offset: 0x2942AE0 VA: 0x1829440E0
	public static bool4x3 op_LessThanOrEqual(float4x3 lhs, float4x3 rhs) { }

	// RVA: 0x29441E0 Offset: 0x2942BE0 VA: 0x1829441E0
	public static bool4x3 op_LessThanOrEqual(float4x3 lhs, float rhs) { }

	// RVA: 0x29442A0 Offset: 0x2942CA0 VA: 0x1829442A0
	public static bool4x3 op_LessThanOrEqual(float lhs, float4x3 rhs) { }

	// RVA: 0x29438A0 Offset: 0x29422A0 VA: 0x1829438A0
	public static bool4x3 op_GreaterThan(float4x3 lhs, float4x3 rhs) { }

	// RVA: 0x29437E0 Offset: 0x29421E0 VA: 0x1829437E0
	public static bool4x3 op_GreaterThan(float4x3 lhs, float rhs) { }

	// RVA: 0x29439A0 Offset: 0x29423A0 VA: 0x1829439A0
	public static bool4x3 op_GreaterThan(float lhs, float4x3 rhs) { }

	// RVA: 0x2943560 Offset: 0x2941F60 VA: 0x182943560
	public static bool4x3 op_GreaterThanOrEqual(float4x3 lhs, float4x3 rhs) { }

	// RVA: 0x2943720 Offset: 0x2942120 VA: 0x182943720
	public static bool4x3 op_GreaterThanOrEqual(float4x3 lhs, float rhs) { }

	// RVA: 0x2943660 Offset: 0x2942060 VA: 0x182943660
	public static bool4x3 op_GreaterThanOrEqual(float lhs, float4x3 rhs) { }

	// RVA: 0x2945550 Offset: 0x2943F50 VA: 0x182945550
	public static float4x3 op_UnaryNegation(float4x3 val) { }

	// RVA: 0x29456B0 Offset: 0x29440B0 VA: 0x1829456B0
	public static float4x3 op_UnaryPlus(float4x3 val) { }

	// RVA: 0x2943200 Offset: 0x2941C00 VA: 0x182943200
	public static bool4x3 op_Equality(float4x3 lhs, float4x3 rhs) { }

	// RVA: 0x29433A0 Offset: 0x2941DA0 VA: 0x1829433A0
	public static bool4x3 op_Equality(float4x3 lhs, float rhs) { }

	// RVA: 0x29430B0 Offset: 0x2941AB0 VA: 0x1829430B0
	public static bool4x3 op_Equality(float lhs, float4x3 rhs) { }

	// RVA: 0x2943DF0 Offset: 0x29427F0 VA: 0x182943DF0
	public static bool4x3 op_Inequality(float4x3 lhs, float4x3 rhs) { }

	// RVA: 0x2943CA0 Offset: 0x29426A0 VA: 0x182943CA0
	public static bool4x3 op_Inequality(float4x3 lhs, float rhs) { }

	// RVA: 0x2943F90 Offset: 0x2942990 VA: 0x182943F90
	public static bool4x3 op_Inequality(float lhs, float4x3 rhs) { }

	// RVA: 0xF6D000 Offset: 0xF6BA00 VA: 0x180F6D000
	public ref float4 get_Item(int index) { }

	// RVA: 0x293B0B0 Offset: 0x2939AB0 VA: 0x18293B0B0 Slot: 4
	public bool Equals(float4x3 rhs) { }

	// RVA: 0x29419C0 Offset: 0x29403C0 VA: 0x1829419C0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2941A70 Offset: 0x2940470 VA: 0x182941A70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2941F90 Offset: 0x2940990 VA: 0x182941F90 Slot: 3
	public override string ToString() { }

	// RVA: 0x2941AA0 Offset: 0x29404A0 VA: 0x182941AA0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
