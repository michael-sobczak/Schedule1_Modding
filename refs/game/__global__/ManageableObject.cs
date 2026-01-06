public abstract class ManageableObject : MonoBehaviour // TypeDefIndex: 1260
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ManageableObjectType GetObjectType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Preset GetCurrentPreset();

	// RVA: 0x618830 Offset: 0x617230 VA: 0x180618830
	public void SetPreset(Preset newPreset) { }

	// RVA: 0x618990 Offset: 0x617390 VA: 0x180618990 Slot: 6
	protected virtual void SetPreset_Internal(Preset preset) { }

	// RVA: 0x618830 Offset: 0x617230 VA: 0x180618830
	public void ExistingPresetDeleted(Preset replacement) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }
}
