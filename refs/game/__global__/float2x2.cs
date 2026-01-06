public struct float2x2 : IEquatable<float2x2>, IFormattable // TypeDefIndex: 10901
{
	// Fields
	public float2 c0; // 0x0
	public float2 c1; // 0x8
	public static readonly float2x2 identity; // 0x0
	public static readonly float2x2 zero; // 0x10

	// Properties
	public float2 Item { get; }

	// Methods

	// RVA: 0xC41170 Offset: 0xC3FB70 VA: 0x180C41170
	public void .ctor(float2 c0, float2 c1) { }

	// RVA: 0x2929B20 Offset: 0x2928520 VA: 0x182929B20
	public void .ctor(float m00, float m01, float m10, float m11) { }

	// RVA: 0x2712650 Offset: 0x2711050 VA: 0x182712650
	public void .ctor(float v) { }

	// RVA: 0x29299C0 Offset: 0x29283C0 VA: 0x1829299C0
	public void .ctor(bool v) { }

	// RVA: 0x2929A90 Offset: 0x2928490 VA: 0x182929A90
	public void .ctor(bool2x2 v) { }

	// RVA: 0x2929AF0 Offset: 0x29284F0 VA: 0x182929AF0
	public void .ctor(int v) { }

	// RVA: 0x2929B80 Offset: 0x2928580 VA: 0x182929B80
	public void .ctor(int2x2 v) { }

	// RVA: 0x2929BC0 Offset: 0x29285C0 VA: 0x182929BC0
	public void .ctor(uint v) { }

	// RVA: 0x2929A00 Offset: 0x2928400 VA: 0x182929A00
	public void .ctor(uint2x2 v) { }

	// RVA: 0x2929A60 Offset: 0x2928460 VA: 0x182929A60
	public void .ctor(double v) { }

	// RVA: 0x2929B40 Offset: 0x2928540 VA: 0x182929B40
	public void .ctor(double2x2 v) { }

	// RVA: 0x2710A40 Offset: 0x270F440 VA: 0x182710A40
	public static float2x2 op_Implicit(float v) { }

	// RVA: 0x2899560 Offset: 0x2897F60 VA: 0x182899560
	public static float2x2 op_Explicit(bool v) { }

	// RVA: 0x28995A0 Offset: 0x2897FA0 VA: 0x1828995A0
	public static float2x2 op_Explicit(bool2x2 v) { }

	// RVA: 0x28993E0 Offset: 0x2897DE0 VA: 0x1828993E0
	public static float2x2 op_Implicit(int v) { }

	// RVA: 0x2899500 Offset: 0x2897F00 VA: 0x182899500
	public static float2x2 op_Implicit(int2x2 v) { }

	// RVA: 0x2899470 Offset: 0x2897E70 VA: 0x182899470
	public static float2x2 op_Implicit(uint v) { }

	// RVA: 0x2899350 Offset: 0x2897D50 VA: 0x182899350
	public static float2x2 op_Implicit(uint2x2 v) { }

	// RVA: 0x28994C0 Offset: 0x2897EC0 VA: 0x1828994C0
	public static float2x2 op_Explicit(double v) { }

	// RVA: 0x2899420 Offset: 0x2897E20 VA: 0x182899420
	public static float2x2 op_Explicit(double2x2 v) { }

	// RVA: 0x292A9E0 Offset: 0x29293E0 VA: 0x18292A9E0
	public static float2x2 op_Multiply(float2x2 lhs, float2x2 rhs) { }

	// RVA: 0x292AA70 Offset: 0x2929470 VA: 0x18292AA70
	public static float2x2 op_Multiply(float2x2 lhs, float rhs) { }

	// RVA: 0x292AA30 Offset: 0x2929430 VA: 0x18292AA30
	public static float2x2 op_Multiply(float lhs, float2x2 rhs) { }

	// RVA: 0x2929C10 Offset: 0x2928610 VA: 0x182929C10
	public static float2x2 op_Addition(float2x2 lhs, float2x2 rhs) { }

	// RVA: 0x2929CA0 Offset: 0x29286A0 VA: 0x182929CA0
	public static float2x2 op_Addition(float2x2 lhs, float rhs) { }

	// RVA: 0x2929C60 Offset: 0x2928660 VA: 0x182929C60
	public static float2x2 op_Addition(float lhs, float2x2 rhs) { }

	// RVA: 0x292AB30 Offset: 0x2929530 VA: 0x18292AB30
	public static float2x2 op_Subtraction(float2x2 lhs, float2x2 rhs) { }

	// RVA: 0x292AAF0 Offset: 0x29294F0 VA: 0x18292AAF0
	public static float2x2 op_Subtraction(float2x2 lhs, float rhs) { }

	// RVA: 0x292AAB0 Offset: 0x29294B0 VA: 0x18292AAB0
	public static float2x2 op_Subtraction(float lhs, float2x2 rhs) { }

	// RVA: 0x2929D30 Offset: 0x2928730 VA: 0x182929D30
	public static float2x2 op_Division(float2x2 lhs, float2x2 rhs) { }

	// RVA: 0x2929DC0 Offset: 0x29287C0 VA: 0x182929DC0
	public static float2x2 op_Division(float2x2 lhs, float rhs) { }

	// RVA: 0x2929D80 Offset: 0x2928780 VA: 0x182929D80
	public static float2x2 op_Division(float lhs, float2x2 rhs) { }

	// RVA: 0x292A940 Offset: 0x2929340 VA: 0x18292A940
	public static float2x2 op_Modulus(float2x2 lhs, float2x2 rhs) { }

	// RVA: 0x292A830 Offset: 0x2929230 VA: 0x18292A830
	public static float2x2 op_Modulus(float2x2 lhs, float rhs) { }

	// RVA: 0x292A8B0 Offset: 0x29292B0 VA: 0x18292A8B0
	public static float2x2 op_Modulus(float lhs, float2x2 rhs) { }

	// RVA: 0x292A2F0 Offset: 0x2928CF0 VA: 0x18292A2F0
	public static float2x2 op_Increment(float2x2 val) { }

	// RVA: 0x2929CE0 Offset: 0x29286E0 VA: 0x182929CE0
	public static float2x2 op_Decrement(float2x2 val) { }

	// RVA: 0x292A730 Offset: 0x2929130 VA: 0x18292A730
	public static bool2x2 op_LessThan(float2x2 lhs, float2x2 rhs) { }

	// RVA: 0x292A7C0 Offset: 0x29291C0 VA: 0x18292A7C0
	public static bool2x2 op_LessThan(float2x2 lhs, float rhs) { }

	// RVA: 0x292A6B0 Offset: 0x29290B0 VA: 0x18292A6B0
	public static bool2x2 op_LessThan(float lhs, float2x2 rhs) { }

	// RVA: 0x292A5B0 Offset: 0x2928FB0 VA: 0x18292A5B0
	public static bool2x2 op_LessThanOrEqual(float2x2 lhs, float2x2 rhs) { }

	// RVA: 0x292A640 Offset: 0x2929040 VA: 0x18292A640
	public static bool2x2 op_LessThanOrEqual(float2x2 lhs, float rhs) { }

	// RVA: 0x292A530 Offset: 0x2928F30 VA: 0x18292A530
	public static bool2x2 op_LessThanOrEqual(float lhs, float2x2 rhs) { }

	// RVA: 0x292A1E0 Offset: 0x2928BE0 VA: 0x18292A1E0
	public static bool2x2 op_GreaterThan(float2x2 lhs, float2x2 rhs) { }

	// RVA: 0x292A270 Offset: 0x2928C70 VA: 0x18292A270
	public static bool2x2 op_GreaterThan(float2x2 lhs, float rhs) { }

	// RVA: 0x292A170 Offset: 0x2928B70 VA: 0x18292A170
	public static bool2x2 op_GreaterThan(float lhs, float2x2 rhs) { }

	// RVA: 0x292A070 Offset: 0x2928A70 VA: 0x18292A070
	public static bool2x2 op_GreaterThanOrEqual(float2x2 lhs, float2x2 rhs) { }

	// RVA: 0x2929FF0 Offset: 0x29289F0 VA: 0x182929FF0
	public static bool2x2 op_GreaterThanOrEqual(float2x2 lhs, float rhs) { }

	// RVA: 0x292A100 Offset: 0x2928B00 VA: 0x18292A100
	public static bool2x2 op_GreaterThanOrEqual(float lhs, float2x2 rhs) { }

	// RVA: 0x292AB80 Offset: 0x2929580 VA: 0x18292AB80
	public static float2x2 op_UnaryNegation(float2x2 val) { }

	// RVA: 0x292ABC0 Offset: 0x29295C0 VA: 0x18292ABC0
	public static float2x2 op_UnaryPlus(float2x2 val) { }

	// RVA: 0x2929E00 Offset: 0x2928800 VA: 0x182929E00
	public static bool2x2 op_Equality(float2x2 lhs, float2x2 rhs) { }

	// RVA: 0x2929EC0 Offset: 0x29288C0 VA: 0x182929EC0
	public static bool2x2 op_Equality(float2x2 lhs, float rhs) { }

	// RVA: 0x2929F60 Offset: 0x2928960 VA: 0x182929F60
	public static bool2x2 op_Equality(float lhs, float2x2 rhs) { }

	// RVA: 0x292A340 Offset: 0x2928D40 VA: 0x18292A340
	public static bool2x2 op_Inequality(float2x2 lhs, float2x2 rhs) { }

	// RVA: 0x292A490 Offset: 0x2928E90 VA: 0x18292A490
	public static bool2x2 op_Inequality(float2x2 lhs, float rhs) { }

	// RVA: 0x292A400 Offset: 0x2928E00 VA: 0x18292A400
	public static bool2x2 op_Inequality(float lhs, float2x2 rhs) { }

	// RVA: 0xF6CFF0 Offset: 0xF6B9F0 VA: 0x180F6CFF0
	public ref float2 get_Item(int index) { }

	// RVA: 0x29292A0 Offset: 0x2927CA0 VA: 0x1829292A0 Slot: 4
	public bool Equals(float2x2 rhs) { }

	// RVA: 0x29292F0 Offset: 0x2927CF0 VA: 0x1829292F0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x29293B0 Offset: 0x2927DB0 VA: 0x1829293B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2929760 Offset: 0x2928160 VA: 0x182929760 Slot: 3
	public override string ToString() { }

	// RVA: 0x2929550 Offset: 0x2927F50 VA: 0x182929550 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x29293D0 Offset: 0x2927DD0 VA: 0x1829293D0
	public static float2x2 Rotate(float angle) { }

	// RVA: 0x29294E0 Offset: 0x2927EE0 VA: 0x1829294E0
	public static float2x2 Scale(float s) { }

	// RVA: 0x29294B0 Offset: 0x2927EB0 VA: 0x1829294B0
	public static float2x2 Scale(float x, float y) { }

	// RVA: 0x2929510 Offset: 0x2927F10 VA: 0x182929510
	public static float2x2 Scale(float2 v) { }

	// RVA: 0x2929980 Offset: 0x2928380 VA: 0x182929980
	private static void .cctor() { }
}
