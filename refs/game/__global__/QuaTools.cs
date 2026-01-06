public static class QuaTools // TypeDefIndex: 14040
{
	// Methods

	// RVA: 0x1EAA6E0 Offset: 0x1EA90E0 VA: 0x181EAA6E0
	public static float GetYaw(Quaternion space, Vector3 forward) { }

	// RVA: 0x1EAA660 Offset: 0x1EA9060 VA: 0x181EAA660
	public static float GetPitch(Quaternion space, Vector3 forward) { }

	// RVA: 0x1EAA3B0 Offset: 0x1EA8DB0 VA: 0x181EAA3B0
	public static float GetBank(Quaternion space, Vector3 forward, Vector3 up) { }

	// RVA: 0x1EAA750 Offset: 0x1EA9150 VA: 0x181EAA750
	public static float GetYaw(Quaternion space, Quaternion rotation) { }

	// RVA: 0x1EAA580 Offset: 0x1EA8F80 VA: 0x181EAA580
	public static float GetPitch(Quaternion space, Quaternion rotation) { }

	// RVA: 0x1EAA150 Offset: 0x1EA8B50 VA: 0x181EAA150
	public static float GetBank(Quaternion space, Quaternion rotation) { }

	// RVA: 0x1EAA830 Offset: 0x1EA9230 VA: 0x181EAA830
	public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight) { }

	// RVA: 0x1EAB330 Offset: 0x1EA9D30 VA: 0x181EAB330
	public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight) { }

	// RVA: 0x1EAA8A0 Offset: 0x1EA92A0 VA: 0x181EAA8A0
	public static Quaternion LinearBlend(Quaternion q, float weight) { }

	// RVA: 0x1EAB3A0 Offset: 0x1EA9DA0 VA: 0x181EAB3A0
	public static Quaternion SphericalBlend(Quaternion q, float weight) { }

	// RVA: 0x1EA9B10 Offset: 0x1EA8510 VA: 0x181EA9B10
	public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis) { }

	// RVA: 0x1EAB180 Offset: 0x1EA9B80 VA: 0x181EAB180
	public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation) { }

	// RVA: 0x1EA9C70 Offset: 0x1EA8670 VA: 0x181EA9C70
	public static Quaternion FromToRotation(Quaternion from, Quaternion to) { }

	// RVA: 0x1EA9EA0 Offset: 0x1EA88A0 VA: 0x181EA9EA0
	public static Vector3 GetAxis(Vector3 v) { }

	// RVA: 0x1EA9880 Offset: 0x1EA8280 VA: 0x181EA9880
	public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing) { }

	// RVA: 0x1EA9720 Offset: 0x1EA8120 VA: 0x181EA9720
	public static float ClampAngle(float angle, float clampWeight, int clampSmoothing) { }

	// RVA: 0x1EAA980 Offset: 0x1EA9380 VA: 0x181EAA980
	public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetAxis1, Vector3 targetAxis2, Vector3 axis1, Vector3 axis2) { }

	// RVA: 0x1EAB4D0 Offset: 0x1EA9ED0 VA: 0x181EAB4D0
	public static Vector3 ToBiPolar(Vector3 euler) { }

	// RVA: 0x1EAB480 Offset: 0x1EA9E80 VA: 0x181EAB480
	public static float ToBiPolar(float angle) { }

	// RVA: 0x1EAAC80 Offset: 0x1EA9680 VA: 0x181EAAC80
	public static Quaternion MirrorYZ(Quaternion r, Quaternion space) { }

	// RVA: 0x1EAB030 Offset: 0x1EA9A30 VA: 0x181EAB030
	public static Quaternion MirrorYZ(Quaternion r) { }
}
