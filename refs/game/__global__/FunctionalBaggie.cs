public class FunctionalBaggie : FunctionalPackaging // TypeDefIndex: 2351
{
	// Fields
	public SkinnedMeshRenderer[] BagMeshes; // 0x138
	public GameObject FunnelCollidersContainer; // 0x140
	public GameObject FullyPackedBlocker; // 0x148
	public Collider DynamicCollider; // 0x150
	[CompilerGenerated]
	private CursorManager.ECursorType <HoveredCursor>k__BackingField; // 0x158
	private float ClosedDelta; // 0x15C

	// Properties
	public override CursorManager.ECursorType HoveredCursor { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x858090 Offset: 0x856A90 VA: 0x180858090 Slot: 4
	public override CursorManager.ECursorType get_HoveredCursor() { }

	[CompilerGenerated]
	// RVA: 0x8580A0 Offset: 0x856AA0 VA: 0x1808580A0 Slot: 5
	protected override void set_HoveredCursor(CursorManager.ECursorType value) { }

	// RVA: 0x857ED0 Offset: 0x8568D0 VA: 0x180857ED0
	public void SetClosed(float closedDelta) { }

	// RVA: 0x857F70 Offset: 0x856970 VA: 0x180857F70 Slot: 6
	public override void StartClick(RaycastHit hit) { }

	// RVA: 0x857E00 Offset: 0x856800 VA: 0x180857E00 Slot: 20
	public override void Seal() { }

	// RVA: 0x857DC0 Offset: 0x8567C0 VA: 0x180857DC0 Slot: 17
	protected override void FullyPacked() { }

	// RVA: 0x858070 Offset: 0x856A70 VA: 0x180858070
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(FunctionalBaggie.<<Seal>g__Routine|11_0>d))]
	// RVA: 0x858000 Offset: 0x856A00 VA: 0x180858000
	private IEnumerator <Seal>g__Routine|11_0() { }
}
