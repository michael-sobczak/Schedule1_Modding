public static class V3Tools // TypeDefIndex: 14045
{
	// Methods

	// RVA: 0x1EAD4B0 Offset: 0x1EABEB0 VA: 0x181EAD4B0
	public static float GetYaw(Vector3 forward) { }

	// RVA: 0x1EAD300 Offset: 0x1EABD00 VA: 0x181EAD300
	public static float GetPitch(Vector3 forward) { }

	// RVA: 0x1EAD210 Offset: 0x1EABC10 VA: 0x181EAD210
	public static float GetBank(Vector3 forward, Vector3 up) { }

	// RVA: 0x1EAD400 Offset: 0x1EABE00 VA: 0x181EAD400
	public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward) { }

	// RVA: 0x1EAD350 Offset: 0x1EABD50 VA: 0x181EAD350
	public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward) { }

	// RVA: 0x1EAD080 Offset: 0x1EABA80 VA: 0x181EAD080
	public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up) { }

	// RVA: 0x1EAD6B0 Offset: 0x1EAC0B0 VA: 0x181EAD6B0
	public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight) { }

	// RVA: 0x1EADB00 Offset: 0x1EAC500 VA: 0x181EADB00
	public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight) { }

	// RVA: 0x1EACD70 Offset: 0x1EAB770 VA: 0x181EACD70
	public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight) { }

	// RVA: 0x1EACB90 Offset: 0x1EAB590 VA: 0x181EACB90
	public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight) { }

	// RVA: 0x1EACF40 Offset: 0x1EAB940 VA: 0x181EACF40
	public static Vector3 Flatten(Vector3 v, Vector3 normal) { }

	// RVA: 0x1EAC960 Offset: 0x1EAB360 VA: 0x181EAC960
	public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing) { }

	// RVA: 0x1EAC530 Offset: 0x1EAAF30 VA: 0x181EAC530
	public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed) { }

	// RVA: 0x1EAC730 Offset: 0x1EAB130 VA: 0x181EAC730
	public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue) { }

	// RVA: 0x1EAD780 Offset: 0x1EAC180 VA: 0x181EAD780
	public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint) { }

	// RVA: 0x1EAD910 Offset: 0x1EAC310 VA: 0x181EAD910
	public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal) { }

	// RVA: 0x1EADB90 Offset: 0x1EAC590 VA: 0x181EADB90
	public static Vector3 TransformPointUnscaled(Transform t, Vector3 point) { }

	// RVA: 0x1EAD4D0 Offset: 0x1EABED0 VA: 0x181EAD4D0
	public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point) { }

	// RVA: 0x1EAD5C0 Offset: 0x1EABFC0 VA: 0x181EAD5C0
	public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point) { }

	// RVA: 0x1EADC70 Offset: 0x1EAC670 VA: 0x181EADC70
	public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point) { }

	// RVA: 0x1EACB50 Offset: 0x1EAB550 VA: 0x181EACB50
	public static Vector3 Div(Vector3 v1, Vector3 v2) { }
}
