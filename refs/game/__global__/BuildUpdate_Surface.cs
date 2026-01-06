public class BuildUpdate_Surface : BuildUpdate_Base // TypeDefIndex: 2118
{
	// Fields
	public GameObject GhostModel; // 0x20
	public SurfaceItem BuildableItemClass; // 0x28
	public ItemInstance ItemInstance; // 0x30
	public float CurrentRotation; // 0x38
	[Header("Settings")]
	public LayerMask DetectionMask; // 0x3C
	protected bool validPosition; // 0x40
	protected Material currentGhostMaterial; // 0x48
	protected Surface hoveredValidSurface; // 0x50

	// Properties
	private float detectionRange { get; }

	// Methods

	// RVA: 0x7FF9C0 Offset: 0x7FE3C0 VA: 0x1807FF9C0
	private float get_detectionRange() { }

	// RVA: 0x493100 Offset: 0x491B00 VA: 0x180493100 Slot: 5
	protected virtual void Start() { }

	// RVA: 0x7FF830 Offset: 0x7FE230 VA: 0x1807FF830 Slot: 6
	protected virtual void Update() { }

	// RVA: 0x7FE000 Offset: 0x7FCA00 VA: 0x1807FE000 Slot: 7
	protected virtual void LateUpdate() { }

	// RVA: 0x7FEE60 Offset: 0x7FD860 VA: 0x1807FEE60
	protected void PositionObjectInFrontOfPlayer(float dist, bool sanitizeForward) { }

	// RVA: 0x7FDED0 Offset: 0x7FC8D0 VA: 0x1807FDED0
	private bool IsSurfaceValidForItem(Surface surface, Collider hitCollider, Vector3 hitPoint) { }

	// RVA: 0x7FDD90 Offset: 0x7FC790 VA: 0x1807FDD90
	protected void CheckRotation() { }

	// RVA: 0x7FF6A0 Offset: 0x7FE0A0 VA: 0x1807FF6A0
	protected void UpdateMaterials() { }

	// RVA: 0x7FEAD0 Offset: 0x7FD4D0 VA: 0x1807FEAD0 Slot: 8
	protected virtual void Place() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
