public struct Vector3 : IEquatable<Vector3>, IFormattable // TypeDefIndex: 11754
{
	// Fields
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	private static readonly Vector3 zeroVector; // 0x0
	private static readonly Vector3 oneVector; // 0xC
	private static readonly Vector3 upVector; // 0x18
	private static readonly Vector3 downVector; // 0x24
	private static readonly Vector3 leftVector; // 0x30
	private static readonly Vector3 rightVector; // 0x3C
	private static readonly Vector3 forwardVector; // 0x48
	private static readonly Vector3 backVector; // 0x54
	private static readonly Vector3 positiveInfinityVector; // 0x60
	private static readonly Vector3 negativeInfinityVector; // 0x6C

	// Properties
	public float Item { get; set; }
	public Vector3 normalized { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static Vector3 zero { get; }
	public static Vector3 one { get; }
	public static Vector3 forward { get; }
	public static Vector3 back { get; }
	public static Vector3 up { get; }
	public static Vector3 down { get; }
	public static Vector3 left { get; }
	public static Vector3 right { get; }

	// Methods

	[FreeFunction("VectorScripting::Slerp", IsThreadSafe = True)]
	// RVA: 0x2CB7230 Offset: 0x2CB5C30 VA: 0x182CB7230
	public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	[FreeFunction("VectorScripting::SlerpUnclamped", IsThreadSafe = True)]
	// RVA: 0x2CB7150 Offset: 0x2CB5B50 VA: 0x182CB7150
	public static Vector3 SlerpUnclamped(Vector3 a, Vector3 b, float t) { }

	[FreeFunction("VectorScripting::OrthoNormalize", IsThreadSafe = True)]
	// RVA: 0x2CB6C00 Offset: 0x2CB5600 VA: 0x182CB6C00
	private static void OrthoNormalize2(ref Vector3 a, ref Vector3 b) { }

	// RVA: 0x2CB6C00 Offset: 0x2CB5600 VA: 0x182CB6C00
	public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CB6F20 Offset: 0x2CB5920 VA: 0x182CB6F20
	public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta) { }

	// RVA: 0x2CB68F0 Offset: 0x2CB52F0 VA: 0x182CB68F0
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x2CB68A0 Offset: 0x2CB52A0 VA: 0x182CB68A0
	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x2CB6A90 Offset: 0x2CB5490 VA: 0x182CB6A90
	public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB7600 Offset: 0x2CB6000 VA: 0x182CB7600
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB76C0 Offset: 0x2CB60C0 VA: 0x182CB76C0
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime) { }

	// RVA: 0x2CB72A0 Offset: 0x2CB5CA0 VA: 0x182CB72A0
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	// RVA: 0xC0D030 Offset: 0xC0BA30 VA: 0x180C0D030
	public float get_Item(int index) { }

	// RVA: 0xC0D0C0 Offset: 0xC0BAC0 VA: 0x180C0D0C0
	public void set_Item(int index, float value) { }

	// RVA: 0x8272A0 Offset: 0x825CA0 VA: 0x1808272A0
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x2CB7B70 Offset: 0x2CB6570 VA: 0x182CB7B70
	public void .ctor(float x, float y) { }

	// RVA: 0x8272A0 Offset: 0x825CA0 VA: 0x1808272A0
	public void Set(float newX, float newY, float newZ) { }

	// RVA: 0x2CB6FA0 Offset: 0x2CB59A0 VA: 0x182CB6FA0
	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	// RVA: 0x2CB6FD0 Offset: 0x2CB59D0 VA: 0x182CB6FD0
	public void Scale(Vector3 scale) { }

	// RVA: 0x2CB6630 Offset: 0x2CB5030 VA: 0x182CB6630
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2CB6840 Offset: 0x2CB5240 VA: 0x182CB6840 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CB6790 Offset: 0x2CB5190 VA: 0x182CB6790 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x292F1D0 Offset: 0x292DBD0 VA: 0x18292F1D0 Slot: 4
	public bool Equals(Vector3 other) { }

	// RVA: 0x44CFE0 Offset: 0x44B9E0 VA: 0x18044CFE0
	public static Vector3 Normalize(Vector3 value) { }

	// RVA: 0x719C50 Offset: 0x718650 VA: 0x180719C50
	public void Normalize() { }

	// RVA: 0x2CB7DC0 Offset: 0x2CB67C0 VA: 0x182CB7DC0
	public Vector3 get_normalized() { }

	// RVA: 0x2CB6760 Offset: 0x2CB5160 VA: 0x182CB6760
	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2CB6D70 Offset: 0x2CB5770 VA: 0x182CB6D70
	public static Vector3 Project(Vector3 vector, Vector3 onNormal) { }

	// RVA: 0x2CB6C50 Offset: 0x2CB5650 VA: 0x182CB6C50
	public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) { }

	// RVA: 0x2CB63C0 Offset: 0x2CB4DC0 VA: 0x182CB63C0
	public static float Angle(Vector3 from, Vector3 to) { }

	// RVA: 0x2CB7000 Offset: 0x2CB5A00 VA: 0x182CB7000
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	// RVA: 0x2CB6690 Offset: 0x2CB5090 VA: 0x182CB6690
	public static float Distance(Vector3 a, Vector3 b) { }

	// RVA: 0x2CB6530 Offset: 0x2CB4F30 VA: 0x182CB6530
	public static Vector3 ClampMagnitude(Vector3 vector, float maxLength) { }

	// RVA: 0x2CB6960 Offset: 0x2CB5360 VA: 0x182CB6960
	public static float Magnitude(Vector3 vector) { }

	// RVA: 0x2CB7CD0 Offset: 0x2CB66D0 VA: 0x182CB7CD0
	public float get_magnitude() { }

	// RVA: 0x2CB7780 Offset: 0x2CB6180 VA: 0x182CB7780
	public static float SqrMagnitude(Vector3 vector) { }

	// RVA: 0x2CB7780 Offset: 0x2CB6180 VA: 0x182CB7780
	public float get_sqrMagnitude() { }

	// RVA: 0x2CB6A50 Offset: 0x2CB5450 VA: 0x182CB6A50
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2CB6A10 Offset: 0x2CB5410 VA: 0x182CB6A10
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2CB7F00 Offset: 0x2CB6900 VA: 0x182CB7F00
	public static Vector3 get_zero() { }

	// RVA: 0x2CB7E10 Offset: 0x2CB6810 VA: 0x182CB7E10
	public static Vector3 get_one() { }

	// RVA: 0x2CB7C30 Offset: 0x2CB6630 VA: 0x182CB7C30
	public static Vector3 get_forward() { }

	// RVA: 0x2CB7B90 Offset: 0x2CB6590 VA: 0x182CB7B90
	public static Vector3 get_back() { }

	// RVA: 0x2CB7EB0 Offset: 0x2CB68B0 VA: 0x182CB7EB0
	public static Vector3 get_up() { }

	// RVA: 0x2CB7BE0 Offset: 0x2CB65E0 VA: 0x182CB7BE0
	public static Vector3 get_down() { }

	// RVA: 0x2CB7C80 Offset: 0x2CB6680 VA: 0x182CB7C80
	public static Vector3 get_left() { }

	// RVA: 0x2CB7E60 Offset: 0x2CB6860 VA: 0x182CB7E60
	public static Vector3 get_right() { }

	// RVA: 0x44B590 Offset: 0x449F90 VA: 0x18044B590
	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	// RVA: 0x44B5C0 Offset: 0x449FC0 VA: 0x18044B5C0
	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	// RVA: 0x2CB8050 Offset: 0x2CB6A50 VA: 0x182CB8050
	public static Vector3 op_UnaryNegation(Vector3 a) { }

	// RVA: 0x2CB8020 Offset: 0x2CB6A20 VA: 0x182CB8020
	public static Vector3 op_Multiply(Vector3 a, float d) { }

	// RVA: 0x2CB7FF0 Offset: 0x2CB69F0 VA: 0x182CB7FF0
	public static Vector3 op_Multiply(float d, Vector3 a) { }

	// RVA: 0x44D100 Offset: 0x44BB00 VA: 0x18044D100
	public static Vector3 op_Division(Vector3 a, float d) { }

	// RVA: 0x2CB7F50 Offset: 0x2CB6950 VA: 0x182CB7F50
	public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2CB7F90 Offset: 0x2CB6990 VA: 0x182CB7F90
	public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2CB77C0 Offset: 0x2CB61C0 VA: 0x182CB77C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2CB77B0 Offset: 0x2CB61B0 VA: 0x182CB77B0
	public string ToString(string format) { }

	// RVA: 0x2CB77D0 Offset: 0x2CB61D0 VA: 0x182CB77D0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2CB79F0 Offset: 0x2CB63F0 VA: 0x182CB79F0
	private static void .cctor() { }

	// RVA: 0x2CB71C0 Offset: 0x2CB5BC0 VA: 0x182CB71C0
	private static void Slerp_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret) { }

	// RVA: 0x2CB70E0 Offset: 0x2CB5AE0 VA: 0x182CB70E0
	private static void SlerpUnclamped_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret) { }

	// RVA: 0x2CB6EB0 Offset: 0x2CB58B0 VA: 0x182CB6EB0
	private static void RotateTowards_Injected(ref Vector3 current, ref Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 ret) { }
}
