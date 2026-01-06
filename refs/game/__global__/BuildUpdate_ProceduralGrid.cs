public class BuildUpdate_ProceduralGrid : BuildUpdate_Base // TypeDefIndex: 2117
{
	// Fields
	public GameObject GhostModel; // 0x20
	public ProceduralGridItem ItemClass; // 0x28
	public ItemInstance ItemInstance; // 0x30
	[Header("Settings")]
	public float detectionRange; // 0x38
	public LayerMask detectionMask; // 0x3C
	public float rotation_Smoothing; // 0x40
	protected float currentRotation; // 0x44
	protected bool validPosition; // 0x48
	protected Material currentGhostMaterial; // 0x50
	protected BuildUpdate_ProceduralGrid.Intersection bestIntersection; // 0x58

	// Methods

	// RVA: 0x7FDC30 Offset: 0x7FC630 VA: 0x1807FDC30 Slot: 5
	protected virtual void Update() { }

	// RVA: 0x7FCDB0 Offset: 0x7FB7B0 VA: 0x1807FCDB0 Slot: 6
	protected virtual void LateUpdate() { }

	// RVA: 0x7FC940 Offset: 0x7FB340 VA: 0x1807FC940
	protected void CheckRotation() { }

	// RVA: 0x7FBC30 Offset: 0x7FA630 VA: 0x1807FBC30
	protected void ApplyRotation() { }

	// RVA: 0x7FC0A0 Offset: 0x7FAAA0 VA: 0x1807FC0A0 Slot: 7
	protected virtual void CheckGridIntersections() { }

	// RVA: 0x7FDAA0 Offset: 0x7FC4A0 VA: 0x1807FDAA0
	protected void UpdateMaterials() { }

	// RVA: 0x7FCB90 Offset: 0x7FB590 VA: 0x1807FCB90
	private bool IsMatchValid(FootprintTile footprintTile, ProceduralTile matchedTile) { }

	// RVA: 0x7FD2F0 Offset: 0x7FBCF0 VA: 0x1807FD2F0
	protected void Place() { }

	// RVA: 0x7FCA30 Offset: 0x7FB430 VA: 0x1807FCA30
	private ProceduralTile GetNearbyProcTile() { }

	// RVA: 0x7FDD70 Offset: 0x7FC770 VA: 0x1807FDD70
	public void .ctor() { }
}
