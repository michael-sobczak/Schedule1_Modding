public struct PhysicsScene : IEquatable<PhysicsScene> // TypeDefIndex: 18483
{
	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x2D35540 Offset: 0x2D33F40 VA: 0x182D35540 Slot: 3
	public override string ToString() { }

	// RVA: 0x2CC3F40 Offset: 0x2CC2940 VA: 0x182CC3F40
	public static bool op_Equality(PhysicsScene lhs, PhysicsScene rhs) { }

	// RVA: 0x2CEA9E0 Offset: 0x2CE93E0 VA: 0x182CEA9E0
	public static bool op_Inequality(PhysicsScene lhs, PhysicsScene rhs) { }

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2D342A0 Offset: 0x2D32CA0 VA: 0x182D342A0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2CC3DD0 Offset: 0x2CC27D0 VA: 0x182CC3DD0 Slot: 4
	public bool Equals(PhysicsScene other) { }

	// RVA: 0x2D349D0 Offset: 0x2D333D0 VA: 0x182D349D0
	public bool IsValid() { }

	[NativeMethod("IsPhysicsSceneValid")]
	[StaticAccessor("GetPhysicsManager()", 0)]
	// RVA: 0x2D34990 Offset: 0x2D33390 VA: 0x182D34990
	private static bool IsValid_Internal(PhysicsScene physicsScene) { }

	// RVA: 0x2D35180 Offset: 0x2D33B80 VA: 0x182D35180
	public void Simulate(float step) { }

	// RVA: 0x2D34EC0 Offset: 0x2D338C0 VA: 0x182D34EC0
	public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	[NativeName("RaycastTest")]
	// RVA: 0x2D345D0 Offset: 0x2D32FD0 VA: 0x182D345D0
	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D35010 Offset: 0x2D33A10 VA: 0x182D35010
	public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeName("Raycast")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	// RVA: 0x2D346B0 Offset: 0x2D330B0 VA: 0x182D346B0
	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D34D80 Offset: 0x2D33780 VA: 0x182D34D80
	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	[NativeName("RaycastNonAlloc")]
	// RVA: 0x2D344F0 Offset: 0x2D32EF0 VA: 0x182D344F0
	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	[NativeName("CapsuleCast")]
	// RVA: 0x2D34BE0 Offset: 0x2D335E0 VA: 0x182D34BE0
	private static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D34320 Offset: 0x2D32D20 VA: 0x182D34320
	private static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D34140 Offset: 0x2D32B40 VA: 0x182D34140
	public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	[NativeName("SphereCast")]
	// RVA: 0x2D34CF0 Offset: 0x2D336F0 VA: 0x182D34CF0
	private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D34820 Offset: 0x2D33220 VA: 0x182D34820
	private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D35400 Offset: 0x2D33E00 VA: 0x182D35400
	public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	[NativeName("SphereCastNonAlloc")]
	// RVA: 0x2D34790 Offset: 0x2D33190 VA: 0x182D34790
	private static int Internal_SphereCastNonAlloc(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D35310 Offset: 0x2D33D10 VA: 0x182D35310
	public int SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeName("OverlapSphereNonAlloc")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	// RVA: 0x2D34A80 Offset: 0x2D33480 VA: 0x182D34A80
	private static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D34AF0 Offset: 0x2D334F0 VA: 0x182D34AF0
	public int OverlapSphere(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D34950 Offset: 0x2D33350 VA: 0x182D34950
	private static bool IsValid_Internal_Injected(ref PhysicsScene physicsScene) { }

	// RVA: 0x2D34560 Offset: 0x2D32F60 VA: 0x182D34560
	private static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D34640 Offset: 0x2D33040 VA: 0x182D34640
	private static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D34480 Offset: 0x2D32E80 VA: 0x182D34480
	private static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D34B70 Offset: 0x2D33570 VA: 0x182D34B70
	private static bool Query_CapsuleCast_Injected(ref PhysicsScene physicsScene, ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D34C80 Offset: 0x2D33680 VA: 0x182D34C80
	private static bool Query_SphereCast_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D34720 Offset: 0x2D33120 VA: 0x182D34720
	private static int Internal_SphereCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D34A10 Offset: 0x2D33410 VA: 0x182D34A10
	private static int OverlapSphereNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }
}
