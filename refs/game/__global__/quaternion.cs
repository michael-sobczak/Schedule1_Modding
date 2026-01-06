public struct Quaternion : IEquatable<Quaternion>, IFormattable // TypeDefIndex: 11755
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Quaternion identityQuaternion; // 0x0
	public const float kEpsilon = 1E-06;

	// Properties
	public static Quaternion identity { get; }
	public Vector3 eulerAngles { get; set; }
	public Quaternion normalized { get; }

	// Methods

	[FreeFunction("FromToQuaternionSafe", IsThreadSafe = True)]
	// RVA: 0x2CAB2B0 Offset: 0x2CA9CB0 VA: 0x182CAB2B0
	public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CAB5F0 Offset: 0x2CA9FF0 VA: 0x182CAB5F0
	public static Quaternion Inverse(Quaternion rotation) { }

	[FreeFunction("QuaternionScripting::Slerp", IsThreadSafe = True)]
	// RVA: 0x2CABD30 Offset: 0x2CAA730 VA: 0x182CABD30
	public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunction("QuaternionScripting::SlerpUnclamped", IsThreadSafe = True)]
	// RVA: 0x2CABC50 Offset: 0x2CAA650 VA: 0x182CABC50
	public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[FreeFunction("QuaternionScripting::Lerp", IsThreadSafe = True)]
	// RVA: 0x2CAB7A0 Offset: 0x2CAA1A0 VA: 0x182CAB7A0
	public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunction("QuaternionScripting::LerpUnclamped", IsThreadSafe = True)]
	// RVA: 0x2CAB6C0 Offset: 0x2CAA0C0 VA: 0x182CAB6C0
	public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[FreeFunction("EulerToQuaternion", IsThreadSafe = True)]
	// RVA: 0x2CAB360 Offset: 0x2CA9D60 VA: 0x182CAB360
	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	[FreeFunction("QuaternionScripting::ToEuler", IsThreadSafe = True)]
	// RVA: 0x2CAB550 Offset: 0x2CA9F50 VA: 0x182CAB550
	private static Vector3 Internal_ToEulerRad(Quaternion rotation) { }

	[FreeFunction("QuaternionScripting::ToAxisAngle", IsThreadSafe = True)]
	// RVA: 0x2CAB4A0 Offset: 0x2CA9EA0 VA: 0x182CAB4A0
	private static void Internal_ToAxisAngleRad(Quaternion q, out Vector3 axis, out float angle) { }

	[FreeFunction("QuaternionScripting::AngleAxis", IsThreadSafe = True)]
	// RVA: 0x2CAAF10 Offset: 0x2CA9910 VA: 0x182CAAF10
	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	[FreeFunction("QuaternionScripting::LookRotation", IsThreadSafe = True)]
	// RVA: 0x2CAB930 Offset: 0x2CAA330 VA: 0x182CAB930
	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAB870 Offset: 0x2CAA270 VA: 0x182CAB870
	public static Quaternion LookRotation(Vector3 forward) { }

	// RVA: 0xDA46A0 Offset: 0xDA30A0 VA: 0x180DA46A0
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x2CAC1E0 Offset: 0x2CAABE0 VA: 0x182CAC1E0
	public static Quaternion get_identity() { }

	// RVA: 0x44B3E0 Offset: 0x449DE0 VA: 0x18044B3E0
	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x2CAC2D0 Offset: 0x2CAACD0 VA: 0x182CAC2D0
	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	// RVA: 0x2CAB640 Offset: 0x2CAA040 VA: 0x182CAB640
	private static bool IsEqualUsingDot(float dot) { }

	// RVA: 0x2CAC270 Offset: 0x2CAAC70 VA: 0x182CAC270
	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x4BECF0 Offset: 0x4BD6F0 VA: 0x1804BECF0
	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x2CAB000 Offset: 0x2CA9A00 VA: 0x182CAB000
	public static float Dot(Quaternion a, Quaternion b) { }

	// RVA: 0x2CAAF70 Offset: 0x2CA9970 VA: 0x182CAAF70
	public static float Angle(Quaternion a, Quaternion b) { }

	// RVA: 0x2CAB3B0 Offset: 0x2CA9DB0 VA: 0x182CAB3B0
	private static Vector3 Internal_MakePositive(Vector3 euler) { }

	// RVA: 0x2CAC0D0 Offset: 0x2CAAAD0 VA: 0x182CAC0D0
	public Vector3 get_eulerAngles() { }

	// RVA: 0x2CAC440 Offset: 0x2CAAE40 VA: 0x182CAC440
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x2CAB1D0 Offset: 0x2CA9BD0 VA: 0x182CAB1D0
	public static Quaternion Euler(float x, float y, float z) { }

	// RVA: 0x2CAB140 Offset: 0x2CA9B40 VA: 0x182CAB140
	public static Quaternion Euler(Vector3 euler) { }

	// RVA: 0x2CABDA0 Offset: 0x2CAA7A0 VA: 0x182CABDA0
	public void ToAngleAxis(out float angle, out Vector3 axis) { }

	// RVA: 0x2CABAA0 Offset: 0x2CAA4A0 VA: 0x182CABAA0
	public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { }

	// RVA: 0x2CAB990 Offset: 0x2CAA390 VA: 0x182CAB990
	public static Quaternion Normalize(Quaternion q) { }

	// RVA: 0x2CAC230 Offset: 0x2CAAC30 VA: 0x182CAC230
	public Quaternion get_normalized() { }

	// RVA: 0xB021F0 Offset: 0xB00BF0 VA: 0x180B021F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CAB040 Offset: 0x2CA9A40 VA: 0x182CAB040 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2CA2C20 Offset: 0x2CA1620 VA: 0x182CA2C20 Slot: 4
	public bool Equals(Quaternion other) { }

	// RVA: 0x2CAC080 Offset: 0x2CAAA80 VA: 0x182CAC080 Slot: 3
	public override string ToString() { }

	// RVA: 0x2CABE00 Offset: 0x2CAA800 VA: 0x182CABE00 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2CAC090 Offset: 0x2CAAA90 VA: 0x182CAC090
	private static void .cctor() { }

	// RVA: 0x2CAB250 Offset: 0x2CA9C50 VA: 0x182CAB250
	private static void FromToRotation_Injected(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion ret) { }

	// RVA: 0x2CAB5A0 Offset: 0x2CA9FA0 VA: 0x182CAB5A0
	private static void Inverse_Injected(ref Quaternion rotation, out Quaternion ret) { }

	// RVA: 0x2CABCC0 Offset: 0x2CAA6C0 VA: 0x182CABCC0
	private static void Slerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x2CABBE0 Offset: 0x2CAA5E0 VA: 0x182CABBE0
	private static void SlerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x2CAB730 Offset: 0x2CAA130 VA: 0x182CAB730
	private static void Lerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x2CAB650 Offset: 0x2CAA050 VA: 0x182CAB650
	private static void LerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x2CAB310 Offset: 0x2CA9D10 VA: 0x182CAB310
	private static void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret) { }

	// RVA: 0x2CAB500 Offset: 0x2CA9F00 VA: 0x182CAB500
	private static void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret) { }

	// RVA: 0x2CAB440 Offset: 0x2CA9E40 VA: 0x182CAB440
	private static void Internal_ToAxisAngleRad_Injected(ref Quaternion q, out Vector3 axis, out float angle) { }

	// RVA: 0x2CAAEB0 Offset: 0x2CA98B0 VA: 0x182CAAEB0
	private static void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret) { }

	// RVA: 0x2CAB810 Offset: 0x2CAA210 VA: 0x182CAB810
	private static void LookRotation_Injected(ref Vector3 forward, ref Vector3 upwards, out Quaternion ret) { }
}
