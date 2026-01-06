public struct Vector2 : IEquatable<Vector2>, IFormattable // TypeDefIndex: 11757
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	private static readonly Vector2 zeroVector; // 0x0
	private static readonly Vector2 oneVector; // 0x8
	private static readonly Vector2 upVector; // 0x10
	private static readonly Vector2 downVector; // 0x18
	private static readonly Vector2 leftVector; // 0x20
	private static readonly Vector2 rightVector; // 0x28
	private static readonly Vector2 positiveInfinityVector; // 0x30
	private static readonly Vector2 negativeInfinityVector; // 0x38
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;

	// Properties
	public float Item { get; set; }
	public Vector2 normalized { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static Vector2 zero { get; }
	public static Vector2 one { get; }
	public static Vector2 up { get; }
	public static Vector2 down { get; }
	public static Vector2 left { get; }
	public static Vector2 right { get; }
	public static Vector2 positiveInfinity { get; }
	public static Vector2 negativeInfinity { get; }

	// Methods

	// RVA: 0xA7A120 Offset: 0xA78B20 VA: 0x180A7A120
	public float get_Item(int index) { }

	// RVA: 0x1A47E20 Offset: 0x1A46820 VA: 0x181A47E20
	public void set_Item(int index, float value) { }

	// RVA: 0x7B38F0 Offset: 0x7B22F0 VA: 0x1807B38F0
	public void .ctor(float x, float y) { }

	// RVA: 0x7B38F0 Offset: 0x7B22F0 VA: 0x1807B38F0
	public void Set(float newX, float newY) { }

	// RVA: 0x43C230 Offset: 0x43AC30 VA: 0x18043C230
	public static Vector2 Lerp(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x28AF220 Offset: 0x28ADC20 VA: 0x1828AF220
	public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t) { }

	// RVA: 0xDAC660 Offset: 0xDAB060 VA: 0x180DAC660
	public static Vector2 Scale(Vector2 a, Vector2 b) { }

	// RVA: 0x2CD2250 Offset: 0x2CD0C50 VA: 0x182CD2250
	public void Normalize() { }

	// RVA: 0x44CE50 Offset: 0x44B850 VA: 0x18044CE50
	public Vector2 get_normalized() { }

	// RVA: 0x2CD2780 Offset: 0x2CD1180 VA: 0x182CD2780 Slot: 3
	public override string ToString() { }

	// RVA: 0x2CD2790 Offset: 0x2CD1190 VA: 0x182CD2790 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2CD2190 Offset: 0x2CD0B90 VA: 0x182CD2190 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CD20F0 Offset: 0x2CD0AF0 VA: 0x182CD20F0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x7B3800 Offset: 0x7B2200 VA: 0x1807B3800 Slot: 4
	public bool Equals(Vector2 other) { }

	// RVA: 0x2CD22E0 Offset: 0x2CD0CE0 VA: 0x182CD22E0
	public static Vector2 Perpendicular(Vector2 inDirection) { }

	// RVA: 0x2CD20C0 Offset: 0x2CD0AC0 VA: 0x182CD20C0
	public static float Dot(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x2CD2AE0 Offset: 0x2CD14E0 VA: 0x182CD2AE0
	public float get_magnitude() { }

	// RVA: 0x2CD2CD0 Offset: 0x2CD16D0 VA: 0x182CD2CD0
	public float get_sqrMagnitude() { }

	// RVA: 0x2CD1DB0 Offset: 0x2CD07B0 VA: 0x182CD1DB0
	public static float Angle(Vector2 from, Vector2 to) { }

	// RVA: 0x2CD2310 Offset: 0x2CD0D10 VA: 0x182CD2310
	public static float SignedAngle(Vector2 from, Vector2 to) { }

	// RVA: 0x2CD2010 Offset: 0x2CD0A10 VA: 0x182CD2010
	public static float Distance(Vector2 a, Vector2 b) { }

	// RVA: 0x2CD1F10 Offset: 0x2CD0910 VA: 0x182CD1F10
	public static Vector2 ClampMagnitude(Vector2 vector, float maxLength) { }

	// RVA: 0x28AECE0 Offset: 0x28AD6E0 VA: 0x1828AECE0
	public static float SqrMagnitude(Vector2 a) { }

	// RVA: 0x2CD2210 Offset: 0x2CD0C10 VA: 0x182CD2210
	public static Vector2 Min(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x2CD21D0 Offset: 0x2CD0BD0 VA: 0x182CD21D0
	public static Vector2 Max(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x2CD24D0 Offset: 0x2CD0ED0 VA: 0x182CD24D0
	public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	// RVA: 0x2928B40 Offset: 0x2927540 VA: 0x182928B40
	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	// RVA: 0x29291C0 Offset: 0x2927BC0 VA: 0x1829291C0
	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	// RVA: 0xDAC660 Offset: 0xDAB060 VA: 0x180DAC660
	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	// RVA: 0x2928C10 Offset: 0x2927610 VA: 0x182928C10
	public static Vector2 op_Division(Vector2 a, Vector2 b) { }

	// RVA: 0x2929250 Offset: 0x2927C50 VA: 0x182929250
	public static Vector2 op_UnaryNegation(Vector2 a) { }

	// RVA: 0x2929160 Offset: 0x2927B60 VA: 0x182929160
	public static Vector2 op_Multiply(Vector2 a, float d) { }

	// RVA: 0x2929190 Offset: 0x2927B90 VA: 0x182929190
	public static Vector2 op_Multiply(float d, Vector2 a) { }

	// RVA: 0x2928BE0 Offset: 0x29275E0 VA: 0x182928BE0
	public static Vector2 op_Division(Vector2 a, float d) { }

	// RVA: 0x2CD2D90 Offset: 0x2CD1790 VA: 0x182CD2D90
	public static bool op_Equality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x2CD2DE0 Offset: 0x2CD17E0 VA: 0x182CD2DE0
	public static bool op_Inequality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x2C9B630 Offset: 0x2C9A030 VA: 0x182C9B630
	public static Vector2 op_Implicit(Vector3 v) { }

	// RVA: 0x470540 Offset: 0x46EF40 VA: 0x180470540
	public static Vector3 op_Implicit(Vector2 v) { }

	// RVA: 0x2CD2D40 Offset: 0x2CD1740 VA: 0x182CD2D40
	public static Vector2 get_zero() { }

	// RVA: 0x2CD2BE0 Offset: 0x2CD15E0 VA: 0x182CD2BE0
	public static Vector2 get_one() { }

	// RVA: 0x2CD2CF0 Offset: 0x2CD16F0 VA: 0x182CD2CF0
	public static Vector2 get_up() { }

	// RVA: 0x2CD2A40 Offset: 0x2CD1440 VA: 0x182CD2A40
	public static Vector2 get_down() { }

	// RVA: 0x2CD2A90 Offset: 0x2CD1490 VA: 0x182CD2A90
	public static Vector2 get_left() { }

	// RVA: 0x2CD2C80 Offset: 0x2CD1680 VA: 0x182CD2C80
	public static Vector2 get_right() { }

	// RVA: 0x2CD2C30 Offset: 0x2CD1630 VA: 0x182CD2C30
	public static Vector2 get_positiveInfinity() { }

	// RVA: 0x2CD2B90 Offset: 0x2CD1590 VA: 0x182CD2B90
	public static Vector2 get_negativeInfinity() { }

	// RVA: 0x2CD2950 Offset: 0x2CD1350 VA: 0x182CD2950
	private static void .cctor() { }
}
