public class Physics // TypeDefIndex: 18465
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEvent; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEventCCD; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Physics.ContactEventDelegate ContactEvent; // 0x10
	private static readonly Collision s_ReusableCollision; // 0x18

	// Properties
	public static Vector3 gravity { get; set; }
	public static SimulationMode simulationMode { get; set; }
	public static bool invokeCollisionCallbacks { get; }
	[NativeProperty("DefaultPhysicsSceneHandle", True, 0, True)]
	public static PhysicsScene defaultPhysicsScene { get; }
	public static bool autoSyncTransforms { set; }
	public static bool reuseCollisionCallbacks { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2D368D0 Offset: 0x2D352D0 VA: 0x182D368D0
	private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	[ThreadSafe]
	// RVA: 0x2D3ADB0 Offset: 0x2D397B0 VA: 0x182D3ADB0
	public static Vector3 get_gravity() { }

	// RVA: 0x2D3AF30 Offset: 0x2D39930 VA: 0x182D3AF30
	public static void set_gravity(Vector3 value) { }

	// RVA: 0x2D3AE80 Offset: 0x2D39880 VA: 0x182D3AE80
	public static SimulationMode get_simulationMode() { }

	// RVA: 0x2D3AFA0 Offset: 0x2D399A0 VA: 0x182D3AFA0
	public static void set_simulationMode(SimulationMode value) { }

	// RVA: 0x2D3AE20 Offset: 0x2D39820 VA: 0x182D3AE20
	public static bool get_invokeCollisionCallbacks() { }

	// RVA: 0x2D3AD00 Offset: 0x2D39700 VA: 0x182D3AD00
	public static PhysicsScene get_defaultPhysicsScene() { }

	// RVA: 0x2D36210 Offset: 0x2D34C10 VA: 0x182D36210
	public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore) { }

	[ExcludeFromDocs]
	// RVA: 0x2D36270 Offset: 0x2D34C70 VA: 0x182D36270
	public static void IgnoreCollision(Collider collider1, Collider collider2) { }

	// RVA: 0x2D38C10 Offset: 0x2D37610 VA: 0x182D38C10
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x2D388A0 Offset: 0x2D372A0 VA: 0x182D388A0
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x2D39660 Offset: 0x2D38060 VA: 0x182D39660
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x2D39340 Offset: 0x2D37D40 VA: 0x182D39340
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	// RVA: 0x2D39260 Offset: 0x2D37C60 VA: 0x182D39260
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	// RVA: 0x2D38CE0 Offset: 0x2D376E0 VA: 0x182D38CE0
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x2D387D0 Offset: 0x2D371D0 VA: 0x182D387D0
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x2D38A40 Offset: 0x2D37440 VA: 0x182D38A40
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	// RVA: 0x2D39190 Offset: 0x2D37B90 VA: 0x182D39190
	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x2D38DB0 Offset: 0x2D377B0 VA: 0x182D38DB0
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x2D38F40 Offset: 0x2D37940 VA: 0x182D38F40
	public static bool Raycast(Ray ray, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x2D397F0 Offset: 0x2D381F0 VA: 0x182D397F0
	public static bool Raycast(Ray ray) { }

	// RVA: 0x2D39580 Offset: 0x2D37F80 VA: 0x182D39580
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x2D38B10 Offset: 0x2D37510 VA: 0x182D38B10
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x2D390D0 Offset: 0x2D37AD0 VA: 0x182D390D0
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x2D394C0 Offset: 0x2D37EC0 VA: 0x182D394C0
	public static bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	// RVA: 0x2D36660 Offset: 0x2D35060 VA: 0x182D36660
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x2D36780 Offset: 0x2D35180 VA: 0x182D36780
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x2D365D0 Offset: 0x2D34FD0 VA: 0x182D365D0
	public static bool Linecast(Vector3 start, Vector3 end) { }

	// RVA: 0x2D36400 Offset: 0x2D34E00 VA: 0x182D36400
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x2D36820 Offset: 0x2D35220 VA: 0x182D36820
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x2D36530 Offset: 0x2D34F30 VA: 0x182D36530
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo) { }

	// RVA: 0x2D35700 Offset: 0x2D34100 VA: 0x182D35700
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D3A870 Offset: 0x2D39270 VA: 0x182D3A870
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x2D3A580 Offset: 0x2D38F80 VA: 0x182D3A580
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x2D3A650 Offset: 0x2D39050 VA: 0x182D3A650
	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x2D3A740 Offset: 0x2D39140 VA: 0x182D3A740
	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask) { }

	// RVA: 0x2D3A9E0 Offset: 0x2D393E0 VA: 0x182D3A9E0
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x2D3AAB0 Offset: 0x2D394B0 VA: 0x182D3AAB0
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[NativeName("RaycastAll")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	// RVA: 0x2D36360 Offset: 0x2D34D60 VA: 0x182D36360
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D37730 Offset: 0x2D36130 VA: 0x182D37730
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x2D37680 Offset: 0x2D36080 VA: 0x182D37680
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x2D379A0 Offset: 0x2D363A0 VA: 0x182D379A0
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x2D37A40 Offset: 0x2D36440 VA: 0x182D37A40
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	// RVA: 0x2D378F0 Offset: 0x2D362F0 VA: 0x182D378F0
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCode]
	[ExcludeFromDocs]
	// RVA: 0x2D375E0 Offset: 0x2D35FE0 VA: 0x182D375E0
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x2D37540 Offset: 0x2D35F40 VA: 0x182D37540
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x2D37AE0 Offset: 0x2D364E0 VA: 0x182D37AE0
	public static RaycastHit[] RaycastAll(Ray ray) { }

	// RVA: 0x2D38320 Offset: 0x2D36D20 VA: 0x182D38320
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	// RVA: 0x2D37E70 Offset: 0x2D36870 VA: 0x182D37E70
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x2D37B70 Offset: 0x2D36570 VA: 0x182D37B70
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x2D37CF0 Offset: 0x2D366F0 VA: 0x182D37CF0
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	// RVA: 0x2D384B0 Offset: 0x2D36EB0 VA: 0x182D384B0
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x2D38190 Offset: 0x2D36B90 VA: 0x182D38190
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x2D38000 Offset: 0x2D36A00 VA: 0x182D38000
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x2D38640 Offset: 0x2D37040 VA: 0x182D38640
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	[NativeName("SphereCastAll")]
	// RVA: 0x2D37480 Offset: 0x2D35E80 VA: 0x182D37480
	private static RaycastHit[] Query_SphereCastAll(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D3A290 Offset: 0x2D38C90 VA: 0x182D3A290
	public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x2D3A110 Offset: 0x2D38B10 VA: 0x182D3A110
	public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask) { }

	// RVA: 0x2D3A1D0 Offset: 0x2D38BD0 VA: 0x182D3A1D0
	public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x2D3A000 Offset: 0x2D38A00 VA: 0x182D3A000
	public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask) { }

	[NativeName("OverlapSphere")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	// RVA: 0x2D37030 Offset: 0x2D35A30 VA: 0x182D37030
	private static Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D37160 Offset: 0x2D35B60 VA: 0x182D37160
	public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x2D370D0 Offset: 0x2D35AD0 VA: 0x182D370D0
	public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x2D37250 Offset: 0x2D35C50 VA: 0x182D37250
	public static Collider[] OverlapSphere(Vector3 position, float radius) { }

	[NativeName("Simulate")]
	// RVA: 0x2D39EA0 Offset: 0x2D388A0 VA: 0x182D39EA0
	internal static void Simulate_Internal(PhysicsScene physicsScene, float step) { }

	// RVA: 0x2D39F20 Offset: 0x2D38920 VA: 0x182D39F20
	public static void Simulate(float step) { }

	// RVA: 0x2D3ABD0 Offset: 0x2D395D0 VA: 0x182D3ABD0
	public static void SyncTransforms() { }

	// RVA: 0x2D3AEB0 Offset: 0x2D398B0 VA: 0x182D3AEB0
	public static void set_autoSyncTransforms(bool value) { }

	// RVA: 0x2D3AE50 Offset: 0x2D39850 VA: 0x182D3AE50
	public static bool get_reuseCollisionCallbacks() { }

	[NativeName("ComputePenetration")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	// RVA: 0x2D37340 Offset: 0x2D35D40 VA: 0x182D37340
	private static bool Query_ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance) { }

	// RVA: 0x2D35DD0 Offset: 0x2D347D0 VA: 0x182D35DD0
	public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance) { }

	// RVA: 0x2D36EF0 Offset: 0x2D358F0 VA: 0x182D36EF0
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[NativeName("SphereTest")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	// RVA: 0x2D35B30 Offset: 0x2D34530 VA: 0x182D35B30
	private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D35BD0 Offset: 0x2D345D0 VA: 0x182D35BD0
	public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x2D35CC0 Offset: 0x2D346C0 VA: 0x182D35CC0
	public static bool CheckSphere(Vector3 position, float radius, int layerMask) { }

	// RVA: 0x2D3A450 Offset: 0x2D38E50 VA: 0x182D3A450
	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	[NativeName("CapsuleTest")]
	// RVA: 0x2D35910 Offset: 0x2D34310 VA: 0x182D35910
	private static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D359B0 Offset: 0x2D343B0 VA: 0x182D359B0
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[NativeName("OverlapBox")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	// RVA: 0x2D36BE0 Offset: 0x2D355E0 VA: 0x182D36BE0
	private static Collider[] OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D36C80 Offset: 0x2D35680 VA: 0x182D36C80
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x2D36DA0 Offset: 0x2D357A0 VA: 0x182D36DA0
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) { }

	[StaticAccessor("GetPhysicsManager()")]
	[ThreadSafe]
	// RVA: 0x2D35620 Offset: 0x2D34020 VA: 0x182D35620
	public static void BakeMesh(int meshID, bool convex, MeshColliderCookingOptions cookingOptions) { }

	// RVA: 0x2D35680 Offset: 0x2D34080 VA: 0x182D35680
	public static void BakeMesh(int meshID, bool convex) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x2D35FA0 Offset: 0x2D349A0 VA: 0x182D35FA0
	internal static Collider GetColliderByInstanceID(int instanceID) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x2D35F60 Offset: 0x2D34960 VA: 0x182D35F60
	internal static Component GetBodyByInstanceID(int instanceID) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x2D39D60 Offset: 0x2D38760 VA: 0x182D39D60
	private static void SendOnCollisionEnter(Component component, Collision collision) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x2D39E00 Offset: 0x2D38800 VA: 0x182D39E00
	private static void SendOnCollisionStay(Component component, Collision collision) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x2D39DB0 Offset: 0x2D387B0 VA: 0x182D39DB0
	private static void SendOnCollisionExit(Component component, Collision collision) { }

	[RequiredByNativeCode]
	// RVA: 0x2D369D0 Offset: 0x2D353D0 VA: 0x182D369D0
	private static void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count) { }

	// RVA: 0x2D39980 Offset: 0x2D38380 VA: 0x182D39980
	private static void ReportContacts(NativeArray.ReadOnly<ContactPairHeader> array) { }

	// RVA: 0x2D35FE0 Offset: 0x2D349E0 VA: 0x182D35FE0
	private static Collision GetCollisionToReport(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	// RVA: 0x2D3AC00 Offset: 0x2D39600 VA: 0x182D3AC00
	private static void .cctor() { }

	// RVA: 0x2D3AD70 Offset: 0x2D39770 VA: 0x182D3AD70
	private static void get_gravity_Injected(out Vector3 ret) { }

	// RVA: 0x2D3AEF0 Offset: 0x2D398F0 VA: 0x182D3AEF0
	private static void set_gravity_Injected(ref Vector3 value) { }

	// RVA: 0x2D3ACC0 Offset: 0x2D396C0 VA: 0x182D3ACC0
	private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret) { }

	// RVA: 0x2D362F0 Offset: 0x2D34CF0 VA: 0x182D362F0
	private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D37410 Offset: 0x2D35E10 VA: 0x182D37410
	private static RaycastHit[] Query_SphereCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D36FC0 Offset: 0x2D359C0 VA: 0x182D36FC0
	private static Collider[] OverlapSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D39E50 Offset: 0x2D38850 VA: 0x182D39E50
	private static void Simulate_Internal_Injected(ref PhysicsScene physicsScene, float step) { }

	// RVA: 0x2D372D0 Offset: 0x2D35CD0 VA: 0x182D372D0
	private static bool Query_ComputePenetration_Injected(Collider colliderA, ref Vector3 positionA, ref Quaternion rotationA, Collider colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance) { }

	// RVA: 0x2D35AC0 Offset: 0x2D344C0 VA: 0x182D35AC0
	private static bool CheckSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D358A0 Offset: 0x2D342A0 VA: 0x182D358A0
	private static bool CheckCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 start, ref Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2D36B70 Offset: 0x2D35570 VA: 0x182D36B70
	private static Collider[] OverlapBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }
}
