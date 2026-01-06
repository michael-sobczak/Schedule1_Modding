public class FunctionalProduct : Draggable // TypeDefIndex: 2458
{
	// Fields
	public bool ClampZ; // 0xC0
	[Header("References")]
	public Transform AlignmentPoint; // 0xC8
	public ProductVisualsSetter Visuals; // 0xD0
	private Vector3 startLocalPos; // 0xD8
	private float lowestMaxZ; // 0xE4
	[CompilerGenerated]
	private SmoothedVelocityCalculator <VelocityCalculator>k__BackingField; // 0xE8

	// Properties
	public SmoothedVelocityCalculator VelocityCalculator { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0
	public SmoothedVelocityCalculator get_VelocityCalculator() { }

	[CompilerGenerated]
	// RVA: 0x4E8E60 Offset: 0x4E7860 VA: 0x1804E8E60
	private void set_VelocityCalculator(SmoothedVelocityCalculator value) { }

	// RVA: 0x88E660 Offset: 0x88D060 VA: 0x18088E660 Slot: 14
	public virtual void Initialize(PackagingStation station, ItemInstance item, Transform alignment, bool align = True) { }

	// RVA: 0x88E4F0 Offset: 0x88CEF0 VA: 0x18088E4F0 Slot: 15
	public virtual void Initialize(ItemInstance item) { }

	// RVA: 0x88E420 Offset: 0x88CE20 VA: 0x18088E420 Slot: 16
	public virtual void InitializeVisuals(ItemInstance item) { }

	// RVA: 0x88DEA0 Offset: 0x88C8A0 VA: 0x18088DEA0
	public void AlignTo(Transform alignment) { }

	// RVA: 0x88E410 Offset: 0x88CE10 VA: 0x18088E410 Slot: 9
	protected override void FixedUpdate() { }

	// RVA: 0x88E7F0 Offset: 0x88D1F0 VA: 0x18088E7F0 Slot: 12
	protected override void LateUpdate() { }

	// RVA: 0x88E290 Offset: 0x88CC90 VA: 0x18088E290
	private void Clamp() { }

	// RVA: 0x88E990 Offset: 0x88D390 VA: 0x18088E990
	public void .ctor() { }
}
