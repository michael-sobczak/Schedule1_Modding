public static class Transforms // TypeDefIndex: 18180
{
	// Methods

	[Extension]
	// RVA: 0xDAA850 Offset: 0xDA9250 VA: 0x180DAA850
	public static Vector3 GetOnScreenPosition(RectTransform rectTransform, Vector3 desiredPosition, Vector2 padding) { }

	[Extension]
	// RVA: 0xDAAAA0 Offset: 0xDA94A0 VA: 0x180DAAAA0
	public static void SetParentAndKeepTransform(Transform src, Transform parent) { }

	[Extension]
	// RVA: 0xDAA5E0 Offset: 0xDA8FE0 VA: 0x180DAA5E0
	public static void DestroyChildren(Transform t, bool destroyImmediately = False) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static void DestroyChildren<T>(Transform t, bool destroyImmediately = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF61A20 Offset: 0xF60420 VA: 0x180F61A20
	|-Transforms.DestroyChildren<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void GetComponentsInChildren<T>(Transform parent, List<T> results, bool includeParent = True, bool includeInactive = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF61B30 Offset: 0xF60530 VA: 0x180F61B30
	|-Transforms.GetComponentsInChildren<object>
	*/

	[Extension]
	// RVA: 0xDAA9C0 Offset: 0xDA93C0 VA: 0x180DAA9C0
	public static Vector3 GetPosition(Transform t, bool localSpace) { }

	[Extension]
	// RVA: 0xDAAA10 Offset: 0xDA9410 VA: 0x180DAAA10
	public static Quaternion GetRotation(Transform t, bool localSpace) { }

	[Extension]
	// RVA: 0xDAAA60 Offset: 0xDA9460 VA: 0x180DAAA60
	public static Vector3 GetScale(Transform t) { }

	[Extension]
	// RVA: 0xDAABA0 Offset: 0xDA95A0 VA: 0x180DAABA0
	public static void SetPosition(Transform t, bool localSpace, Vector3 pos) { }

	[Extension]
	// RVA: 0xDAABF0 Offset: 0xDA95F0 VA: 0x180DAABF0
	public static void SetRotation(Transform t, bool localSpace, Quaternion rot) { }

	[Extension]
	// RVA: 0xDAAC30 Offset: 0xDA9630 VA: 0x180DAAC30
	public static void SetScale(Transform t, Vector3 scale) { }
}
