public class PalletSlot : MonoBehaviour, IGUIDRegisterable // TypeDefIndex: 2388
{
	// Fields
	[CompilerGenerated]
	private Guid <GUID>k__BackingField; // 0x20
	[CompilerGenerated]
	private Pallet <occupant>k__BackingField; // 0x30
	public Action onPalletAdded; // 0x38
	public Action onPalletRemoved; // 0x40

	// Properties
	public Guid GUID { get; set; }
	public Pallet occupant { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4976D0 Offset: 0x4960D0 VA: 0x1804976D0 Slot: 4
	public Guid get_GUID() { }

	[CompilerGenerated]
	// RVA: 0x4976E0 Offset: 0x4960E0 VA: 0x1804976E0
	protected void set_GUID(Guid value) { }

	// RVA: 0x879850 Offset: 0x878250 VA: 0x180879850 Slot: 6
	public void SetGUID(Guid guid) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public Pallet get_occupant() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void set_occupant(Pallet value) { }

	// RVA: 0x8798B0 Offset: 0x8782B0 VA: 0x1808798B0
	public void SetOccupant(Pallet _occupant) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
