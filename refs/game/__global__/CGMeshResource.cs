public class CGMeshResource : DuplicateEditorMesh, IPoolable // TypeDefIndex: 10627
{
	// Fields
	public const MeshColliderCookingOptions EverMeshColliderCookingOptions = 30;
	private MeshRenderer mRenderer; // 0x38
	private Collider mCollider; // 0x40
	private static readonly HashSet<Mesh> UsedMeshes; // 0x0

	// Properties
	public MeshRenderer Renderer { get; }
	public Collider Collider { get; }

	// Methods

	// RVA: 0x4DBB50 Offset: 0x4DA550 VA: 0x1804DBB50
	public MeshRenderer get_Renderer() { }

	// RVA: 0x4DBAC0 Offset: 0x4DA4C0 VA: 0x1804DBAC0
	public Collider get_Collider() { }

	[UsedImplicitly]
	[Obsolete("No more used in Curvy. Will get removed. Copy it if you still need it")]
	// RVA: 0x4DAEF0 Offset: 0x4D98F0 VA: 0x1804DAEF0
	public Mesh Prepare() { }

	// RVA: 0x4DA980 Offset: 0x4D9380 VA: 0x1804DA980
	public bool ColliderMatches(CGColliderEnum type) { }

	// RVA: 0x4DAF40 Offset: 0x4D9940 VA: 0x1804DAF40
	public void RemoveCollider() { }

	// RVA: 0x4DAFD0 Offset: 0x4D99D0 VA: 0x1804DAFD0
	public bool UpdateCollider(CGColliderEnum mode, bool convex, bool isTrigger, PhysicMaterial material, MeshColliderCookingOptions meshCookingOptions = 30) { }

	// RVA: 0x4DADE0 Offset: 0x4D97E0 VA: 0x1804DADE0 Slot: 9
	public void OnBeforePush() { }

	// RVA: 0x4DACC0 Offset: 0x4D96C0 VA: 0x1804DACC0 Slot: 10
	public void OnAfterPop() { }

	// RVA: 0x4DAC10 Offset: 0x4D9610 VA: 0x1804DAC10
	private static Mesh GetNewMesh() { }

	// RVA: 0x4DAB40 Offset: 0x4D9540 VA: 0x1804DAB40
	private static Mesh GetNewMesh(Mesh oldMesh) { }

	[UsedImplicitly]
	// RVA: 0x4DA6C0 Offset: 0x4D90C0 VA: 0x1804DA6C0
	protected void Awake() { }

	[UsedImplicitly]
	// RVA: 0x4DAE50 Offset: 0x4D9850 VA: 0x1804DAE50
	public void OnDestroy() { }

	[Obsolete("Too slow, used only in sanity checks")]
	[UsedImplicitly]
	// RVA: 0x4DB850 Offset: 0x4DA250 VA: 0x1804DB850
	private static bool UsesSharedMesh(CGMeshResource meshResource) { }

	// RVA: 0x44B2F0 Offset: 0x449CF0 VA: 0x18044B2F0
	public void .ctor() { }

	// RVA: 0x4DBA30 Offset: 0x4DA430 VA: 0x1804DBA30
	private static void .cctor() { }
}
