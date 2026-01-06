public class ManageablePot : ManageableObject // TypeDefIndex: 1261
{
	// Fields
	public PotPreset CurrentPreset; // 0x20

	// Methods

	// RVA: 0x618A90 Offset: 0x617490 VA: 0x180618A90 Slot: 7
	protected virtual void Awake() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 4
	public override ManageableObjectType GetObjectType() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 5
	public override Preset GetCurrentPreset() { }

	// RVA: 0x618AC0 Offset: 0x6174C0 VA: 0x180618AC0 Slot: 6
	protected override void SetPreset_Internal(Preset newPreset) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
