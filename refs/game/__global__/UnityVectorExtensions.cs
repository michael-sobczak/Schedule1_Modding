public static class UnityVectorExtensions // TypeDefIndex: 16267
{
	// Fields
	public const float Epsilon = 0.0001;

	// Methods

	[Extension]
	// RVA: 0xC4E120 Offset: 0xC4CB20 VA: 0x180C4E120
	public static bool IsNaN(Vector2 v) { }

	[Extension]
	// RVA: 0xC4E150 Offset: 0xC4CB50 VA: 0x180C4E150
	public static bool IsNaN(Vector3 v) { }

	[Extension]
	// RVA: 0xC4DAD0 Offset: 0xC4C4D0 VA: 0x180C4DAD0
	public static float ClosestPointOnSegment(Vector3 p, Vector3 s0, Vector3 s1) { }

	[Extension]
	// RVA: 0xC4DA30 Offset: 0xC4C430 VA: 0x180C4DA30
	public static float ClosestPointOnSegment(Vector2 p, Vector2 s0, Vector2 s1) { }

	[Extension]
	// RVA: 0xC4E2A0 Offset: 0xC4CCA0 VA: 0x180C4E2A0
	public static Vector3 ProjectOntoPlane(Vector3 vector, Vector3 planeNormal) { }

	[Extension]
	// RVA: 0xC4EA30 Offset: 0xC4D430 VA: 0x180C4EA30
	public static Vector2 SquareNormalize(Vector2 v) { }

	// RVA: 0xC4DD40 Offset: 0xC4C740 VA: 0x180C4DD40
	public static int FindIntersection(in Vector2 p1, in Vector2 p2, in Vector2 q1, in Vector2 q2, out Vector2 intersection) { }

	[Extension]
	// RVA: 0xC4DD10 Offset: 0xC4C710 VA: 0x180C4DD10
	private static float Cross(Vector2 v1, Vector2 v2) { }

	[Extension]
	// RVA: 0xC4D890 Offset: 0xC4C290 VA: 0x180C4D890
	public static Vector2 Abs(Vector2 v) { }

	[Extension]
	// RVA: 0xC4D8C0 Offset: 0xC4C2C0 VA: 0x180C4D8C0
	public static Vector3 Abs(Vector3 v) { }

	[Extension]
	// RVA: 0xC4E240 Offset: 0xC4CC40 VA: 0x180C4E240
	public static bool IsUniform(Vector2 v) { }

	[Extension]
	// RVA: 0xC4E180 Offset: 0xC4CB80 VA: 0x180C4E180
	public static bool IsUniform(Vector3 v) { }

	[Extension]
	// RVA: 0xC4D900 Offset: 0xC4C300 VA: 0x180C4D900
	public static bool AlmostZero(Vector3 v) { }

	[Extension]
	// RVA: 0xC4DBC0 Offset: 0xC4C5C0 VA: 0x180C4DBC0
	internal static void ConservativeSetPositionAndRotation(Transform t, Vector3 pos, Quaternion rot) { }

	// RVA: 0xC4D940 Offset: 0xC4C340 VA: 0x180C4D940
	public static float Angle(Vector3 v1, Vector3 v2) { }

	// RVA: 0xC4E520 Offset: 0xC4CF20 VA: 0x180C4E520
	public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 up) { }

	// RVA: 0xC4E330 Offset: 0xC4CD30 VA: 0x180C4E330
	public static Quaternion SafeFromToRotation(Vector3 v1, Vector3 v2, Vector3 up) { }

	// RVA: 0xC4E720 Offset: 0xC4D120 VA: 0x180C4E720
	public static Vector3 SlerpWithReferenceUp(Vector3 vA, Vector3 vB, float t, Vector3 up) { }
}
