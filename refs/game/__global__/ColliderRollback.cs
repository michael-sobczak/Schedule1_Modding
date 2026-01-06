public class ColliderRollback : NetworkBehaviour // TypeDefIndex: 12652
{
	// Fields
	[Tooltip("How to configure the bounding box check.")]
	[SerializeField]
	private ColliderRollback.BoundingBoxType _boundingBox; // 0x118
	[Tooltip("Physics type to generate a bounding box for.")]
	[SerializeField]
	private RollbackPhysicsType _physicsType; // 0x11C
	[Tooltip("Size for the bounding box.. This is only used when BoundingBox is set to Manual.")]
	[SerializeField]
	private Vector3 _boundingBoxSize; // 0x120
	[Tooltip("Objects holding colliders which can rollback.")]
	[SerializeField]
	private GameObject[] _colliderParents; // 0x130
	private bool NetworkInitialize___EarlyFishNet.Component.ColliderRollback.ColliderRollbackFishNet.Runtime.dll_Excuted; // 0x138
	private bool NetworkInitialize__LateFishNet.Component.ColliderRollback.ColliderRollbackFishNet.Runtime.dll_Excuted; // 0x139

	// Methods

	// RVA: 0xD26A20 Offset: 0xD25420 VA: 0x180D26A20
	public void .ctor() { }

	// RVA: 0xCE95C0 Offset: 0xCE7FC0 VA: 0x180CE95C0 Slot: 19
	public override void NetworkInitialize___Early() { }

	// RVA: 0x64BFE0 Offset: 0x64A9E0 VA: 0x18064BFE0 Slot: 20
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 21
	public override void Awake() { }
}
