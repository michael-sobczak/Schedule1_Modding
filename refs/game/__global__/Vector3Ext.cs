public static class Vector3Ext // TypeDefIndex: 10469
{
	// Methods

	[Extension]
	// RVA: 0x4A08F0 Offset: 0x49F2F0 VA: 0x1804A08F0
	public static float AngleSigned(Vector3 a, Vector3 b, Vector3 normal) { }

	[Extension]
	// RVA: 0x4A0B80 Offset: 0x49F580 VA: 0x1804A0B80
	public static Vector3 RotateAround(Vector3 point, Vector3 origin, Quaternion rotation) { }

	[Extension]
	// RVA: 0x4A0C40 Offset: 0x49F640 VA: 0x1804A0C40
	public static Vector2 ToVector2(Vector3 v) { }

	[Extension]
	// RVA: 0x4A0A10 Offset: 0x49F410 VA: 0x1804A0A10
	public static bool Approximately(Vector3 v1, Vector3 v2) { }

	[Extension]
	// RVA: 0x4A0AC0 Offset: 0x49F4C0 VA: 0x1804A0AC0
	public static bool NotApproximately(Vector3 v1, Vector3 v2) { }
}
