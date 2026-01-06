public class Physics2D // TypeDefIndex: 18824
{
	// Fields
	private static List<Rigidbody2D> m_LastDisabledRigidbody2D; // 0x0

	// Properties
	public static PhysicsScene2D defaultPhysicsScene { get; }
	[StaticAccessor("GetPhysics2DSettings()")]
	public static bool queriesHitTriggers { get; }
	[StaticAccessor("GetPhysics2DSettings()")]
	public static SimulationMode2D simulationMode { set; }

	// Methods

	// RVA: 0x1102840 Offset: 0x1101240 VA: 0x181102840
	public static PhysicsScene2D get_defaultPhysicsScene() { }

	// RVA: 0x2D2FDB0 Offset: 0x2D2E7B0 VA: 0x182D2FDB0
	public static bool get_queriesHitTriggers() { }

	// RVA: 0x2D2FDE0 Offset: 0x2D2E7E0 VA: 0x182D2FDE0
	public static void set_simulationMode(SimulationMode2D value) { }

	// RVA: 0x2D2FC90 Offset: 0x2D2E690 VA: 0x182D2FC90
	public static bool Simulate(float step) { }

	[NativeMethod("Simulate_Binding")]
	// RVA: 0x2D2FC10 Offset: 0x2D2E610 VA: 0x182D2FC10
	internal static bool Simulate_Internal(PhysicsScene2D physicsScene, float step) { }

	// RVA: 0x2D2FCF0 Offset: 0x2D2E6F0 VA: 0x182D2FCF0
	public static void SyncTransforms() { }

	[ExcludeFromDocs]
	// RVA: 0x2D2EC20 Offset: 0x2D2D620 VA: 0x182D2EC20
	public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x2D2FA60 Offset: 0x2D2E460 VA: 0x182D2FA60
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	[ExcludeFromDocs]
	// RVA: 0x2D2F6E0 Offset: 0x2D2E0E0 VA: 0x182D2F6E0
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) { }

	[RequiredByNativeCode]
	[ExcludeFromDocs]
	// RVA: 0x2D2F450 Offset: 0x2D2DE50 VA: 0x182D2F450
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x2D2F8C0 Offset: 0x2D2E2C0 VA: 0x182D2F8C0
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) { }

	// RVA: 0x2D2F1B0 Offset: 0x2D2DBB0 VA: 0x182D2F1B0
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) { }

	[ExcludeFromDocs]
	// RVA: 0x2D2F350 Offset: 0x2D2DD50 VA: 0x182D2F350
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x2D2F5E0 Offset: 0x2D2DFE0 VA: 0x182D2F5E0
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	// RVA: 0x2D2F7C0 Offset: 0x2D2E1C0 VA: 0x182D2F7C0
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = ∞) { }

	[ExcludeFromDocs]
	// RVA: 0x2D2F050 Offset: 0x2D2DA50 VA: 0x182D2F050
	public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	[NativeMethod("RaycastAll_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x2D2EFB0 Offset: 0x2D2D9B0 VA: 0x182D2EFB0
	private static RaycastHit2D[] RaycastAll_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[ExcludeFromDocs]
	// RVA: 0x2D2E2B0 Offset: 0x2D2CCB0 VA: 0x182D2E2B0
	public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask) { }

	// RVA: 0x2D2EAE0 Offset: 0x2D2D4E0 VA: 0x182D2EAE0
	public static RaycastHit2D GetRayIntersection(Ray ray, float distance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x2D2E740 Offset: 0x2D2D140 VA: 0x182D2E740
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	[ExcludeFromDocs]
	// RVA: 0x2D2E650 Offset: 0x2D2D050 VA: 0x182D2E650
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) { }

	[RequiredByNativeCode]
	// RVA: 0x2D2E560 Offset: 0x2D2CF60 VA: 0x182D2E560
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("GetRayIntersectionAll_Binding")]
	// RVA: 0x2D2E4C0 Offset: 0x2D2CEC0 VA: 0x182D2E4C0
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x2D2EA00 Offset: 0x2D2D400 VA: 0x182D2EA00
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	[ExcludeFromDocs]
	// RVA: 0x2D2E820 Offset: 0x2D2D220 VA: 0x182D2E820
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) { }

	[RequiredByNativeCode]
	// RVA: 0x2D2E910 Offset: 0x2D2D310 VA: 0x182D2E910
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask) { }

	// RVA: 0x2D2EE80 Offset: 0x2D2D880 VA: 0x182D2EE80
	public static int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x2D2EDA0 Offset: 0x2D2D7A0 VA: 0x182D2EDA0
	public static int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x2D2FD20 Offset: 0x2D2E720 VA: 0x182D2FD20
	private static void .cctor() { }

	// RVA: 0x2D2FBC0 Offset: 0x2D2E5C0 VA: 0x182D2FBC0
	private static bool Simulate_Internal_Injected(ref PhysicsScene2D physicsScene, float step) { }

	// RVA: 0x2D2EF40 Offset: 0x2D2D940 VA: 0x182D2EF40
	private static RaycastHit2D[] RaycastAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter) { }

	// RVA: 0x2D2E450 Offset: 0x2D2CE50 VA: 0x182D2E450
	private static RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask) { }
}
