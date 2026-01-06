internal class SafeModuleHandle : SafeHandle // TypeDefIndex: 17300
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x1AA62B0 Offset: 0x1AA4CB0 VA: 0x181AA62B0
	public void .ctor() { }

	// RVA: 0x1E0CA30 Offset: 0x1E0B430 VA: 0x181E0CA30 Slot: 5
	public override bool get_IsInvalid() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1E0C9A0 Offset: 0x1E0B3A0 VA: 0x181E0C9A0 Slot: 7
	protected override bool ReleaseHandle() { }
}
