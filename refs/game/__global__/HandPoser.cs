public class HandPoser : Poser // TypeDefIndex: 14163
{
	// Fields
	protected Transform[] children; // 0x58
	private Transform _poseRoot; // 0x60
	private Transform[] poseChildren; // 0x68
	private Vector3[] defaultLocalPositions; // 0x70
	private Quaternion[] defaultLocalRotations; // 0x78

	// Methods

	// RVA: 0x1F20310 Offset: 0x1F1ED10 VA: 0x181F20310 Slot: 7
	public override void AutoMapping() { }

	// RVA: 0x1F20510 Offset: 0x1F1EF10 VA: 0x181F20510 Slot: 8
	protected override void InitiatePoser() { }

	// RVA: 0x1F203E0 Offset: 0x1F1EDE0 VA: 0x181F203E0 Slot: 10
	protected override void FixPoserTransforms() { }

	// RVA: 0x1F208B0 Offset: 0x1F1F2B0 VA: 0x181F208B0 Slot: 9
	protected override void UpdatePoser() { }

	// RVA: 0x1F20700 Offset: 0x1F1F100 VA: 0x181F20700
	protected void StoreDefaultState() { }

	// RVA: 0x1F202F0 Offset: 0x1F1ECF0 VA: 0x181F202F0
	public void .ctor() { }
}
