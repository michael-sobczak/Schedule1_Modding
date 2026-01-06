public static class UnityQuaternionExtensions // TypeDefIndex: 16268
{
	// Methods

	// RVA: 0xC4D030 Offset: 0xC4BA30 VA: 0x180C4D030
	public static Quaternion SlerpWithReferenceUp(Quaternion qA, Quaternion qB, float t, Vector3 up) { }

	[Extension]
	// RVA: 0xC4CEB0 Offset: 0xC4B8B0 VA: 0x180C4CEB0
	public static Quaternion Normalized(Quaternion q) { }

	[Extension]
	// RVA: 0xC4C950 Offset: 0xC4B350 VA: 0x180C4C950
	public static Vector2 GetCameraRotationToTarget(Quaternion orient, Vector3 lookAtDir, Vector3 worldUp) { }

	[Extension]
	// RVA: 0xC4C630 Offset: 0xC4B030 VA: 0x180C4C630
	public static Quaternion ApplyCameraRotation(Quaternion orient, Vector2 rot, Vector3 worldUp) { }
}
