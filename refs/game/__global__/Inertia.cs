public class Inertia : OffsetModifier // TypeDefIndex: 14202
{
	// Fields
	[Tooltip("The array of Bodies")]
	public Inertia.Body[] bodies; // 0x38
	[Tooltip("The array of OffsetLimits")]
	public OffsetModifier.OffsetLimits[] limits; // 0x40

	// Methods

	// RVA: 0x1F22060 Offset: 0x1F20A60 VA: 0x181F22060
	public void ResetBodies() { }

	// RVA: 0x1F21EF0 Offset: 0x1F208F0 VA: 0x181F21EF0 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x55D3D0 Offset: 0x55BDD0 VA: 0x18055D3D0
	public void .ctor() { }
}
