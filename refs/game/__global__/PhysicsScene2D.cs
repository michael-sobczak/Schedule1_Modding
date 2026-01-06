public struct PhysicsScene2D : IEquatable<PhysicsScene2D> // TypeDefIndex: 18822
{
	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x2D31020 Offset: 0x2D2FA20 VA: 0x182D31020 Slot: 3
	public override string ToString() { }

	// RVA: 0x2CEA9E0 Offset: 0x2CE93E0 VA: 0x182CEA9E0
	public static bool op_Inequality(PhysicsScene2D lhs, PhysicsScene2D rhs) { }

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2D30030 Offset: 0x2D2EA30 VA: 0x182D30030 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2CC3DD0 Offset: 0x2CC27D0 VA: 0x182CC3DD0 Slot: 4
	public bool Equals(PhysicsScene2D other) { }

	// RVA: 0x2D30470 Offset: 0x2D2EE70 VA: 0x182D30470
	public bool IsValid() { }

	[StaticAccessor("GetPhysicsManager2D()", 1)]
	[NativeMethod("IsPhysicsSceneValid")]
	// RVA: 0x2D30430 Offset: 0x2D2EE30 VA: 0x182D30430
	private static bool IsValid_Internal(PhysicsScene2D physicsScene) { }

	// RVA: 0x2D30F40 Offset: 0x2D2F940 VA: 0x182D30F40
	public bool Simulate(float step) { }

	// RVA: 0x2D30590 Offset: 0x2D2EF90 VA: 0x182D30590
	public RaycastHit2D Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter) { }

	[NativeMethod("Linecast_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x2D30520 Offset: 0x2D2EF20 VA: 0x182D30520
	private static RaycastHit2D Linecast_Internal(PhysicsScene2D physicsScene, Vector2 start, Vector2 end, ContactFilter2D contactFilter) { }

	// RVA: 0x2D30D20 Offset: 0x2D2F720 VA: 0x182D30D20
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5) { }

	// RVA: 0x2D30E60 Offset: 0x2D2F860 VA: 0x182D30E60
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[NativeMethod("Raycast_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x2D30B60 Offset: 0x2D2F560 VA: 0x182D30B60
	private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	// RVA: 0x2D30BE0 Offset: 0x2D2F5E0 VA: 0x182D30BE0
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("RaycastArray_Binding")]
	// RVA: 0x2D30980 Offset: 0x2D2F380 VA: 0x182D30980
	private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x2D30C80 Offset: 0x2D2F680 VA: 0x182D30C80
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("RaycastList_Binding")]
	// RVA: 0x2D30A70 Offset: 0x2D2F470 VA: 0x182D30A70
	private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x2D2FF20 Offset: 0x2D2E920 VA: 0x182D2FF20
	public RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[NativeMethod("CircleCast_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x2D2FE90 Offset: 0x2D2E890 VA: 0x182D2FE90
	private static RaycastHit2D CircleCast_Internal(PhysicsScene2D physicsScene, Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	// RVA: 0x2D30280 Offset: 0x2D2EC80 VA: 0x182D30280
	public RaycastHit2D GetRayIntersection(Ray ray, float distance, int layerMask = -5) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("GetRayIntersection_Binding")]
	// RVA: 0x2D30200 Offset: 0x2D2EC00 VA: 0x182D30200
	private static RaycastHit2D GetRayIntersection_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	// RVA: 0x2D30360 Offset: 0x2D2ED60 VA: 0x182D30360
	public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, int layerMask = -5) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("GetRayIntersectionArray_Binding")]
	// RVA: 0x2D30120 Offset: 0x2D2EB20 VA: 0x182D30120
	private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	// RVA: 0x2D308A0 Offset: 0x2D2F2A0 VA: 0x182D308A0
	public int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, Collider2D[] results) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("OverlapPointArray_Binding")]
	// RVA: 0x2D30840 Offset: 0x2D2F240 VA: 0x182D30840
	private static int OverlapPointArray_Internal(PhysicsScene2D physicsScene, Vector2 point, ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x2D30740 Offset: 0x2D2F140 VA: 0x182D30740
	public int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, Collider2D[] results) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("OverlapCircleArray_Binding")]
	// RVA: 0x2D306D0 Offset: 0x2D2F0D0 VA: 0x182D306D0
	private static int OverlapCircleArray_Internal(PhysicsScene2D physicsScene, Vector2 point, float radius, ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x2D303F0 Offset: 0x2D2EDF0 VA: 0x182D303F0
	private static bool IsValid_Internal_Injected(ref PhysicsScene2D physicsScene) { }

	// RVA: 0x2D304B0 Offset: 0x2D2EEB0 VA: 0x182D304B0
	private static void Linecast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 start, ref Vector2 end, ref ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	// RVA: 0x2D30AF0 Offset: 0x2D2F4F0 VA: 0x182D30AF0
	private static void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	// RVA: 0x2D30910 Offset: 0x2D2F310 VA: 0x182D30910
	private static int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x2D30A00 Offset: 0x2D2F400 VA: 0x182D30A00
	private static int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x2D2FE20 Offset: 0x2D2E820 VA: 0x182D2FE20
	private static void CircleCast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, float radius, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	// RVA: 0x2D30190 Offset: 0x2D2EB90 VA: 0x182D30190
	private static void GetRayIntersection_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, out RaycastHit2D ret) { }

	// RVA: 0x2D300B0 Offset: 0x2D2EAB0 VA: 0x182D300B0
	private static int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	// RVA: 0x2D307D0 Offset: 0x2D2F1D0 VA: 0x182D307D0
	private static int OverlapPointArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x2D30660 Offset: 0x2D2F060 VA: 0x182D30660
	private static int OverlapCircleArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, float radius, ref ContactFilter2D contactFilter, Collider2D[] results) { }
}
