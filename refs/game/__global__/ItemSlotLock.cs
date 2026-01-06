public class ItemSlotLock // TypeDefIndex: 3079
{
	// Fields
	[CompilerGenerated]
	private ItemSlot <Slot>k__BackingField; // 0x10
	[CompilerGenerated]
	private NetworkObject <LockOwner>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <LockReason>k__BackingField; // 0x20

	// Properties
	public ItemSlot Slot { get; set; }
	public NetworkObject LockOwner { get; set; }
	public string LockReason { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public ItemSlot get_Slot() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	protected void set_Slot(ItemSlot value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public NetworkObject get_LockOwner() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	protected void set_LockOwner(NetworkObject value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_LockReason() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_LockReason(string value) { }

	// RVA: 0x99D240 Offset: 0x99BC40 VA: 0x18099D240
	public void .ctor(ItemSlot slot, NetworkObject lockOwner, string lockReason) { }
}
