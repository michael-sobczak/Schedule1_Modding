public class FunctionalJar : FunctionalPackaging // TypeDefIndex: 2352
{
	// Fields
	[CompilerGenerated]
	private CursorManager.ECursorType <HoveredCursor>k__BackingField; // 0x138
	[Header("References")]
	public Draggable Lid; // 0x140
	public Transform LidStartPoint; // 0x148
	public Collider LidSensor; // 0x150
	public Collider LidCollider; // 0x158
	public GameObject FullyPackedBlocker; // 0x160
	private GameObject LidObject; // 0x168
	private Vector3 lidPosition; // 0x170

	// Properties
	public override CursorManager.ECursorType HoveredCursor { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x858810 Offset: 0x857210 VA: 0x180858810 Slot: 4
	public override CursorManager.ECursorType get_HoveredCursor() { }

	[CompilerGenerated]
	// RVA: 0x858820 Offset: 0x857220 VA: 0x180858820 Slot: 5
	protected override void set_HoveredCursor(CursorManager.ECursorType value) { }

	// RVA: 0x858220 Offset: 0x856C20 VA: 0x180858220 Slot: 14
	public override void Initialize(PackagingStation _station, Transform alignment, bool align = False) { }

	// RVA: 0x8580B0 Offset: 0x856AB0 VA: 0x1808580B0 Slot: 15
	public override void Destroy() { }

	// RVA: 0x858160 Offset: 0x856B60 VA: 0x180858160 Slot: 19
	protected override void EnableSealing() { }

	// RVA: 0x858500 Offset: 0x856F00 VA: 0x180858500 Slot: 12
	protected override void LateUpdate() { }

	// RVA: 0x858510 Offset: 0x856F10 VA: 0x180858510 Slot: 18
	protected override void OnTriggerStay(Collider other) { }

	// RVA: 0x858600 Offset: 0x857000 VA: 0x180858600 Slot: 20
	public override void Seal() { }

	// RVA: 0x8581E0 Offset: 0x856BE0 VA: 0x1808581E0 Slot: 17
	protected override void FullyPacked() { }

	// RVA: 0x8587A0 Offset: 0x8571A0 VA: 0x1808587A0
	public void .ctor() { }
}
