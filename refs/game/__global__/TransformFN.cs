public static class TransformFN // TypeDefIndex: 12496
{
	// Methods

	[Extension]
	// RVA: 0xD1CB10 Offset: 0xD1B510 VA: 0x180D1CB10
	public static TransformProperties GetWorldProperties(Transform t) { }

	[Extension]
	// RVA: 0xD1CFA0 Offset: 0xD1B9A0 VA: 0x180D1CFA0
	public static void SetWorldProperties(TransformPropertiesCls tp, Transform t) { }

	[Extension]
	// RVA: 0xD1CCE0 Offset: 0xD1B6E0 VA: 0x180D1CCE0
	public static void SetTransformOffsets(Transform t, Transform target, ref Vector3 pos, ref Quaternion rot) { }

	[Extension]
	// RVA: 0xD1C710 Offset: 0xD1B110 VA: 0x180D1C710
	public static TransformProperties GetTransformOffsets(Transform t, Transform target) { }

	[Extension]
	// RVA: 0xD1CBF0 Offset: 0xD1B5F0 VA: 0x180D1CBF0
	public static void SetLocalPositionAndRotation(Transform t, Vector3 pos, Quaternion rot) { }

	[Extension]
	// RVA: 0xD1CC50 Offset: 0xD1B650 VA: 0x180D1CC50
	public static void SetLocalPositionRotationAndScale(Transform t, Vector3 pos, Quaternion rot, Vector3 scale) { }
}
