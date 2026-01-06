public struct Vector4 : IEquatable<Vector4>, IFormattable // TypeDefIndex: 11760
{
	// Fields
	public const float kEpsilon = 1E-05;
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Vector4 zeroVector; // 0x0
	private static readonly Vector4 oneVector; // 0x10
	private static readonly Vector4 positiveInfinityVector; // 0x20
	private static readonly Vector4 negativeInfinityVector; // 0x30

	// Properties
	public float Item { get; set; }
	public Vector4 normalized { get; }
	public float sqrMagnitude { get; }
	public static Vector4 zero { get; }
	public static Vector4 one { get; }

	// Methods

	// RVA: 0xA7A1A0 Offset: 0xA78BA0 VA: 0x180A7A1A0
	public float get_Item(int index) { }

	// RVA: 0xC41FB0 Offset: 0xC409B0 VA: 0x180C41FB0
	public void set_Item(int index, float value) { }

	// RVA: 0xDA46A0 Offset: 0xDA30A0 VA: 0x180DA46A0
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x2CD3BE0 Offset: 0x2CD25E0 VA: 0x182CD3BE0
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x2CD3BD0 Offset: 0x2CD25D0 VA: 0x182CD3BD0
	public void .ctor(float x, float y) { }

	// RVA: 0xDA46A0 Offset: 0xDA30A0 VA: 0x180DA46A0
	public void Set(float newX, float newY, float newZ, float newW) { }

	// RVA: 0x2CA3000 Offset: 0x2CA1A00 VA: 0x182CA3000
	public static Vector4 Lerp(Vector4 a, Vector4 b, float t) { }

	// RVA: 0x2CD3820 Offset: 0x2CD2220 VA: 0x182CD3820
	public void Scale(Vector4 scale) { }

	// RVA: 0xB021F0 Offset: 0xB00BF0 VA: 0x180B021F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CD35C0 Offset: 0x2CD1FC0 VA: 0x182CD35C0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x214CBC0 Offset: 0x214B5C0 VA: 0x18214CBC0 Slot: 4
	public bool Equals(Vector4 other) { }

	// RVA: 0x2CD3750 Offset: 0x2CD2150 VA: 0x182CD3750
	public static Vector4 Normalize(Vector4 a) { }

	// RVA: 0x2CD3C00 Offset: 0x2CD2600 VA: 0x182CD3C00
	public Vector4 get_normalized() { }

	// RVA: 0x2CAB000 Offset: 0x2CA9A00 VA: 0x182CAB000
	public static float Dot(Vector4 a, Vector4 b) { }

	// RVA: 0x2CD3680 Offset: 0x2CD2080 VA: 0x182CD3680
	public static float Magnitude(Vector4 a) { }

	// RVA: 0x2CD3860 Offset: 0x2CD2260 VA: 0x182CD3860
	public float get_sqrMagnitude() { }

	// RVA: 0x2CD3D20 Offset: 0x2CD2720 VA: 0x182CD3D20
	public static Vector4 get_zero() { }

	// RVA: 0x2CD3CD0 Offset: 0x2CD26D0 VA: 0x182CD3CD0
	public static Vector4 get_one() { }

	// RVA: 0x2CA3660 Offset: 0x2CA2060 VA: 0x182CA3660
	public static Vector4 op_Addition(Vector4 a, Vector4 b) { }

	// RVA: 0x2CA38E0 Offset: 0x2CA22E0 VA: 0x182CA38E0
	public static Vector4 op_Subtraction(Vector4 a, Vector4 b) { }

	// RVA: 0x2CD3EF0 Offset: 0x2CD28F0 VA: 0x182CD3EF0
	public static Vector4 op_UnaryNegation(Vector4 a) { }

	// RVA: 0x2CA37E0 Offset: 0x2CA21E0 VA: 0x182CA37E0
	public static Vector4 op_Multiply(Vector4 a, float d) { }

	// RVA: 0x2CA3830 Offset: 0x2CA2230 VA: 0x182CA3830
	public static Vector4 op_Multiply(float d, Vector4 a) { }

	// RVA: 0x2CA36C0 Offset: 0x2CA20C0 VA: 0x182CA36C0
	public static Vector4 op_Division(Vector4 a, float d) { }

	// RVA: 0x2CD3D70 Offset: 0x2CD2770 VA: 0x182CD3D70
	public static bool op_Equality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x2CD3E80 Offset: 0x2CD2880 VA: 0x182CD3E80
	public static bool op_Inequality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x2CD3DF0 Offset: 0x2CD27F0 VA: 0x182CD3DF0
	public static Vector4 op_Implicit(Vector3 v) { }

	// RVA: 0x2CD3DD0 Offset: 0x2CD27D0 VA: 0x182CD3DD0
	public static Vector3 op_Implicit(Vector4 v) { }

	// RVA: 0x2CD3E40 Offset: 0x2CD2840 VA: 0x182CD3E40
	public static Vector4 op_Implicit(Vector2 v) { }

	// RVA: 0x2C9B630 Offset: 0x2C9A030 VA: 0x182C9B630
	public static Vector2 op_Implicit(Vector4 v) { }

	// RVA: 0x2CD3B30 Offset: 0x2CD2530 VA: 0x182CD3B30 Slot: 3
	public override string ToString() { }

	// RVA: 0x2CD38B0 Offset: 0x2CD22B0 VA: 0x182CD38B0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2CD3860 Offset: 0x2CD2260 VA: 0x182CD3860
	public static float SqrMagnitude(Vector4 a) { }

	// RVA: 0x2CD3B40 Offset: 0x2CD2540 VA: 0x182CD3B40
	private static void .cctor() { }
}
