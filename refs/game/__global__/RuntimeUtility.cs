public static class RuntimeUtility // TypeDefIndex: 16180
{
	// Fields
	private static RaycastHit[] s_HitBuffer; // 0x0
	private static int[] s_PenetrationIndexBuffer; // 0x8
	private static SphereCollider s_ScratchCollider; // 0x10
	private static GameObject s_ScratchColliderGameObject; // 0x18

	// Methods

	// RVA: 0xC24990 Offset: 0xC23390 VA: 0x180C24990
	public static void DestroyObject(Object obj) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public static bool IsPrefab(GameObject gameObject) { }

	// RVA: 0xC25160 Offset: 0xC23B60 VA: 0x180C25160
	public static bool RaycastIgnoreTag(Ray ray, out RaycastHit hitInfo, float rayLength, int layerMask, in string ignoreTag) { }

	// RVA: 0xC25510 Offset: 0xC23F10 VA: 0x180C25510
	public static bool SphereCastIgnoreTag(Vector3 rayStart, float radius, Vector3 dir, out RaycastHit hitInfo, float rayLength, int layerMask, in string ignoreTag) { }

	// RVA: 0xC24BC0 Offset: 0xC235C0 VA: 0x180C24BC0
	internal static SphereCollider GetScratchCollider() { }

	// RVA: 0xC24A10 Offset: 0xC23410 VA: 0x180C24A10
	internal static void DestroyScratchCollider() { }

	// RVA: 0xC24E90 Offset: 0xC23890 VA: 0x180C24E90
	public static AnimationCurve NormalizeCurve(AnimationCurve curve, bool normalizeX, bool normalizeY) { }

	// RVA: 0xC25F90 Offset: 0xC24990 VA: 0x180C25F90
	private static void .cctor() { }
}
