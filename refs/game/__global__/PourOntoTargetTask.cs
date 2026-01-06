public class PourOntoTargetTask : GrowContainerPourTask // TypeDefIndex: 812
{
	// Fields
	public float SUCCESS_THRESHOLD; // 0xD0
	public float SUCCESS_TIME; // 0xD4
	private float timeOverTarget; // 0xD8

	// Methods

	// RVA: 0x5AC290 Offset: 0x5AAC90 VA: 0x1805AC290
	public void .ctor(GrowContainer _growContainer, ItemInstance _itemInstance, Pourable _pourablePrefab) { }

	// RVA: 0x5AC100 Offset: 0x5AAB00 VA: 0x1805AC100 Slot: 9
	public override void Update() { }

	// RVA: 0x5AC020 Offset: 0x5AAA20 VA: 0x1805AC020 Slot: 6
	public override void StopTask() { }

	// RVA: 0x5AC060 Offset: 0x5AAA60 VA: 0x1805AC060 Slot: 19
	public virtual void TargetReached() { }
}
