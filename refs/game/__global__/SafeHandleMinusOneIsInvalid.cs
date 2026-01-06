public abstract class SafeHandleMinusOneIsInvalid : SafeHandle // TypeDefIndex: 3548
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x1AA62C0 Offset: 0x1AA4CC0 VA: 0x181AA62C0
	protected void .ctor(bool ownsHandle) { }

	// RVA: 0x1AA6310 Offset: 0x1AA4D10 VA: 0x181AA6310 Slot: 5
	public override bool get_IsInvalid() { }
}
